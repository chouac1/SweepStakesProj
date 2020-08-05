using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class Sweepstakes
    {
        //member variables

        public string sweepstakes;
        Dictionary<int, Contestant> contestants;
        Random rng;

        //constructor
        public Sweepstakes()
        {
            contestants = new Dictionary<int, Contestant>(); //hold contestants
            rng = new Random();
        }

        //member methods

        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = contestants.Count;
            contestants.Add(contestant.RegistrationNumber, contestant);
        }

        public Contestant PickWinner() 
        {
            int randomNumber = rng.Next(0, contestants.Count);
            Contestant result = contestants[randomNumber];
            return result;
        }

        public void PrintContestantInfo(Contestant contestant) 
        {
            UserInterface.DisplayContestantInfo(contestant.FirstName + contestant.LastName);            
        }
    }
}
