using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ASSIGNMENT
 * Skapa ett program där användaren får mata in tre heltal, varefter programmet
 * beräknar summan och medelvärdet av dessa tal.
 */

namespace Exercise0302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string userInput;
            int integer1;
            int integer2;
            int integer3;
            int sum;
            double average;

            // Ask user for three integers
            Console.Write("Please enter an integer: ");
            userInput = Console.ReadLine();
            integer1 = Convert.ToInt32(userInput);
            Console.Write("Please enter another integer: ");
            userInput = Console.ReadLine();
            integer2 = Convert.ToInt32(userInput);
            Console.Write("Please enter another integer: ");
            userInput = Console.ReadLine();
            integer3 = Convert.ToInt32(userInput);

            // Calculate sum and average
            sum = integer1 + integer2 + integer3;
            average = (double) sum / 3;

            // Display results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
        }
    }
}
