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
    public partial class DepositeForm : Form
    {
        public DepositeForm()
        {
            InitializeComponent();
        }

        private void DepositeButton_Click(object sender, EventArgs e)
        {
            // Function ->> Deposite amount of money the account balance 
            try
            {

                AccountLoginForm frm = new AccountLoginForm();
                // Take the AccNum of the account 
                string AccNum = AccountLoginForm.accNum;
                string PW = AccountLoginForm.pw; 
                // Find the Client with this account Number 
                Client c = BankSystem.FO_client.FindClient(AccNum);
                Accountant emp = new Accountant();
                
                //
                emp.SetOperation(new Deposite());
                double amount = Convert.ToDouble(AmountOfMoneyTextBox.Text);
                double flag = 0.0;
                double balance = c.ClientAccount.getBalance();

                // Deposite Function
                emp.operation.DoOperation(ref balance, ref  amount, ref flag);
                // set new balance of the Client After Deposite 
                c.ClientAccount.setBalance(balance);
                BankSystem.FO_client.Update(AccNum, c);

                MessageBox.Show("Your account balance is " + c.ClientAccount.getBalance());

                // Save Change To the TotalBankBalance
                double b = Convert.ToDouble(BankSystem.TotalBalanceOfBank.GetBankBalance()) + Convert.ToDouble(AmountOfMoneyTextBox.Text);
                BankSystem.TotalBalanceOfBank.SetBalance(Convert.ToDouble(b));
                BankSystem.TotalBalanceOfBank.save();

                // Save Action to the LogFile 
                DateTime time = DateTime.Now;
                FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                StreamWriter Sr = new StreamWriter(fs);
                Sr.WriteLine(time + "Client With Account Number" + AccNum + " deposite" + AmountOfMoneyTextBox.Text + "L.E");
                Sr.Close();
                fs.Close();


                // Return To the (AccountOperationsForm ) Hide this Form (Deposite Form)
                AccountOperationsForm form = new AccountOperationsForm();
                this.Hide();
                form.ShowDialog();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            //// hnade 3ala func deposite 
            /// //arg3 ll form ( AccountForm)
            
        }

        private void AmountOfMoneyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
