namespace LastUpdateOOp
{
    partial class Manager_LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_LoginForm));
            this.ManagerIDLabel = new System.Windows.Forms.Label();
            this.ManagerPasswordLabel = new System.Windows.Forms.Label();
            this.ManagerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ManagerIDTextBox = new System.Windows.Forms.TextBox();
            this.ManagerLoginButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManagerIDLabel
            // 
            this.ManagerIDLabel.AutoSize = true;
            this.ManagerIDLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.ManagerIDLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ManagerIDLabel.Location = new System.Drawing.Point(376, 162);
            this.ManagerIDLabel.Name = "ManagerIDLabel";
            this.ManagerIDLabel.Size = new System.Drawing.Size(33, 23);
            this.ManagerIDLabel.TabIndex = 0;
            this.ManagerIDLabel.Text = "ID";
            // 
            // ManagerPasswordLabel
            // 
            this.ManagerPasswordLabel.AutoSize = true;
            this.ManagerPasswordLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.ManagerPasswordLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ManagerPasswordLabel.Location = new System.Drawing.Point(377, 229);
            this.ManagerPasswordLabel.Name = "ManagerPasswordLabel";
            this.ManagerPasswordLabel.Size = new System.Drawing.Size(102, 23);
            this.ManagerPasswordLabel.TabIndex = 1;
            this.ManagerPasswordLabel.Text = "Password";
            // 
            // ManagerPasswordTextBox
            // 
            this.ManagerPasswordTextBox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ManagerPasswordTextBox.Location = new System.Drawing.Point(582, 228);
            this.ManagerPasswordTextBox.Name = "ManagerPasswordTextBox";
            this.ManagerPasswordTextBox.PasswordChar = '*';
            this.ManagerPasswordTextBox.Size = new System.Drawing.Size(100, 28);
            this.ManagerPasswordTextBox.TabIndex = 2;
            // 
            // ManagerIDTextBox
            // 
            this.ManagerIDTextBox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ManagerIDTextBox.Location = new System.Drawing.Point(582, 158);
            this.ManagerIDTextBox.Name = "ManagerIDTextBox";
            this.ManagerIDTextBox.Size = new System.Drawing.Size(100, 28);
            this.ManagerIDTextBox.TabIndex = 3;
            // 
            // ManagerLoginButton
            // 
            this.ManagerLoginButton.BackColor = System.Drawing.Color.Goldenrod;
            this.ManagerLoginButton.Font = new System.Drawing.Font("Tahoma", 21F, System.Drawing.FontStyle.Bold);
            this.ManagerLoginButton.Location = new System.Drawing.Point(856, 338);
            this.ManagerLoginButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.ManagerLoginButton.Name = "ManagerLoginButton";
            this.ManagerLoginButton.Size = new System.Drawing.Size(121, 55);
            this.ManagerLoginButton.TabIndex = 4;
            this.ManagerLoginButton.Text = "Login";
            this.ManagerLoginButton.UseVisualStyleBackColor = false;
            this.ManagerLoginButton.Click += new System.EventHandler(this.ManagerLoginButton_Click);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(421, 46);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(218, 32);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Manager Login";
            // 
            // Manager_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.ManagerLoginButton);
            this.Controls.Add(this.ManagerIDTextBox);
            this.Controls.Add(this.ManagerPasswordTextBox);
            this.Controls.Add(this.ManagerPasswordLabel);
            this.Controls.Add(this.ManagerIDLabel);
            this.Name = "Manager_LoginForm";
            this.Text = "Manager Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ManagerIDLabel;
        private System.Windows.Forms.Label ManagerPasswordLabel;
        private System.Windows.Forms.TextBox ManagerPasswordTextBox;
        private System.Windows.Forms.TextBox ManagerIDTextBox;
        private System.Windows.Forms.Button ManagerLoginButton;
        private System.Windows.Forms.Label LoginLabel;
    }
}