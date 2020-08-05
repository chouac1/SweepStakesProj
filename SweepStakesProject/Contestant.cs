using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Contestant
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }
        public Contestant()
        {
            FirstName = UserInterface.GatherUserInputString("Please enter your first name.");
            LastName = UserInterface.GatherUserInputString("Please enter your last name.");
            EmailAddress = UserInterface.GatherUserInputString("Please enter your email address.");           
        }
    }
}
