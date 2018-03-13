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
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm ()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeRegisterationButton_Click(object sender, EventArgs e)
        {


            BankSystem bank = new BankSystem(); 
            Accountant accountant = new Accountant();

            // Check if filling All information or not
            if (EmployeeFirstNameTextBox.Text == "" || EmployeeLastNameTextBox.Text == "" || EmployeeAddressTextBox.Text == "" || CollegeOfGraduationTextBox.Text == "" || YearOfGraduationComboBox.SelectedItem.ToString() == "" || EmployeeBirthDateComboBox.SelectedItem.ToString() == "" || EmployeeMailTextBox.Text == "" || EmployeeGradeComboBox.SelectedItem.ToString() == "" || EmployeePasswordTextBox.Text == "" || EmployeePositionTextBox.Text == "" || (MaleRadioButton.Checked != true && FemaleRadioButton.Checked != true))
                MessageBox.Show("Please complete filling your information.");

         
            else
            {
                try
                {
                    // Fill accountent object with the information from textbox 
                    accountant.FirstName = EmployeeFirstNameTextBox.Text;
                    accountant.LastName = EmployeeLastNameTextBox.Text;
                    accountant.Address = EmployeeAddressTextBox.Text;
                    accountant.BirthDate = EmployeeBirthDateComboBox.SelectedItem.ToString();
                    accountant.Mail = EmployeeMailTextBox.Text;
                    accountant.Grade = EmployeeGradeComboBox.SelectedItem.ToString();
                    accountant.Password = EmployeePasswordTextBox.Text;
                    accountant.Position = EmployeePositionTextBox.Text;
                    long ssn = Int64.Parse(EmployeeSSNTextBox.Text);
                    long phone = Int64.Parse(EmployeePhoneNumberTextBox.Text);
                    accountant.PhoneNumber = EmployeePhoneNumberTextBox.Text;
                    accountant.SSN = EmployeeSSNTextBox.Text;
                    accountant.YearOfGraduation = YearOfGraduationComboBox.SelectedItem.ToString();
                    accountant.CollegeOfGraduate = CollegeOfGraduationTextBox.Text;
                    accountant.ID = (bank.BankManager.IDOfEmployee).ToString();

                    if (MaleRadioButton.Checked)
                    {
                        accountant.Gender = MaleRadioButton.Text.ToString();
                    }
                    if (FemaleRadioButton.Checked)
                    {
                        accountant.Gender = FemaleRadioButton.Text.ToString();
                    }
                    // add the accountent object to the list of accounants & then save at file 
                    bank.BankManager.AddEmployee(accountant);

                    MessageBox.Show("Employee ID is " + accountant.ID);




                    // Save action at LogFile
                    DateTime time = DateTime.Now;
                    FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                    StreamWriter Sr = new StreamWriter(fs);
                    Sr.WriteLine(time + " Employee With ID "+accountant.ID+" has been Added ");
                    Sr.Close();
                    fs.Close();


                    //Return to (  ManagerOperationsForm ) && hide this form (AddEmployeeForm)
                    this.Hide();
                    ManagerOperationsForm manger = new ManagerOperationsForm();
                    manger.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EmployeePasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeMailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeBirthDateTextBox_Validating(object sender, CancelEventArgs e)
        {
            

           
        }
    }
}


