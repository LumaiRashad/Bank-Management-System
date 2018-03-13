using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LastUpdateOOp;
using System.Windows.Forms;
namespace LastUpdateOOp
{
     class FileOperationOfEmployee
    {
        public static List<Accountant> EmployeeList;
        public static string ID;
        public FileOperationOfEmployee()

        {
            ID = "";
        }
        public FileOperationOfEmployee(List<Accountant> Emp_list)
        {
            EmployeeList = Emp_list;
        }
        public string GetID()
        {
            return ID;

        }
        public void SaveAtFile()//save data of list in file.
        {
            FileStream FS = new FileStream("EmployeeData.txt", FileMode.Create);
            StreamWriter SW = new StreamWriter(FS);
           // FileStream NewFile = new FileStream("RemovedEmployee.txt", FileMode.OpenOrCreate);
            // StreamWriter sw = new StreamWriter(NewFile);
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                string EmployeeData = EmployeeList[i].FirstName + "&" + EmployeeList[i].LastName + "&" + EmployeeList[i].SSN + "&" + EmployeeList[i].Gender + "&" + EmployeeList[i].BirthDate + "&" + EmployeeList[i].Mail + "&" + EmployeeList[i].Address + "&" + EmployeeList[i].PhoneNumber + "&" + EmployeeList[i].Password + "&" + EmployeeList[i].Position + "&" + EmployeeList[i].Grade + "&" + EmployeeList[i].ID+"&"+EmployeeList[i].YearOfGraduation+"&"+EmployeeList[i].CollegeOfGraduate;
                SW.WriteLine(EmployeeData);
            }
            SW.Close();
           // sw.Close();
           // File.Delete("EmployeetData.txt");
           // File.Copy("RemovedEmployee.txt", "EmployeetData.txt");
           // File.Delete("RemovedEmployee.txt");

        }
        public Accountant FindEmployee(string id)
        {
            return EmployeeList.Find(Accountant => Accountant.ID == ID);
        }
        public bool CheckFind(string id)
        {
            ID = id;
            if (EmployeeList.Any(Accountant => Accountant.ID == ID))
                return true;
            else
                return false;
        }

        public bool Login(string accNum, string password)
        {
           

                Accountant employee = FindEmployee(accNum);

                if (employee.Password== password)
                {

                    return true;
                   
                }
                else
                {
                   
                    return false;

                }
            

           
        }

        public void AddEmployee(Accountant emp)//add a Client to my list after check.
        {
            //if (CheckFind(emp.ID) == false)
            //{
                EmployeeList.Add(emp);
                SaveAtFile();
                //Console.WriteLine("Successfully Added");
               //  MessageBox.Show("Successfully Added");
            //}
            //else
            //    //Console.WriteLine("Already Exist!!!");
            //MessageBox.Show("Already Exist!!!");

        }
        public void Load()//load data of file in list.
        {
            FileStream FS = new FileStream("EmployeeData.txt", FileMode.OpenOrCreate);
//FileStream NewFile = new FileStream("RemovedEmployee.txt", FileMode.OpenOrCreate);
       //    StreamWriter SW = new StreamWriter(NewFile);
            StreamReader SR = new StreamReader(FS);
            string[] fields;
            while (SR.Peek() != -1)
            {
                Accountant emp = new Accountant();
                string line = SR.ReadLine();
                fields = line.Split('&');
                emp.FirstName = fields[0];
                emp.LastName = fields[1];
                emp.SSN = fields[2];
                emp.Gender = fields[3];
                emp.BirthDate = fields[4];
                emp.Mail = fields[5];
                emp.Address = fields[6];
                emp.PhoneNumber = fields[7];
                emp.Password = fields[8];
                emp.Position = fields[9];
                emp.Grade = fields[10];
                emp.ID = fields[11];
                emp.YearOfGraduation = fields[12];
                emp.CollegeOfGraduate = fields[13];
                EmployeeList.Add(emp);
            }

            SR.Close();
        //    SW.Close();
       //     File.Copy("EmployeetData.txt", "RemovedEmployee.txt");
        //    File.Delete("EmployeetData.txt");
        //    File.Delete("RemovedEmployee.txt");
        }
        public void Delete(string id)
        {
            if (CheckFind(id) == true)
            {
                EmployeeList.RemoveAll(Accountant => Accountant.ID == id);//remove all object have the ssn.
               SaveAtFile();
                 MessageBox.Show("Successfully Deleted");
             
            }
            else
             MessageBox.Show("Not Exist!!!");
        }
        public void Update(String id, Accountant emp)//remove an employee from my list and add the new one then save in file.
        {
            EmployeeList.RemoveAll(Accountant => Accountant.ID == id);
            EmployeeList.Add(emp);
           SaveAtFile();
            // MessageBox.Show("Successfully Updated");
        }
    }
}
