using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
   public  class Balance
    {
        public static double LoansBalance { get; set; }
        public static double BankBalance { get; set; }
        

        public Balance()
        {
            LoansBalance = BankBalance = 0;
        }

        public Balance(double loan, double bank)
        {
            LoansBalance = loan;
            BankBalance = bank;
        }

       public void LoadBalance()
       {
           FileStream FS = new FileStream("BankBalance.txt", FileMode.OpenOrCreate);
           StreamReader SR = new StreamReader(FS);
            string[] fields;
            while (SR.Peek() != -1)
            {
                string line = SR.ReadLine();
                fields = line.Split('&');
                LoansBalance = Convert.ToDouble(fields[1]);
                BankBalance = Convert.ToDouble(fields[0]);
            }
            SR.Close();
       }

       public void save()
       {
           FileStream FS = new FileStream("BankBalance.txt", FileMode.Create);
           StreamWriter Sw = new StreamWriter(FS);
           Sw.WriteLine(BankBalance+"&"+LoansBalance);
           Sw.Close();
       }

       public void SetLoan(double loan)
        {
            LoansBalance = loan;
        }

        public void SetBalance(double bank)
        {
            BankBalance = bank;
        }

        public string GetLoanBalance()
        {
            return LoansBalance.ToString();

        }

        public string GetBankBalance()
        {
            return BankBalance.ToString();

        }



    }
}