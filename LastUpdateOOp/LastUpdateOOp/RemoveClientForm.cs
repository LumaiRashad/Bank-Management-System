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
    public partial class RemoveClientForm : Form
    {
        public RemoveClientForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveClientButton_Click(object sender, EventArgs e)


        {
            // Check if he Filling All the Information
          if (ClientAccountNumberTextBox.Text == "" && ClientPasswordTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter Your Information !!!! ");
                }
                else if (ClientAccountNumberTextBox.Text == "")
                    MessageBox.Show("Please Enter Your Account Number !!!! ");
                else if (ClientPasswordTextBox.Text == "")
                    MessageBox.Show("Please Enter Your PassWord !!!! ");
                else
                {
                    
                    if (BankSystem.FO_client.Login(ClientAccountNumberTextBox.Text, ClientPasswordTextBox.Text))
                    {
                        // Delete Employee Using static (FO_Client) static object of FileOpeartionOfClient
                        BankSystem.FO_client.Delete(ClientAccountNumberTextBox.Text);


                        // Save ction to the LogFile
                        DateTime time = DateTime.Now;
                        FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                        StreamWriter Sr = new StreamWriter(fs);
                        Sr.WriteLine(time + " Client With Account Number " + ClientAccountNumberTextBox.Text + " has been Removed ");
                        Sr.Close();
                        fs.Close();

                    }
                    else
                    {
                        MessageBox.Show(" The password that you've entered is incorrect");

                    }

                    

                }


          //Return To the (EmployeeOperationsForm) && Hide this Form ( RemoveClientForm)
          this.Hide();
          EmployeeOperationsForm employee = new EmployeeOperationsForm();
          employee.ShowDialog();


        }
          
    }
}
