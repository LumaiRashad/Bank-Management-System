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
    public partial class IDloginEmployee : Form
    {
        // Static object To use(path) it at the following Form &
        public static Accountant employee { set; get; }
        public IDloginEmployee()
        {
            InitializeComponent();
        }

        private void IDloginEmployee_Load(object sender, EventArgs e)
        {
            
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            // Function ->> To Check if the employee foumd to be updated or not && get this employee
            try
            {
                employee = new Accountant();

                if (BankSystem.FO_employee.CheckFind(EmployeeIDTextBox.Text))
                {
                    // if he found the employee he will put it the (emloyee) static object to path it to the ( following or next ) form 
                    employee = BankSystem.FO_employee.FindEmployee(EmployeeIDTextBox.Text);

                    UpdateEmployeeForm update = new UpdateEmployeeForm();

                    // Open UpdateEmployeeForm && Hide this Form (IDloginEmployee)
                    this.Hide();
                    update.ShowDialog();
                }
                else
                {
                    
                    MessageBox.Show(" Not found !!! ");
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }

        }

    }

 }

