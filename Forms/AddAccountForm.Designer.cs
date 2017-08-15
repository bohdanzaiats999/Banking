namespace Banking.Forms
{
    partial class AddAccountForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.DepositGroupBox = new System.Windows.Forms.GroupBox();
            this.DepositInterestRate15RadioButton = new System.Windows.Forms.RadioButton();
            this.DepositInterestRate25RadioButton = new System.Windows.Forms.RadioButton();
            this.DepositMoneyLabel = new System.Windows.Forms.Label();
            this.DepositInterestRateLabel = new System.Windows.Forms.Label();
            this.DepositMoneyTextBox = new System.Windows.Forms.TextBox();
            this.CreditGroupBox = new System.Windows.Forms.GroupBox();
            this.CreditAvailabilityCollateralCheckBox = new System.Windows.Forms.CheckBox();
            this.CreditMonthlyPaymentLabel = new System.Windows.Forms.Label();
            this.CreditMonthlyPaymentTextBox = new System.Windows.Forms.TextBox();
            this.CreditInterestRate15RadioButton = new System.Windows.Forms.RadioButton();
            this.CreditInterestRate25RadioButton = new System.Windows.Forms.RadioButton();
            this.CreditMoneyLabel = new System.Windows.Forms.Label();
            this.CreditInterestRateLabel = new System.Windows.Forms.Label();
            this.CreditMoneyTextBox = new System.Windows.Forms.TextBox();
            this.DepositGroupBox.SuspendLayout();
            this.CreditGroupBox.SuspendLayout();
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
            this.ChooseAccountСomboBox.Location = new System.Drawing.Point(21, 28);
            this.ChooseAccountСomboBox.Name = "ChooseAccountСomboBox";
            this.ChooseAccountСomboBox.Size = new System.Drawing.Size(181, 21);
            this.ChooseAccountСomboBox.TabIndex = 1;
            this.ChooseAccountСomboBox.TabStop = false;
            this.ChooseAccountСomboBox.Tag = "";
            this.ChooseAccountСomboBox.SelectedIndexChanged += new System.EventHandler(this.ChooseAccountСomboBox_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 285);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Location = new System.Drawing.Point(396, 285);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(98, 23);
            this.AddAccountButton.TabIndex = 3;
            this.AddAccountButton.Text = "Add Account";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // DepositGroupBox
            // 
            this.DepositGroupBox.Controls.Add(this.DepositInterestRate15RadioButton);
            this.DepositGroupBox.Controls.Add(this.DepositInterestRate25RadioButton);
            this.DepositGroupBox.Controls.Add(this.DepositMoneyLabel);
            this.DepositGroupBox.Controls.Add(this.DepositInterestRateLabel);
            this.DepositGroupBox.Controls.Add(this.DepositMoneyTextBox);
            this.DepositGroupBox.Location = new System.Drawing.Point(77, 94);
            this.DepositGroupBox.Name = "DepositGroupBox";
            this.DepositGroupBox.Size = new System.Drawing.Size(254, 147);
            this.DepositGroupBox.TabIndex = 4;
            this.DepositGroupBox.TabStop = false;
            this.DepositGroupBox.Text = "Deposit";
            this.DepositGroupBox.Visible = false;
            // 
            // DepositInterestRate15RadioButton
            // 
            this.DepositInterestRate15RadioButton.AutoSize = true;
            this.DepositInterestRate15RadioButton.Checked = true;
            this.DepositInterestRate15RadioButton.Location = new System.Drawing.Point(137, 44);
            this.DepositInterestRate15RadioButton.Name = "DepositInterestRate15RadioButton";
            this.DepositInterestRate15RadioButton.Size = new System.Drawing.Size(37, 17);
            this.DepositInterestRate15RadioButton.TabIndex = 5;
            this.DepositInterestRate15RadioButton.TabStop = true;
            this.DepositInterestRate15RadioButton.Text = "15";
            this.DepositInterestRate15RadioButton.UseVisualStyleBackColor = true;
            // 
            // DepositInterestRate25RadioButton
            // 
            this.DepositInterestRate25RadioButton.AutoSize = true;
            this.DepositInterestRate25RadioButton.Location = new System.Drawing.Point(137, 67);
            this.DepositInterestRate25RadioButton.Name = "DepositInterestRate25RadioButton";
            this.DepositInterestRate25RadioButton.Size = new System.Drawing.Size(37, 17);
            this.DepositInterestRate25RadioButton.TabIndex = 4;
            this.DepositInterestRate25RadioButton.Text = "25";
            this.DepositInterestRate25RadioButton.UseVisualStyleBackColor = true;
            // 
            // DepositMoneyLabel
            // 
            this.DepositMoneyLabel.AutoSize = true;
            this.DepositMoneyLabel.Location = new System.Drawing.Point(9, 22);
            this.DepositMoneyLabel.Name = "DepositMoneyLabel";
            this.DepositMoneyLabel.Size = new System.Drawing.Size(39, 13);
            this.DepositMoneyLabel.TabIndex = 3;
            this.DepositMoneyLabel.Text = "Money";
            // 
            // DepositInterestRateLabel
            // 
            this.DepositInterestRateLabel.AutoSize = true;
            this.DepositInterestRateLabel.Location = new System.Drawing.Point(137, 22);
            this.DepositInterestRateLabel.Name = "DepositInterestRateLabel";
            this.DepositInterestRateLabel.Size = new System.Drawing.Size(85, 13);
            this.DepositInterestRateLabel.TabIndex = 2;
            this.DepositInterestRateLabel.Text = "Interest Rate (%)";
            // 
            // DepositMoneyTextBox
            // 
            this.DepositMoneyTextBox.Location = new System.Drawing.Point(6, 41);
            this.DepositMoneyTextBox.Name = "DepositMoneyTextBox";
            this.DepositMoneyTextBox.Size = new System.Drawing.Size(73, 20);
            this.DepositMoneyTextBox.TabIndex = 1;
            this.DepositMoneyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepositMoneyTextBox_KeyPress);
            // 
            // CreditGroupBox
            // 
            this.CreditGroupBox.Controls.Add(this.CreditAvailabilityCollateralCheckBox);
            this.CreditGroupBox.Controls.Add(this.CreditMonthlyPaymentLabel);
            this.CreditGroupBox.Controls.Add(this.CreditMonthlyPaymentTextBox);
            this.CreditGroupBox.Controls.Add(this.CreditInterestRate15RadioButton);
            this.CreditGroupBox.Controls.Add(this.CreditInterestRate25RadioButton);
            this.CreditGroupBox.Controls.Add(this.CreditMoneyLabel);
            this.CreditGroupBox.Controls.Add(this.CreditInterestRateLabel);
            this.CreditGroupBox.Controls.Add(this.CreditMoneyTextBox);
            this.CreditGroupBox.Location = new System.Drawing.Point(45, 69);
            this.CreditGroupBox.Name = "CreditGroupBox";
            this.CreditGroupBox.Size = new System.Drawing.Size(371, 210);
            this.CreditGroupBox.TabIndex = 6;
            this.CreditGroupBox.TabStop = false;
            this.CreditGroupBox.Text = "Credit";
            this.CreditGroupBox.Visible = false;
            // 
            // CreditAvailabilityCollateralCheckBox
            // 
            this.CreditAvailabilityCollateralCheckBox.AutoSize = true;
            this.CreditAvailabilityCollateralCheckBox.Location = new System.Drawing.Point(137, 105);
            this.CreditAvailabilityCollateralCheckBox.Name = "CreditAvailabilityCollateralCheckBox";
            this.CreditAvailabilityCollateralCheckBox.Size = new System.Drawing.Size(121, 17);
            this.CreditAvailabilityCollateralCheckBox.TabIndex = 8;
            this.CreditAvailabilityCollateralCheckBox.Text = "Availability Collateral";
            this.CreditAvailabilityCollateralCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreditMonthlyPaymentLabel
            // 
            this.CreditMonthlyPaymentLabel.AutoSize = true;
            this.CreditMonthlyPaymentLabel.Location = new System.Drawing.Point(7, 84);
            this.CreditMonthlyPaymentLabel.Name = "CreditMonthlyPaymentLabel";
            this.CreditMonthlyPaymentLabel.Size = new System.Drawing.Size(88, 13);
            this.CreditMonthlyPaymentLabel.TabIndex = 7;
            this.CreditMonthlyPaymentLabel.Text = "Monthly Payment";
            // 
            // CreditMonthlyPaymentTextBox
            // 
            this.CreditMonthlyPaymentTextBox.Location = new System.Drawing.Point(6, 103);
            this.CreditMonthlyPaymentTextBox.Name = "CreditMonthlyPaymentTextBox";
            this.CreditMonthlyPaymentTextBox.Size = new System.Drawing.Size(73, 20);
            this.CreditMonthlyPaymentTextBox.TabIndex = 6;
            this.CreditMonthlyPaymentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreditMonthlyPaymentTextBox_KeyPress);
            // 
            // CreditInterestRate15RadioButton
            // 
            this.CreditInterestRate15RadioButton.AutoSize = true;
            this.CreditInterestRate15RadioButton.Checked = true;
            this.CreditInterestRate15RadioButton.Location = new System.Drawing.Point(137, 44);
            this.CreditInterestRate15RadioButton.Name = "CreditInterestRate15RadioButton";
            this.CreditInterestRate15RadioButton.Size = new System.Drawing.Size(37, 17);
            this.CreditInterestRate15RadioButton.TabIndex = 5;
            this.CreditInterestRate15RadioButton.TabStop = true;
            this.CreditInterestRate15RadioButton.Text = "15";
            this.CreditInterestRate15RadioButton.UseVisualStyleBackColor = true;
            // 
            // CreditInterestRate25RadioButton
            // 
            this.CreditInterestRate25RadioButton.AutoSize = true;
            this.CreditInterestRate25RadioButton.Location = new System.Drawing.Point(137, 67);
            this.CreditInterestRate25RadioButton.Name = "CreditInterestRate25RadioButton";
            this.CreditInterestRate25RadioButton.Size = new System.Drawing.Size(37, 17);
            this.CreditInterestRate25RadioButton.TabIndex = 4;
            this.CreditInterestRate25RadioButton.Text = "25";
            this.CreditInterestRate25RadioButton.UseVisualStyleBackColor = true;
            // 
            // CreditMoneyLabel
            // 
            this.CreditMoneyLabel.AutoSize = true;
            this.CreditMoneyLabel.Location = new System.Drawing.Point(9, 22);
            this.CreditMoneyLabel.Name = "CreditMoneyLabel";
            this.CreditMoneyLabel.Size = new System.Drawing.Size(39, 13);
            this.CreditMoneyLabel.TabIndex = 3;
            this.CreditMoneyLabel.Text = "Money";
            // 
            // CreditInterestRateLabel
            // 
            this.CreditInterestRateLabel.AutoSize = true;
            this.CreditInterestRateLabel.Location = new System.Drawing.Point(137, 22);
            this.CreditInterestRateLabel.Name = "CreditInterestRateLabel";
            this.CreditInterestRateLabel.Size = new System.Drawing.Size(85, 13);
            this.CreditInterestRateLabel.TabIndex = 2;
            this.CreditInterestRateLabel.Text = "Interest Rate (%)";
            // 
            // CreditMoneyTextBox
            // 
            this.CreditMoneyTextBox.Location = new System.Drawing.Point(6, 41);
            this.CreditMoneyTextBox.Name = "CreditMoneyTextBox";
            this.CreditMoneyTextBox.Size = new System.Drawing.Size(73, 20);
            this.CreditMoneyTextBox.TabIndex = 1;
            this.CreditMoneyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreditMoneyTextBox_KeyPress);
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 320);
            this.Controls.Add(this.CreditGroupBox);
            this.Controls.Add(this.DepositGroupBox);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChooseAccountСomboBox);
            this.Name = "AddAccountForm";
            this.Text = "AddAccountForm";
            this.DepositGroupBox.ResumeLayout(false);
            this.DepositGroupBox.PerformLayout();
            this.CreditGroupBox.ResumeLayout(false);
            this.CreditGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseAccountСomboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.GroupBox DepositGroupBox;
        private System.Windows.Forms.TextBox DepositMoneyTextBox;
        private System.Windows.Forms.Label DepositMoneyLabel;
        private System.Windows.Forms.Label DepositInterestRateLabel;
        private System.Windows.Forms.RadioButton DepositInterestRate25RadioButton;
        private System.Windows.Forms.RadioButton DepositInterestRate15RadioButton;
        private System.Windows.Forms.GroupBox CreditGroupBox;
        private System.Windows.Forms.RadioButton CreditInterestRate15RadioButton;
        private System.Windows.Forms.RadioButton CreditInterestRate25RadioButton;
        private System.Windows.Forms.Label CreditMoneyLabel;
        private System.Windows.Forms.Label CreditInterestRateLabel;
        private System.Windows.Forms.TextBox CreditMoneyTextBox;
        private System.Windows.Forms.TextBox CreditMonthlyPaymentTextBox;
        private System.Windows.Forms.Label CreditMonthlyPaymentLabel;
        private System.Windows.Forms.CheckBox CreditAvailabilityCollateralCheckBox;
    }
}