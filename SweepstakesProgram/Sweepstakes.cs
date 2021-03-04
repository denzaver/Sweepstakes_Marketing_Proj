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
        Random random;

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
            random = new Random();
        }

        // member methods
        public void RegisterContestant(Contestant contestant) //SF: should be capturing the info being passed into UserInterface and assigning it to the contestants values
        {
            contestant.firstName = UserInterface.GetFirstName();
            contestant.lastName = UserInterface.GetLastName();
            contestant.emailAddress = UserInterface.GetEmail();
            contestant.registrationNumber = UserInterface.GetRegistrationNum();
        }

        public Contestant PickWinner()
        {
            int randomChoise = random.Next(contestants.Count);

            return contestants[randomChoise];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Here is the information you provided: \n" +
                $"Name: {contestant.firstName} {contestant.lastName} \n" +
                $"Email Address: {contestant.emailAddress} \n" +
                $"Registration number: {contestant.registrationNumber}");
        }

        
    }
}
