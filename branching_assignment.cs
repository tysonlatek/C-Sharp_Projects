using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

            Console.WriteLine("Please enter a package weight:");
            string packageWeight = Console.ReadLine();
            int weight = Convert.ToInt32(packageWeight);

            string tooHeavy = weight > 50 ? "Package is too heavy to be shipped via Package Express. Have a good day." : "Please enter a package width:";
            Console.WriteLine(tooHeavy);

            string packageWidth = Console.ReadLine();
            int width = Convert.ToInt32(packageWidth);

            Console.WriteLine("Please enter a package height:");
            string packageHeight = Console.ReadLine();
            int height = Convert.ToInt32(packageHeight);

            Console.WriteLine("Please enter a package length:");
            string packageLength = Console.ReadLine();
            int length = Convert.ToInt32(packageLength);

            string tooBig = width > 50 || height > 50 || length > 50 ? "Package is too big to be shipped via Package Express. Have a good day." : "";
            Console.WriteLine(tooBig);

            int quote = ((width * height * length) * weight) / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00\nThank you!");

            Console.ReadLine();
        }
    }
}
