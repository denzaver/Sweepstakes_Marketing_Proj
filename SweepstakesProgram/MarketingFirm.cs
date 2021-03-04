using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    class MarketingFirm
    {
        //member variable
        private ISweepstakesManger _manager;

        //property
        
        
        //constructor
        public MarketingFirm(ISweepstakesManger manager)
        {
            _manager = manager;
        }

        // member methods
        public void CreateSweepstake()
        {
            Sweepstakes prize = new Sweepstakes("trip");
            _manager.InsertSweepstake(prize);
            
        }

        

    }
}
