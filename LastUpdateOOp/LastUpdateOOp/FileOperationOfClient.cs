using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace LastUpdateOOp
{
    internal class FileOperationOfClient
    {
        public static List<Client> ClientList;
        public static string AccountNumber;

        public List<Client> GetClientlist()
        {
            return ClientList;
        }
        public FileOperationOfClient()
        {
            AccountNumber = "";
        }

        public FileOperationOfClient(List<Client> Cl_list)
        {
            ClientList = Cl_list;
        }

        public string GetAccNum()
        {
            return AccountNumber;

        }

        public void SaveAtFile() //save data of list in file.
        {
            FileStream FS = new FileStream("ClintData.txt", FileMode.Create);
            StreamWriter SW = new StreamWriter(FS);
         //   ClientList = ClientList.OrderBy(Client => Client.ClientAccount.AccNum).ToList();
            for (int i = 0; i < ClientList.Count; i++)
            {
                string clientData = ClientList[i].FirstName + "&" + ClientList[i].LastName + "&" + ClientList[i].SSN +
                                    "&" + ClientList[i].Gender + "&" + ClientList[i].BirthDate + "&" +
                                    ClientList[i].Mail + "&" + ClientList[i].Address + "&" + ClientList[i].PhoneNumber +
                                    "&" + ClientList[i].ClientAccount.Password + "&" +
                                    ClientList[i].ClientAccount.AccNum + "&" +
                                    ClientList[i].ClientAccount.getBalance().ToString() + "&" +
                                    ClientList[i].ClientAccount.Activation + "&" + ClientList[i].LoanFlag + "&" +
                                    ClientList[i].Blacklist + "&" + ClientList[i].PayLoanCheck;
                SW.WriteLine(clientData);
            }
            SW.Close();

        }

        public Client FindClient(string accNum)
        {
            return ClientList.Find(Client => Client.ClientAccount.AccNum == accNum);
        }

        public bool CheckFind(string accNum)
        {
            AccountNumber = accNum;
            if (ClientList.Any(Client => Client.ClientAccount.AccNum == AccountNumber))
                return true;
            else
                return false;
        }

        public void AddClient(Client client) //add an Client to my list after check.
        {
            //if (CheckFind(client.ClientAccount.AccNum) == false)
            //{
                ClientList.Add(client);
                SaveAtFile();

                MessageBox.Show("Successfully Added");
            //}
            //else
            //    MessageBox.Show("Already Exist!!!");

        }

        public bool Login(string accNum, string password)
        {
            if (CheckFind(accNum))
            {
                Client client = FindClient(accNum);
                if (client.ClientAccount.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }
        }

        public void Load() //load data of file in list.
        {
            FileStream FS = new FileStream("ClintData.txt", FileMode.OpenOrCreate);
            //FileStream NewFile = new FileStream("RemovedClien.txt", FileMode.OpenOrCreate);
            //StreamWriter SW = new StreamWriter(NewFile);
            StreamReader SR = new StreamReader(FS);
            string[] fields;
            while (SR.Peek() != -1)
            {
                Client c = new Client();
                string line = SR.ReadLine();
                fields = line.Split('&');
                c.FirstName = fields[0];
                c.LastName = fields[1];
                c.SSN = fields[2];
                c.Gender = fields[3];
                c.BirthDate = fields[4];
                c.Mail = fields[5];
                c.Address = fields[6];
                c.PhoneNumber = fields[7];
                c.ClientAccount.Password = fields[8];
                c.ClientAccount.AccNum = fields[9];
                c.ClientAccount.setBalance(double.Parse(fields[10]));
                c.ClientAccount.Activation = bool.Parse(fields[11]);
                c.LoanFlag = bool.Parse(fields[12]);
                if (c.LoanFlag == true)
                {
                    c.ClientLoan = GetLoan(c.ClientAccount.AccNum);
                }
                c.Blacklist = bool.Parse(fields[13]);
                c.PayLoanCheck = bool.Parse(fields[14]);
                ClientList.Add(c);
            }
            SR.Close();
            //SW.Close();
            // File.Delete("ClintData.txt");
            //File.Copy("RemovedClien.txt", "ClintData.txt");
            //File.Delete("RemovedClien.txt");


        }

        private Loan GetLoan(string accountNumber)
        {
            Loan temp = new Loan();
            FileStream FS = new FileStream("LoanData.txt", FileMode.OpenOrCreate);
            StreamReader SR = new StreamReader(FS);
            string[] fields;
            while (SR.Peek() != -1)
            {
                Loan obj = new Loan();
                string line = SR.ReadLine();
                fields = line.Split('&');
                obj.AccNumber = fields[0];
                obj.LoanTime = fields[1];
                obj.loanvalue = fields[2];
                obj.warrenty = fields[3];
                obj.warrentyValue = fields[4];
                obj.installmentPerioud = fields[5];
                obj.installmentValue = fields[6];
                obj.PaymentAmount = fields[7];
                if (fields[8] == "True")
                    obj.blacklist = true;
                else
                    obj.blacklist = false;
                if (fields[9] == "True")
                    obj.payloanCheck = true;
                else
                    obj.blacklist = false;
                if (obj.AccNumber == accountNumber)
                {
                    temp = obj;
                    break;
                }

            }
            SR.Close();

            return temp;
        }

        public void Update(String accNum, Client c)
        //remove an employee from my list and add the new one then save in file.
        {
            ClientList.RemoveAll(Client => Client.ClientAccount.AccNum == accNum);
            ClientList.Add(c);
            SaveAtFile();
            // MessageBox.Show("Successfully Updated");
        }

        public void Delete(string accNum)
        {
            if (CheckFind(accNum) == true)
            {
                ClientList.RemoveAll(Client => Client.ClientAccount.AccNum == accNum); //remove all object have the ssn.
                SaveAtFile();
                MessageBox.Show("Successfully Deleted");

            }
            else
                MessageBox.Show("Not Exist!!!");
        }
    }
}
