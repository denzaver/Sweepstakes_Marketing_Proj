using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    class SweepstakesStackManager : ISweepstakesManger // this is a from if dependency injection, where its dependent class is being injcted into it
    {                                                       // from the ISweepstakesProgram interface providing it with the methods/functions it needs and shares with similar classes
        //member variables                                      //it will hold the references being passes in from the MakretingFirm class
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
