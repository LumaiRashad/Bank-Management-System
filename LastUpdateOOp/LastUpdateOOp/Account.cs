using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
    
 public    class Account
    {
        public string Password { get; set; }
        public string AccNum { get; set; }
        public bool Activation { get; set; }
        public static double Balance { get; set; }

        public Account ()
        {
            Password = AccNum = "";
            Balance = 0;
            Activation = false;
        }

        public void setBalance(double money)
        {
            Balance = money;
        }

        public double getBalance()
        {
            return Balance;
        }
    }
}
