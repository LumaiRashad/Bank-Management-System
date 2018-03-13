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
    public partial class AcceptLoanForm : Form
    {

        public AcceptLoanForm()
        {

            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TakeLoanButton_Click(object sender, EventArgs e)
        {

            Loan acceptedLoan = new Loan();

            // LoanFileOperation Loanoperation = new LoanFileOperation();

            acceptedLoan.AccNumber = RequestLoanForm.Takedloan.AccNumber;
            acceptedLoan.loanvalue = RequestLoanForm.Takedloan.loanvalue;
            acceptedLoan.warrenty = RequestLoanForm.Takedloan.warrenty;
            acceptedLoan.warrentyValue = RequestLoanForm.Takedloan.warrentyValue;
            acceptedLoan.PaymentAmount = RequestLoanForm.Takedloan.PaymentAmount;
            acceptedLoan.installmentValue = RequestLoanForm.Takedloan.installmentValue;
            acceptedLoan.installmentPerioud = RequestLoanForm.Takedloan.installmentPerioud;
            acceptedLoan.LoanTime = RequestLoanForm.Takedloan.LoanTime;
            acceptedLoan.payloanCheck = false;
            acceptedLoan.blacklist = false;

            Accountant.L_FO.AddLoan(acceptedLoan, acceptedLoan.AccNumber);



            DateTime time = DateTime.Now;
            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
            StreamWriter Sr = new StreamWriter(fs);
            Sr.WriteLine(time + " Client With Account Number  " + AccountLoginForm.accNum+ " has taked a loan ");
            Sr.Close();
            fs.Close();



     
            string accNum = AccountLoginForm.accNum;
            Client c = BankSystem.FO_client.FindClient(accNum);
            c.LoanFlag = true;
            BankSystem.FO_client.Update(accNum, c);
            AccountOperationsForm returnForm = new AccountOperationsForm();
            this.Hide();
            returnForm.ShowDialog();
          
            // azwd loan da 3nde f file w list bt3te 
            // kda hwa wsh a5d loan htl3lo message en loan ata5d successfuly 
            // Yrg3 b2a l ( Account operations ) 



        }

        private void RefuseButton_Click(object sender, EventArgs e)
        {
            AccountOperationsForm returnForm = new AccountOperationsForm();
            this.Hide();
            returnForm.ShowDialog();

            // hytl3lo message box en el loan mt5dsh 5alas :D 
            // yrg3 l ( AccountOperations Form ) 

        }

        private void AcceptLoanForm_Load(object sender, EventArgs e)
        {
            // show in the form 

            AccNumberTextBox.Text = RequestLoanForm.Takedloan.AccNumber;
            LoanValueTextBox.Text = RequestLoanForm.Takedloan.loanvalue;
            WarrantyTextBox.Text = RequestLoanForm.Takedloan.warrenty;
            WarrantyValueTextBox.Text = RequestLoanForm.Takedloan.warrentyValue;
            PaybackAmountTextBox.Text = RequestLoanForm.Takedloan.PaymentAmount;
            InstallmentAmountTextBox.Text = RequestLoanForm.Takedloan.installmentValue;
            InstallmentProcessTextBox.Text = RequestLoanForm.Takedloan.installmentPerioud;
            LoanTimeTextBox.Text = RequestLoanForm.Takedloan.LoanTime;

        }

        private void InstallmentProcessTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
