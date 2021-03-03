using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProgram
{
    static class UserInterface // needs to get info from the user
    {

        public static string GetFirstName()
        {
            Console.WriteLine("Please enter your first name:");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please enter your last name:");
            string lastName = Console.ReadLine();
            return lastName;
        }

        public static string GetEmail()
        {
            Console.WriteLine("Please enter your email address:");
            string emailAddress = Console.ReadLine();
            return emailAddress;
        }

        public static int GetRegistrationNum()
        {
            Console.WriteLine("Please enter your email address:");
            int registrationNumber = Convert.ToInt32(Console.ReadLine());
            return registrationNumber;
        }

    }
}
