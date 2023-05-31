using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            string yearsOld = Console.ReadLine();
            byte age = Convert.ToByte(yearsOld);
            bool sixteenPlus = age > 15;

            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false.\"");
            string drivingUnderInfluence = Console.ReadLine();
            bool dui = Convert.ToBoolean(drivingUnderInfluence);

            Console.WriteLine("How many speeding tickets do you have?");
            string howManyTickets = Console.ReadLine();
            byte tickets = Convert.ToByte(howManyTickets);
            bool lessThanFourTickets = tickets <= 3;

            bool qualified = sixteenPlus == true && dui == false && lessThanFourTickets == true;
            Console.WriteLine("\nQualified?\n" + qualified);

            Console.ReadLine();
        }
    }
}
