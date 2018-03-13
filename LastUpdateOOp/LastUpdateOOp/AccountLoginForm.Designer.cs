namespace LastUpdateOOp
{
    partial class AccountLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountLoginForm));
            this.LoginLabel = new System.Windows.Forms.Label();
            this.ClientAccountNumberLabel = new System.Windows.Forms.Label();
            this.AccountPasswordLabel = new System.Windows.Forms.Label();
            this.AccountPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ClientAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.AccountLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(459, 51);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(110, 35);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClientAccountNumberLabel
            // 
            this.ClientAccountNumberLabel.AutoSize = true;
            this.ClientAccountNumberLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientAccountNumberLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ClientAccountNumberLabel.Location = new System.Drawing.Point(288, 163);
            this.ClientAccountNumberLabel.Name = "ClientAccountNumberLabel";
            this.ClientAccountNumberLabel.Size = new System.Drawing.Size(169, 23);
            this.ClientAccountNumberLabel.TabIndex = 1;
            this.ClientAccountNumberLabel.Text = "Account Number";
            // 
            // AccountPasswordLabel
            // 
            this.AccountPasswordLabel.AutoSize = true;
            this.AccountPasswordLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.AccountPasswordLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.AccountPasswordLabel.Location = new System.Drawing.Point(288, 225);
            this.AccountPasswordLabel.Name = "AccountPasswordLabel";
            this.AccountPasswordLabel.Size = new System.Drawing.Size(102, 23);
            this.AccountPasswordLabel.TabIndex = 2;
            this.AccountPasswordLabel.Text = "Password";
            // 
            // AccountPasswordTextBox
            // 
            this.AccountPasswordTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.AccountPasswordTextBox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.AccountPasswordTextBox.Location = new System.Drawing.Point(591, 225);
            this.AccountPasswordTextBox.Name = "AccountPasswordTextBox";
            this.AccountPasswordTextBox.PasswordChar = '*';
            this.AccountPasswordTextBox.Size = new System.Drawing.Size(100, 28);
            this.AccountPasswordTextBox.TabIndex = 3;
            this.AccountPasswordTextBox.TextChanged += new System.EventHandler(this.AccountPasswordTextBox_TextChanged);
            // 
            // ClientAccountNumberTextBox
            // 
            this.ClientAccountNumberTextBox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ClientAccountNumberTextBox.Location = new System.Drawing.Point(591, 163);
            this.ClientAccountNumberTextBox.Name = "ClientAccountNumberTextBox";
            this.ClientAccountNumberTextBox.Size = new System.Drawing.Size(100, 28);
            this.ClientAccountNumberTextBox.TabIndex = 4;
            // 
            // AccountLoginButton
            // 
            this.AccountLoginButton.BackColor = System.Drawing.Color.Goldenrod;
            this.AccountLoginButton.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Bold);
            this.AccountLoginButton.Location = new System.Drawing.Point(856, 338);
            this.AccountLoginButton.Name = "AccountLoginButton";
            this.AccountLoginButton.Size = new System.Drawing.Size(121, 55);
            this.AccountLoginButton.TabIndex = 5;
            this.AccountLoginButton.Text = "Login";
            this.AccountLoginButton.UseVisualStyleBackColor = false;
            this.AccountLoginButton.Click += new System.EventHandler(this.AccountLoginButton_Click);
            // 
            // AccountLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.AccountLoginButton);
            this.Controls.Add(this.ClientAccountNumberTextBox);
            this.Controls.Add(this.AccountPasswordTextBox);
            this.Controls.Add(this.AccountPasswordLabel);
            this.Controls.Add(this.ClientAccountNumberLabel);
            this.Controls.Add(this.LoginLabel);
            this.Name = "AccountLoginForm";
            this.Text = "Account Login Form";
            this.Load += new System.EventHandler(this.AccountLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label ClientAccountNumberLabel;
        private System.Windows.Forms.Label AccountPasswordLabel;
       public System.Windows.Forms.TextBox AccountPasswordTextBox;
       public System.Windows.Forms.TextBox ClientAccountNumberTextBox;
        private System.Windows.Forms.Button AccountLoginButton;
    }
}