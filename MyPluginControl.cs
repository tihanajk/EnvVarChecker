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
            public string DisplayName { get; set; }
            public string SchemaName { get; set; }
            public string DataType { get; set; }
            public string DefaultValue { get; set; }
            public string CurrentValue { get; set; }
        }

        private void FetchEnvVarInfo()
        {
            var envVarId = (EnvVarsCombobox.SelectedItem as ListObject).Value;

            WorkAsync(new WorkAsyncInfo()
            {
                Message = "Fetching env var info",
                AsyncArgument = null,
                Work = (worker, args) =>
                {
                    var fetchValue = $@"<fetch top='1'>
                                          <entity name='environmentvariablevalue'>
                                            <attribute name='value' />
                                            <filter>
                                              <condition attribute='environmentvariabledefinitionid' operator='eq' value='{envVarId}' />
                                            </filter>
                                          </entity>
                                        </fetch>";
                    var value = Service.RetrieveMultiple(new FetchExpression(fetchValue)).Entities.FirstOrDefault();

                    var envVar = Service.Retrieve("environmentvariabledefinition", new Guid(envVarId), new ColumnSet(true));

                    var envVarInfo = new EnvVarInfo() { };
                    envVarInfo.SchemaName = (string)envVar["schemaname"];
                    envVarInfo.DisplayName = (string)envVar["displayname"];
                    envVarInfo.DataType = (string)envVar.FormattedValues["type"];
                    envVarInfo.DefaultValue = envVar.Contains("defaultvalue") ? (envVar["defaultvalue"]).ToString() : null;

                    if (value != null) envVarInfo.CurrentValue = (string)value["value"];


                    args.Result = envVarInfo;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EnvVarInfo;

                    schemaName1.Text = result.SchemaName;
                    displayName1.Text = result.DisplayName;
                    defaultValue1.Text = result.DefaultValue;
                    currentValue1.Text = result.CurrentValue;
                }
            });
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void saveBtn_env1_Click(object sender, EventArgs e)
        {

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
            ExecuteMethod(FetchEnvVarInfo);
        }

        private void selectEnv2Btn_Click(object sender, EventArgs e)
        {
            var connectionSelector = new ConnectionSelector();
            if (connectionSelector.ShowDialog() == DialogResult.OK)
            {
                var selectedConnections = connectionSelector.SelectedConnections;
                ENV2 = selectedConnections[0];

                selectEnv2Btn.Text = ENV2.ConnectionName;
            }

        }
    }
}