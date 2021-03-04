using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    class Sweepstakes
    {

        // member variables
        private Dictionary<int, Contestant> contestants;
        private string name;

        // property
        public string Name
        {
            get
            {
                return name;
            }
        }

        // constructor
        public Sweepstakes(string name)
        {
            contestants = new Dictionary<int, Contestant>();
        }

        // member methods
        public void RegisterContestant(Contestant contestant)
        {

        }

        public Contestant PickWinner()
        {
            return null;
        }

        public void PrintContestantinfo(Contestant contestant)
        {

        }

        
    }
}
