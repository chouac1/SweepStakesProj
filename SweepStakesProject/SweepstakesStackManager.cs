using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepstakesStackManager : ISweepstakesManager
    {       
        //member variables
        public Stack myStack;
        public Contestant contestants;
        //constructor
        public SweepstakesStackManager()
        {
            myStack = new Stack();
            contestants = new Contestant();
        }

        //methods
        public void AddStack()
        {
            myStack.Push(contestants);
        }

        public void RemoveStack()
        {
            myStack.Pop();
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);
        }
    }
}
