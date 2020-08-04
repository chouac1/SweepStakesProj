using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public class UserInterface
    {
        //member variables
        public string firstName;
        public string lastName;
        public string userEmail;
        public int userRegistrationNumber;

        //constructor
        public UserInterface()
        {
            firstName = GetFirstName();
            lastName = GetLastName();
            userEmail = GetEmail();
            userRegistrationNumber = GetRegistrationNumber()
        }

        //member methods
        public string GetFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            string result = Console.ReadLine();
            return result;
        }

        public string GetLastName()
        {
            Console.WriteLine("Please enter your last name.");
            string result = Console.ReadLine();
            return result;
        }

        public string GetEmail()
        {
            Console.WriteLine("Please enter your email.");
            string result = Console.ReadLine();
            return result;
        }

        public int GetRegistrationNumber()
        {
            Console.WriteLine("Please enter your registration number.");
            int result = int.Parse(Console.ReadLine());
            return result;
        }

    }
}
