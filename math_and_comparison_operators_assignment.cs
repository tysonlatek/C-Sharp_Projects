using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparison_Opereators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program \n\nPerson 1:");
            Console.WriteLine("\nPlease enter a hourly rate:");
            string hourlyRate = Console.ReadLine();
            double rate = Convert.ToDouble(hourlyRate);
            Console.WriteLine("\nPlease enter the amount of hours worked per week:");
            string weeklyHours = Console.ReadLine();
            double hours = Convert.ToDouble(weeklyHours);
            double salary = rate * hours;

            Console.WriteLine("\n\nPerson 2:");
            Console.WriteLine("\nPlease enter a hourly rate:");
            string hourlyRate2 = Console.ReadLine();
            double rate2 = Convert.ToDouble(hourlyRate2);
            Console.WriteLine("\nPlease enter the amount of hours worked per week:");
            string weeklyHours2 = Console.ReadLine();
            double hours2 = Convert.ToDouble(weeklyHours2);
            double salary2 = rate2 * hours2;

            Console.WriteLine("\n\nAnnual Salary of Person 1:\n" + salary);

            Console.WriteLine("\nAnnual Salary of Person 2:\n" + salary2);

            bool comparison = salary > salary2;

            Console.WriteLine("\n\nDoes Person 1 make more than Person 2?\n" + comparison);

            Console.ReadLine();
        }
    }
}
