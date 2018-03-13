namespace LastUpdateOOp
{
    partial class DepositeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositeForm));
            this.DepositeLabel = new System.Windows.Forms.Label();
            this.AmountOfMoneyLabel = new System.Windows.Forms.Label();
            this.AmountOfMoneyTextBox = new System.Windows.Forms.TextBox();
            this.DepositeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepositeLabel
            // 
            this.DepositeLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.DepositeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositeLabel.Location = new System.Drawing.Point(459, 51);
            this.DepositeLabel.Name = "DepositeLabel";
            this.DepositeLabel.Size = new System.Drawing.Size(150, 35);
            this.DepositeLabel.TabIndex = 0;
            this.DepositeLabel.Text = "Deposite";
            // 
            // AmountOfMoneyLabel
            // 
            this.AmountOfMoneyLabel.AutoSize = true;
            this.AmountOfMoneyLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.AmountOfMoneyLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.AmountOfMoneyLabel.Location = new System.Drawing.Point(331, 225);
            this.AmountOfMoneyLabel.Name = "AmountOfMoneyLabel";
            this.AmountOfMoneyLabel.Size = new System.Drawing.Size(182, 23);
            this.AmountOfMoneyLabel.TabIndex = 1;
            this.AmountOfMoneyLabel.Text = "Amount Of Money";
            // 
            // AmountOfMoneyTextBox
            // 
            this.AmountOfMoneyTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.AmountOfMoneyTextBox.Location = new System.Drawing.Point(614, 225);
            this.AmountOfMoneyTextBox.Name = "AmountOfMoneyTextBox";
            this.AmountOfMoneyTextBox.Size = new System.Drawing.Size(100, 30);
            this.AmountOfMoneyTextBox.TabIndex = 2;
            this.AmountOfMoneyTextBox.TextChanged += new System.EventHandler(this.AmountOfMoneyTextBox_TextChanged);
            // 
            // DepositeButton
            // 
            this.DepositeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.DepositeButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.DepositeButton.Location = new System.Drawing.Point(856, 338);
            this.DepositeButton.Name = "DepositeButton";
            this.DepositeButton.Size = new System.Drawing.Size(121, 55);
            this.DepositeButton.TabIndex = 3;
            this.DepositeButton.Text = "Deposite";
            this.DepositeButton.UseVisualStyleBackColor = false;
            this.DepositeButton.Click += new System.EventHandler(this.DepositeButton_Click);
            // 
            // DepositeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.DepositeButton);
            this.Controls.Add(this.AmountOfMoneyTextBox);
            this.Controls.Add(this.AmountOfMoneyLabel);
            this.Controls.Add(this.DepositeLabel);
            this.Name = "DepositeForm";
            this.Text = "DepositeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DepositeLabel;
        private System.Windows.Forms.Label AmountOfMoneyLabel;
        private System.Windows.Forms.TextBox AmountOfMoneyTextBox;
        private System.Windows.Forms.Button DepositeButton;
    }
}