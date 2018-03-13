using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastUpdateOOp
{
    public partial class RequestLoanForm : Form
    {
        public static   Loan Takedloan { get; set; }
        public RequestLoanForm()
        {
            InitializeComponent();
        }

        private void RequestLoanButton_Click(object sender, EventArgs e)
        {

            string AccNum = AccountLoginForm.accNum; //frm.ClientAccountNumberTextBox.Text.ToString();
            string PW = AccountLoginForm.pw; //frm.AccountPasswordTextBox.Text.ToString();
           
            // da ele bn2lo el form el tnya 
           
                Takedloan = new Loan();


                Loan loan = new Loan();
                loan.loanvalue = LoanvalueTextBox.Text;

                loan.warrenty = WarrantyComboBox.Text;

                loan.warrentyValue = WarrantyValueTextBox.Text;

                loan.installmentPerioud = InstallmentPerioudComboBox.Text;


                if (loan.LoanRequest(loan.loanvalue, loan.warrentyValue))
                {

                    loan.Calculate_InstallmentAmount();
                    loan.TimeNow();

                    AcceptLoanForm acceptedloan = new AcceptLoanForm();
                    this.Hide();

                    Takedloan.AccNumber = AccNum;
                    Takedloan.loanvalue = LoanvalueTextBox.Text;
                    Takedloan.warrenty = WarrantyComboBox.Text;
                    Takedloan.warrentyValue = WarrantyValueTextBox.Text;
                    Takedloan.PaymentAmount = loan.PaymentAmount;
                    Takedloan.installmentValue = loan.installmentValue;
                    Takedloan.installmentPerioud = InstallmentPerioudComboBox.SelectedItem.ToString();
                    Takedloan.LoanTime = loan.LoanTime;

                    acceptedloan.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" Your Loan is Refused !!! ");
                }


            

            // hy7sble ynf3 a5od loan wala la2 
            // law Mnf3sh ->> hydene messageBox 
            // Law nfa3 ->>1- hy3ml obj mn loan w y7sble el 7sabat bt3to ( istallment w payamount w gaw da ) 
            //             2- Hytft7 ( AcceptedLoan Form )


        }

        private void RequestLoanForm_Load(object sender, EventArgs e)
        {

        }

        private void InstallmentPerioudComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
