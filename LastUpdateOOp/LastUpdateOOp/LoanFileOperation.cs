using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LastUpdateOOp
{
public     class LoanFileOperation
    {
        
        static List<Client> LoanClientList;
        FileOperationOfClient FO=new FileOperationOfClient();

        public static List<Loan> LoanList;
        public static string AccountNumber;
        public LoanFileOperation()
        {
            
            {
                LoanClientList = FO.GetClientlist();
                LoanList = new List<Loan>();
                AccountNumber = "";
                if (LoanClientList !=NULL)
                {
                    for (int i = 0; i < LoanClientList.Count; i++)
                    {
                        if (LoanClientList[i].LoanFlag == true)
                        {
                            LoanList.Add(LoanClientList[i].ClientLoan);
                        }

                    }
                }
            }
        }
        public LoanFileOperation(List<Loan> Lon_list)
        {
            LoanList = Lon_list;
        }
        public string GetAccNum()
        {
            return AccountNumber;

        }
        public void SaveAtFile()//save data of list in file.
        {
            FileStream FS = new FileStream("LoanData.txt", FileMode.Create);
            StreamWriter SW = new StreamWriter(FS);
            for (int i = 0; i < LoanList.Count; i++)
            {
                string LoanData = LoanList[i].AccNumber + "&" + LoanList[i].LoanTime + "&" + LoanList[i].loanvalue + "&" + LoanList[i].warrenty + "&" + LoanList[i].warrentyValue + "&" + LoanList[i].installmentPerioud + "&" + LoanList[i].installmentValue + "&" + LoanList[i].PaymentAmount + "&" + LoanList[i].blacklist + "&" + LoanList[i].payloanCheck;
                SW.WriteLine(LoanData);
            }
            SW.Close();

        }

        public Loan Findloan(string accNum)
        {
            return LoanList.Find(Loan => Loan.AccNumber == accNum);

        }
        public bool CheckFind(string accNum)
        {
            if (LoanList.Any(Loan => Loan.AccNumber == accNum))
                return true;
            else
                return false;
        }
        //public bool haveALoan(string accNum)
        //{
        //    Client c = LoanClientList.Find(Client => Client.ClientAccount.AccNum == accNum);
        //    if (CheckFind(accNum) == true && c.LoanFlag == true)
        //        return true;
        //    else
        //        return false;
        //}
        public void AddLoan(Loan lon, string accNum)
        {
            if (CheckFind(accNum) == false)
            {
                LoanList.Add(lon);
                SaveAtFile();
               // Console.WriteLine("Successfully Added");
                MessageBox.Show(" Loan is Taked Successfuly");
            }
            else
               // Console.WriteLine("Already Exist!!!");
            MessageBox.Show("Already Exist!!!");

        }
        public void Load()//load data of file in list.
        {
            if (LoanList.Count != 0)
            {
                FileStream FS = new FileStream("LoanData.txt", FileMode.OpenOrCreate);
               // FileStream NewFile = new FileStream("RemovedClien.txt", FileMode.OpenOrCreate);
              //  StreamWriter SW = new StreamWriter(NewFile);
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
                    LoanList.Add(obj);
                }
                SR.Close();
                // SW.Close();
             //   File.Delete("LoanData.txt");
              //  File.Copy("RemovedClien.txt", "ClintData.txt");
              //  File.Delete("RemovedClien.txt");

            }
            else
            {
                
            }
        }



        public List<Client> NULL { get; set; }
    }
}

