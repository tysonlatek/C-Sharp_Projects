using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25 };

            Console.WriteLine("Please enter a number:");
            int numInput = Convert.ToInt32(Console.ReadLine());

            foreach (int num in numbers)
            {
                int result = num / numInput;
                Console.WriteLine(num + " divided by " + numInput + " = " + result);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }
        Console.WriteLine("The try/catch block has been executed.");
        Console.ReadLine();
    }
}