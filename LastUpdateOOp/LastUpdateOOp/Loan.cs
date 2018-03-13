using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastUpdateOOp
{
 public class Loan
    {
        // fe class client ama nro7 client law a5d loan hy7otle time da :D 


        /// <summary>
        /// H5odha by Refrence mn el client 
        /// </summary>
        public string LoanTime { set; get; }
        public string AccNumber { set; get; }
        public bool blacklist { set; get; }
        public bool payloanCheck { set; get; }

        /// <summary>
        /// Hyd5lhmle mn Forms
        /// </summary>
        public string loanvalue { set; get; }
        public string warrenty { set; get; }
        public string warrentyValue { set; get; }
        public string installmentPerioud { set; get; }

        /// <summary>
        /// Hy7sbhmle mn functions 
        /// </summary>
        public string installmentValue { set; get; }//New
        public string PaymentAmount { set; get; } // New

        public Balance TotalBankloanbalance_obj = new Balance();
        public string loan_balanceOfBank = Balance.LoansBalance.ToString();


        // constructor 

        public Loan()
        {

            blacklist = payloanCheck = false;
            loanvalue = warrenty = warrentyValue = installmentPerioud = LoanTime = installmentValue = "";
        }
        // first Constructor to creat a loan object 
        public Loan(string accNum, ref bool blackList, ref bool PLoanCheck)
        {
            loan_balanceOfBank = TotalBankloanbalance_obj.GetLoanBalance();
            AccNumber = accNum;
            blacklist = blackList;
            payloanCheck = PLoanCheck;
        }

        // Secound Constructor to itialize the data of loan obj form Form 
        public Loan(string Loan, string Warrenty, string WarrentyValue, string InstallmentPerioud)
        {
            loanvalue = Loan;
            warrenty = Warrenty;
            warrentyValue = WarrentyValue;
            installmentPerioud = InstallmentPerioud;

        }
        // After creat the obj The first  fun to call
        public void TimeNow()
        {
            DateTime Date = DateTime.Now;
            string Day = Convert.ToString(Date.Day);
            string Month = Convert.ToString(Date.Month);
            string year = Convert.ToString(Date.Year);

            LoanTime = Day + "/" + Month + "/" + year;

        }

        // check if we can take a loan or not 
        // when press Request button 
        public bool LoanRequest(String LoanValue, string WarrentyValue)
        {

            if ((Convert.ToDouble(loan_balanceOfBank) > Convert.ToDouble(LoanValue)) &&
                (Convert.ToDouble(LoanValue) <= Convert.ToDouble(WarrentyValue)) )
            {

                double b = Convert.ToDouble(BankSystem.TotalBalanceOfBank.GetLoanBalance()) - Convert.ToDouble(LoanValue);
                BankSystem.TotalBalanceOfBank.SetLoan(b);
                BankSystem.TotalBalanceOfBank.save();
                return true;

            }
            else
            {
                return false;
            }
        }


        // Calculate the installment 

        public void Calculate_InstallmentAmount()
        {
            

            PaymentAmount = Math.Round (((Convert.ToDouble(loanvalue) * (7.5 / 100)) + Convert.ToDouble(loanvalue))).ToString();
            installmentValue =  Math.Round((Convert.ToDouble(PaymentAmount) / (Convert.ToDouble(installmentPerioud) * 12.0))).ToString();



        }

        // // public  string returnDate()
        //{
        //    // get dateform file 
        //    Split funcion
        //}
        //// Func to get day && date 
        // need in file operations 

        ////public bool BlacklistCheck()
        ////{

        // call  string returnDate() w n7ooto f variable 
        //// //code 2 for loop .. hwa hyb3thale string 
        //// //ana h3mlha b substring

        ////private DateTime Date = new DateTime();
        ////private int Monthvalue, Dayvalue;

        ////    Monthvalue = Date.Month - (Month*30);
        ////    Dayval = Date.Day - Day;
        ////    Monthvalue += Dayvalue;
        ////    if (Monthvalue > 60)
        ////    {
        ////        return true;
        ////    }
        ////    else
        ////    {
        ////        return false;
        ////    }

        //}

        //

        // payment the loan  && set if the client paied the loan and if he isa a balced list 
        public void LoanPayment(string pay)
        {

            if (pay == installmentValue)
            {
                loan_balanceOfBank = (Convert.ToDouble(loan_balanceOfBank) + Convert.ToDouble(pay)).ToString();
                TotalBankloanbalance_obj.SetLoan(Convert.ToDouble(loan_balanceOfBank));
                BankSystem.TotalBalanceOfBank.save();
                MessageBox.Show(" You Paid your Monthly Installment   ");
            }
            else
            {
                MessageBox.Show(" Please enter only the Installment amount ");
            }
        }
    }
}

