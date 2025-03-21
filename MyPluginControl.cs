using McTools.Xrm.Connection;
using McTools.Xrm.Connection.WinForms;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace EnvVarChecker
{
    public partial class MyPluginControl : PluginControlBase
    {
        private Settings mySettings;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        private ConnectionDetail ENV1;
        private ConnectionDetail ENV2;
        private ConnectionDetail ENV3;

        private IOrganizationService SERVICE2;
        private IOrganizationService SERVICE3;

        private void MyPluginControl_Load(object sender, EventArgs e)
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
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
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

            ExecuteMethod(GetSolutions);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }
        private class ListObject
        {
            public string Name { get; set; }
            public string Value { get; set; }
            public string LogName { get; set; }
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

        class EnvVarInfo
        {
            public Guid Id { get; set; }
            public Guid ValueId { get; set; }
            public string DisplayName { get; set; }
            public string SchemaName { get; set; }
            public string DataType { get; set; }
            public string DefaultValue { get; set; }
            public string CurrentValue { get; set; }
        }

        private EnvVarInfo EnvVar1_Info = new EnvVarInfo();
        private EnvVarInfo EnvVar2_Info = new EnvVarInfo();
        private EnvVarInfo EnvVar3_Info = new EnvVarInfo();

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
                        ClearInfo(env_num);
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
                    envVarInfo.DisplayName = (string)envVar["displayname"];
                    envVarInfo.DataType = (string)envVar.FormattedValues["type"];
                    envVarInfo.DefaultValue = envVar.Contains("defaultvalue") ? (envVar["defaultvalue"]).ToString() : null;

                    if (value != null)
                    {
                        envVarInfo.ValueId = value.Id;
                        envVarInfo.CurrentValue = (string)value["value"];
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
                }
            });
        }

        private void ClearInfo(int env_num)
        {
            if (env_num == 1)
            {
                schemaName1.Text = "";
                displayName1.Text = "";
                defaultValue1.Text = "";
                currentValue1.Text = "";
            }
            else if (env_num == 2)
            {
                schemaName2.Text = "";
                displayName2.Text = "";
                defaultValue2.Text = "";
                currentValue2.Text = "";
            }
            else if (env_num == 3)
            {
                schemaName3.Text = "";
                displayName3.Text = "";
                defaultValue3.Text = "";
                currentValue3.Text = "";
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
            }
            else if (env_num == 2)
            {
                schemaName2.Text = info.SchemaName;
                displayName2.Text = info.DisplayName;
                defaultValue2.Text = info.DefaultValue;
                currentValue2.Text = info.CurrentValue;
            }
            else if (env_num == 3)
            {
                schemaName3.Text = info.SchemaName;
                displayName3.Text = info.DisplayName;
                defaultValue3.Text = info.DefaultValue;
                currentValue3.Text = info.CurrentValue;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                    service.Update(envVar);

                    if (info.CurrentValue != "")
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
                }
            });
        }

        private void saveBtn_env1_Click(object sender, EventArgs e)
        {
            var envVar = schemaName1.Text;
            var displayName = displayName1.Text;
            var defaultValue = defaultValue1.Text;
            var currentValue = currentValue1.Text;

            EnvVar1_Info.DisplayName = displayName;
            EnvVar1_Info.DefaultValue = defaultValue;
            EnvVar1_Info.CurrentValue = currentValue;

            ExecuteMethod(() => UpdateEnvVar(Service, EnvVar1_Info));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SolutionsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteMethod(GetEnvVars);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void LoadSolutionsBtn_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetSolutions);
        }

        private void EnvVarsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExecuteMethod(() => FetchEnvVarInfo(Service, 1));
        }

        private void selectEnv2Btn_Click(object sender, EventArgs e)
        {
            var connectionSelector = new ConnectionSelector();
            if (connectionSelector.ShowDialog() == DialogResult.OK)
            {
                var selectedConnections = connectionSelector.SelectedConnections;
                ENV2 = selectedConnections[0];

                SERVICE2 = ENV2.GetCrmServiceClient();

                env2_label.Text = ENV2.ConnectionName;

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

                env3_label.Text = ENV3.ConnectionName;

                ExecuteMethod(() => FetchEnvVarInfo(SERVICE3, 3));
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var byId = idMatchCheckbox.Checked;

            nameMatchCheckbox.Checked = !byId;
        }

        private void nameMatchCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            var byName = nameMatchCheckbox.Checked;

           idMatchCheckbox.Checked = !byName;
        }
    }
}