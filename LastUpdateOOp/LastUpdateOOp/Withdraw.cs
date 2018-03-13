using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
    class Withdraw : Operation
    {
        //implement do operation

        public override void DoOperation(ref double balance, ref double amount, ref double flagg)
        {

            balance -= amount;


        }

    }
}