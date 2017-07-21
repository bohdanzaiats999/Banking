namespace Banking.Forms
{
    partial class OpenBillForm
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
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.OpenBillButton = new System.Windows.Forms.Button();
            this.LoginLable = new System.Windows.Forms.Label();
            this.PasswordLable = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LoginTextBox.Location = new System.Drawing.Point(68, 38);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(300, 30);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PasswordTextBox.Location = new System.Drawing.Point(68, 121);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(300, 30);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(68, 204);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(300, 30);
            this.ConfirmPasswordTextBox.TabIndex = 2;
            // 
            // OpenBillButton
            // 
            this.OpenBillButton.Location = new System.Drawing.Point(164, 252);
            this.OpenBillButton.Name = "OpenBillButton";
            this.OpenBillButton.Size = new System.Drawing.Size(100, 35);
            this.OpenBillButton.TabIndex = 3;
            this.OpenBillButton.Text = "Open Bill";
            this.OpenBillButton.UseVisualStyleBackColor = true;
            this.OpenBillButton.Click += new System.EventHandler(this.OpenBillButton_Click);
            // 
            // LoginLable
            // 
            this.LoginLable.AutoSize = true;
            this.LoginLable.BackColor = System.Drawing.Color.Transparent;
            this.LoginLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoginLable.Location = new System.Drawing.Point(174, -4);
            this.LoginLable.Name = "LoginLable";
            this.LoginLable.Size = new System.Drawing.Size(88, 31);
            this.LoginLable.TabIndex = 4;
            this.LoginLable.Text = "Login:";
            // 
            // PasswordLable
            // 
            this.PasswordLable.AutoSize = true;
            this.PasswordLable.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PasswordLable.Location = new System.Drawing.Point(147, 79);
            this.PasswordLable.Name = "PasswordLable";
            this.PasswordLable.Size = new System.Drawing.Size(142, 31);
            this.PasswordLable.TabIndex = 5;
            this.PasswordLable.Text = "Password:";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(96, 162);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(244, 31);
            this.ConfirmPasswordLabel.TabIndex = 6;
            this.ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(1, 254);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(77, 33);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OpenBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banking.Properties.Resources.icon_web_2x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(449, 290);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.PasswordLable);
            this.Controls.Add(this.LoginLable);
            this.Controls.Add(this.OpenBillButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "OpenBillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opening bill ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Button OpenBillButton;
        private System.Windows.Forms.Label LoginLable;
        private System.Windows.Forms.Label PasswordLable;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Button BackButton;
    }
}