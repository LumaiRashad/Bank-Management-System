namespace LastUpdateOOp
{
    partial class PayForLoanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForLoanForm));
            this.PayLabel = new System.Windows.Forms.Label();
            this.AmountOfMoneyLabel = new System.Windows.Forms.Label();
            this.AmountOfMoneyTextBox = new System.Windows.Forms.TextBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PayLabel
            // 
            this.PayLabel.AutoSize = true;
            this.PayLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.PayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayLabel.Location = new System.Drawing.Point(403, 59);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(196, 32);
            this.PayLabel.TabIndex = 0;
            this.PayLabel.Text = "Pay For Loan";
            // 
            // AmountOfMoneyLabel
            // 
            this.AmountOfMoneyLabel.AutoSize = true;
            this.AmountOfMoneyLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.AmountOfMoneyLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.AmountOfMoneyLabel.Location = new System.Drawing.Point(281, 199);
            this.AmountOfMoneyLabel.Name = "AmountOfMoneyLabel";
            this.AmountOfMoneyLabel.Size = new System.Drawing.Size(182, 23);
            this.AmountOfMoneyLabel.TabIndex = 1;
            this.AmountOfMoneyLabel.Text = "Amount Of Money";
            // 
            // AmountOfMoneyTextBox
            // 
            this.AmountOfMoneyTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.AmountOfMoneyTextBox.Location = new System.Drawing.Point(610, 192);
            this.AmountOfMoneyTextBox.Name = "AmountOfMoneyTextBox";
            this.AmountOfMoneyTextBox.Size = new System.Drawing.Size(100, 30);
            this.AmountOfMoneyTextBox.TabIndex = 2;
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.Goldenrod;
            this.PayButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.PayButton.Location = new System.Drawing.Point(856, 338);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(121, 55);
            this.PayButton.TabIndex = 3;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // PayForLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.AmountOfMoneyTextBox);
            this.Controls.Add(this.AmountOfMoneyLabel);
            this.Controls.Add(this.PayLabel);
            this.Name = "PayForLoanForm";
            this.Text = "PayForLoanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PayLabel;
        private System.Windows.Forms.Label AmountOfMoneyLabel;
        private System.Windows.Forms.TextBox AmountOfMoneyTextBox;
        private System.Windows.Forms.Button PayButton;
    }
}