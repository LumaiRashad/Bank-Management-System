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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string AccNum = AccountLoginForm.accNum;
                Client NewClient = BankSystem.FO_client.FindClient(AccNum);
                NewClient.FirstName = ClientFirstNameTextBox.Text;
                NewClient.LastName = ClientLastNameTextBox.Text;
                NewClient.Address = ClientAddressTextBox.Text;
                NewClient.PhoneNumber = ClientPhoneNumberTextBox.Text;
                NewClient.SSN = ClientSSNTextBox.Text;
                NewClient.ClientAccount.AccNum = AccNum;
                NewClient.BirthDate = ClientBirthDateTextBox.Text;
                NewClient.Mail = ClientMailTextBox.Text;
                if (FemaleRadioButton.Checked)
                {
                    NewClient.Gender = FemaleRadioButton.Text;
                }
                else if (MaleRadioButton.Checked)
                {
                    NewClient.Gender = MaleRadioButton.Text;
                }

                DialogResult result = MessageBox.Show("Are you want to Updata?", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    BankSystem.FO_client.Update(AccNum, NewClient);


                    // Save Action to the LogFile 
                    DateTime time = DateTime.Now;
                    FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                    StreamWriter Sr = new StreamWriter(fs);
                    Sr.WriteLine(time + " Client With Account Number " + AccountLoginForm.accNum+ " has been Updated ");
                    Sr.Close();
                    fs.Close();



                    // Return To the (AccountOperationsForm ) Hide this Form (Withdraw Form)
                    AccountOperationsForm form = new AccountOperationsForm();
                    this.Hide();
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            string AccNum = AccountLoginForm.accNum;
            Client c = BankSystem.FO_client.FindClient(AccNum);
            ClientFirstNameTextBox.Text = c.FirstName;
            ClientLastNameTextBox.Text = c.LastName;
            ClientSSNTextBox.Text = c.SSN;
            ClientPhoneNumberTextBox.Text = c.PhoneNumber;
            ClientAddressTextBox.Text = c.Address;
            ClientBirthDateTextBox.Text = c.BirthDate;
            ClientMailTextBox.Text = c.Mail;

            ClientAccountNumberTextBox.Text = c.ClientAccount.AccNum;
            if (c.Gender == "Male")
            {
                this.MaleRadioButton.Checked = true;

            }
            else if (c.Gender == "Female")
            {
                this.FemaleRadioButton.Checked = true;
            }
        }

        private void ClientAccountNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientPhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientLastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
