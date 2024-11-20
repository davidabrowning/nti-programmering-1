using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0301
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string userInput;
            int integer1;
            int integer2;
            int sum;

            // Ask user for two integers
            Console.WriteLine("Please enter an integer:");
            userInput = Console.ReadLine();
            integer1 = Convert.ToInt32(userInput);
            Console.WriteLine("Please enter another integer:");
            userInput = Console.ReadLine();
            integer2 = Convert.ToInt32(userInput);

            // Calculate sum
            sum = integer1 + integer2;

            // Display result
            Console.WriteLine(integer1 + " + " + integer2 + " = " + sum);
        }
    }
}
