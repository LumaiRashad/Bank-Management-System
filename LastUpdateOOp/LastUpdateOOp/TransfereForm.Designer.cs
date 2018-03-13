namespace LastUpdateOOp
{
    partial class TransfereForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransfereForm));
            this.TransferLabel = new System.Windows.Forms.Label();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.AmountOfMoneyLabel = new System.Windows.Forms.Label();
            this.AccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.AmountOfMoneyTextBox = new System.Windows.Forms.TextBox();
            this.TransferButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TransferLabel
            // 
            this.TransferLabel.AutoSize = true;
            this.TransferLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.TransferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferLabel.Location = new System.Drawing.Point(459, 51);
            this.TransferLabel.Name = "TransferLabel";
            this.TransferLabel.Size = new System.Drawing.Size(128, 32);
            this.TransferLabel.TabIndex = 0;
            this.TransferLabel.Text = "Transfer";
            this.TransferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.AccountNumberLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.AccountNumberLabel.Location = new System.Drawing.Point(288, 163);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(212, 23);
            this.AccountNumberLabel.TabIndex = 1;
            this.AccountNumberLabel.Text = "Account Number \'TO\'";
            this.AccountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AmountOfMoneyLabel
            // 
            this.AmountOfMoneyLabel.AutoSize = true;
            this.AmountOfMoneyLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.AmountOfMoneyLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.AmountOfMoneyLabel.Location = new System.Drawing.Point(288, 255);
            this.AmountOfMoneyLabel.Name = "AmountOfMoneyLabel";
            this.AmountOfMoneyLabel.Size = new System.Drawing.Size(182, 23);
            this.AmountOfMoneyLabel.TabIndex = 2;
            this.AmountOfMoneyLabel.Text = "Amount Of Money";
            // 
            // AccountNumberTextBox
            // 
            this.AccountNumberTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.AccountNumberTextBox.Location = new System.Drawing.Point(612, 160);
            this.AccountNumberTextBox.Name = "AccountNumberTextBox";
            this.AccountNumberTextBox.Size = new System.Drawing.Size(100, 30);
            this.AccountNumberTextBox.TabIndex = 3;
            // 
            // AmountOfMoneyTextBox
            // 
            this.AmountOfMoneyTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.AmountOfMoneyTextBox.Location = new System.Drawing.Point(612, 255);
            this.AmountOfMoneyTextBox.Name = "AmountOfMoneyTextBox";
            this.AmountOfMoneyTextBox.Size = new System.Drawing.Size(100, 30);
            this.AmountOfMoneyTextBox.TabIndex = 4;
            // 
            // TransferButton
            // 
            this.TransferButton.BackColor = System.Drawing.Color.Goldenrod;
            this.TransferButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.TransferButton.Location = new System.Drawing.Point(856, 338);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(121, 55);
            this.TransferButton.TabIndex = 5;
            this.TransferButton.Text = "Transfer";
            this.TransferButton.UseVisualStyleBackColor = false;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // TransfereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.TransferButton);
            this.Controls.Add(this.AmountOfMoneyTextBox);
            this.Controls.Add(this.AccountNumberTextBox);
            this.Controls.Add(this.AmountOfMoneyLabel);
            this.Controls.Add(this.AccountNumberLabel);
            this.Controls.Add(this.TransferLabel);
            this.Name = "TransfereForm";
            this.Text = "TransfereForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransferLabel;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.Label AmountOfMoneyLabel;
        private System.Windows.Forms.TextBox AccountNumberTextBox;
        private System.Windows.Forms.TextBox AmountOfMoneyTextBox;
        private System.Windows.Forms.Button TransferButton;
    }
}