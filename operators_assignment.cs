using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee id1 = new Employee(123);
            Employee id2 = new Employee(321);
            if (id1 == id2)
            {
                Console.WriteLine("The IDs are identical.");
            }
            else
            {
                Console.WriteLine("The IDs are different.");
            }
            Console.ReadLine();
        }
    }
}