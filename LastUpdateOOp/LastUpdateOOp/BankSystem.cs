using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
    class BankSystem
    {
        public static Balance TotalBalanceOfBank = new Balance();
        public static List<Client> ClientList = new List<Client>();
        public static List<Accountant> EmployeeList = new List<Accountant>();
        public Manager BankManager=new Manager(/*FO_employee, EmployeeList*/);
        public static FileOperationOfClient FO_client = new FileOperationOfClient(ClientList);
        public static FileOperationOfEmployee FO_employee = new FileOperationOfEmployee(EmployeeList);
        public long AccNumOfClient { get; set; }

        public BankSystem()
        {
            //FO_client = new FileOperationOfClient(ClientList);
            //FO_employee = new FileOperationOfEmployee(EmployeeList);
            //BankManager = new Manager(FO_employee, EmployeeList);  

            if (ClientList.Count == 0)
            {
                AccNumOfClient = 20000;
            }
            else
            {
                AccNumOfClient = Convert.ToInt64(ClientList[ClientList.Count - 1].ClientAccount.AccNum) + 1;
            }

        }
      
        
        public void LoadAllFiles()
        {
            FO_client.Load();
            FO_employee.Load();
            TotalBalanceOfBank.LoadBalance();

        }
        public void SetBalance(Balance balance)
        {
            TotalBalanceOfBank = balance;
        }
        public Balance GetBalance()
        {
            return TotalBalanceOfBank;
        }
    }
}
