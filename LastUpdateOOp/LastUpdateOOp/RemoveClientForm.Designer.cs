namespace LastUpdateOOp
{
    partial class RemoveClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveClientForm));
            this.RemoveClientLabel = new System.Windows.Forms.Label();
            this.ClientAccountNumberLabel = new System.Windows.Forms.Label();
            this.ClientPasswordLabel = new System.Windows.Forms.Label();
            this.ClientPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ClientAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.RemoveClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveClientLabel
            // 
            this.RemoveClientLabel.AutoSize = true;
            this.RemoveClientLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.RemoveClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveClientLabel.Location = new System.Drawing.Point(418, 51);
            this.RemoveClientLabel.Name = "RemoveClientLabel";
            this.RemoveClientLabel.Size = new System.Drawing.Size(214, 32);
            this.RemoveClientLabel.TabIndex = 0;
            this.RemoveClientLabel.Text = "Remove Client";
            this.RemoveClientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientAccountNumberLabel
            // 
            this.ClientAccountNumberLabel.AutoSize = true;
            this.ClientAccountNumberLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientAccountNumberLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ClientAccountNumberLabel.Location = new System.Drawing.Point(342, 130);
            this.ClientAccountNumberLabel.Name = "ClientAccountNumberLabel";
            this.ClientAccountNumberLabel.Size = new System.Drawing.Size(169, 23);
            this.ClientAccountNumberLabel.TabIndex = 1;
            this.ClientAccountNumberLabel.Text = "Account Number";
            // 
            // ClientPasswordLabel
            // 
            this.ClientPasswordLabel.AutoSize = true;
            this.ClientPasswordLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientPasswordLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ClientPasswordLabel.Location = new System.Drawing.Point(342, 183);
            this.ClientPasswordLabel.Name = "ClientPasswordLabel";
            this.ClientPasswordLabel.Size = new System.Drawing.Size(102, 23);
            this.ClientPasswordLabel.TabIndex = 2;
            this.ClientPasswordLabel.Text = "Password";
            this.ClientPasswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ClientPasswordTextBox
            // 
            this.ClientPasswordTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ClientPasswordTextBox.Location = new System.Drawing.Point(630, 176);
            this.ClientPasswordTextBox.Name = "ClientPasswordTextBox";
            this.ClientPasswordTextBox.PasswordChar = '*';
            this.ClientPasswordTextBox.Size = new System.Drawing.Size(100, 30);
            this.ClientPasswordTextBox.TabIndex = 3;
            // 
            // ClientAccountNumberTextBox
            // 
            this.ClientAccountNumberTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.ClientAccountNumberTextBox.Location = new System.Drawing.Point(630, 130);
            this.ClientAccountNumberTextBox.Name = "ClientAccountNumberTextBox";
            this.ClientAccountNumberTextBox.Size = new System.Drawing.Size(100, 30);
            this.ClientAccountNumberTextBox.TabIndex = 4;
            // 
            // RemoveClientButton
            // 
            this.RemoveClientButton.BackColor = System.Drawing.Color.Goldenrod;
            this.RemoveClientButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.RemoveClientButton.Location = new System.Drawing.Point(856, 338);
            this.RemoveClientButton.Name = "RemoveClientButton";
            this.RemoveClientButton.Size = new System.Drawing.Size(121, 55);
            this.RemoveClientButton.TabIndex = 5;
            this.RemoveClientButton.Text = "Remove";
            this.RemoveClientButton.UseVisualStyleBackColor = false;
            this.RemoveClientButton.Click += new System.EventHandler(this.RemoveClientButton_Click);
            // 
            // RemoveClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.RemoveClientButton);
            this.Controls.Add(this.ClientAccountNumberTextBox);
            this.Controls.Add(this.ClientPasswordTextBox);
            this.Controls.Add(this.ClientPasswordLabel);
            this.Controls.Add(this.ClientAccountNumberLabel);
            this.Controls.Add(this.RemoveClientLabel);
            this.Name = "RemoveClientForm";
            this.Text = "Remove Client Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RemoveClientLabel;
        private System.Windows.Forms.Label ClientAccountNumberLabel;
        private System.Windows.Forms.Label ClientPasswordLabel;
        private System.Windows.Forms.TextBox ClientPasswordTextBox;
        private System.Windows.Forms.TextBox ClientAccountNumberTextBox;
        private System.Windows.Forms.Button RemoveClientButton;
    }
}