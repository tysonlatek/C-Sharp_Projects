using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator multiply = new Calculator();
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int optNum;
            if (int.TryParse(Console.ReadLine(), out optNum))
            {
                Calculator.Multiply(num, optNum);
            }
            else
            {
                Calculator.Multiply(num);
            }
            Console.ReadLine();
        }
    }
}