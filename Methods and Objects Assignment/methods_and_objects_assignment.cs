using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { FirstName = "John", LastName = "Smith" };
            person.SayName();
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();
            Console.ReadLine();
        }
    }
}
