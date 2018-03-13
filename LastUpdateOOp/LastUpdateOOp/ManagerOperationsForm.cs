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
    public partial class ManagerOperationsForm : Form
    {
        public ManagerOperationsForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {

            // Open (AddEmployeeForm) &&  Hide this form (ManagerOperationsForm)
            AddEmployeeForm addEmployee=new AddEmployeeForm();
            this.Hide();
            addEmployee.ShowDialog();
          
           

        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {

          // open(RemoveEmployeeForm) &&  Hide this form (ManagerOperationsForm)
            RemoveEmployeeForm removeEmployee=new RemoveEmployeeForm();
            this.Hide();
            removeEmployee.ShowDialog();
        
        }

        private void ManagerLogoutButton_Click(object sender, EventArgs e)
        {
            
            StartForm returnForm =new StartForm();


            // Save Action At LogFile
            DateTime time = DateTime.Now;
            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
            StreamWriter Sr = new StreamWriter(fs);
            Sr.WriteLine(time + " Manager Of Bank has logged out");
            Sr.Close();
            fs.Close();

            //  Return to (Start Form ) &&  Hide this form (ManagerOperationsForm)
            this.Hide();
            returnForm.ShowDialog();
            

          
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
         IDloginEmployee Idlogin=new IDloginEmployee();
            this.Hide();
            Idlogin.ShowDialog();
        }

    }
}
