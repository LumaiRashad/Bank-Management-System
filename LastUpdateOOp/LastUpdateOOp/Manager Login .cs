using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LastUpdateOOp
{
    public partial class Manager_LoginForm : Form
    {
        public Manager_LoginForm()
        {
            InitializeComponent();
        }

        private void ManagerLoginButton_Click(object sender, EventArgs e)
        {
            // It's Function ->> Login of Manager to the system 



            BankSystem bank=new BankSystem();
            
            // Check if he enterd the data or not 
            if (ManagerIDTextBox.Text == "" && ManagerPasswordTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Your Information !!!! ");
            }
            else if (ManagerIDTextBox.Text == "")
                MessageBox.Show("Please Enter Your ID !!!! ");
            else if (ManagerPasswordTextBox.Text == "")
                MessageBox.Show("Please Enter Your PassWord !!!! ");


            else
            {
                // Check login
                if (bank.BankManager.Login(ManagerIDTextBox.Text, ManagerPasswordTextBox.Text))
                {

                    //Save at Logfile
                    DateTime time = DateTime.Now;
                    FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                    StreamWriter Sr = new StreamWriter(fs);
                    Sr.WriteLine(time + " Manager Of Bank has logged in");
                    Sr.Close();
                    fs.Close();


                    //Open the manager profile Or Account in the system && Hide this form (Manager Login Form )
                    ManagerOperationsForm managerOperations = new ManagerOperationsForm();
                   
                    this.Hide();
                    managerOperations.ShowDialog();
                    

                }
                else
                {
                    // if id & password != id & password of the Bank Manager
                        MessageBox.Show(" The Information that you've entered is incorrect");
                    
                }


            }
         

        }
    }
}
