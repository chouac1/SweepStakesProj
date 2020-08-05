using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Member Variables

        public Queue myQueue;
        public Contestant contestants;
        
        //Constructor
        public SweepstakesQueueManager()
        {
            myQueue = new Queue();
            contestants = new Contestant();
        }
        
        //Member Methods
        public void AddQueue()
        {
            myQueue.Enqueue(contestants);
        }

        public void DeleteQueue()
        {
            myQueue.Dequeue();
        }
        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
