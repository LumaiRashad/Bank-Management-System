using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
 public    class Employee : Person
    {
        public string Position { get; set; }
        public string Grade { get; set; }
        public string ID { get; set; }
        public string YearOfGraduation { get; set; }

        public string Password { get; set; }
        public string CollegeOfGraduate { set; get; }

        public DateTime date = DateTime.Now;
        public override int CalculateAge( string Year)
        {
             return  ((date.Year - int.Parse(Year)) * 12 * 30) / 365;
        }
        public Employee()
        {
            Position = ID = Grade = Mail = BirthDate = Address = SSN = Password = Gender =YearOfGraduation=CollegeOfGraduate= "";
        }

        public Employee(string FName, string LName, string id, string pass, string pos, string EM, string BD, string AD, string GD, string ssn, string gender, string  GY,string CG)//parameterized constructor
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
            YearOfGraduation = GY;
            CollegeOfGraduate = CG;


        }



    }
}
