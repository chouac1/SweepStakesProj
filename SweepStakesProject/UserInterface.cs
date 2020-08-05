using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    public static class UserInterface
    {
        //member variables

        //constructor

        ////member methods

        public static string GatherUserInputString(string prompt)
        {
            Console.WriteLine(prompt);
            string result = Console.ReadLine();
            return result;
        }

        public static string DisplayContestantInfo(string namePassThru)
        {
            Console.WriteLine($"Your winner is " + namePassThru + " !");
            return namePassThru;
        }

    }
}
