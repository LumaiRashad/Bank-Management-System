using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.IO;
namespace LastUpdateOOp
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void ClientRegistrationButton_Click(object sender, EventArgs e)
        {
            // Functio->> Add Client To the list && file 
            BankSystem bank = new BankSystem();
            Client client = new Client();

            // Calculalte the age of Client To check if his age is legal to create an account 
            int clientage = client.CalculateAge(ClientBirthDateComboBox.SelectedItem.ToString());

            // Check if he filling All the Information
            if (ClientFirstNameTextBox.Text == "" || ClientLastNameTextBox.Text == "" || ClientMailTextBox.Text == "" ||
                ClientPhoneNumberTextBox.Text == "" || ClientSSNTextBox.Text == "" || ClientAddressTextBox.Text == "" ||
                ClientBirthDateComboBox.SelectedItem.ToString() == "" || AccountBalanceTextBox.Text == "" ||
                (MaleRadioButton.Checked != true && FemaleRadioButton.Checked != true))
            {
                MessageBox.Show("Please complete filling your information.");
            }


           
        

    else 
            {

                // Check if balance is more than 500
                if (Convert.ToDouble(AccountBalanceTextBox.Text) < 500.0)
                {
                    MessageBox.Show(" The Minimum Balance is 500 L.E ");
                }

                else
                {
                    // Check Age
                    if (clientage <= 18)
                    {
                        MessageBox.Show(" Date that you have entered under Legal Age ");
                    }
                    else
                    {
                        try
                        {
                            
                            // Create a client form Text box to add it to the list & file 
                            client.FirstName = ClientFirstNameTextBox.Text;
                            client.LastName = ClientLastNameTextBox.Text;
                            client.Mail = ClientMailTextBox.Text;
                            client.Address = ClientAddressTextBox.Text;
                            client.BirthDate = ClientBirthDateComboBox.SelectedItem.ToString();
                            client.SSN = ClientSSNTextBox.Text;
                            client.PhoneNumber = ClientPhoneNumberTextBox.Text;
                            client.ClientAccount.Password = AccountPasswordTextBox.Text;
                            long ssn = Int64.Parse(ClientSSNTextBox.Text);
                            long phone = Int64.Parse(ClientPhoneNumberTextBox.Text);
                            client.ClientAccount.setBalance(Convert.ToDouble(AccountBalanceTextBox.Text));
                            client.ClientAccount.AccNum = (bank.AccNumOfClient).ToString(); // Know the last AccNumber in the list && Create a new AccountNumber to the Client
                            if (MaleRadioButton.Checked)
                            {
                                client.Gender = MaleRadioButton.Text.ToString();
                            }
                            if (FemaleRadioButton.Checked)
                            {
                                client.Gender = FemaleRadioButton.Text.ToString();
                            }
                            client.ClientAccount.Activation = true;
                            client.LoanFlag = false;

                            // Add Client 
                            BankSystem.FO_client.AddClient(client);

                            // Update the total balance OF Bank && save the  change According to the Account 
                           double b= Convert.ToDouble(BankSystem.TotalBalanceOfBank.GetBankBalance())+Convert.ToDouble(AccountBalanceTextBox.Text);
                            BankSystem.TotalBalanceOfBank.SetBalance(Convert.ToDouble(b));
                            BankSystem.TotalBalanceOfBank.save();

                            //  fo.AddClient(client);
                            MessageBox.Show("Account Number is " + client.ClientAccount.AccNum);

                            // Save Change to the LogFile
                            DateTime time = DateTime.Now;
                            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                            StreamWriter Sr = new StreamWriter(fs);
                            Sr.WriteLine(time + " Client With AccountNumber  " + client.ClientAccount.AccNum + " has been Added ");
                            Sr.Close();
                            fs.Close();




                            // Return to (EmployeeOperationsForm ) && Hide this Form (AddClientform )
                            this.Hide();
                            EmployeeOperationsForm employee = new EmployeeOperationsForm();
                            employee.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            // add client to the list of clients 
            // (Acc Number )>> ana ele bdholo 
            // a show el ( Employee operations )

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
