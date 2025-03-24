namespace EnvVarChecker
{
    partial class NewEnvVarDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.displayNameText = new System.Windows.Forms.TextBox();
            this.schemaNameText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTypeOption = new System.Windows.Forms.ComboBox();
            this.currentValueText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.defaultValueText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.destinationEnvs = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // displayNameText
            // 
            this.displayNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayNameText.Location = new System.Drawing.Point(12, 31);
            this.displayNameText.Name = "displayNameText";
            this.displayNameText.Size = new System.Drawing.Size(517, 20);
            this.displayNameText.TabIndex = 1;
            // 
            // schemaNameText
            // 
            this.schemaNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.schemaNameText.Location = new System.Drawing.Point(12, 79);
            this.schemaNameText.Name = "schemaNameText";
            this.schemaNameText.Size = new System.Drawing.Size(517, 20);
            this.schemaNameText.TabIndex = 13;
            this.schemaNameText.TextChanged += new System.EventHandler(this.schemaNameText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(9, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name (add the prefix too)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(9, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // descriptionText
            // 
            this.descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionText.Location = new System.Drawing.Point(12, 128);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(517, 83);
            this.descriptionText.TabIndex = 15;
            this.descriptionText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description:";
            // 
            // dataTypeOption
            // 
            this.dataTypeOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataTypeOption.FormattingEnabled = true;
            this.dataTypeOption.Location = new System.Drawing.Point(12, 241);
            this.dataTypeOption.Name = "dataTypeOption";
            this.dataTypeOption.Size = new System.Drawing.Size(517, 21);
            this.dataTypeOption.TabIndex = 17;
            this.dataTypeOption.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // currentValueText
            // 
            this.currentValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentValueText.Location = new System.Drawing.Point(11, 342);
            this.currentValueText.Name = "currentValueText";
            this.currentValueText.Size = new System.Drawing.Size(518, 20);
            this.currentValueText.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(9, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Current value:";
            // 
            // defaultValueText
            // 
            this.defaultValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defaultValueText.Location = new System.Drawing.Point(11, 291);
            this.defaultValueText.Name = "defaultValueText";
            this.defaultValueText.Size = new System.Drawing.Size(518, 20);
            this.defaultValueText.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(9, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Default value:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // destinationEnvs
            // 
            this.destinationEnvs.BackColor = System.Drawing.SystemColors.Control;
            this.destinationEnvs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.destinationEnvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationEnvs.FormattingEnabled = true;
            this.destinationEnvs.Location = new System.Drawing.Point(11, 393);
            this.destinationEnvs.Name = "destinationEnvs";
            this.destinationEnvs.Size = new System.Drawing.Size(238, 90);
            this.destinationEnvs.TabIndex = 22;
            this.destinationEnvs.SelectedIndexChanged += new System.EventHandler(this.destinationEnvs_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(8, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Add to environments:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelBtn.Location = new System.Drawing.Point(456, 476);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(73, 33);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.Enabled = false;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.Location = new System.Drawing.Point(386, 476);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(64, 33);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NewEnvVarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 521);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.destinationEnvs);
            this.Controls.Add(this.currentValueText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.defaultValueText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataTypeOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.schemaNameText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.displayNameText);
            this.Controls.Add(this.label1);
            this.Name = "NewEnvVarDialog";
            this.Text = "New environment variable";
            this.Load += new System.EventHandler(this.NewEnvVarDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox displayNameText;
        private System.Windows.Forms.TextBox schemaNameText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dataTypeOption;
        private System.Windows.Forms.TextBox currentValueText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox defaultValueText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox destinationEnvs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}