using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LastUpdateOOp
{
    public partial class UpdateEmployeeForm : Form
    {
        public UpdateEmployeeForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UpdateEmployeeForm_Load(object sender, EventArgs e)
        {


           // load the (employee) static object in the form to show it when the form appear
          FirstNameTextBox.Text = IDloginEmployee.employee.FirstName;
          LastNameTextBox .Text =IDloginEmployee. employee.LastName;
          SSNTextBox.Text =IDloginEmployee. employee.SSN;
          PhoneNumberTextBox.Text = IDloginEmployee.employee.PhoneNumber;
          AddressTextBox.Text = IDloginEmployee.employee.Address;      
          MailTextBox.Text =IDloginEmployee. employee.Mail;
         IDTextBox.Text =IDloginEmployee. employee.ID;
          GradeTextBox.Text = IDloginEmployee.employee.Grade;
         CollegeOfGraduationTextBox.Text = IDloginEmployee.employee.CollegeOfGraduate;
            PositionTextBox.Text = IDloginEmployee.employee.Position;






        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
             // Function ->> Update Employee Information ( Only which can be logically updated ) 

            try
            {
                // Copy the information after update to the new object (accountent)
                string ID = IDloginEmployee.employee.ID;
                Accountant accountant= IDloginEmployee.employee;
                accountant.FirstName = FirstNameTextBox.Text;
                accountant.LastName = LastNameTextBox.Text;
                accountant.Address = AddressTextBox.Text;
                accountant.CollegeOfGraduate = CollegeOfGraduationTextBox.Text;
                accountant.Mail = MailTextBox.Text;
                accountant.Grade = GradeTextBox.Text;
                accountant.Position = PositionTextBox.Text;
                accountant.ID = IDTextBox.Text;
                accountant.SSN = SSNTextBox.Text;
                accountant.PhoneNumber = PhoneNumberTextBox.Text;
                BankSystem bank=new BankSystem();

                // Check if he want to update 
                DialogResult result = MessageBox.Show("Are you want to Updata?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    // update the employee By updatefunc in ( Manager)
                    bank.BankManager.Update(IDloginEmployee.employee.ID, accountant);

                   
                    ManagerOperationsForm manager = new ManagerOperationsForm();

                    // Save action to the Logfile 
                    DateTime time = DateTime.Now;
                    FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                    StreamWriter Sr = new StreamWriter(fs);
                    Sr.WriteLine(time + " Employee With ID " + IDloginEmployee.employee.ID + " has been Updated ");
                    Sr.Close();
                    fs.Close();

                    //Return to (ManagerOperationsForm ) && Hide this Form (EmployeeUpdateForm )
                    this.Hide();
                    manager.ShowDialog();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
