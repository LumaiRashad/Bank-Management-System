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
    public partial class EmployeeOperationsForm : Form
    {
        public EmployeeOperationsForm()
        {
            InitializeComponent();
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            //Open ( AddClientForm ) && Hide this Form (EmployeeOperation Form )
            AddClientForm addClient=new AddClientForm();
            this.Hide();
            addClient.ShowDialog();
            
        }


        private void RemoveClientButton_Click(object sender, EventArgs e)
        {

            //Open (RemoveClientForm) && Hide this Form (EmployeeOperation Form )
            RemoveClientForm removeClient=new RemoveClientForm();
            this.Hide();
            removeClient.ShowDialog();
     



        }

        private void AccountLoginButton_Click(object sender, EventArgs e)
        {

            //   Open  ( AccountLoginForm)  && Hide this Form (EmployeeOperation Form )
            AccountLoginForm accountLogin=new AccountLoginForm();
            this.Hide();
            accountLogin.ShowDialog();
           



        }

        private void EmployeeLogoutButton_Click(object sender, EventArgs e)
        {


            DateTime time = DateTime.Now;
            FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
            StreamWriter Sr = new StreamWriter(fs);
            Sr.WriteLine(time + " Employee Of ID" +  EmployeeLoginForm.ID  +" has logged out");
            Sr.Close();
            fs.Close();

            // Return To (  StartForm) && Hide this Form (EmployeeOperation Form )
            StartForm returntoStartForm =new StartForm();
            this.Hide();
            returntoStartForm.ShowDialog();

        }
    }
}
