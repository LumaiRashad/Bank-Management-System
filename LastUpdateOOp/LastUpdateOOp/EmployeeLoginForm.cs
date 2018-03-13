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
using System.Runtime.InteropServices;

namespace LastUpdateOOp
{
    public partial class EmployeeLoginForm : Form
    {
        // Static variable to store the ID of employee To use it at the following Forms 
        public static string ID;
        public EmployeeLoginForm()
        {
            InitializeComponent();
        }

        private void ClientLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                 // It's Function ->> Login of Employee to the system 

             
                BankSystem Bank = new BankSystem();

                // Check if he enterd the data or not 
                if (EmployeeIDTextBox.Text == "" && EmployeePasswordTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Your Information !!!! ");
                }
                else if (EmployeeIDTextBox.Text == "")
                    MessageBox.Show("Please Enter Your ID !!!! ");
                else if (EmployeePasswordTextBox.Text == "")
                    MessageBox.Show("Please Enter Your PassWord !!!! ");
                else

                {
                    // if he found the accnum then he will Check the login 
                    if (BankSystem.FO_employee.CheckFind(EmployeeIDTextBox.Text))
                    {
                        if (BankSystem.FO_employee.Login(EmployeeIDTextBox.Text, EmployeePasswordTextBox.Text))

                        {
                            // Save action to LogFile
                            DateTime time = DateTime.Now;
                            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                            StreamWriter Sr = new StreamWriter(fs);
                            Sr.WriteLine(time + "Employee With ID" + EmployeeIDTextBox.Text + " has logged in");
                            Sr.Close();
                            fs.Close();


                            EmployeeOperationsForm employeeOperations = new EmployeeOperationsForm();

                            // Return to (  employeeOperations) && Hide this Form (EmployeLoginForm)
                            this.Hide();
                            // Save the staticValue (store)
                            ID = EmployeeIDTextBox.Text;
                            employeeOperations.ShowDialog();

                        }
                        else
                        {
                            MessageBox.Show(" The password that you've entered is incorrect");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The ID that you've entered doesn't match any Profile ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeePasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
