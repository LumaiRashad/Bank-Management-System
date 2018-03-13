using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
    class Deposite : Operation
    {



        //implement do operation
        public override void DoOperation(ref double balance, ref double amount, ref double flag)
        {

            balance += amount;


        }

    }
}
