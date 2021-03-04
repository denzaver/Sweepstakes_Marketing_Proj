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
        public void CreateSweepstake() //this is a form of dependency injection, where the the object is being created but the other classes/objdct where the information 
                                           // is being passed doesnt need to know what being pass, just needs to know that something is ebing passed in.
        {                                       // this way each type of sweepstakes can be created differently.
            Sweepstakes prize = new Sweepstakes("trip");
            _manager.InsertSweepstake(prize);
            
        }

    }
}
