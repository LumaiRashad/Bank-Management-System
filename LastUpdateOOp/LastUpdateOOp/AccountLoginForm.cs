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
    public partial class AccountLoginForm : Form
    {
        // Static Variable to Path (use) it at the Following Forms
        public static String accNum;
        public static String pw;
        public AccountLoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AccountLoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                BankSystem bank = new BankSystem();
                // Check if he Filling all the Information
                if (ClientAccountNumberTextBox.Text == "" && AccountPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Your Information !!!! ");
                }
                else if (ClientAccountNumberTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Your Account Number!!!! ");
                }
                else if (AccountPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Your PassWord !!!! ");

                }
                else
                {
                    // Check if the acc is Found Or not 
                    if (BankSystem.FO_client.CheckFind(ClientAccountNumberTextBox.Text))
                    {
                        // login 
                        if (BankSystem.FO_client.Login(ClientAccountNumberTextBox.Text, AccountPasswordTextBox.Text))
                        {
                            AccountOperationsForm accountOperations = new AccountOperationsForm();

                            // Save Change to the Logfile 
                            DateTime time = DateTime.Now;
                            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                            StreamWriter Sr = new StreamWriter(fs);
                            Sr.WriteLine(time + "Client With Account Number" + ClientAccountNumberTextBox.Text + " has logged in");
                            Sr.Close();
                            fs.Close();


                            //Open ( accountOperations ) && Hide this Form (AccountLoginForm)
                            this.Hide();
                            // save the satatic accnumber to use it at the following Forms
                            accNum = ClientAccountNumberTextBox.Text; 
                            pw = AccountPasswordTextBox.Text;
                            accountOperations.ShowDialog();
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

        private void AccountPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountLoginForm_Load(object sender, EventArgs e)
        {

        }

    }
            // open ( AccountOperations Form ) && close this form or hide it 

        }
 
