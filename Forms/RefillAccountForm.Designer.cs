namespace Banking.Forms
{
    partial class RefillAccountForm
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
            this.RefillAccountTextBox = new System.Windows.Forms.TextBox();
            this.RefillAccountButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RefillAccountTextBox
            // 
            this.RefillAccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RefillAccountTextBox.Location = new System.Drawing.Point(131, 144);
            this.RefillAccountTextBox.Name = "RefillAccountTextBox";
            this.RefillAccountTextBox.Size = new System.Drawing.Size(100, 38);
            this.RefillAccountTextBox.TabIndex = 0;
            this.RefillAccountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RefillAccountTextBox_KeyPress);
            // 
            // RefillAccountButton
            // 
            this.RefillAccountButton.Location = new System.Drawing.Point(144, 213);
            this.RefillAccountButton.Name = "RefillAccountButton";
            this.RefillAccountButton.Size = new System.Drawing.Size(75, 32);
            this.RefillAccountButton.TabIndex = 1;
            this.RefillAccountButton.Text = "Refill";
            this.RefillAccountButton.UseVisualStyleBackColor = true;
            this.RefillAccountButton.Click += new System.EventHandler(this.RefillAccountButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 316);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RefillAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 357);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RefillAccountButton);
            this.Controls.Add(this.RefillAccountTextBox);
            this.Name = "RefillAccountForm";
            this.Text = "RefillAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RefillAccountTextBox;
        private System.Windows.Forms.Button RefillAccountButton;
        private System.Windows.Forms.Button BackButton;
    }
}