using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
    class Transfere : Operation
    {
        //implement do operation
        public Deposite deposite;

        public Withdraw withdraw;
        public override void DoOperation(ref double balancefrom, ref double amount, ref double balanceto)
        {
            double flag = 0.0;
            deposite = new Deposite();
            withdraw = new Withdraw();
            deposite.DoOperation(ref balanceto, ref amount, ref flag);
            withdraw.DoOperation(ref balancefrom, ref amount, ref flag);

        }

    }
}
