using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator multiplication = new Calculator();
            Calculator.MathOp(5, 10);

            Calculator division = new Calculator();
            Calculator.MathOp(9.80f, 15);

            Calculator addition = new Calculator();
            Calculator.MathOp("15", 20);

            Console.ReadLine();
        }
    }
}