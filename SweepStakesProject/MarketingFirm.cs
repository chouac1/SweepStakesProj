using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakesProject
{
    class MarketingFirm : ISweepstakesManager
    {
        public ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager) 
        {
            this.manager = manager; 
            //This dependency injection (DI) uses constructor injection.
        }

        public Sweepstakes GetSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            return sweepstakes;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            //myQueue.Enqueue(sweepstakes);
        }
    }
}
