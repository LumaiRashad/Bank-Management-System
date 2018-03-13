namespace LastUpdateOOp
{
    partial class EmployeeOperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeOperationsForm));
            this.AddClientButton = new System.Windows.Forms.Button();
            this.RemoveClientButton = new System.Windows.Forms.Button();
            this.AccountLoginButton = new System.Windows.Forms.Button();
            this.EmployeeLogoutButton = new System.Windows.Forms.Button();
            this.ClientOperationsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddClientButton
            // 
            this.AddClientButton.BackColor = System.Drawing.Color.Goldenrod;
            this.AddClientButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.AddClientButton.Location = new System.Drawing.Point(436, 119);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(149, 55);
            this.AddClientButton.TabIndex = 0;
            this.AddClientButton.Text = "Add Client";
            this.AddClientButton.UseVisualStyleBackColor = false;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // RemoveClientButton
            // 
            this.RemoveClientButton.BackColor = System.Drawing.Color.Goldenrod;
            this.RemoveClientButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.RemoveClientButton.Location = new System.Drawing.Point(436, 206);
            this.RemoveClientButton.Name = "RemoveClientButton";
            this.RemoveClientButton.Size = new System.Drawing.Size(149, 54);
            this.RemoveClientButton.TabIndex = 1;
            this.RemoveClientButton.Text = "Remove Client";
            this.RemoveClientButton.UseVisualStyleBackColor = false;
            this.RemoveClientButton.Click += new System.EventHandler(this.RemoveClientButton_Click);
            // 
            // AccountLoginButton
            // 
            this.AccountLoginButton.BackColor = System.Drawing.Color.Goldenrod;
            this.AccountLoginButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.AccountLoginButton.Location = new System.Drawing.Point(436, 290);
            this.AccountLoginButton.Name = "AccountLoginButton";
            this.AccountLoginButton.Size = new System.Drawing.Size(149, 58);
            this.AccountLoginButton.TabIndex = 2;
            this.AccountLoginButton.Text = " Login Account";
            this.AccountLoginButton.UseVisualStyleBackColor = false;
            this.AccountLoginButton.Click += new System.EventHandler(this.AccountLoginButton_Click);
            // 
            // EmployeeLogoutButton
            // 
            this.EmployeeLogoutButton.BackColor = System.Drawing.Color.Goldenrod;
            this.EmployeeLogoutButton.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.EmployeeLogoutButton.Location = new System.Drawing.Point(451, 398);
            this.EmployeeLogoutButton.Name = "EmployeeLogoutButton";
            this.EmployeeLogoutButton.Size = new System.Drawing.Size(121, 55);
            this.EmployeeLogoutButton.TabIndex = 3;
            this.EmployeeLogoutButton.Text = "Logout";
            this.EmployeeLogoutButton.UseVisualStyleBackColor = false;
            this.EmployeeLogoutButton.Click += new System.EventHandler(this.EmployeeLogoutButton_Click);
            // 
            // ClientOperationsLabel
            // 
            this.ClientOperationsLabel.AutoSize = true;
            this.ClientOperationsLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientOperationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientOperationsLabel.Location = new System.Drawing.Point(386, 35);
            this.ClientOperationsLabel.Name = "ClientOperationsLabel";
            this.ClientOperationsLabel.Size = new System.Drawing.Size(236, 32);
            this.ClientOperationsLabel.TabIndex = 4;
            this.ClientOperationsLabel.Text = "Client Operations";
            this.ClientOperationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.ClientOperationsLabel);
            this.Controls.Add(this.EmployeeLogoutButton);
            this.Controls.Add(this.AccountLoginButton);
            this.Controls.Add(this.RemoveClientButton);
            this.Controls.Add(this.AddClientButton);
            this.Name = "EmployeeOperationsForm";
            this.Text = "Employee Operations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button RemoveClientButton;
        private System.Windows.Forms.Button AccountLoginButton;
        private System.Windows.Forms.Button EmployeeLogoutButton;
        private System.Windows.Forms.Label ClientOperationsLabel;
    }
}