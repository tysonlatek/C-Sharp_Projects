using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        public enum daysOfTheWeek
        {
            Sunday = 0, Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5, Saturday = 6
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it today?");
            string input = Console.ReadLine();

            daysOfTheWeek day;
            try
            {
                if (Enum.TryParse(input, out day))
                {
                    Console.WriteLine("\nSo today is {0}? Alright, thanks!", day);
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}