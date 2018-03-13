namespace LastUpdateOOp
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.ManagerButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.ExistButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ManagerButton
            // 
            this.ManagerButton.BackColor = System.Drawing.Color.Goldenrod;
            this.ManagerButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ManagerButton.Location = new System.Drawing.Point(295, 298);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(121, 45);
            this.ManagerButton.TabIndex = 2;
            this.ManagerButton.Text = "Manager";
            this.ManagerButton.UseVisualStyleBackColor = false;
            this.ManagerButton.Click += new System.EventHandler(this.ManagerButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.EmployeeButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.EmployeeButton.Location = new System.Drawing.Point(687, 298);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(121, 45);
            this.EmployeeButton.TabIndex = 3;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // ExistButton
            // 
            this.ExistButton.BackColor = System.Drawing.Color.Goldenrod;
            this.ExistButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.ExistButton.Location = new System.Drawing.Point(468, 381);
            this.ExistButton.Name = "ExistButton";
            this.ExistButton.Size = new System.Drawing.Size(180, 41);
            this.ExistButton.TabIndex = 4;
            this.ExistButton.Text = "Exit";
            this.ExistButton.UseVisualStyleBackColor = false;
            this.ExistButton.Click += new System.EventHandler(this.ExistButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.ExistButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.ManagerButton);
            this.Name = "StartForm";
            this.Text = "Start Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ManagerButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button ExistButton;
    }
}

