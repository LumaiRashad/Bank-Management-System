using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
 public    class Client : Person
    {

        public Account ClientAccount;
        public bool LoanFlag;
        public bool Blacklist;
        public bool PayLoanCheck;
        public Loan ClientLoan;

        public DateTime date = DateTime.Now;

        public override int CalculateAge(string Year)
        {
            return  ((date.Year - int.Parse(Year)) * 12 * 30) / 365;

        }
        public Client()
        {
            FirstName = LastName = Mail = BirthDate = Address = SSN = Gender = PhoneNumber = "";
            LoanFlag = false;
            Blacklist = false;
            PayLoanCheck = false;
            ClientAccount = new Account();
            // ClientLoan=new Loan();
        }

     public Loan GetLoan()
     {
         return ClientLoan;

     }
        public void LoanCheck(bool flag)
        {
            if (flag == true)
            {
                LoanFlag = true;
                ClientLoan = new Loan(ClientAccount.AccNum, ref  Blacklist, ref PayLoanCheck);
            }
        }
        public Client(string FM, string LN, string EM, string BD, string AD, string ssn, string gender, string mobile)
        {
            FirstName = FM;
            LastName = LN;
            Gender = gender;
            // ClientAccount = Acc;
            SSN = ssn;
            Mail = EM;
            BirthDate = BD;
            Address = AD;
            PhoneNumber = mobile;
        }



    }
}
