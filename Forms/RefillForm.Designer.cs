namespace Banking.Forms
{
    partial class RefillForm
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
            this.RefillTextBox = new System.Windows.Forms.TextBox();
            this.RefillLabel = new System.Windows.Forms.Label();
            this.RefillButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RefillTextBox
            // 
            this.RefillTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RefillTextBox.Location = new System.Drawing.Point(149, 170);
            this.RefillTextBox.Name = "RefillTextBox";
            this.RefillTextBox.Size = new System.Drawing.Size(115, 30);
            this.RefillTextBox.TabIndex = 0;
            this.RefillTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RefillTextBox_KeyPress);
            // 
            // RefillLabel
            // 
            this.RefillLabel.AutoSize = true;
            this.RefillLabel.BackColor = System.Drawing.Color.Transparent;
            this.RefillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RefillLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RefillLabel.Location = new System.Drawing.Point(107, 71);
            this.RefillLabel.Name = "RefillLabel";
            this.RefillLabel.Size = new System.Drawing.Size(199, 93);
            this.RefillLabel.TabIndex = 1;
            this.RefillLabel.Text = "    Amount\r\n          of \r\n replenishment:";
            // 
            // RefillButton
            // 
            this.RefillButton.Location = new System.Drawing.Point(167, 206);
            this.RefillButton.Name = "RefillButton";
            this.RefillButton.Size = new System.Drawing.Size(79, 36);
            this.RefillButton.TabIndex = 2;
            this.RefillButton.Text = "Refill";
            this.RefillButton.UseVisualStyleBackColor = true;
            this.RefillButton.Click += new System.EventHandler(this.RefillButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 261);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RefillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banking.Properties.Resources.CHto_takoe_internet_banking_ris_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 302);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RefillButton);
            this.Controls.Add(this.RefillLabel);
            this.Controls.Add(this.RefillTextBox);
            this.Name = "RefillForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refill";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RefillTextBox;
        private System.Windows.Forms.Label RefillLabel;
        private System.Windows.Forms.Button RefillButton;
        private System.Windows.Forms.Button BackButton;
    }
}