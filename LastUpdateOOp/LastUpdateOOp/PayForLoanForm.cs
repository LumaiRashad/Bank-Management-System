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
    public partial class PayForLoanForm : Form
    {
        public PayForLoanForm()
        {
            InitializeComponent();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            string accNum = AccountLoginForm.accNum;
            string pw = AccountLoginForm.pw;
            if (Accountant.L_FO.CheckFind(accNum))
            {
                Loan paiedforLoan = Accountant.L_FO.Findloan(accNum);
                paiedforLoan.LoanPayment(AmountOfMoneyTextBox.Text);
                Accountant.L_FO.SaveAtFile();

                DateTime time = DateTime.Now;
                FileStream fs = new FileStream("BankLogFile.txt", FileMode.Append);
                StreamWriter Sr = new StreamWriter(fs);
                Sr.WriteLine(time + " Client With Account Number  " + AccountLoginForm.accNum + " has paied his Installment's loan ");
                Sr.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("You already havn't a loan");
            }

            AccountOperationsForm accountOperations=new AccountOperationsForm();
            this.Hide();
            accountOperations.ShowDialog();
            // hshsof law daf3 aktr aw a2l mn installment amout h2olo message box en la2 adf3le only el installment 
            // w b3d ma ydf3 byzwd 3ala loan balance w kol da 3mleno b el functions ele f loan 
            // arg3 ll (AccountOperations)

        }
    }
}
