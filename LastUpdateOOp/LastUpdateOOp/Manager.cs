using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace LastUpdateOOp
{
    class Manager : Employee
    {
        public static List<Accountant> EmployeeList=BankSystem.EmployeeList;
        public static FileOperationOfEmployee FO_employee=BankSystem.FO_employee;
        private FileStream FS = new FileStream("BankManger.txt", FileMode.OpenOrCreate);
        public long  IDOfEmployee { get; set; }


        public Manager( /*FileOperationOfEmployee Fo_emp, List<Accountant> ListACC*/)
        {
            // EmployeeList = ListACC;
            //  FO_employee = Fo_emp;
            StreamReader SR = new StreamReader(FS);
            string[] fields;
            while (SR.Peek() != -1)
            {
                string line = SR.ReadLine();
                fields = line.Split('&');
                FirstName = fields[0];
                LastName = fields[1];
                SSN = fields[2];
                Gender = fields[3];
                BirthDate = fields[4];
                Mail = fields[5];
                Address = fields[6];
                PhoneNumber = fields[7];
                Password = fields[8];
                Position = fields[9];
                Grade = fields[10];
                ID = fields[11];


            }
            SR.Close();
            if (EmployeeList.Count == 0)
            {
                IDOfEmployee = 1000;
            }
            else
            {
                IDOfEmployee = Convert.ToInt64(EmployeeList[EmployeeList.Count - 1].ID) + 1;
            }
        }

        public bool Login(string id, string password)
        {
            if (ID == id && Password == password)
                return true;
            else
                return false;
        }
        
        public void AddEmployee(Accountant accountent)
        {
            FO_employee.AddEmployee(accountent);
           
        }

        public void DeleteEmployee(string id)
        {
            FO_employee.Delete(id);
          
        }

        public void Update(string  id ,Accountant emp)
        {
            FO_employee.Update(id, emp);
        }


    }
}
