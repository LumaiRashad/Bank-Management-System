namespace LastUpdateOOp
{
    partial class RemoveEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveEmployeeForm));
            this.RemoveEmployeeLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.RemoveEmployeeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveEmployeeLabel
            // 
            this.RemoveEmployeeLabel.AutoSize = true;
            this.RemoveEmployeeLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.RemoveEmployeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployeeLabel.Location = new System.Drawing.Point(349, 9);
            this.RemoveEmployeeLabel.Name = "RemoveEmployeeLabel";
            this.RemoveEmployeeLabel.Size = new System.Drawing.Size(269, 32);
            this.RemoveEmployeeLabel.TabIndex = 0;
            this.RemoveEmployeeLabel.Text = "Remove Employee";
            this.RemoveEmployeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.BackColor = System.Drawing.Color.Goldenrod;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.EmployeeIDLabel.Location = new System.Drawing.Point(12, 157);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(132, 23);
            this.EmployeeIDLabel.TabIndex = 1;
            this.EmployeeIDLabel.Text = "Employee ID";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(247, 154);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(100, 30);
            this.EmployeeIDTextBox.TabIndex = 2;
            this.EmployeeIDTextBox.TextChanged += new System.EventHandler(this.EmployeeIDTextBox_TextChanged);
            // 
            // RemoveEmployeeButton
            // 
            this.RemoveEmployeeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.RemoveEmployeeButton.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.RemoveEmployeeButton.Location = new System.Drawing.Point(106, 323);
            this.RemoveEmployeeButton.Name = "RemoveEmployeeButton";
            this.RemoveEmployeeButton.Size = new System.Drawing.Size(121, 55);
            this.RemoveEmployeeButton.TabIndex = 3;
            this.RemoveEmployeeButton.Text = "Remove";
            this.RemoveEmployeeButton.UseVisualStyleBackColor = false;
            this.RemoveEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // RemoveEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1071, 482);
            this.Controls.Add(this.RemoveEmployeeButton);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.RemoveEmployeeLabel);
            this.Name = "RemoveEmployeeForm";
            this.Text = "Remove Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RemoveEmployeeLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.Button RemoveEmployeeButton;
    }
}