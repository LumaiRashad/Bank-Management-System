using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
   public class Accountant : Employee
    {
        public Operation operation;
        public static LoanFileOperation L_FO=new LoanFileOperation();

        public void LoadLoans()
        {
            L_FO.Load();

        }

        public void SetOperation(Operation obj)
        {
            operation = obj;

        }


        public Accountant()
        {
            Position = ID= Grade = Mail = BirthDate = Address = SSN = Password = Gender = "";
        }

        public Accountant(string FName, string LName, string id, string pass, string pos, string EM, string BD, string AD, string GD, string ssn, string gender)//parameterized constructor
        {
            FirstName = FName;
            LastName = LName;
            SSN = ssn;
            Mail = EM;
            BirthDate = BD;
            Address = AD;
            Password = pass;
            ID = id;
            Position = pos;
            Grade = GD;
            Gender = gender;


        }

        // creat object form balance w h2dr access 3ala 7agat ele gwah  **<< Done 

        // gwah object mn no3 operation w 3ala 7asb el request ele hygelo 
        // hncall mno withdraw w deposite w update w transfer w take loan

        // Add client ->>> hya5od mn form w y3ml client kaml y add mn file operation(client)al
        // Remove Client ->>hy5od el acc num mn form w el file operation hwa ele h ydelete (client )l 

        // Login account ->> hy5od el accnum w y search b file oper w yrg3lo el client (client )
        //-------------------------
        // hn7tag n3ml sitter f accountent ta5od obj mn operation w hwa y set f from 3ala 7asb el form ele h y set 3leh 
        //update mn file operations
        // take loan ->> y tcheck mn loanopearations aw mn client nfso 
        // request loan ->> bst5dm object mn loan 


    }
}
