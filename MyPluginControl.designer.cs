﻿namespace EnvVarChecker
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPluginControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.loadVarsBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idMatchCheckbox = new System.Windows.Forms.CheckBox();
            this.nameMatchCheckbox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EnvVarsCombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SolutionsCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentValue1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.defaultValue1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.displayName1 = new System.Windows.Forms.TextBox();
            this.schemaName1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refresh1 = new System.Windows.Forms.Button();
            this.save1_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.selectEnv2Btn = new System.Windows.Forms.Button();
            this.currentValue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultValue2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayName2 = new System.Windows.Forms.TextBox();
            this.schemaName2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.refresh2 = new System.Windows.Forms.Button();
            this.save2_btn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.selectEnv3Btn = new System.Windows.Forms.Button();
            this.currentValue3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.defaultValue3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.displayName3 = new System.Windows.Forms.TextBox();
            this.schemaName3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.refresh3 = new System.Windows.Forms.Button();
            this.save3_btn = new System.Windows.Forms.Button();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssSeparator1,
            this.toolStripButton1,
            this.loadVarsBtn});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1063, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            this.toolStripMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripMenu_ItemClicked);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(88, 22);
            this.toolStripButton1.Text = "Load solutions";
            this.toolStripButton1.Click += new System.EventHandler(this.LoadSolutionsBtn_Click);
            // 
            // loadVarsBtn
            // 
            this.loadVarsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.loadVarsBtn.Image = ((System.Drawing.Image)(resources.GetObject("loadVarsBtn.Image")));
            this.loadVarsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadVarsBtn.Name = "loadVarsBtn";
            this.loadVarsBtn.Size = new System.Drawing.Size(86, 22);
            this.loadVarsBtn.Text = "Load variables";
            this.loadVarsBtn.Click += new System.EventHandler(this.loadVarsBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.idMatchCheckbox);
            this.groupBox1.Controls.Add(this.nameMatchCheckbox);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.EnvVarsCombobox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SolutionsCombobox);
            this.groupBox1.Location = new System.Drawing.Point(2, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1059, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // idMatchCheckbox
            // 
            this.idMatchCheckbox.AutoSize = true;
            this.idMatchCheckbox.Location = new System.Drawing.Point(705, 36);
            this.idMatchCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.idMatchCheckbox.Name = "idMatchCheckbox";
            this.idMatchCheckbox.Size = new System.Drawing.Size(34, 17);
            this.idMatchCheckbox.TabIndex = 9;
            this.idMatchCheckbox.Text = "id";
            this.idMatchCheckbox.UseVisualStyleBackColor = true;
            this.idMatchCheckbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // nameMatchCheckbox
            // 
            this.nameMatchCheckbox.AutoSize = true;
            this.nameMatchCheckbox.Checked = true;
            this.nameMatchCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nameMatchCheckbox.Location = new System.Drawing.Point(609, 36);
            this.nameMatchCheckbox.Margin = new System.Windows.Forms.Padding(2);
            this.nameMatchCheckbox.Name = "nameMatchCheckbox";
            this.nameMatchCheckbox.Size = new System.Drawing.Size(92, 17);
            this.nameMatchCheckbox.TabIndex = 8;
            this.nameMatchCheckbox.Text = "schema name";
            this.nameMatchCheckbox.UseVisualStyleBackColor = true;
            this.nameMatchCheckbox.CheckedChanged += new System.EventHandler(this.nameMatchCheckbox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(606, 16);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(216, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Match env vars in different environments by:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Env var:";
            // 
            // EnvVarsCombobox
            // 
            this.EnvVarsCombobox.FormattingEnabled = true;
            this.EnvVarsCombobox.Location = new System.Drawing.Point(313, 32);
            this.EnvVarsCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.EnvVarsCombobox.Name = "EnvVarsCombobox";
            this.EnvVarsCombobox.Size = new System.Drawing.Size(275, 21);
            this.EnvVarsCombobox.TabIndex = 3;
            this.EnvVarsCombobox.SelectedIndexChanged += new System.EventHandler(this.EnvVarsCombobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Solution:";
            // 
            // SolutionsCombobox
            // 
            this.SolutionsCombobox.FormattingEnabled = true;
            this.SolutionsCombobox.Location = new System.Drawing.Point(18, 32);
            this.SolutionsCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.SolutionsCombobox.Name = "SolutionsCombobox";
            this.SolutionsCombobox.Size = new System.Drawing.Size(275, 21);
            this.SolutionsCombobox.TabIndex = 0;
            this.SolutionsCombobox.SelectedIndexChanged += new System.EventHandler(this.SolutionsCombobox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.currentValue1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.defaultValue1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.displayName1);
            this.groupBox2.Controls.Add(this.schemaName1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.refresh1);
            this.groupBox2.Controls.Add(this.save1_btn);
            this.groupBox2.Location = new System.Drawing.Point(2, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(370, 467);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source env";
            // 
            // currentValue1
            // 
            this.currentValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValue1.Location = new System.Drawing.Point(6, 266);
            this.currentValue1.Margin = new System.Windows.Forms.Padding(2);
            this.currentValue1.Multiline = true;
            this.currentValue1.Name = "currentValue1";
            this.currentValue1.Size = new System.Drawing.Size(360, 73);
            this.currentValue1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current value";
            // 
            // defaultValue1
            // 
            this.defaultValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValue1.Location = new System.Drawing.Point(6, 161);
            this.defaultValue1.Margin = new System.Windows.Forms.Padding(2);
            this.defaultValue1.Multiline = true;
            this.defaultValue1.Name = "defaultValue1";
            this.defaultValue1.Size = new System.Drawing.Size(360, 70);
            this.defaultValue1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Default Value";
            // 
            // displayName1
            // 
            this.displayName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayName1.Location = new System.Drawing.Point(6, 109);
            this.displayName1.Margin = new System.Windows.Forms.Padding(2);
            this.displayName1.Name = "displayName1";
            this.displayName1.Size = new System.Drawing.Size(360, 20);
            this.displayName1.TabIndex = 6;
            // 
            // schemaName1
            // 
            this.schemaName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaName1.Enabled = false;
            this.schemaName1.Location = new System.Drawing.Point(6, 60);
            this.schemaName1.Margin = new System.Windows.Forms.Padding(2);
            this.schemaName1.Name = "schemaName1";
            this.schemaName1.Size = new System.Drawing.Size(360, 20);
            this.schemaName1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Schema name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display name";
            // 
            // refresh1
            // 
            this.refresh1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh1.Location = new System.Drawing.Point(256, 17);
            this.refresh1.Margin = new System.Windows.Forms.Padding(2);
            this.refresh1.Name = "refresh1";
            this.refresh1.Size = new System.Drawing.Size(53, 21);
            this.refresh1.TabIndex = 2;
            this.refresh1.Text = "Refresh";
            this.refresh1.UseVisualStyleBackColor = true;
            this.refresh1.Click += new System.EventHandler(this.refresh1_Click);
            // 
            // save1_btn
            // 
            this.save1_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save1_btn.Location = new System.Drawing.Point(313, 17);
            this.save1_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save1_btn.Name = "save1_btn";
            this.save1_btn.Size = new System.Drawing.Size(53, 21);
            this.save1_btn.TabIndex = 0;
            this.save1_btn.Text = "Save";
            this.save1_btn.UseVisualStyleBackColor = true;
            this.save1_btn.Click += new System.EventHandler(this.save1_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.selectEnv2Btn);
            this.groupBox3.Controls.Add(this.currentValue2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.defaultValue2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.displayName2);
            this.groupBox3.Controls.Add(this.schemaName2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.refresh2);
            this.groupBox3.Controls.Add(this.save2_btn);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(376, 101);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(337, 467);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Env 2";
            // 
            // selectEnv2Btn
            // 
            this.selectEnv2Btn.Location = new System.Drawing.Point(6, 15);
            this.selectEnv2Btn.Margin = new System.Windows.Forms.Padding(2);
            this.selectEnv2Btn.Name = "selectEnv2Btn";
            this.selectEnv2Btn.Size = new System.Drawing.Size(53, 21);
            this.selectEnv2Btn.TabIndex = 11;
            this.selectEnv2Btn.Text = "Select";
            this.selectEnv2Btn.UseVisualStyleBackColor = true;
            this.selectEnv2Btn.Click += new System.EventHandler(this.selectEnv2Btn_Click);
            // 
            // currentValue2
            // 
            this.currentValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValue2.Enabled = false;
            this.currentValue2.Location = new System.Drawing.Point(6, 266);
            this.currentValue2.Margin = new System.Windows.Forms.Padding(2);
            this.currentValue2.Multiline = true;
            this.currentValue2.Name = "currentValue2";
            this.currentValue2.Size = new System.Drawing.Size(327, 73);
            this.currentValue2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current value";
            // 
            // defaultValue2
            // 
            this.defaultValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValue2.Enabled = false;
            this.defaultValue2.Location = new System.Drawing.Point(6, 161);
            this.defaultValue2.Margin = new System.Windows.Forms.Padding(2);
            this.defaultValue2.Multiline = true;
            this.defaultValue2.Name = "defaultValue2";
            this.defaultValue2.Size = new System.Drawing.Size(327, 70);
            this.defaultValue2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Default Value";
            // 
            // displayName2
            // 
            this.displayName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayName2.Enabled = false;
            this.displayName2.Location = new System.Drawing.Point(6, 109);
            this.displayName2.Margin = new System.Windows.Forms.Padding(2);
            this.displayName2.Name = "displayName2";
            this.displayName2.Size = new System.Drawing.Size(327, 20);
            this.displayName2.TabIndex = 6;
            // 
            // schemaName2
            // 
            this.schemaName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaName2.Enabled = false;
            this.schemaName2.Location = new System.Drawing.Point(6, 60);
            this.schemaName2.Margin = new System.Windows.Forms.Padding(2);
            this.schemaName2.Name = "schemaName2";
            this.schemaName2.Size = new System.Drawing.Size(327, 20);
            this.schemaName2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 44);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Schema name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Display name";
            // 
            // refresh2
            // 
            this.refresh2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh2.Enabled = false;
            this.refresh2.Location = new System.Drawing.Point(223, 17);
            this.refresh2.Margin = new System.Windows.Forms.Padding(2);
            this.refresh2.Name = "refresh2";
            this.refresh2.Size = new System.Drawing.Size(53, 21);
            this.refresh2.TabIndex = 2;
            this.refresh2.Text = "Refresh";
            this.refresh2.UseVisualStyleBackColor = true;
            this.refresh2.Click += new System.EventHandler(this.refresh2_Click);
            // 
            // save2_btn
            // 
            this.save2_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save2_btn.Enabled = false;
            this.save2_btn.Location = new System.Drawing.Point(280, 17);
            this.save2_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save2_btn.Name = "save2_btn";
            this.save2_btn.Size = new System.Drawing.Size(53, 21);
            this.save2_btn.TabIndex = 0;
            this.save2_btn.Text = "Save";
            this.save2_btn.UseVisualStyleBackColor = true;
            this.save2_btn.Click += new System.EventHandler(this.save2_btn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.selectEnv3Btn);
            this.groupBox4.Controls.Add(this.currentValue3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.defaultValue3);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.displayName3);
            this.groupBox4.Controls.Add(this.schemaName3);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.refresh3);
            this.groupBox4.Controls.Add(this.save3_btn);
            this.groupBox4.Location = new System.Drawing.Point(717, 101);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(344, 467);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Env 3";
            // 
            // selectEnv3Btn
            // 
            this.selectEnv3Btn.Location = new System.Drawing.Point(4, 15);
            this.selectEnv3Btn.Margin = new System.Windows.Forms.Padding(2);
            this.selectEnv3Btn.Name = "selectEnv3Btn";
            this.selectEnv3Btn.Size = new System.Drawing.Size(53, 21);
            this.selectEnv3Btn.TabIndex = 12;
            this.selectEnv3Btn.Text = "Select";
            this.selectEnv3Btn.UseVisualStyleBackColor = true;
            this.selectEnv3Btn.Click += new System.EventHandler(this.selectEnv3Btn_Click);
            // 
            // currentValue3
            // 
            this.currentValue3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValue3.Enabled = false;
            this.currentValue3.Location = new System.Drawing.Point(4, 266);
            this.currentValue3.Margin = new System.Windows.Forms.Padding(2);
            this.currentValue3.Multiline = true;
            this.currentValue3.Name = "currentValue3";
            this.currentValue3.Size = new System.Drawing.Size(337, 73);
            this.currentValue3.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 245);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Current value";
            // 
            // defaultValue3
            // 
            this.defaultValue3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValue3.Enabled = false;
            this.defaultValue3.Location = new System.Drawing.Point(6, 161);
            this.defaultValue3.Margin = new System.Windows.Forms.Padding(2);
            this.defaultValue3.Multiline = true;
            this.defaultValue3.Name = "defaultValue3";
            this.defaultValue3.Size = new System.Drawing.Size(334, 70);
            this.defaultValue3.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Default Value";
            // 
            // displayName3
            // 
            this.displayName3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayName3.Enabled = false;
            this.displayName3.Location = new System.Drawing.Point(6, 109);
            this.displayName3.Margin = new System.Windows.Forms.Padding(2);
            this.displayName3.Name = "displayName3";
            this.displayName3.Size = new System.Drawing.Size(334, 20);
            this.displayName3.TabIndex = 6;
            // 
            // schemaName3
            // 
            this.schemaName3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaName3.Enabled = false;
            this.schemaName3.Location = new System.Drawing.Point(6, 60);
            this.schemaName3.Margin = new System.Windows.Forms.Padding(2);
            this.schemaName3.Name = "schemaName3";
            this.schemaName3.Size = new System.Drawing.Size(334, 20);
            this.schemaName3.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Schema name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 88);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Display name";
            // 
            // refresh3
            // 
            this.refresh3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refresh3.Enabled = false;
            this.refresh3.Location = new System.Drawing.Point(230, 17);
            this.refresh3.Margin = new System.Windows.Forms.Padding(2);
            this.refresh3.Name = "refresh3";
            this.refresh3.Size = new System.Drawing.Size(53, 21);
            this.refresh3.TabIndex = 2;
            this.refresh3.Text = "Refresh";
            this.refresh3.UseVisualStyleBackColor = true;
            this.refresh3.Click += new System.EventHandler(this.refresh3_Click);
            // 
            // save3_btn
            // 
            this.save3_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save3_btn.Enabled = false;
            this.save3_btn.Location = new System.Drawing.Point(287, 17);
            this.save3_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save3_btn.Name = "save3_btn";
            this.save3_btn.Size = new System.Drawing.Size(53, 21);
            this.save3_btn.TabIndex = 0;
            this.save3_btn.Text = "Save";
            this.save3_btn.UseVisualStyleBackColor = true;
            this.save3_btn.Click += new System.EventHandler(this.save3_btn_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1063, 570);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox SolutionsCombobox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button save1_btn;
        private System.Windows.Forms.Button refresh1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox schemaName1;
        private System.Windows.Forms.TextBox displayName1;
        private System.Windows.Forms.TextBox currentValue1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox defaultValue1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton loadVarsBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox EnvVarsCombobox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox currentValue2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox defaultValue2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox displayName2;
        private System.Windows.Forms.TextBox schemaName2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button refresh2;
        private System.Windows.Forms.Button save2_btn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox currentValue3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox defaultValue3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox displayName3;
        private System.Windows.Forms.TextBox schemaName3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button refresh3;
        private System.Windows.Forms.Button save3_btn;
        private System.Windows.Forms.Button selectEnv2Btn;
        private System.Windows.Forms.Button selectEnv3Btn;
        private System.Windows.Forms.CheckBox nameMatchCheckbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox idMatchCheckbox;
    }
}
