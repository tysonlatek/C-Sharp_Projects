using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int numAdd = Convert.ToInt32(Console.ReadLine());
            Calculator.Addition(numAdd, 10);
            Console.WriteLine("\nPlease enter a number:");
            int numSub = Convert.ToInt32(Console.ReadLine());
            Calculator.Subtraction(numSub, 10);
            Console.WriteLine("\nPlease enter a number:");
            int numMul = Convert.ToInt32(Console.ReadLine());
            Calculator.Multiplication(numMul, 10);
            Console.ReadLine();
        }
    }
}