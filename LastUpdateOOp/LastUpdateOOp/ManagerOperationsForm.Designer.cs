namespace LastUpdateOOp
{
    partial class ManagerOperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerOperationsForm));
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.RemoveEmployeeButton = new System.Windows.Forms.Button();
            this.ManagerLogoutButton = new System.Windows.Forms.Button();
            this.ManagerLabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.AddEmployeeButton.Location = new System.Drawing.Point(438, 127);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(147, 47);
            this.AddEmployeeButton.TabIndex = 2;
            this.AddEmployeeButton.Text = "Add Employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // RemoveEmployeeButton
            // 
            this.RemoveEmployeeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.RemoveEmployeeButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.RemoveEmployeeButton.Location = new System.Drawing.Point(438, 205);
            this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            this.RemoveEmployeeButton.Size = new System.Drawing.Size(147, 43);
            this.RemoveEmployeeButton.TabIndex = 3;
            this.RemoveEmployeeButton.Text = " Remove Employee";
            this.RemoveEmployeeButton.UseVisualStyleBackColor = false;
            this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // ManagerLogoutButton
            // 
            this.ManagerLogoutButton.BackColor = System.Drawing.Color.Goldenrod;
            this.ManagerLogoutButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ManagerLogoutButton.Location = new System.Drawing.Point(451, 389);
            this.ManagerLogoutButton.Name = "ManagerLogoutButton";
            this.ManagerLogoutButton.Size = new System.Drawing.Size(121, 55);
            this.ManagerLogoutButton.TabIndex = 4;
            this.ManagerLogoutButton.Text = "Logout";
            this.ManagerLogoutButton.UseVisualStyleBackColor = false;
            this.ManagerLogoutButton.Click += new System.EventHandler(this.ManagerLogoutButton_Click);
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.AutoSize = true;
            this.ManagerLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.ManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerLabel.Location = new System.Drawing.Point(380, 40);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(260, 32);
            this.ManagerLabel.TabIndex = 5;
            this.ManagerLabel.Text = "Manager Account ";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Goldenrod;
            this.UpdateButton.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.UpdateButton.Location = new System.Drawing.Point(438, 284);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(147, 44);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Update Employee ";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ManagerOperationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ManagerLabel);
            this.Controls.Add(this.ManagerLogoutButton);
            this.Controls.Add(this.RemoveEmployeeButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Name = "ManagerOperationsForm";
            this.Text = "Manager Operations Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button RemoveEmployeeButton;
        private System.Windows.Forms.Button ManagerLogoutButton;
        private System.Windows.Forms.Label ManagerLabel;
        private System.Windows.Forms.Button UpdateButton;
    }
}