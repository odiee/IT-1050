using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name?");
            string firstName;
            firstName = Console.ReadLine();

            
            Console.Write("What is your middle initial?");
            string middleIntial;
            middleIntial = Console.ReadLine();

            Console.Write("What is your last name?");
            string lastName;
            lastName = Console.ReadLine();

            Console.Write("What is your full name?");
            string fullName;
            fullName = Console.ReadLine();

            Console.Write("What is your height feet?");
            int heightFeet;
            heightFeet = int.Parse(Console.ReadLine());

            Console.Write("What is your height inches?");
            double heightInches;
            heightInches = double.Parse(Console.ReadLine());

            Console.Write("What is your height centimeters?");
            double totalHeightCM;          
            totalHeightCM = double.Parse(Console.ReadLine());

            Console.Write("What is your age?");
            int age;
            age = 22;
            age = int.Parse(Console.ReadLine());

            Console.Write("Are you a citizen?");
            bool isCitizen; 
            isCitizen = bool.Parse(Console.ReadLine());


            bool canVote;
            canVote = age >= 18;
            canVote = true;
            canVote = bool.Parse(Console.ReadLine());

        }
    }
}
