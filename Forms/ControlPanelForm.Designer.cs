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
            this.button4 = new System.Windows.Forms.Button();
            this.AccountStatusLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RefillButton
            // 
            this.RefillButton.Location = new System.Drawing.Point(51, 203);
            this.RefillButton.Name = "RefillButton";
            this.RefillButton.Size = new System.Drawing.Size(129, 46);
            this.RefillButton.TabIndex = 0;
            this.RefillButton.Text = "Refill";
            this.RefillButton.UseVisualStyleBackColor = true;
            this.RefillButton.Click += new System.EventHandler(this.RefillButton_Click);
            // 
            // ToSendMoneyButton
            // 
            this.ToSendMoneyButton.Location = new System.Drawing.Point(51, 254);
            this.ToSendMoneyButton.Name = "ToSendMoneyButton";
            this.ToSendMoneyButton.Size = new System.Drawing.Size(129, 46);
            this.ToSendMoneyButton.TabIndex = 1;
            this.ToSendMoneyButton.Text = "To send money";
            this.ToSendMoneyButton.UseVisualStyleBackColor = true;
            this.ToSendMoneyButton.Click += new System.EventHandler(this.ToSendMoneyButton_Click);
            // 
            // GetCashButton
            // 
            this.GetCashButton.Location = new System.Drawing.Point(180, 203);
            this.GetCashButton.Name = "GetCashButton";
            this.GetCashButton.Size = new System.Drawing.Size(129, 46);
            this.GetCashButton.TabIndex = 2;
            this.GetCashButton.Text = "Get cash";
            this.GetCashButton.UseVisualStyleBackColor = true;
            this.GetCashButton.Click += new System.EventHandler(this.GetCashButton_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(180, 254);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // AccountStatusLabel
            // 
            this.AccountStatusLabel.AutoSize = true;
            this.AccountStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccountStatusLabel.Location = new System.Drawing.Point(151, 84);
            this.AccountStatusLabel.Name = "AccountStatusLabel";
            this.AccountStatusLabel.Size = new System.Drawing.Size(29, 31);
            this.AccountStatusLabel.TabIndex = 4;
            this.AccountStatusLabel.Text = "0";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 307);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ControlPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 342);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AccountStatusLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.GetCashButton);
            this.Controls.Add(this.ToSendMoneyButton);
            this.Controls.Add(this.RefillButton);
            this.Name = "ControlPanelForm";
            this.Text = "Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefillButton;
        private System.Windows.Forms.Button ToSendMoneyButton;
        private System.Windows.Forms.Button GetCashButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label AccountStatusLabel;
        private System.Windows.Forms.Button BackButton;
    }
}