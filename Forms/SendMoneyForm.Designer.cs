namespace Banking.Forms
{
    partial class SendMoneyForm
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
            this.ToTheCardTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ToTheCardLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ToTheCardTextBox
            // 
            this.ToTheCardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ToTheCardTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToTheCardTextBox.Location = new System.Drawing.Point(89, 88);
            this.ToTheCardTextBox.MaximumSize = new System.Drawing.Size(300, 30);
            this.ToTheCardTextBox.MaxLength = 100;
            this.ToTheCardTextBox.Name = "ToTheCardTextBox";
            this.ToTheCardTextBox.Size = new System.Drawing.Size(214, 30);
            this.ToTheCardTextBox.TabIndex = 2;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AmountTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AmountTextBox.Location = new System.Drawing.Point(137, 186);
            this.AmountTextBox.MaximumSize = new System.Drawing.Size(300, 30);
            this.AmountTextBox.MaxLength = 100;
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(118, 30);
            this.AmountTextBox.TabIndex = 3;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.Color.Transparent;
            this.SendButton.Location = new System.Drawing.Point(149, 285);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(93, 32);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ToTheCardLabel
            // 
            this.ToTheCardLabel.AutoSize = true;
            this.ToTheCardLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToTheCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToTheCardLabel.Location = new System.Drawing.Point(121, 54);
            this.ToTheCardLabel.MinimumSize = new System.Drawing.Size(5, 5);
            this.ToTheCardLabel.Name = "ToTheCardLabel";
            this.ToTheCardLabel.Size = new System.Drawing.Size(151, 31);
            this.ToTheCardLabel.TabIndex = 6;
            this.ToTheCardLabel.Text = "To the card";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(143, 152);
            this.AmountLabel.MinimumSize = new System.Drawing.Size(5, 5);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(107, 31);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Amount";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 288);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SendMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 329);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ToTheCardLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.ToTheCardTextBox);
            this.Name = "SendMoneyForm";
            this.Text = "SendMoneyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ToTheCardTextBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label ToTheCardLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Button BackButton;
    }
}