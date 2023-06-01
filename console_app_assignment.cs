using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number:");
            int guess = Convert.ToInt32(Console.ReadLine());
            bool isEight = guess == 8;

            do
            {
                switch (guess)
                {
                    case 7:
                        Console.WriteLine("So close!");
                        Console.WriteLine("Guess a number:");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("You guessed it!");
                        isEight = true;
                        break;
                    case 9:
                        Console.WriteLine("So close!");
                        Console.WriteLine("Guess a number:");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Try again.");
                        Console.WriteLine("Guess a number:");
                        guess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

            while (!isEight);

            Console.Read();
        }
    }
}
