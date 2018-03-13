namespace LastUpdateOOp
{
    partial class WithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawForm));
            this.WithdrawLabel = new System.Windows.Forms.Label();
            this.AmountOfMoneyLabel = new System.Windows.Forms.Label();
            this.AmountOfMoneyTextBox = new System.Windows.Forms.TextBox();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WithdrawLabel
            // 
            this.WithdrawLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.WithdrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawLabel.Location = new System.Drawing.Point(459, 51);
            this.WithdrawLabel.Name = "WithdrawLabel";
            this.WithdrawLabel.Size = new System.Drawing.Size(150, 35);
            this.WithdrawLabel.TabIndex = 0;
            this.WithdrawLabel.Text = "Withdraw";
            this.WithdrawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WithdrawLabel.Click += new System.EventHandler(this.WithdrawLabel_Click);
            // 
            // AmountOfMoneyLabel
            // 
            this.AmountOfMoneyLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.AmountOfMoneyLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.AmountOfMoneyLabel.Location = new System.Drawing.Point(331, 225);
            this.AmountOfMoneyLabel.Name = "AmountOfMoneyLabel";
            this.AmountOfMoneyLabel.Size = new System.Drawing.Size(190, 25);
            this.AmountOfMoneyLabel.TabIndex = 1;
            this.AmountOfMoneyLabel.Text = "Amount Of Money";
            this.AmountOfMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountOfMoneyTextBox
            // 
            this.AmountOfMoneyTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.AmountOfMoneyTextBox.Location = new System.Drawing.Point(588, 225);
            this.AmountOfMoneyTextBox.Name = "AmountOfMoneyTextBox";
            this.AmountOfMoneyTextBox.Size = new System.Drawing.Size(110, 30);
            this.AmountOfMoneyTextBox.TabIndex = 2;
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.BackColor = System.Drawing.Color.Goldenrod;
            this.WithdrawButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.WithdrawButton.Location = new System.Drawing.Point(850, 338);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(121, 55);
            this.WithdrawButton.TabIndex = 3;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = false;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // WithdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.WithdrawButton);
            this.Controls.Add(this.AmountOfMoneyTextBox);
            this.Controls.Add(this.AmountOfMoneyLabel);
            this.Controls.Add(this.WithdrawLabel);
            this.Name = "WithdrawForm";
            this.Text = "WithdrawForm";
            this.Load += new System.EventHandler(this.WithdrawForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WithdrawLabel;
        private System.Windows.Forms.Label AmountOfMoneyLabel;
        private System.Windows.Forms.TextBox AmountOfMoneyTextBox;
        private System.Windows.Forms.Button WithdrawButton;
    }
}