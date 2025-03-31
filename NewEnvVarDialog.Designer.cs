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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEnvVarDialog));
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
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display name";
            // 
            // displayNameText
            // 
            this.displayNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayNameText.Location = new System.Drawing.Point(22, 57);
            this.displayNameText.Margin = new System.Windows.Forms.Padding(6);
            this.displayNameText.Name = "displayNameText";
            this.displayNameText.Size = new System.Drawing.Size(955, 29);
            this.displayNameText.TabIndex = 1;
            // 
            // schemaNameText
            // 
            this.schemaNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schemaNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.schemaNameText.Location = new System.Drawing.Point(22, 146);
            this.schemaNameText.Margin = new System.Windows.Forms.Padding(6);
            this.schemaNameText.Name = "schemaNameText";
            this.schemaNameText.Size = new System.Drawing.Size(955, 29);
            this.schemaNameText.TabIndex = 13;
            this.schemaNameText.TextChanged += new System.EventHandler(this.schemaNameText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(16, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name (add the prefix too)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 415);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Data type:";
            // 
            // descriptionText
            // 
            this.descriptionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionText.Location = new System.Drawing.Point(22, 236);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(6);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(955, 150);
            this.descriptionText.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(16, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Description:";
            // 
            // dataTypeOption
            // 
            this.dataTypeOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTypeOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataTypeOption.FormattingEnabled = true;
            this.dataTypeOption.Location = new System.Drawing.Point(22, 445);
            this.dataTypeOption.Margin = new System.Windows.Forms.Padding(6);
            this.dataTypeOption.Name = "dataTypeOption";
            this.dataTypeOption.Size = new System.Drawing.Size(955, 32);
            this.dataTypeOption.TabIndex = 17;
            // 
            // currentValueText
            // 
            this.currentValueText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentValueText.Location = new System.Drawing.Point(20, 631);
            this.currentValueText.Margin = new System.Windows.Forms.Padding(6);
            this.currentValueText.Name = "currentValueText";
            this.currentValueText.Size = new System.Drawing.Size(957, 29);
            this.currentValueText.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(16, 602);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Current value:";
            // 
            // defaultValueText
            // 
            this.defaultValueText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultValueText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.defaultValueText.Location = new System.Drawing.Point(20, 537);
            this.defaultValueText.Margin = new System.Windows.Forms.Padding(6);
            this.defaultValueText.Name = "defaultValueText";
            this.defaultValueText.Size = new System.Drawing.Size(957, 29);
            this.defaultValueText.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(16, 508);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Default value:";
            // 
            // destinationEnvs
            // 
            this.destinationEnvs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationEnvs.BackColor = System.Drawing.SystemColors.Control;
            this.destinationEnvs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.destinationEnvs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.destinationEnvs.FormattingEnabled = true;
            this.destinationEnvs.Location = new System.Drawing.Point(20, 726);
            this.destinationEnvs.Margin = new System.Windows.Forms.Padding(6);
            this.destinationEnvs.Name = "destinationEnvs";
            this.destinationEnvs.Size = new System.Drawing.Size(957, 156);
            this.destinationEnvs.TabIndex = 22;
            this.destinationEnvs.SelectedIndexChanged += new System.EventHandler(this.destinationEnvs_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(15, 696);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Add to environments:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelBtn.Location = new System.Drawing.Point(843, 983);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(134, 61);
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
            this.saveBtn.Location = new System.Drawing.Point(714, 983);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(117, 61);
            this.saveBtn.TabIndex = 25;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NewEnvVarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 1059);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewEnvVarDialog";
            this.Text = "New environment variable";
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