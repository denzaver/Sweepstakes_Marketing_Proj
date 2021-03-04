using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    class SweepstakesQueueManager : ISweepstakesManger // this is a from if dependency injection, where its dependent class is being injcted into it
    {                                                       // from the ISweepstakesProgram interface providing it with the methods/functions it needs and shares with similar classes
                                                               //it will hold the references being passes in from the MakretingFirm class
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();
        public void InsertSweepstake(Sweepstakes sweepstakes) 
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepStake()
        {
            return queue.Dequeue();
        }
    }
}
