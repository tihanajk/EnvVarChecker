using McTools.Xrm.Connection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EnvVarChecker
{
    public partial class NewEnvVarDialog : Form
    {
        List<ConnectionDetail> _envs;
        private void InitializeDestEnvs()
        {
            foreach (var item in _envs)
            {
                if (item == null) continue;
                var val = new KeyValuePair<Guid?, string>(item.ConnectionId, item.ConnectionName) { };
                if (!destinationEnvs.Items.Contains(val)) destinationEnvs.Items.Add(val, false);
            }

            destinationEnvs.DisplayMember = "Value";
        }

        private void InitializeDataType()
        {
            var types = new List<ListObject>
            {
                new ListObject { Name = "String", Value = "100000000" },
                new ListObject { Name = "Number", Value = "100000001" },
                new ListObject { Name = "Boolean", Value = "100000002" },
                new ListObject { Name = "Json", Value = "100000003" }
            };
            dataTypeOption.DataSource = types;

            dataTypeOption.DisplayMember = "Name";
        }

        public NewEnvVarDialog(List<ConnectionDetail> envs)
        {
            _envs = envs;
            InitializeComponent();

            InitializeDestEnvs();

            InitializeDataType();
        }

        private void CheckAllowSaveBtn()
        {
            var schemaName = schemaNameText.Text;

            var selectedDest = destinationEnvs.CheckedItems.Count > 0;

            var allowSave = schemaName != null && schemaName != "" && selectedDest;

            saveBtn.Enabled = allowSave;
        }

        private void schemaNameText_TextChanged(object sender, EventArgs e)
        {
            CheckAllowSaveBtn();
        }

        private void destinationEnvs_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAllowSaveBtn();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        public CreateInfo createInfo;

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var envVarInfo = new EnvVarInfo();
            envVarInfo.DisplayName = displayNameText.Text;
            envVarInfo.SchemaName = schemaNameText.Text;
            envVarInfo.Description = descriptionText.Text;
            envVarInfo.DefaultValue = defaultValueText.Text;
            envVarInfo.CurrentValue = currentValueText.Text;
            envVarInfo.DataType = int.Parse((dataTypeOption.SelectedItem as ListObject).Value);
            envVarInfo.DataType_formatted = (dataTypeOption.SelectedItem as ListObject).Name;

            var dest = new List<ConnectionDetail>();
            foreach (var item in destinationEnvs.CheckedItems)
            {
                if (item is KeyValuePair<Guid?, string> i)
                {
                    dest.Add(_envs.Find(env => env != null && env?.ConnectionId == i.Key));
                }
            }
            createInfo = new CreateInfo();
            createInfo.dest = dest;
            createInfo.info = envVarInfo;

            this.DialogResult = DialogResult.OK; // Close with OK result
            this.Close();



        }
    }
}
