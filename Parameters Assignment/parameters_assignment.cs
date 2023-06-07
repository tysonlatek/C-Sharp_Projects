using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> names = new Employee<string>();
            names.things = new List<string>() { "John", "Josh", "Joe" };
            Employee<int> ids = new Employee<int>();
            ids.things = new List<int>() { 1, 5, 8 };
            foreach (string name in names.things)
            {
                Console.WriteLine(name);
            }
            foreach (int id in ids.things)
            {
                Console.WriteLine(id);
            }
            Console.ReadLine();
        }
    }
}