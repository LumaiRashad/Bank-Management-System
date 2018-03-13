using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastUpdateOOp
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            // load files to the lists 1- ClientData , 2-EmployeeData , 3-LoanData ,4-BankManager , 5- Bank Balance ,6-BankBlance 
                                    
           

                BankSystem bank = new BankSystem();
                bank.LoadAllFiles();
                Accountant emp=new Accountant();
                emp.LoadLoans();
           
            InitializeComponent();

        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            // open ManegerLoginForm 
            Manager_LoginForm managerlogin=new Manager_LoginForm();
            managerlogin.ShowDialog(); 

            //It wont hide it (Start Form ), but it will be minimized:
            this.WindowState = FormWindowState.Minimized;

           


        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            // open(Employee login form )
            EmployeeLoginForm employeeLogin=new EmployeeLoginForm();
            employeeLogin.ShowDialog();

            //  It wont hide it  (Start Form ) , but it will be minimized:
            this.WindowState = FormWindowState.Minimized;
           


        }

        private void StartForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void ExistButton_Click(object sender, EventArgs e)
        {
            // Close the Program 
            this.Close();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
       

        }
    }
}
