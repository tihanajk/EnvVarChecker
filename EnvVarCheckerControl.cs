using McTools.Xrm.Connection;
using McTools.Xrm.Connection.WinForms;
using Microsoft.Win32;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.Streaming.Values;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web.Services.Description;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.ThemeVS2012;
using XrmToolBox.Extensibility;

namespace EnvVarChecker
{
    public partial class EnvVarCheckerControl : PluginControlBase
    {
        private Settings mySettings;

        private bool COMPARING = false;

        public EnvVarCheckerControl()
        {
            InitializeComponent();

            InitializeTooltip();
        }

        private void InitializeTooltip()
        {
            refresh_tooltip.SetToolTip(refresh1, "Refresh variable info");
            refresh_tooltip.SetToolTip(refresh2, "Refresh variable info");
            refresh_tooltip.SetToolTip(refresh3, "Refresh variable info");

            save_tooltip.SetToolTip(save1_btn, "Save variable info");
            save_tooltip.SetToolTip(save2_btn, "Save variable info");
            save_tooltip.SetToolTip(save3_btn, "Save variable info");
        }

        private ConnectionDetail ENV1;
        private ConnectionDetail ENV2;
        private ConnectionDetail ENV3;

        private IOrganizationService SERVICE2;
        private IOrganizationService SERVICE3;

        private void EnvVarCheckerControl_Load(object sender, EventArgs e)
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnvVarCheckerControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            ENV1 = detail;

            groupBox2.Text = ENV1.ConnectionName;

            exportDropdownBtn.Enabled = true;

            ExecuteMethod(GetSolutions);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void GetSolutions()
        {
            WorkAsync(new WorkAsyncInfo()
            {
                Message = "Getting solutions",
                AsyncArgument = null,
                Work = (worker, args) =>
                {
                    var query = new QueryExpression("solution");
                    query.ColumnSet.AddColumns("friendlyname", "solutionid", "uniquename");
                    query.AddOrder("friendlyname", OrderType.Ascending);

                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;

                    SolutionsCombobox.DataSource = new List<ListObject>();

                    if (result != null)
                    {
                        var items = new List<ListObject>();

                        items.Add(new ListObject()
                        {
                            Name = "<All Solutions>",
                            Value = "1"
                        });

                        foreach (var sol in result.Entities)
                        {
                            var friendlyName = sol.Contains("friendlyname") ? (string)sol["friendlyname"] : "";
                            var name = $"{friendlyName} ({sol["uniquename"]})";
                            var solutionId = sol.Id.ToString();

                            items.Add(new ListObject()
                            {
                                Name = name,
                                Value = solutionId,
                            });
                        }

                        SolutionsCombobox.DataSource = items;
                        SolutionsCombobox.DisplayMember = "Name";
                        SolutionsCombobox.ValueMember = "Value";
                    }
                }
            });
        }

        private void GetEnvVars()
        {
            var selectedSolution = SolutionsCombobox.SelectedItem as ListObject;
            var all = selectedSolution.Value == "1";
            WorkAsync(new WorkAsyncInfo()
            {
                Message = "Getting environment variables",
                AsyncArgument = null,
                Work = (worker, args) =>
                {
                    var link = !all
                    ? $@"<link-entity name='solutioncomponent' from='objectid' to='environmentvariabledefinitionid'>
                            <filter>
                                <condition attribute='solutionid' operator='eq' value='{selectedSolution.Value}' />
                            </filter>
                        </link-entity>"
                    : "";
                    var fetchXml = $@"<fetch>
                                      <entity name='environmentvariabledefinition'>
                                        <attribute name='environmentvariabledefinitionid' />
                                        <attribute name='displayname' />
                                        <attribute name='schemaname' />
                                        {link}
                                        <filter>
                                            <condition attribute='type' operator='ne' value='100000004' />
                                            <condition attribute='type' operator='ne' value='100000005' />
                                        </filter>
                                        <order attribute='displayname' />
                                      </entity>
                                    </fetch>";

                    args.Result = Service.RetrieveMultiple(new FetchExpression(fetchXml));
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;

                    EnvVarsCombobox.DataSource = new List<ListObject>();

                    if (result != null)
                    {
                        var items = new List<ListObject>();

                        foreach (var envVar in result.Entities)
                        {
                            var friendlyName = envVar.Contains("displayname") ? (string)envVar["displayname"] : "";
                            var name = $"{friendlyName} ({envVar["schemaname"]})";
                            var envVarId = envVar.Id.ToString();

                            items.Add(new ListObject()
                            {
                                Name = name,
                                Value = envVarId,
                                LogName = (string)envVar["schemaname"],
                            });
                        }

                        EnvVarsCombobox.DataSource = items;
                        EnvVarsCombobox.DisplayMember = "Name";
                        EnvVarsCombobox.ValueMember = "Value";
                    }
                }
            });
        }

        private EnvVarInfo EnvVar1_Info;
        private EnvVarInfo EnvVar2_Info;
        private EnvVarInfo EnvVar3_Info;

        private void FetchEnvVarInfo(IOrganizationService service, int env_num)
        {
            var EV = EnvVarsCombobox.SelectedItem as ListObject;

            var envVarFilter =
                idMatchCheckbox.Checked ?
                $@"<filter>
                    <condition attribute='environmentvariabledefinitionid' operator='eq' value='{EV.Value}' />
                </filter>" :
                $@"<filter>
                    <condition attribute='schemaname' operator='eq' value='{EV.LogName}' />
                </filter>";

            WorkAsync(new WorkAsyncInfo()
            {
                Message = "Fetching env var info",
                AsyncArgument = null,
                Work = (worker, args) =>
                {
                    var fetchEnvVar = $@"<fetch top='1'>
                                          <entity name='environmentvariabledefinition'>
                                            {envVarFilter}
                                          </entity>
                                        </fetch>";
                    var envVar = service.RetrieveMultiple(new FetchExpression(fetchEnvVar)).Entities.FirstOrDefault();
                    if (envVar == null)
                    {
                        return;
                    }

                    var fetchValue = $@"<fetch top='1'>
                                          <entity name='environmentvariablevalue'>
                                            <attribute name='value' />
                                            <filter>
                                              <condition attribute='environmentvariabledefinitionid' operator='eq' value='{envVar.Id}' />
                                            </filter>
                                          </entity>
                                        </fetch>";
                    var value = service.RetrieveMultiple(new FetchExpression(fetchValue)).Entities.FirstOrDefault();


                    var envVarInfo = new EnvVarInfo() { };
                    envVarInfo.Id = envVar.Id;
                    envVarInfo.SchemaName = (string)envVar["schemaname"];
                    envVarInfo.DisplayName = envVar.Contains("displayname") ? (string)envVar["displayname"] : "";
                    envVarInfo.DataType = ((OptionSetValue)envVar["type"]).Value;
                    envVarInfo.DataType_formatted = envVar.FormattedValues["type"];
                    envVarInfo.DefaultValue = envVar.Contains("defaultvalue") ? (envVar["defaultvalue"]).ToString() : null;
                    envVarInfo.Description = envVar.Contains("description") ? (string)envVar["description"] : "";

                    if (value != null)
                    {
                        envVarInfo.ValueId = value.Id;
                        envVarInfo.CurrentValue = value.Contains("value") ? (string)value["value"] : "";
                    }

                    if (env_num == 1) EnvVar1_Info = envVarInfo;
                    else if (env_num == 2) EnvVar2_Info = envVarInfo;
                    else if (env_num == 3) EnvVar3_Info = envVarInfo;

                    args.Result = envVarInfo;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EnvVarInfo;

                    if (result != null) SetInfo(result, env_num);
                    else ClearInfo(env_num);

                    HandleCompareLogic();
                }
            });


        }

        private void ClearInfo(int env_num)
        {
            if (env_num == 1)
            {
                EnvVar1_Info = null;

                schemaName1.Text = "";
                displayName1.Text = "";
                defaultValue1.Text = "";
                currentValue1.Text = "";
                description1.Text = "";
                type1.Text = "";

                displayName1.Enabled = false;
                defaultValue1.Enabled = false;
                currentValue1.Enabled = false;
                description1.Enabled = false;

                refresh1.Enabled = false;
                save1_btn.Enabled = false;
            }
            else if (env_num == 2)
            {
                EnvVar2_Info = null;

                schemaName2.Text = "";
                displayName2.Text = "";
                defaultValue2.Text = "";
                currentValue2.Text = "";
                description2.Text = "";
                type2.Text = "";

                displayName2.Enabled = false;
                defaultValue2.Enabled = false;
                currentValue2.Enabled = false;
                description2.Enabled = false;

                refresh2.Enabled = false;
                save2_btn.Enabled = false;
            }
            else if (env_num == 3)
            {
                EnvVar3_Info = null;

                schemaName3.Text = "";
                displayName3.Text = "";
                defaultValue3.Text = "";
                currentValue3.Text = "";

                description3.Text = "";
                type3.Text = "";

                displayName3.Enabled = false;
                defaultValue3.Enabled = false;
                currentValue3.Enabled = false;
                description3.Enabled = false;

                refresh3.Enabled = false;
                save3_btn.Enabled = false;
            }
        }

        private void SetInfo(EnvVarInfo info, int env_num)
        {
            if (env_num == 1)
            {
                schemaName1.Text = info.SchemaName;
                displayName1.Text = info.DisplayName;
                defaultValue1.Text = info.DefaultValue;
                currentValue1.Text = info.CurrentValue;

                description1.Text = info.Description;
                type1.Text = info.DataType_formatted;

                displayName1.Enabled = true;
                defaultValue1.Enabled = true;
                currentValue1.Enabled = true;
                defaultValue1.Enabled = true;
                description1.Enabled = true;

                refresh1.Enabled = true;
                save1_btn.Enabled = true;
            }
            else if (env_num == 2)
            {
                schemaName2.Text = info.SchemaName;
                displayName2.Text = info.DisplayName;
                defaultValue2.Text = info.DefaultValue;
                currentValue2.Text = info.CurrentValue;

                description2.Text = info.Description;
                type2.Text = info.DataType_formatted;

                displayName2.Enabled = true;
                defaultValue2.Enabled = true;
                currentValue2.Enabled = true;
                defaultValue2.Enabled = true;
                description2.Enabled = true;

                refresh2.Enabled = true;
                save2_btn.Enabled = true;

                if (info.DefaultValue != EnvVar1_Info.DefaultValue) defaultValue2.ForeColor = Color.Red;
            }
            else if (env_num == 3)
            {
                schemaName3.Text = info.SchemaName;
                displayName3.Text = info.DisplayName;
                defaultValue3.Text = info.DefaultValue;
                currentValue3.Text = info.CurrentValue;

                description3.Text = info.Description;
                type3.Text = info.DataType_formatted;

                displayName3.Enabled = true;
                defaultValue3.Enabled = true;
                currentValue3.Enabled = true;
                defaultValue3.Enabled = true;
                description3.Enabled = true;

                refresh3.Enabled = true;
                save3_btn.Enabled = true;
            }
        }

        private void UpdateEnvVar(IOrganizationService service, EnvVarInfo info)
        {
            WorkAsync(new WorkAsyncInfo()
            {
                Message = "Updating env var info",
                AsyncArgument = null,
                Work = (worker, args) =>
                {
                    var envVar = new Entity("environmentvariabledefinition", info.Id);

                    envVar["displayname"] = info.DisplayName;
                    envVar["defaultvalue"] = info.DefaultValue;
                    envVar["description"] = info.Description;

                    service.Update(envVar);

                    if (info.CurrentValue_modif)
                    {
                        var envVarValue = new Entity("environmentvariablevalue");
                        if (info.ValueId != null) envVarValue.Id = info.ValueId;
                        envVarValue["value"] = info.CurrentValue;

                        if (info.ValueId == Guid.Empty)
                        {
                            envVarValue["environmentvariabledefinitionid"] = new EntityReference(envVar.LogicalName, envVar.Id);
                            var id = service.Create(envVarValue);
                            info.ValueId = id;
                        }
                        else service.Update(envVarValue);

                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    info.CurrentValue_modif = false;

                    HandleCompareLogic();
                }
            });
        }

        private void save1_btn_Click(object sender, EventArgs e)
        {
            var envVar = schemaName1.Text;
            var displayName = displayName1.Text;
            var defaultValue = defaultValue1.Text;
            var currentValue = currentValue1.Text;
            var description = description1.Text;


            EnvVar1_Info.DisplayName = displayName;
            EnvVar1_Info.DefaultValue = defaultValue;
            EnvVar1_Info.Description = description;

            EnvVar1_Info.CurrentValue_modif = EnvVar1_Info.CurrentValue != currentValue;
            if (EnvVar1_Info.CurrentValue_modif) EnvVar1_Info.CurrentValue = currentValue;

            ExecuteMethod(() => UpdateEnvVar(Service, EnvVar1_Info));
        }

        private void save2_btn_Click(object sender, EventArgs e)
        {
            var envVar = schemaName2.Text;
            var displayName = displayName2.Text;
            var defaultValue = defaultValue2.Text;
            var currentValue = currentValue2.Text;
            var description = description2.Text;


            EnvVar2_Info.DisplayName = displayName;
            EnvVar2_Info.DefaultValue = defaultValue;
            EnvVar2_Info.Description = description;

            EnvVar2_Info.CurrentValue_modif = EnvVar2_Info.CurrentValue != currentValue;
            if (EnvVar2_Info.CurrentValue_modif) EnvVar2_Info.CurrentValue = currentValue;

            ExecuteMethod(() => UpdateEnvVar(SERVICE2, EnvVar2_Info));
        }

        private void save3_btn_Click(object sender, EventArgs e)
        {
            var envVar = schemaName3.Text;
            var displayName = displayName3.Text;
            var defaultValue = defaultValue3.Text;
            var currentValue = currentValue3.Text;
            var description = description3.Text;

            EnvVar3_Info.DisplayName = displayName;
            EnvVar3_Info.DefaultValue = defaultValue;
            EnvVar3_Info.Description = description;

            EnvVar3_Info.CurrentValue_modif = EnvVar3_Info.CurrentValue != currentValue;
            if (EnvVar3_Info.CurrentValue_modif) EnvVar3_Info.CurrentValue = currentValue;

            ExecuteMethod(() => UpdateEnvVar(SERVICE3, EnvVar3_Info));
        }

        private void SolutionsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteMethod(GetEnvVars);
        }

        private void LoadSolutionsBtn_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetSolutions);
        }


        private void solutionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetSolutions);
        }

        private void EnvVarsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteMethod(() => FetchEnvVarInfo(Service, 1));

            if (ENV2 != null)
            {
                ExecuteMethod(() => FetchEnvVarInfo(SERVICE2, 2));
            }

            if (ENV3 != null)
            {
                ExecuteMethod(() => FetchEnvVarInfo(SERVICE3, 3));
            }
        }

        private void loadVarsBtn_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetEnvVars);
        }

        private void variablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetEnvVars);
        }

        private void selectEnv2Btn_Click(object sender, EventArgs e)
        {
            var connectionSelector = new ConnectionSelector();
            if (connectionSelector.ShowDialog() == DialogResult.OK)
            {
                var selectedConnections = connectionSelector.SelectedConnections;
                ENV2 = selectedConnections[0];

                SERVICE2 = ENV2.GetCrmServiceClient();

                groupBox3.Text = ENV2.ConnectionName;

                ExecuteMethod(() => FetchEnvVarInfo(SERVICE2, 2));
            }

        }

        private void selectEnv3Btn_Click(object sender, EventArgs e)
        {
            var connectionSelector = new ConnectionSelector();
            if (connectionSelector.ShowDialog() == DialogResult.OK)
            {
                var selectedConnections = connectionSelector.SelectedConnections;
                ENV3 = selectedConnections[0];

                SERVICE3 = ENV3.GetCrmServiceClient();

                groupBox4.Text = ENV3.ConnectionName;

                ExecuteMethod(() => FetchEnvVarInfo(SERVICE3, 3));
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            nameMatchCheckbox.Checked = !idMatchCheckbox.Checked;

            ExecuteMethod(() => FetchEnvVarInfo(Service, 1));
            if (ENV2 != null) ExecuteMethod(() => FetchEnvVarInfo(SERVICE2, 2));
            if (ENV3 != null) ExecuteMethod(() => FetchEnvVarInfo(SERVICE3, 3));
        }

        private void nameMatchCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            idMatchCheckbox.Checked = !nameMatchCheckbox.Checked;

            ExecuteMethod(() => FetchEnvVarInfo(Service, 1));
            if (ENV2 != null) ExecuteMethod(() => FetchEnvVarInfo(SERVICE2, 2));
            if (ENV3 != null) ExecuteMethod(() => FetchEnvVarInfo(SERVICE3, 3));
        }

        private void refresh1_Click(object sender, EventArgs e)
        {
            ExecuteMethod(() => FetchEnvVarInfo(Service, 1));
        }

        private void refresh2_Click(object sender, EventArgs e)
        {
            if (ENV2 == null) return;
            ExecuteMethod(() => FetchEnvVarInfo(SERVICE2, 2));
        }

        private void refresh3_Click(object sender, EventArgs e)
        {
            if (ENV3 == null) return;
            ExecuteMethod(() => FetchEnvVarInfo(SERVICE3, 3));
        }

        private void CreateNewEnvVar(EnvVarInfo info, IOrganizationService service)
        {
            WorkAsync(new WorkAsyncInfo()
            {
                Message = "Creating env var",
                AsyncArgument = null,
                Work = (worker, args) =>
                {
                    var newEnvVar = new Entity("environmentvariabledefinition");
                    newEnvVar.Id = Guid.NewGuid();

                    newEnvVar["schemaname"] = info.SchemaName;
                    newEnvVar["displayname"] = info.DisplayName;
                    newEnvVar["type"] = new OptionSetValue(info.DataType);
                    newEnvVar["defaultvalue"] = info.DefaultValue;
                    newEnvVar["description"] = info.Description;
                    service.Create(newEnvVar);

                    args.Result = newEnvVar;

                    if (info.CurrentValue == null || info.CurrentValue == "") return;

                    var newValue = new Entity("environmentvariablevalue");
                    newValue.Id = Guid.NewGuid();
                    newValue["environmentvariabledefinitionid"] = new EntityReference(newEnvVar.LogicalName, newEnvVar.Id);
                    newValue["value"] = info.CurrentValue;
                    service.Create(newValue);

                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    var variable = args.Result as Entity;
                    MessageBox.Show("Created new variable " + variable.Id);
                }
            });
        }

        private void newEnvVar_btn_Click(object sender, EventArgs e)
        {
            var envs = new List<ConnectionDetail>() { ENV1, ENV2, ENV3 };

            if (envs.Find(env => env != null) == null)
            {
                MessageBox.Show("Select at least one environment first");
                return;
            }

            using (var form = new NewEnvVarDialog(envs))
            {
                if (form.ShowDialog() != DialogResult.OK) return;

                CreateInfo result = form.createInfo;

                var dest = result.dest;
                foreach (var item in dest)
                {
                    ExecuteMethod(() => CreateNewEnvVar(result.info, item.GetCrmServiceClient()));
                }

                //MessageBox.Show($"You entered: {result}");


            }

        }

        private void HandleCompareBtn()
        {
            if (COMPARING)
            {
                compareBtn.Text = "Comparing on";
                compareBtn.BackColor = SystemColors.GradientActiveCaption;
                compareBtn.Image = Properties.Resources.compare;
            }
            else
            {
                compareBtn.Text = "Comparing off";
                compareBtn.BackColor = SystemColors.HighlightText;
                compareBtn.Image = Properties.Resources.compare_off;
            }
        }

        private void HandleCompareLogic()
        {
            if (!COMPARING)
            {
                defaultValue2.ForeColor = SystemColors.WindowText;
                defaultValue3.ForeColor = SystemColors.WindowText;

                currentValue2.ForeColor = SystemColors.WindowText;
                currentValue3.ForeColor = SystemColors.WindowText;

                return;
            }

            if (EnvVar1_Info == null) return;

            if (EnvVar2_Info == null && EnvVar3_Info == null) return;

            // compare env 2 to env 1
            defaultValue2.ForeColor = EnvVar1_Info.DefaultValue != EnvVar2_Info.DefaultValue ? Color.Red : Color.Green;
            currentValue2.ForeColor = EnvVar1_Info.CurrentValue != EnvVar2_Info.CurrentValue ? Color.Red : Color.Green;

            // compare env 3 to env 1
            defaultValue3.ForeColor = EnvVar1_Info.DefaultValue != EnvVar3_Info.DefaultValue ? Color.Red : Color.Green;
            currentValue3.ForeColor = EnvVar1_Info.CurrentValue != EnvVar3_Info.CurrentValue ? Color.Red : Color.Green;

        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            COMPARING = compareBtn.Checked;

            HandleCompareBtn();

            HandleCompareLogic();
        }

        private void PopulateExcel(string fileName)
        {
            IWorkbook workbook = new XSSFWorkbook();

            if (ENV1 != null) WriteEnvVarInfo(workbook, EnvVar1_Info, ENV1.ConnectionName);

            if (ENV2 != null) WriteEnvVarInfo(workbook, EnvVar2_Info, ENV2.ConnectionName);
            if (ENV3 != null) WriteEnvVarInfo(workbook, EnvVar3_Info, ENV3.ConnectionName);

            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }
        }

        private void ColorRowCells(IWorkbook workbook, IRow row, short colorIndex, short textColorIndex)
        {
            ICellStyle headerStyle = workbook.CreateCellStyle();
            // Set background color
            headerStyle.FillForegroundColor = colorIndex;
            headerStyle.FillPattern = FillPattern.SolidForeground;

            IFont font = workbook.CreateFont();
            font.Color = textColorIndex;  // Set the text color (font color)
            headerStyle.SetFont(font);

            foreach (ICell cell in row.Cells)
            {
                cell.CellStyle = headerStyle;
            }
        }

        private void WriteEnvVarInfo(IWorkbook workbook, EnvVarInfo var, string envName)
        {
            ISheet sheet = workbook.CreateSheet(envName);

            AddHeaderRow(workbook, sheet);

            if (var == null) return;

            IRow valueRow = sheet.CreateRow(1);
            valueRow.CreateCell(0).SetCellValue(var.SchemaName);
            valueRow.CreateCell(1).SetCellValue(var.DisplayName);
            valueRow.CreateCell(2).SetCellValue(var.Description);
            valueRow.CreateCell(3).SetCellValue(var.DataType_formatted);
            valueRow.CreateCell(4).SetCellValue(var.DefaultValue);
            valueRow.CreateCell(5).SetCellValue(var.CurrentValue);

            //AutosizeColumns(sheet, 6);
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new System.Windows.Forms.SaveFileDialog();

            saveFileDialog.Filter = "Excel files|*.xlsx";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "Env var";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                WorkAsync(new WorkAsyncInfo()
                {
                    Message = "Populating excel",
                    AsyncArgument = null,
                    Work = (worker, args) =>
                    {
                        PopulateExcel(saveFileDialog.FileName);

                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (args.Error != null)
                        {
                            MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show("Finished");

                        DialogResult confirmResult = MessageBox.Show("Do you want to open the file?", "Excel file", MessageBoxButtons.YesNo);

                        if (confirmResult == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(saveFileDialog.FileName);
                        }
                    }
                });

            }
        }

        private void exportAllBtn_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new System.Windows.Forms.SaveFileDialog();

            saveFileDialog.Filter = "Excel files|*.xlsx";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "All env vars";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                WorkAsync(new WorkAsyncInfo()
                {
                    Message = "Populating excel",
                    AsyncArgument = null,
                    Work = (worker, args) =>
                    {
                        ExecuteMethod(() => PopulateExcel_all(saveFileDialog.FileName));

                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (args.Error != null)
                        {
                            MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show("Finished");

                        DialogResult confirmResult = MessageBox.Show("Do you want to open the file?", "Excel file", MessageBoxButtons.YesNo);

                        if (confirmResult == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(saveFileDialog.FileName);
                        }
                    }
                });

            }
        }

        private void PopulateExcel_all(string fileName)
        {
            IWorkbook workbook = new XSSFWorkbook();

            if (ENV1 != null) ExecuteMethod(() => WriteAllEnvVars(Service, ENV1.ConnectionName, workbook));

            if (ENV2 != null) ExecuteMethod(() => WriteAllEnvVars(SERVICE2, ENV2.ConnectionName, workbook));
            if (ENV3 != null) ExecuteMethod(() => WriteAllEnvVars(SERVICE3, ENV3.ConnectionName, workbook));

            using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }
        }

        private void AddHeaderRow(IWorkbook workbook, ISheet sheet)
        {
            IRow envVarInfoRow = sheet.CreateRow(0);
            envVarInfoRow.CreateCell(0).SetCellValue("Schema name".ToUpper());
            envVarInfoRow.CreateCell(1).SetCellValue("Display name".ToUpper());
            envVarInfoRow.CreateCell(2).SetCellValue("Description".ToUpper());
            envVarInfoRow.CreateCell(3).SetCellValue("Type".ToUpper());
            envVarInfoRow.CreateCell(4).SetCellValue("Default value".ToUpper());
            envVarInfoRow.CreateCell(5).SetCellValue("Value".ToUpper());

            ColorRowCells(workbook, envVarInfoRow, IndexedColors.Indigo.Index, IndexedColors.White.Index);
        }

        private void AutosizeColumns(ISheet sheet, int columnsCount)
        {
            for (int colIndex = 0; colIndex < columnsCount; colIndex++)  // Loop through columns (adjust 6 if needed)
            {
                int maxLength = 0;

                // Find the maximum length of content in the column
                for (int rowIndex = 0; rowIndex < sheet.PhysicalNumberOfRows; rowIndex++)
                {
                    ICell cell = sheet.GetRow(rowIndex).GetCell(colIndex);
                    if (cell != null)
                    {
                        // Get the length of the cell content
                        maxLength = Math.Max(maxLength, cell.ToString().Length);
                    }
                }

                int columnWidth = (maxLength + 2) * 256;
                if (columnWidth > 65535) columnWidth = 65535; // Maximum column width
                sheet.SetColumnWidth(colIndex, columnWidth);
            }
        }

        private void WriteAllEnvVars(IOrganizationService service, string envName, IWorkbook workbook)
        {
            ISheet sheet = workbook.CreateSheet(envName);

            AddHeaderRow(workbook, sheet);

            var fetchXml = $@"<fetch>
                                <entity name='environmentvariabledefinition'>
                                    <attribute name='environmentvariabledefinitionid' />
                                    <attribute name='displayname' />
                                    <attribute name='schemaname' />
                                    <attribute name='defaultvalue' />                                    
                                    <attribute name='description' />
                                    <attribute name='type' />
                                    <order attribute='displayname' />
                                    <link-entity name='environmentvariablevalue' from='environmentvariabledefinitionid' to='environmentvariabledefinitionid' link-type='outer' alias='v'>
                                        <attribute name='value' />
                                    </link-entity>
                                    </entity>
                                </fetch>";
            var result = service.RetrieveMultiple(new FetchExpression(fetchXml));

            var i = 0;

            if (result == null) return;

            foreach (var varInfo in result.Entities)
            {
                ++i;
                IRow varInfoRow = sheet.CreateRow(i);
                varInfoRow.CreateCell(0).SetCellValue((string)varInfo["schemaname"]);

                if (varInfo.Contains("displayname")) varInfoRow.CreateCell(1).SetCellValue((string)varInfo["displayname"]);
                else varInfoRow.CreateCell(1).SetBlank();

                if (varInfo.Contains("description")) varInfoRow.CreateCell(2).SetCellValue((string)varInfo["description"]);
                else varInfoRow.CreateCell(2).SetBlank();

                if (varInfo.Contains("type")) varInfoRow.CreateCell(3).SetCellValue(varInfo.FormattedValues["type"]);
                else varInfoRow.CreateCell(3).SetBlank();

                if (varInfo.Contains("defaultvalue")) varInfoRow.CreateCell(4).SetCellValue((string)varInfo["defaultvalue"]);
                else varInfoRow.CreateCell(4).SetBlank();

                if (varInfo.Contains("v.value"))
                {
                    var value = ((AliasedValue)varInfo["v.value"]).Value.ToString();

                    varInfoRow.CreateCell(5).SetCellValue(value);
                }
                else varInfoRow.CreateCell(5).SetBlank();

                if (i % 2 == 0) ColorRowCells(workbook, varInfoRow, IndexedColors.PaleBlue.Index, IndexedColors.Black.Index);

            }

            //AutosizeColumns(sheet, 6);

        }
    }
}