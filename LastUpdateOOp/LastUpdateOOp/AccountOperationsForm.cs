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
    public partial class AccountOperationsForm : Form
    {
        public AccountOperationsForm()
        {
            InitializeComponent();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            // open ( WithdrawForm ) && hide this (AccountOperationForm)
            WithdrawForm withdraw =new WithdrawForm();
            this.Hide();
            withdraw.ShowDialog();

        }

        private void DepositeButton_Click(object sender, EventArgs e)
        {
            // open ( DepositeForm ) && hide this (AccountOperationForm)
            DepositeForm deposite=new DepositeForm();
            this.Hide();
            deposite.ShowDialog();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            // Open ( TransferForm ) && hide this (AccountOperationForm)
            TransfereForm transfer =new TransfereForm();
            this.Hide();
            transfer.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //// Open ( UpdateForm ) && hide this (AAccountOperationForm)
            UpdateForm update=new UpdateForm();
            this.Hide();
            update.ShowDialog();
        }

        private void TakeaAloanButton_Click(object sender, EventArgs e)
        {
            // Open (RequestLoan Form ) && hide this (AccountOperationForm)
            string AccNum = AccountLoginForm.accNum; 
            Client clientHasaLoan = BankSystem.FO_client.FindClient(AccNum);
            if (clientHasaLoan.LoanFlag == true)
            {
                MessageBox.Show(" You Already took a loan ");
            }
            else
            {
                RequestLoanForm request = new RequestLoanForm();
                this.Hide();
                request.ShowDialog();
            }
        }

        private void BayForLoanButton_Click(object sender, EventArgs e)
        {
            // Open ( PayForLoanForm) && hide this (AccountOperationForm) 
            PayForLoanForm payloan=new PayForLoanForm();
            this.Hide();
            payloan.ShowDialog();

        }

        private void AccountLogoutButton_Click(object sender, EventArgs e)
        {

            // Save the Change at LogFile 
            DateTime time = DateTime.Now;
            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
            StreamWriter Sr = new StreamWriter(fs);
            Sr.WriteLine(time + " Client  Of Account Number " + AccountLoginForm.accNum + " has logged out");
            Sr.Close();
            fs.Close();

            // Return to (EmployeeOperationsForm) && hide this (AccountOperationForm) 
            this.Hide();
            EmployeeOperationsForm employee = new EmployeeOperationsForm();
            employee.ShowDialog();

        
    }
    }
}
