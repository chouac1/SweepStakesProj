using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Contestant
    {
        public string FirstName; 
        public string LastName;
        public string EmailAddress;
        public double RegistrationNumber;
        public Contestant()
        {
            FirstName = "";
            LastName = "";
            EmailAddress = "";
            RegistrationNumber = 0;
        }
    }
}
