namespace Banking.Forms
{
    partial class GetCashForm
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
            this.GetCashTextBox = new System.Windows.Forms.TextBox();
            this.GetCashButton = new System.Windows.Forms.Button();
            this.GetCashLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GetCashTextBox
            // 
            this.GetCashTextBox.Location = new System.Drawing.Point(151, 214);
            this.GetCashTextBox.Name = "GetCashTextBox";
            this.GetCashTextBox.Size = new System.Drawing.Size(123, 20);
            this.GetCashTextBox.TabIndex = 0;
            this.GetCashTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GetCashTextBox_KeyPress);
            // 
            // GetCashButton
            // 
            this.GetCashButton.Location = new System.Drawing.Point(167, 260);
            this.GetCashButton.Name = "GetCashButton";
            this.GetCashButton.Size = new System.Drawing.Size(96, 44);
            this.GetCashButton.TabIndex = 1;
            this.GetCashButton.Text = "Get Cash";
            this.GetCashButton.UseVisualStyleBackColor = true;
            this.GetCashButton.Click += new System.EventHandler(this.GetCashButton_Click);
            // 
            // GetCashLabel
            // 
            this.GetCashLabel.AutoSize = true;
            this.GetCashLabel.Location = new System.Drawing.Point(164, 198);
            this.GetCashLabel.Name = "GetCashLabel";
            this.GetCashLabel.Size = new System.Drawing.Size(88, 13);
            this.GetCashLabel.TabIndex = 2;
            this.GetCashLabel.Text = "Enter the amount";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 326);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GetCashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 361);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GetCashLabel);
            this.Controls.Add(this.GetCashButton);
            this.Controls.Add(this.GetCashTextBox);
            this.Name = "GetCashForm";
            this.Text = "GetCashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GetCashTextBox;
        private System.Windows.Forms.Button GetCashButton;
        private System.Windows.Forms.Label GetCashLabel;
        private System.Windows.Forms.Button BackButton;
    }
}