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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void WithdrawLabel_Click(object sender, EventArgs e)
        {

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                AccountLoginForm frm = new AccountLoginForm();
                string AccNum = AccountLoginForm.accNum; //frm.ClientAccountNumberTextBox.Text.ToString();
                string PW = AccountLoginForm.pw; //frm.AccountPasswordTextBox.Text.ToString();
                Client c = BankSystem.FO_client.FindClient(AccNum);
                Accountant emp = new Accountant();
                emp.SetOperation(new Withdraw());
                double amount = Convert.ToDouble(AmountOfMoneyTextBox.Text);
                double flag = 0.0;
                double balance = c.ClientAccount.getBalance();
                if (balance > amount)
                {
                    emp.operation.DoOperation(ref balance, ref  amount, ref flag);
                    c.ClientAccount.setBalance(balance);
                    BankSystem.FO_client.Update(AccNum, c);
                    MessageBox.Show("Your account balance is " + c.ClientAccount.getBalance());
                    double b = Convert.ToDouble(BankSystem.TotalBalanceOfBank.GetBankBalance()) - Convert.ToDouble(AmountOfMoneyTextBox.Text);
                    BankSystem.TotalBalanceOfBank.SetBalance(Convert.ToDouble(b));
                    BankSystem.TotalBalanceOfBank.save();


                    // Save Action to the LogFile 
                    DateTime time = DateTime.Now;
                    FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                    StreamWriter Sr = new StreamWriter(fs);
                    Sr.WriteLine(time + "Client With Account Number" + AccNum + " withdraw" + AmountOfMoneyTextBox.Text+"L.E");
                    Sr.Close();
                    fs.Close();


                    // Return To the (AccountOperationsForm ) Hide this Form (Withdraw Form)
                    AccountOperationsForm form = new AccountOperationsForm();
                    this.Hide();
                    form.ShowDialog();
                }
                else
                    MessageBox.Show("We are sorry your account is under the minimum allowed.");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            // hnade 3ala func with draw .
            //arg3 ll form ( AccountForm)
        }

        private void WithdrawForm_Load(object sender, EventArgs e)
        {

        }
    }
}
