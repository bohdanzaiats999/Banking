namespace Banking.Forms
{
    partial class ControlPanelForm
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
            this.ChooseAccountСomboBox = new System.Windows.Forms.ComboBox();
            this.ChooseAccuntLabel = new System.Windows.Forms.Label();
            this.ChooseNumberСomboBox = new System.Windows.Forms.ComboBox();
            this.ChooseNumberLabel = new System.Windows.Forms.Label();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ChooseAccountGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseAccountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseAccountСomboBox
            // 
            this.ChooseAccountСomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Current",
            "Deposit",
            "Credit"});
            this.ChooseAccountСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseAccountСomboBox.FormattingEnabled = true;
            this.ChooseAccountСomboBox.Items.AddRange(new object[] {
            "Current",
            "Deposit",
            "Credit"});
            this.ChooseAccountСomboBox.Location = new System.Drawing.Point(6, 47);
            this.ChooseAccountСomboBox.Name = "ChooseAccountСomboBox";
            this.ChooseAccountСomboBox.Size = new System.Drawing.Size(181, 21);
            this.ChooseAccountСomboBox.TabIndex = 0;
            this.ChooseAccountСomboBox.TabStop = false;
            this.ChooseAccountСomboBox.Tag = "";
            this.ChooseAccountСomboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseAccountСomboBox_SelectedIndexChanged);
            // 
            // ChooseAccuntLabel
            // 
            this.ChooseAccuntLabel.AutoSize = true;
            this.ChooseAccuntLabel.Location = new System.Drawing.Point(7, 28);
            this.ChooseAccuntLabel.Name = "ChooseAccuntLabel";
            this.ChooseAccuntLabel.Size = new System.Drawing.Size(47, 13);
            this.ChooseAccuntLabel.TabIndex = 1;
            this.ChooseAccuntLabel.Text = "Account";
            // 
            // ChooseNumberСomboBox
            // 
            this.ChooseNumberСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseNumberСomboBox.FormattingEnabled = true;
            this.ChooseNumberСomboBox.Location = new System.Drawing.Point(239, 47);
            this.ChooseNumberСomboBox.Name = "ChooseNumberСomboBox";
            this.ChooseNumberСomboBox.Size = new System.Drawing.Size(181, 21);
            this.ChooseNumberСomboBox.TabIndex = 2;
            this.ChooseNumberСomboBox.TabStop = false;
            // 
            // ChooseNumberLabel
            // 
            this.ChooseNumberLabel.AutoSize = true;
            this.ChooseNumberLabel.Location = new System.Drawing.Point(248, 27);
            this.ChooseNumberLabel.Name = "ChooseNumberLabel";
            this.ChooseNumberLabel.Size = new System.Drawing.Size(44, 13);
            this.ChooseNumberLabel.TabIndex = 4;
            this.ChooseNumberLabel.Text = "Number";
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(656, 85);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(101, 29);
            this.AddAccountButton.TabIndex = 5;
            this.AddAccountButton.Text = "Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 400);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ChooseAccountGroupBox
            // 
            this.ChooseAccountGroupBox.Controls.Add(this.ChooseAccountСomboBox);
            this.ChooseAccountGroupBox.Controls.Add(this.ChooseAccuntLabel);
            this.ChooseAccountGroupBox.Controls.Add(this.ChooseNumberСomboBox);
            this.ChooseAccountGroupBox.Controls.Add(this.ChooseNumberLabel);
            this.ChooseAccountGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseAccountGroupBox.Location = new System.Drawing.Point(12, 4);
            this.ChooseAccountGroupBox.Name = "ChooseAccountGroupBox";
            this.ChooseAccountGroupBox.Size = new System.Drawing.Size(430, 96);
            this.ChooseAccountGroupBox.TabIndex = 7;
            this.ChooseAccountGroupBox.TabStop = false;
            this.ChooseAccountGroupBox.Text = "Choose Account";
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(769, 441);
            this.Controls.Add(this.ChooseAccountGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddAccountButton);
            this.Name = "ControlPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlPanelForm";
            this.ChooseAccountGroupBox.ResumeLayout(false);
            this.ChooseAccountGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseAccountСomboBox;
        private System.Windows.Forms.Label ChooseAccuntLabel;
        private System.Windows.Forms.ComboBox ChooseNumberСomboBox;
        private System.Windows.Forms.Label ChooseNumberLabel;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox ChooseAccountGroupBox;
    }
}