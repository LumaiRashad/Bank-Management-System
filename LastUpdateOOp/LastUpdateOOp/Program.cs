using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastUpdateOOp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());

            
            //Balance obj = new Balance();
            //Console.WriteLine(Balance.BankBalance);
            //Console.WriteLine(Balance.LoansBalance);


            //DateTime date = DateTime.Now;
            //string m =Convert.ToString(date.Month);
            //string day = Convert.ToString(date.Day);
            //string y = Convert.ToString(date.Year);
            //FileStream F = new FileStream("Hopa.txt", FileMode.OpenOrCreate);
            //StreamWriter sw = new StreamWriter(F);
            //bool flag = true;
            //sw.WriteLine(flag+"&"+day+"/"+m+"/"+y);
            //sw.Close();


        }
    }
}
