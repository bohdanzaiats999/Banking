namespace Banking.Forms
{
    partial class ToSendMoneyForm
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
            this.ReceiverTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SendMoneyButton = new System.Windows.Forms.Button();
            this.ReceiverLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReceiverTextBox
            // 
            this.ReceiverTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ReceiverTextBox.Location = new System.Drawing.Point(107, 110);
            this.ReceiverTextBox.Name = "ReceiverTextBox";
            this.ReceiverTextBox.Size = new System.Drawing.Size(188, 30);
            this.ReceiverTextBox.TabIndex = 0;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AmountTextBox.Location = new System.Drawing.Point(149, 216);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(100, 30);
            this.AmountTextBox.TabIndex = 1;
            this.AmountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountTextBox_KeyPress);
            // 
            // SendMoneyButton
            // 
            this.SendMoneyButton.Location = new System.Drawing.Point(152, 296);
            this.SendMoneyButton.Name = "SendMoneyButton";
            this.SendMoneyButton.Size = new System.Drawing.Size(97, 33);
            this.SendMoneyButton.TabIndex = 2;
            this.SendMoneyButton.Text = "Send Money";
            this.SendMoneyButton.UseVisualStyleBackColor = true;
            this.SendMoneyButton.Click += new System.EventHandler(this.SendMoneyButton_Click);
            // 
            // ReceiverLabel
            // 
            this.ReceiverLabel.AutoSize = true;
            this.ReceiverLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReceiverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ReceiverLabel.Location = new System.Drawing.Point(143, 76);
            this.ReceiverLabel.Name = "ReceiverLabel";
            this.ReceiverLabel.Size = new System.Drawing.Size(130, 31);
            this.ReceiverLabel.TabIndex = 3;
            this.ReceiverLabel.Text = "Receiver:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AmountLabel.Location = new System.Drawing.Point(143, 182);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(115, 31);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Amount:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 302);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 27);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ToSendMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banking.Properties.Resources._48cba3ab;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 341);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ReceiverLabel);
            this.Controls.Add(this.SendMoneyButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.ReceiverTextBox);
            this.Name = "ToSendMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Send Money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ReceiverTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button SendMoneyButton;
        private System.Windows.Forms.Label ReceiverLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button BackButton;
    }
}