using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    class Simulation
    {
        public string GetChoice()
        {
            Console.WriteLine("Which data would you like to use?: Stack or Queue");
            string userInput = Console.ReadLine();
            return userInput;
        }
        
    }
}
