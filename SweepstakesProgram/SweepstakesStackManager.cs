using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    class SweepstakesStackManager : ISweepstakesManger
    {
        //member variables
        private Stack<Sweepstakes> myStack = new Stack<Sweepstakes>();
        
        //constructor


        //member methods
        public void InsertSweepstake(Sweepstakes sweepstakes)
        {
            myStack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepStake()
        {
            myStack.Pop();
            return myStack.Pop();
        }

    }
}
