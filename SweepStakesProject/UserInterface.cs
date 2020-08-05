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

        public static string ChooseSweepStakesMethod()
        {
            Console.WriteLine("Please choose a sweepstake method.");
            Console.WriteLine("(1) Stack Manager Sweepstake");
            Console.WriteLine("(2) Queue Manager Sweepstake");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Console.WriteLine("Awesome choice! You choose a Stack Manager Sweepstake.");
                SweepstakesStackManager sweepstakesStackManager = new SweepstakesStackManager();
            }
            else if (result == "2")
            {
                Console.WriteLine("Awesome choice! You choose a Queue Manager Sweepstake.");
                SweepstakesQueueManager sweepstakesQueueManager = new SweepstakesQueueManager();
            }
            return result;
        }

    }
}
