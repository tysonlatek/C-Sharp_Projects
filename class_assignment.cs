using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator divide = new Calculator();
            Calculator.Divide();
            
            int c;
            float d;
            Calculator output = new Calculator();
            Calculator.Output(out c);
            Calculator.Output(out d);
            Console.ReadLine();
        }
    }
}
