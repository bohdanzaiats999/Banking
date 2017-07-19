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
            this.SuspendLayout();
            // 
            // RefillTextBox
            // 
            this.RefillTextBox.Location = new System.Drawing.Point(141, 164);
            this.RefillTextBox.Name = "RefillTextBox";
            this.RefillTextBox.Size = new System.Drawing.Size(72, 20);
            this.RefillTextBox.TabIndex = 0;
            this.RefillTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RefillTextBox_KeyPress);
            // 
            // RefillLabel
            // 
            this.RefillLabel.AutoSize = true;
            this.RefillLabel.Location = new System.Drawing.Point(116, 148);
            this.RefillLabel.Name = "RefillLabel";
            this.RefillLabel.Size = new System.Drawing.Size(123, 13);
            this.RefillLabel.TabIndex = 1;
            this.RefillLabel.Text = "Amount of replenishment";
            // 
            // RefillButton
            // 
            this.RefillButton.Location = new System.Drawing.Point(119, 203);
            this.RefillButton.Name = "RefillButton";
            this.RefillButton.Size = new System.Drawing.Size(120, 45);
            this.RefillButton.TabIndex = 2;
            this.RefillButton.Text = "Refill";
            this.RefillButton.UseVisualStyleBackColor = true;
            this.RefillButton.Click += new System.EventHandler(this.RefillButton_Click);
            // 
            // RefillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 339);
            this.Controls.Add(this.RefillButton);
            this.Controls.Add(this.RefillLabel);
            this.Controls.Add(this.RefillTextBox);
            this.Name = "RefillForm";
            this.Text = "RefillForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RefillTextBox;
        private System.Windows.Forms.Label RefillLabel;
        private System.Windows.Forms.Button RefillButton;
    }
}