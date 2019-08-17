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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefillAccountTextBox
            // 
            this.RefillAccountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RefillAccountTextBox.Location = new System.Drawing.Point(88, 65);
            this.RefillAccountTextBox.Name = "RefillAccountTextBox";
            this.RefillAccountTextBox.Size = new System.Drawing.Size(100, 38);
            this.RefillAccountTextBox.TabIndex = 0;
            this.RefillAccountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RefillAccountTextBox_KeyPress);
            // 
            // RefillAccountButton
            // 
            this.RefillAccountButton.Location = new System.Drawing.Point(101, 134);
            this.RefillAccountButton.Name = "RefillAccountButton";
            this.RefillAccountButton.Size = new System.Drawing.Size(75, 32);
            this.RefillAccountButton.TabIndex = 1;
            this.RefillAccountButton.Text = "Refill";
            this.RefillAccountButton.UseVisualStyleBackColor = true;
            this.RefillAccountButton.Click += new System.EventHandler(this.RefillAccountButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 208);
            this.BackButton.Name = "BackButton";
            this.BackButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AmountLabel.Location = new System.Drawing.Point(85, 16);
            this.AmountLabel.MinimumSize = new System.Drawing.Size(5, 5);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(107, 31);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Amount";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RefillAccountButton);
            this.groupBox1.Controls.Add(this.AmountLabel);
            this.groupBox1.Controls.Add(this.RefillAccountTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 190);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // RefillAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banking.Properties.Resources.CHto_takoe_internet_banking_ris_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(319, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BackButton);
            this.Name = "RefillAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refill Account";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox RefillAccountTextBox;
        private System.Windows.Forms.Button RefillAccountButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}