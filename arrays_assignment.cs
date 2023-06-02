using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] helloArray = { "Hello", "Hola", "Bonjour" };

            //Console.WriteLine("Choose a number between 0 and 2:");
            //int index = Convert.ToInt32(Console.ReadLine());

            //if (index == 0)
            //{
            //    Console.WriteLine(helloArray[0]);
            //}
            //else if (index == 1)
            //{
            //    Console.WriteLine(helloArray[1]);
            //}
            //else if (index == 2)
            //{
            //    Console.WriteLine(helloArray[2]);
            //}
            //else
            //{
            //    Console.WriteLine("Please choose a number between 0 and 2.");
            //}

            //int[] numArray = { 5, 7, 8, 12, 15 };

            //Console.WriteLine("Choose a number between 0 and 4:");
            //int index = Convert.ToInt32(Console.ReadLine());

            //if (index == 0)
            //{
            //    Console.WriteLine(numArray[0]);
            //}
            //else if (index == 1)
            //{
            //    Console.WriteLine(numArray[1]);
            //}
            //else if (index == 2)
            //{
            //    Console.WriteLine(numArray[2]);
            //}
            //else if (index == 3)
            //{
            //    Console.WriteLine(numArray[3]);
            //}
            //else if (index == 4)
            //{
            //    Console.WriteLine(numArray[4]);
            //}
            //else
            //{
            //    Console.WriteLine("Please choose a number between 0 and 4.");
            //}

            List<string> names = new List<string> { "John", "Jane", "Joe" };

            Console.WriteLine("Choose a number between 0 and 2:");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index == 0)
            {
                Console.WriteLine(names[0]);
            }
            else if (index == 1)
            {
                Console.WriteLine(names[1]);
            }
            else if (index == 2)
            {
                Console.WriteLine(names[2]);
            }
            else
            {
                Console.WriteLine("Please choose a number between 0 and 2.");
            }
            Console.Read();
        }
    }
}
