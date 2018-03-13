using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
    class Request
    {
        public string OperationType { set; get; }
        private string AccNumber { set; get; }
        private string Amount { set; get; }
        private Operation AccountOperations;

        private Request()
        {
            OperationType = AccNumber = Amount = "";

        }

        private Request(string Type, string Number, string amountofmoney)
        {
            OperationType = Type;
            AccNumber = Number;
            Amount = amountofmoney;

        }

        void CheckOperation(string OperationType)
        {

            if (OperationType == "Deposite")
            {
                AccountOperations = new Deposite();
            }
            else if (OperationType == "Withdraw")
            {
                AccountOperations = new Withdraw();
            }

            else if (OperationType == "Transfer")
            {
                AccountOperations = new Transfere();
            }

        }


    }
}
