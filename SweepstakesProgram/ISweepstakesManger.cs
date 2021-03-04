using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    interface ISweepstakesManger
    {

        void InsertSweepstakes(Sweepstakes sweepstakes);

        void SweepStakes();
    }
}
