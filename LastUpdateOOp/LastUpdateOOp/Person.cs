using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastUpdateOOp
{
   public  abstract class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }

        public abstract int CalculateAge( string Year);
    }
}
