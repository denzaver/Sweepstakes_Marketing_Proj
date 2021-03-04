using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    class SweepstakesQueueManager : ISweepstakesManger
    {

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
