namespace LastUpdateOOp
{
    partial class EmployeeLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLoginForm));
            this.ClientLoginLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeePasswordLabel = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EmployeePasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientLoginLabel
            // 
            this.ClientLoginLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientLoginLabel.Location = new System.Drawing.Point(459, 51);
            this.ClientLoginLabel.Name = "ClientLoginLabel";
            this.ClientLoginLabel.Size = new System.Drawing.Size(110, 35);
            this.ClientLoginLabel.TabIndex = 0;
            this.ClientLoginLabel.Text = "Login";
            this.ClientLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.EmployeeIDLabel.Location = new System.Drawing.Point(391, 149);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(33, 23);
            this.EmployeeIDLabel.TabIndex = 1;
            this.EmployeeIDLabel.Text = "ID";
            // 
            // EmployeePasswordLabel
            // 
            this.EmployeePasswordLabel.AutoSize = true;
            this.EmployeePasswordLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.EmployeePasswordLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.EmployeePasswordLabel.Location = new System.Drawing.Point(391, 214);
            this.EmployeePasswordLabel.Name = "EmployeePasswordLabel";
            this.EmployeePasswordLabel.Size = new System.Drawing.Size(102, 23);
            this.EmployeePasswordLabel.TabIndex = 2;
            this.EmployeePasswordLabel.Text = "Password";
            this.EmployeePasswordLabel.Click += new System.EventHandler(this.EmployeePasswordLabel_Click);
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(572, 149);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeeIDTextBox.TabIndex = 3;
            // 
            // EmployeePasswordTextBox
            // 
            this.EmployeePasswordTextBox.Location = new System.Drawing.Point(572, 214);
            this.EmployeePasswordTextBox.Name = "EmployeePasswordTextBox";
            this.EmployeePasswordTextBox.PasswordChar = '*';
            this.EmployeePasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmployeePasswordTextBox.TabIndex = 4;
            // 
            // EmployeeLoginButton
            // 
            this.EmployeeLoginButton.BackColor = System.Drawing.Color.Goldenrod;
            this.EmployeeLoginButton.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Bold);
            this.EmployeeLoginButton.Location = new System.Drawing.Point(856, 338);
            this.EmployeeLoginButton.Name = "EmployeeLoginButton";
            this.EmployeeLoginButton.Size = new System.Drawing.Size(121, 55);
            this.EmployeeLoginButton.TabIndex = 5;
            this.EmployeeLoginButton.Text = "Login";
            this.EmployeeLoginButton.UseVisualStyleBackColor = false;
            this.EmployeeLoginButton.Click += new System.EventHandler(this.ClientLoginButton_Click);
            // 
            // EmployeeLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.EmployeeLoginButton);
            this.Controls.Add(this.EmployeePasswordTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeePasswordLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.ClientLoginLabel);
            this.Name = "EmployeeLoginForm";
            this.Text = "Employee Login";
            this.Load += new System.EventHandler(this.EmployeeLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientLoginLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label EmployeePasswordLabel;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox EmployeePasswordTextBox;
        private System.Windows.Forms.Button EmployeeLoginButton;
    }
}