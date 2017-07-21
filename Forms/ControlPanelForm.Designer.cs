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
            this.RefillButton = new System.Windows.Forms.Button();
            this.ToSendMoneyButton = new System.Windows.Forms.Button();
            this.GetCashButton = new System.Windows.Forms.Button();
            this.CloseAnAccountButton = new System.Windows.Forms.Button();
            this.AccountStatusLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RefillButton
            // 
            this.RefillButton.Location = new System.Drawing.Point(51, 90);
            this.RefillButton.Name = "RefillButton";
            this.RefillButton.Size = new System.Drawing.Size(129, 38);
            this.RefillButton.TabIndex = 0;
            this.RefillButton.Text = "Refill";
            this.RefillButton.UseVisualStyleBackColor = true;
            this.RefillButton.Click += new System.EventHandler(this.RefillButton_Click);
            // 
            // ToSendMoneyButton
            // 
            this.ToSendMoneyButton.Location = new System.Drawing.Point(51, 158);
            this.ToSendMoneyButton.Name = "ToSendMoneyButton";
            this.ToSendMoneyButton.Size = new System.Drawing.Size(129, 38);
            this.ToSendMoneyButton.TabIndex = 1;
            this.ToSendMoneyButton.Text = "To send money";
            this.ToSendMoneyButton.UseVisualStyleBackColor = true;
            this.ToSendMoneyButton.Click += new System.EventHandler(this.ToSendMoneyButton_Click);
            // 
            // GetCashButton
            // 
            this.GetCashButton.Location = new System.Drawing.Point(294, 90);
            this.GetCashButton.Name = "GetCashButton";
            this.GetCashButton.Size = new System.Drawing.Size(129, 38);
            this.GetCashButton.TabIndex = 2;
            this.GetCashButton.Text = "Get cash";
            this.GetCashButton.UseVisualStyleBackColor = true;
            this.GetCashButton.Click += new System.EventHandler(this.GetCashButton_Click);
            // 
            // CloseAnAccountButton
            // 
            this.CloseAnAccountButton.Location = new System.Drawing.Point(294, 157);
            this.CloseAnAccountButton.Name = "CloseAnAccountButton";
            this.CloseAnAccountButton.Size = new System.Drawing.Size(129, 39);
            this.CloseAnAccountButton.TabIndex = 3;
            this.CloseAnAccountButton.Text = "Close an account";
            this.CloseAnAccountButton.UseVisualStyleBackColor = true;
            this.CloseAnAccountButton.Click += new System.EventHandler(this.CloseAnAccountButton_Click);
            // 
            // AccountStatusLabel
            // 
            this.AccountStatusLabel.AutoSize = true;
            this.AccountStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.AccountStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.AccountStatusLabel.Location = new System.Drawing.Point(198, 33);
            this.AccountStatusLabel.Name = "AccountStatusLabel";
            this.AccountStatusLabel.Size = new System.Drawing.Size(75, 46);
            this.AccountStatusLabel.TabIndex = 4;
            this.AccountStatusLabel.Text = "0 $";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(10, 230);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 32);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banking.Properties.Resources._29015;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(455, 272);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AccountStatusLabel);
            this.Controls.Add(this.CloseAnAccountButton);
            this.Controls.Add(this.GetCashButton);
            this.Controls.Add(this.ToSendMoneyButton);
            this.Controls.Add(this.RefillButton);
            this.Name = "ControlPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefillButton;
        private System.Windows.Forms.Button ToSendMoneyButton;
        private System.Windows.Forms.Button GetCashButton;
        private System.Windows.Forms.Button CloseAnAccountButton;
        private System.Windows.Forms.Label AccountStatusLabel;
        private System.Windows.Forms.Button BackButton;
    }
}