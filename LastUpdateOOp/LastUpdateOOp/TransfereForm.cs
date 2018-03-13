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
    public partial class TransfereForm : Form
    {
        public TransfereForm()
        {
            InitializeComponent();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            try
            {
                AccountLoginForm frm = new AccountLoginForm();
                string AccNumfrom = AccountLoginForm.accNum; //frm.ClientAccountNumberTextBox.Text.ToString();
                string PW = AccountLoginForm.pw; //frm.AccountPasswordTextBox.Text.ToString();
                Client cfrom = BankSystem.FO_client.FindClient(AccNumfrom);

                if (AccNumfrom != AccountNumberTextBox.Text)
                {

                    Accountant emp = new Accountant();
                    double amount = Convert.ToDouble(AmountOfMoneyTextBox.Text);
                    double balancefrom = cfrom.ClientAccount.getBalance();
                    if (balancefrom > amount)
                    {
                        DialogResult result =
                            MessageBox.Show(
                                "Are you sure from transfere " + amount + " from " + AccNumfrom + " to " +
                                AccountNumberTextBox.Text, "Caution", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            emp.SetOperation(new Transfere());
                            Client cto = BankSystem.FO_client.FindClient(AccountNumberTextBox.Text);
                            double balanceto = cto.ClientAccount.getBalance();
                            emp.operation.DoOperation(ref balanceto, ref amount, ref balancefrom);
                            cfrom.ClientAccount.setBalance(balancefrom);
                            cto.ClientAccount.setBalance(balanceto);
                            BankSystem.FO_client.Update(AccNumfrom, cfrom);
                            BankSystem.FO_client.Update(AccountNumberTextBox.Text, cto);
                            MessageBox.Show("Your balance is " + cfrom.ClientAccount.getBalance());



                            // Save Action to the LogFile 
                            DateTime time = DateTime.Now;
                            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                            StreamWriter Sr = new StreamWriter(fs);
                            Sr.WriteLine(time + "Client With Account Number" + AccNumfrom + " transfer " + AmountOfMoneyTextBox.Text + "L.E To " + "Client With Account Number" + AccountNumberTextBox.Text);
                            Sr.Close();
                            fs.Close();




                            AccountOperationsForm form = new AccountOperationsForm();
                            this.Hide();
                            form.ShowDialog();
                        }
                    }
                    else
                        MessageBox.Show("We are sorry your account is under the minimum allowed.");
                }
                else
                {
                    MessageBox.Show(" UnAcceptable , You transfer to same account !!!!");
                    AccountOperationsForm form = new AccountOperationsForm();
                    this.Hide();
                    form.ShowDialog();
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            // hnade func Transfer w arg3 ll form ( AccountForm)
        }
    }
}
