using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Part 1:
        //string[] fruits = { "Apple", "Orange", "Pear" };

        //Console.WriteLine("Please enter the name of a vegetable:");
        //string vegetable = Console.ReadLine();

        //for (int f = 0; f < fruits.Length; f++)
        //{
        //    Console.WriteLine(fruits[f] + "-" + vegetable);
        //}
        //Console.ReadLine();

        //Part 2:
        //int decrement = 25;
        //while (decrement > 0)
        //{
        //    Console.WriteLine(decrement);
        //    decrement--;
        //}
        //Console.ReadLine();

        //Part 3:
        //int zero = 0;
        //while (zero < 10)
        //{
        //    Console.WriteLine("Hey!\n");
        //    zero++;
        //}
        //Console.WriteLine("Are you even listening?!");
        //Console.ReadLine();

        //int zero = 0;
        //while (zero <= 5)
        //{
        //    Console.WriteLine("La La La!\n");
        //    zero++;
        //}
        //Console.WriteLine("I love singing!");
        //Console.ReadLine();

        //Part 4 and 5:
        //List<string> names = new List<string> { "John", "Jane", "Joe", "John" };

        //Console.WriteLine("Please enter \"John\", \"Jane\", or \"Joe\" to find thier index/indices in the list:");
        //string searchName = Console.ReadLine();

        //List<int> indices = new List<int>();

        //for (int i = 0; i < names.Count; i++)
        //{
        //    if (names[i] == searchName)
        //    {
        //        indices.Add(i);
        //        Console.WriteLine(searchName + ": " + i);
        //    }
        //    else if (!names.Contains(searchName))
        //    {
        //        Console.WriteLine("That name does not exist within the list. Please enter a valid name.");
        //        break;
        //    }
        //}
        //Console.ReadLine();

        //Part 6:
        List<string> fruits = new List<string>() { "Apple", "Orange", "Kiwi", "Apple" };

        bool duplicates = false;

        foreach (string fruit in fruits)
        {
            int count = 0;

            foreach (string compareItem in fruits)
            {
                if (fruit == compareItem)
                {
                    count++;
                }

                if (count > 1)
                {
                    duplicates = true;
                    break;
                }
            }

            if (duplicates)
            {
                break;
            }
        }

        if (duplicates)
        {
            Console.WriteLine("Duplicates found in the list.");
        }
        else
        {
            Console.WriteLine("No duplicates found in the list.");
        }
        Console.ReadLine();
    }
}