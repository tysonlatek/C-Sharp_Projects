using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator addition = new Calculator();
            Calculator.Addition(num1: 5, num2: 10);
        }
    }
}