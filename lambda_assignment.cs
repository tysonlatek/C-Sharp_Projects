using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee() { firstName = "John", lastName = "A.", id = 1};
            employees.Add(employee1);

            Employee employee2 = new Employee() { firstName = "Jake", lastName = "B.", id = 2 };
            employees.Add(employee2);

            Employee employee3 = new Employee() { firstName = "Joe", lastName = "C.", id = 3 };
            employees.Add(employee3);

            Employee employee4 = new Employee() { firstName = "Josh", lastName = "D.", id = 4 };
            employees.Add(employee4);

            Employee employee5 = new Employee() { firstName = "Jesse", lastName = "E.", id = 5 };
            employees.Add(employee5);

            Employee employee6 = new Employee() { firstName = "James", lastName = "F.", id = 6 };
            employees.Add(employee6);

            Employee employee7 = new Employee() { firstName = "Joan", lastName = "G.", id = 7 };
            employees.Add(employee7);

            Employee employee8 = new Employee() { firstName = "Jane", lastName = "H.", id = 8 };
            employees.Add(employee8);

            Employee employee9 = new Employee() { firstName = "Sam", lastName = "I.", id = 9 };
            employees.Add(employee9);

            Employee employee10 = new Employee() { firstName = "Joe", lastName = "J.", id = 10 };
            employees.Add(employee10);

            //foreach (Employee employee in employees)
            //{
            //    if (employee.firstName == "Joe")
            //    {
            //        Console.WriteLine("ID: {0} \nName: {1} {2}\n", employee.id, employee.firstName, employee.lastName);
            //    }

            //}

            List<Employee> employeesNamedJoe = employees.Where(x => x.firstName == "Joe").ToList();

            Console.WriteLine("Employees named Joe:\n");
            foreach (Employee employee in employeesNamedJoe)
            {
                Console.WriteLine("ID: {0} \nName: {1} {2}\n", employee.id, employee.firstName, employee.lastName);
            }

            List<Employee> idsGreaterThanFive = employees.Where(x => x.id > 5).ToList();

            Console.WriteLine("\nEmployees with IDs greater than 5:\n");
            foreach (Employee employee in idsGreaterThanFive)
            {
                Console.WriteLine("ID: {0} \nName: {1} {2}\n", employee.id, employee.firstName, employee.lastName);
            }
            Console.ReadLine();
        }
    }
}