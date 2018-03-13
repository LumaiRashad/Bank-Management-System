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
    public partial class RemoveEmployeeForm : Form
    {
        public RemoveEmployeeForm()
        {
            InitializeComponent();
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            // function ->> To remove employee form list & file 


            BankSystem bank = new BankSystem();
            ManagerOperationsForm manager = new ManagerOperationsForm();


            //Delete Employee With this ID
            bank.BankManager.DeleteEmployee(EmployeeIDTextBox.Text);

            // Save Action to LogFile
            DateTime time = DateTime.Now;
            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
            StreamWriter Sr = new StreamWriter(fs);
            Sr.WriteLine(time + " Employee With ID " + EmployeeIDTextBox.Text + " has been Removed ");
            Sr.Close();
            fs.Close();


            //Return to (  ManagerOperationsForm ) && hide this form (AddEmployeeForm)
            this.Hide();
            manager.ShowDialog();




        }

        private void EmployeeIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
