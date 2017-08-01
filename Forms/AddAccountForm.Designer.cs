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
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 320);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ChooseAccountСomboBox);
            this.Name = "AddAccountForm";
            this.Text = "AddAccountForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ChooseAccountСomboBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AddAccountButton;
    }
}