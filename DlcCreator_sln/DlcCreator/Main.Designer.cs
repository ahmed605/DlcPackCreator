namespace DlcCreator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.CreateDlcPackButton = new System.Windows.Forms.Button();
            this.DlcTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DlcNameTextBox = new System.Windows.Forms.TextBox();
            this.DlcNameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DlcListItemTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateDlcPackButton
            // 
            this.CreateDlcPackButton.Location = new System.Drawing.Point(284, 67);
            this.CreateDlcPackButton.Name = "CreateDlcPackButton";
            this.CreateDlcPackButton.Size = new System.Drawing.Size(75, 23);
            this.CreateDlcPackButton.TabIndex = 0;
            this.CreateDlcPackButton.Text = "Create Dlc";
            this.CreateDlcPackButton.UseVisualStyleBackColor = true;
            this.CreateDlcPackButton.Click += new System.EventHandler(this.CreateDlcPackButton_Click);
            // 
            // DlcTypeComboBox
            // 
            this.DlcTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DlcTypeComboBox.FormattingEnabled = true;
            this.DlcTypeComboBox.Items.AddRange(new object[] {
            "Map",
            "Vehicle"});
            this.DlcTypeComboBox.Location = new System.Drawing.Point(91, 41);
            this.DlcTypeComboBox.Name = "DlcTypeComboBox";
            this.DlcTypeComboBox.Size = new System.Drawing.Size(268, 21);
            this.DlcTypeComboBox.TabIndex = 1;
            // 
            // DlcNameTextBox
            // 
            this.DlcNameTextBox.Location = new System.Drawing.Point(91, 15);
            this.DlcNameTextBox.Name = "DlcNameTextBox";
            this.DlcNameTextBox.Size = new System.Drawing.Size(268, 20);
            this.DlcNameTextBox.TabIndex = 2;
            // 
            // DlcNameLabel
            // 
            this.DlcNameLabel.AutoSize = true;
            this.DlcNameLabel.Location = new System.Drawing.Point(12, 18);
            this.DlcNameLabel.Name = "DlcNameLabel";
            this.DlcNameLabel.Size = new System.Drawing.Size(65, 15);
            this.DlcNameLabel.TabIndex = 3;
            this.DlcNameLabel.Text = "Dlc Name:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(12, 44);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(36, 15);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "DlcList Item:";
            // 
            // DlcListItemTextBox
            // 
            this.DlcListItemTextBox.Location = new System.Drawing.Point(91, 70);
            this.DlcListItemTextBox.Name = "DlcListItemTextBox";
            this.DlcListItemTextBox.ReadOnly = true;
            this.DlcListItemTextBox.Size = new System.Drawing.Size(187, 20);
            this.DlcListItemTextBox.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 102);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DlcListItemTextBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.DlcNameLabel);
            this.Controls.Add(this.DlcNameTextBox);
            this.Controls.Add(this.DlcTypeComboBox);
            this.Controls.Add(this.CreateDlcPackButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(404, 141);
            this.MinimumSize = new System.Drawing.Size(404, 141);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Dlc Pack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateDlcPackButton;
        private System.Windows.Forms.ComboBox DlcTypeComboBox;
        private System.Windows.Forms.TextBox DlcNameTextBox;
        private System.Windows.Forms.Label DlcNameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DlcListItemTextBox;
    }
}

