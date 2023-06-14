using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Please enter a number:");
            int input = int.Parse(Console.ReadLine());
            DateTime future = now.AddHours(input);
            Console.WriteLine("In {0} hours it will be {1}", input, future);
            Console.ReadLine();
        }
    }
}
