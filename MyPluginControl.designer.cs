namespace EnvVarChecker
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
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EnvVarsCombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SolutionsCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.env1_label = new System.Windows.Forms.Label();
            this.currentValue1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.defaultValue1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.displayName1 = new System.Windows.Forms.TextBox();
            this.schemaName1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.saveBtn_env1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.env2_label = new System.Windows.Forms.Label();
            this.selectEnv2Btn = new System.Windows.Forms.Button();
            this.currentValue2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.defaultValue2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayName2 = new System.Windows.Forms.TextBox();
            this.schemaName2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.env3_label = new System.Windows.Forms.Label();
            this.selectEnv3Btn = new System.Windows.Forms.Button();
            this.currentValue3 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.defaultValue3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.displayName3 = new System.Windows.Forms.TextBox();
            this.schemaName3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.nameMatchCheckbox = new System.Windows.Forms.CheckBox();
            this.idMatchCheckbox = new System.Windows.Forms.CheckBox();
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
            this.toolStripButton2});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1949, 44);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(151, 38);
            this.toolStripButton1.Text = "Load solutions";
            this.toolStripButton1.Click += new System.EventHandler(this.LoadSolutionsBtn_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(167, 38);
            this.toolStripButton2.Text = "toolStripButton2";
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
            this.groupBox1.Location = new System.Drawing.Point(4, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1942, 129);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(724, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Env var:";
            // 
            // EnvVarsCombobox
            // 
            this.EnvVarsCombobox.FormattingEnabled = true;
            this.EnvVarsCombobox.Location = new System.Drawing.Point(818, 28);
            this.EnvVarsCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.EnvVarsCombobox.Name = "EnvVarsCombobox";
            this.EnvVarsCombobox.Size = new System.Drawing.Size(501, 32);
            this.EnvVarsCombobox.TabIndex = 3;
            this.EnvVarsCombobox.SelectedIndexChanged += new System.EventHandler(this.EnvVarsCombobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Solution:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SolutionsCombobox
            // 
            this.SolutionsCombobox.FormattingEnabled = true;
            this.SolutionsCombobox.Location = new System.Drawing.Point(123, 26);
            this.SolutionsCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.SolutionsCombobox.Name = "SolutionsCombobox";
            this.SolutionsCombobox.Size = new System.Drawing.Size(501, 32);
            this.SolutionsCombobox.TabIndex = 0;
            this.SolutionsCombobox.SelectedIndexChanged += new System.EventHandler(this.SolutionsCombobox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.env1_label);
            this.groupBox2.Controls.Add(this.currentValue1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.defaultValue1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.displayName1);
            this.groupBox2.Controls.Add(this.schemaName1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.saveBtn_env1);
            this.groupBox2.Location = new System.Drawing.Point(4, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(678, 862);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Env 1";
            // 
            // env1_label
            // 
            this.env1_label.AutoSize = true;
            this.env1_label.Location = new System.Drawing.Point(7, 35);
            this.env1_label.Name = "env1_label";
            this.env1_label.Size = new System.Drawing.Size(57, 25);
            this.env1_label.TabIndex = 11;
            this.env1_label.Text = "Env1";
            // 
            // currentValue1
            // 
            this.currentValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValue1.Location = new System.Drawing.Point(11, 471);
            this.currentValue1.Margin = new System.Windows.Forms.Padding(4);
            this.currentValue1.Multiline = true;
            this.currentValue1.Name = "currentValue1";
            this.currentValue1.Size = new System.Drawing.Size(657, 131);
            this.currentValue1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 432);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current value";
            // 
            // defaultValue1
            // 
            this.defaultValue1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValue1.Location = new System.Drawing.Point(11, 297);
            this.defaultValue1.Margin = new System.Windows.Forms.Padding(4);
            this.defaultValue1.Multiline = true;
            this.defaultValue1.Name = "defaultValue1";
            this.defaultValue1.Size = new System.Drawing.Size(657, 126);
            this.defaultValue1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Default Value";
            // 
            // displayName1
            // 
            this.displayName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayName1.Location = new System.Drawing.Point(11, 201);
            this.displayName1.Margin = new System.Windows.Forms.Padding(4);
            this.displayName1.Name = "displayName1";
            this.displayName1.Size = new System.Drawing.Size(657, 29);
            this.displayName1.TabIndex = 6;
            // 
            // schemaName1
            // 
            this.schemaName1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaName1.Enabled = false;
            this.schemaName1.Location = new System.Drawing.Point(11, 111);
            this.schemaName1.Margin = new System.Windows.Forms.Padding(4);
            this.schemaName1.Name = "schemaName1";
            this.schemaName1.Size = new System.Drawing.Size(657, 29);
            this.schemaName1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Schema name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(469, 31);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // saveBtn_env1
            // 
            this.saveBtn_env1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn_env1.Location = new System.Drawing.Point(574, 31);
            this.saveBtn_env1.Margin = new System.Windows.Forms.Padding(4);
            this.saveBtn_env1.Name = "saveBtn_env1";
            this.saveBtn_env1.Size = new System.Drawing.Size(97, 39);
            this.saveBtn_env1.TabIndex = 0;
            this.saveBtn_env1.Text = "Save";
            this.saveBtn_env1.UseVisualStyleBackColor = true;
            this.saveBtn_env1.Click += new System.EventHandler(this.saveBtn_env1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.env2_label);
            this.groupBox3.Controls.Add(this.selectEnv2Btn);
            this.groupBox3.Controls.Add(this.currentValue2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.defaultValue2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.displayName2);
            this.groupBox3.Controls.Add(this.schemaName2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(689, 186);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(618, 862);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Env 2";
            // 
            // env2_label
            // 
            this.env2_label.AutoSize = true;
            this.env2_label.Location = new System.Drawing.Point(115, 35);
            this.env2_label.Name = "env2_label";
            this.env2_label.Size = new System.Drawing.Size(57, 25);
            this.env2_label.TabIndex = 12;
            this.env2_label.Text = "Env2";
            // 
            // selectEnv2Btn
            // 
            this.selectEnv2Btn.Location = new System.Drawing.Point(11, 28);
            this.selectEnv2Btn.Margin = new System.Windows.Forms.Padding(4);
            this.selectEnv2Btn.Name = "selectEnv2Btn";
            this.selectEnv2Btn.Size = new System.Drawing.Size(97, 39);
            this.selectEnv2Btn.TabIndex = 11;
            this.selectEnv2Btn.Text = "Select";
            this.selectEnv2Btn.UseVisualStyleBackColor = true;
            this.selectEnv2Btn.Click += new System.EventHandler(this.selectEnv2Btn_Click);
            // 
            // currentValue2
            // 
            this.currentValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValue2.Location = new System.Drawing.Point(11, 471);
            this.currentValue2.Margin = new System.Windows.Forms.Padding(4);
            this.currentValue2.Multiline = true;
            this.currentValue2.Name = "currentValue2";
            this.currentValue2.Size = new System.Drawing.Size(596, 131);
            this.currentValue2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 432);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current value";
            // 
            // defaultValue2
            // 
            this.defaultValue2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValue2.Location = new System.Drawing.Point(11, 297);
            this.defaultValue2.Margin = new System.Windows.Forms.Padding(4);
            this.defaultValue2.Multiline = true;
            this.defaultValue2.Name = "defaultValue2";
            this.defaultValue2.Size = new System.Drawing.Size(596, 126);
            this.defaultValue2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Default Value";
            // 
            // displayName2
            // 
            this.displayName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayName2.Location = new System.Drawing.Point(11, 201);
            this.displayName2.Margin = new System.Windows.Forms.Padding(4);
            this.displayName2.Name = "displayName2";
            this.displayName2.Size = new System.Drawing.Size(596, 29);
            this.displayName2.TabIndex = 6;
            // 
            // schemaName2
            // 
            this.schemaName2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaName2.Enabled = false;
            this.schemaName2.Location = new System.Drawing.Point(11, 111);
            this.schemaName2.Margin = new System.Windows.Forms.Padding(4);
            this.schemaName2.Name = "schemaName2";
            this.schemaName2.Size = new System.Drawing.Size(596, 29);
            this.schemaName2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Schema name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 162);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Display name";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(409, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(513, 31);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.env3_label);
            this.groupBox4.Controls.Add(this.selectEnv3Btn);
            this.groupBox4.Controls.Add(this.currentValue3);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.defaultValue3);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.displayName3);
            this.groupBox4.Controls.Add(this.schemaName3);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(1314, 186);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(631, 862);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Env 3";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // env3_label
            // 
            this.env3_label.AutoSize = true;
            this.env3_label.Location = new System.Drawing.Point(111, 35);
            this.env3_label.Name = "env3_label";
            this.env3_label.Size = new System.Drawing.Size(57, 25);
            this.env3_label.TabIndex = 13;
            this.env3_label.Text = "Env3";
            // 
            // selectEnv3Btn
            // 
            this.selectEnv3Btn.Location = new System.Drawing.Point(7, 28);
            this.selectEnv3Btn.Margin = new System.Windows.Forms.Padding(4);
            this.selectEnv3Btn.Name = "selectEnv3Btn";
            this.selectEnv3Btn.Size = new System.Drawing.Size(97, 39);
            this.selectEnv3Btn.TabIndex = 12;
            this.selectEnv3Btn.Text = "Select";
            this.selectEnv3Btn.UseVisualStyleBackColor = true;
            this.selectEnv3Btn.Click += new System.EventHandler(this.selectEnv3Btn_Click);
            // 
            // currentValue3
            // 
            this.currentValue3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValue3.Location = new System.Drawing.Point(6, 471);
            this.currentValue3.Margin = new System.Windows.Forms.Padding(4);
            this.currentValue3.Multiline = true;
            this.currentValue3.Name = "currentValue3";
            this.currentValue3.Size = new System.Drawing.Size(614, 131);
            this.currentValue3.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 432);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Current value";
            // 
            // defaultValue3
            // 
            this.defaultValue3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValue3.Location = new System.Drawing.Point(11, 297);
            this.defaultValue3.Margin = new System.Windows.Forms.Padding(4);
            this.defaultValue3.Multiline = true;
            this.defaultValue3.Name = "defaultValue3";
            this.defaultValue3.Size = new System.Drawing.Size(609, 126);
            this.defaultValue3.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 258);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Default Value";
            // 
            // displayName3
            // 
            this.displayName3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayName3.Location = new System.Drawing.Point(11, 201);
            this.displayName3.Margin = new System.Windows.Forms.Padding(4);
            this.displayName3.Name = "displayName3";
            this.displayName3.Size = new System.Drawing.Size(609, 29);
            this.displayName3.TabIndex = 6;
            // 
            // schemaName3
            // 
            this.schemaName3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaName3.Enabled = false;
            this.schemaName3.Location = new System.Drawing.Point(11, 111);
            this.schemaName3.Margin = new System.Windows.Forms.Padding(4);
            this.schemaName3.Name = "schemaName3";
            this.schemaName3.Size = new System.Drawing.Size(609, 29);
            this.schemaName3.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Schema name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 162);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Display name";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(422, 31);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 39);
            this.button4.TabIndex = 2;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(526, 31);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 39);
            this.button5.TabIndex = 0;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1436, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(393, 25);
            this.label15.TabIndex = 7;
            this.label15.Text = "Match env vars in different environments by:";
            // 
            // nameMatchCheckbox
            // 
            this.nameMatchCheckbox.AutoSize = true;
            this.nameMatchCheckbox.Checked = true;
            this.nameMatchCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nameMatchCheckbox.Location = new System.Drawing.Point(1518, 54);
            this.nameMatchCheckbox.Name = "nameMatchCheckbox";
            this.nameMatchCheckbox.Size = new System.Drawing.Size(161, 29);
            this.nameMatchCheckbox.TabIndex = 8;
            this.nameMatchCheckbox.Text = "schema name";
            this.nameMatchCheckbox.UseVisualStyleBackColor = true;
            this.nameMatchCheckbox.CheckedChanged += new System.EventHandler(this.nameMatchCheckbox_CheckedChanged);
            // 
            // idMatchCheckbox
            // 
            this.idMatchCheckbox.AutoSize = true;
            this.idMatchCheckbox.Location = new System.Drawing.Point(1441, 54);
            this.idMatchCheckbox.Name = "idMatchCheckbox";
            this.idMatchCheckbox.Size = new System.Drawing.Size(53, 29);
            this.idMatchCheckbox.TabIndex = 9;
            this.idMatchCheckbox.Text = "id";
            this.idMatchCheckbox.UseVisualStyleBackColor = true;
            this.idMatchCheckbox.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1949, 1052);
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
        private System.Windows.Forms.Button saveBtn_env1;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.ToolStripButton toolStripButton2;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox currentValue3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox defaultValue3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox displayName3;
        private System.Windows.Forms.TextBox schemaName3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button selectEnv2Btn;
        private System.Windows.Forms.Button selectEnv3Btn;
        private System.Windows.Forms.Label env1_label;
        private System.Windows.Forms.Label env2_label;
        private System.Windows.Forms.Label env3_label;
        private System.Windows.Forms.CheckBox nameMatchCheckbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox idMatchCheckbox;
    }
}
