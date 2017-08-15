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
            this.MoneyStatusLabel = new System.Windows.Forms.Label();
            this.MoneyInfoLabel = new System.Windows.Forms.Label();
            this.InterestRateStatusLable = new System.Windows.Forms.Label();
            this.InterestRateInfoLabel = new System.Windows.Forms.Label();
            this.InterestRateGroupBox = new System.Windows.Forms.GroupBox();
            this.CloseAccountButton = new System.Windows.Forms.Button();
            this.ChooseAccountGroupBox.SuspendLayout();
            this.InterestRateGroupBox.SuspendLayout();
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
            this.ChooseNumberСomboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseNumberСomboBox_SelectedIndexChanged);
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
            // MoneyStatusLabel
            // 
            this.MoneyStatusLabel.AutoSize = true;
            this.MoneyStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MoneyStatusLabel.Location = new System.Drawing.Point(469, 229);
            this.MoneyStatusLabel.Name = "MoneyStatusLabel";
            this.MoneyStatusLabel.Size = new System.Drawing.Size(51, 31);
            this.MoneyStatusLabel.TabIndex = 8;
            this.MoneyStatusLabel.Text = "0 $";
            // 
            // MoneyInfoLabel
            // 
            this.MoneyInfoLabel.AutoSize = true;
            this.MoneyInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.MoneyInfoLabel.Location = new System.Drawing.Point(169, 229);
            this.MoneyInfoLabel.Name = "MoneyInfoLabel";
            this.MoneyInfoLabel.Size = new System.Drawing.Size(303, 31);
            this.MoneyInfoLabel.TabIndex = 9;
            this.MoneyInfoLabel.Text = "Money on your account:";
            // 
            // InterestRateStatusLable
            // 
            this.InterestRateStatusLable.AutoSize = true;
            this.InterestRateStatusLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.InterestRateStatusLable.Location = new System.Drawing.Point(177, 16);
            this.InterestRateStatusLable.Name = "InterestRateStatusLable";
            this.InterestRateStatusLable.Size = new System.Drawing.Size(60, 31);
            this.InterestRateStatusLable.TabIndex = 10;
            this.InterestRateStatusLable.Text = "0 %";
            // 
            // InterestRateInfoLabel
            // 
            this.InterestRateInfoLabel.AutoSize = true;
            this.InterestRateInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.InterestRateInfoLabel.Location = new System.Drawing.Point(3, 16);
            this.InterestRateInfoLabel.Name = "InterestRateInfoLabel";
            this.InterestRateInfoLabel.Size = new System.Drawing.Size(168, 31);
            this.InterestRateInfoLabel.TabIndex = 11;
            this.InterestRateInfoLabel.Text = "Interest rate:";
            // 
            // InterestRateGroupBox
            // 
            this.InterestRateGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.InterestRateGroupBox.Controls.Add(this.InterestRateInfoLabel);
            this.InterestRateGroupBox.Controls.Add(this.InterestRateStatusLable);
            this.InterestRateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(204)));
            this.InterestRateGroupBox.Location = new System.Drawing.Point(166, 287);
            this.InterestRateGroupBox.Name = "InterestRateGroupBox";
            this.InterestRateGroupBox.Size = new System.Drawing.Size(245, 58);
            this.InterestRateGroupBox.TabIndex = 12;
            this.InterestRateGroupBox.TabStop = false;
            this.InterestRateGroupBox.Visible = false;
            // 
            // CloseAccountButton
            // 
            this.CloseAccountButton.Location = new System.Drawing.Point(656, 216);
            this.CloseAccountButton.Name = "CloseAccountButton";
            this.CloseAccountButton.Size = new System.Drawing.Size(101, 29);
            this.CloseAccountButton.TabIndex = 13;
            this.CloseAccountButton.Text = "Close Account";
            this.CloseAccountButton.UseVisualStyleBackColor = true;
            this.CloseAccountButton.Click += new System.EventHandler(this.CloseAccountButton_Click);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(769, 441);
            this.Controls.Add(this.CloseAccountButton);
            this.Controls.Add(this.InterestRateGroupBox);
            this.Controls.Add(this.MoneyInfoLabel);
            this.Controls.Add(this.MoneyStatusLabel);
            this.Controls.Add(this.ChooseAccountGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddAccountButton);
            this.Name = "ControlPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlPanelForm";
            this.ChooseAccountGroupBox.ResumeLayout(false);
            this.ChooseAccountGroupBox.PerformLayout();
            this.InterestRateGroupBox.ResumeLayout(false);
            this.InterestRateGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseAccountСomboBox;
        private System.Windows.Forms.Label ChooseAccuntLabel;
        private System.Windows.Forms.ComboBox ChooseNumberСomboBox;
        private System.Windows.Forms.Label ChooseNumberLabel;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox ChooseAccountGroupBox;
        private System.Windows.Forms.Label MoneyStatusLabel;
        private System.Windows.Forms.Label MoneyInfoLabel;
        private System.Windows.Forms.Label InterestRateStatusLable;
        private System.Windows.Forms.Label InterestRateInfoLabel;
        private System.Windows.Forms.GroupBox InterestRateGroupBox;
        private System.Windows.Forms.Button CloseAccountButton;
    }
}