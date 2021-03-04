using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    interface ISweepstakesManger
    {

        void InsertSweepstake(Sweepstakes sweepstakes);

         Sweepstakes GetSweepStake();
    }
}
