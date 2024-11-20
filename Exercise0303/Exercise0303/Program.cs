using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ASSIGNMENT INSTRUCTIONS
 * Skapa ett program som omvandlar ett inmatat decimaltal till närmsta heltal.
 * Exempel:
 *      Ange ett decimaltal: 11,534
 *      Decimaltalet 11,534 avrundas till heltalet 12
 */

namespace Exercise0303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string userInput;
            double decimalNumber;
            int roundedNumber;

            // Ask user for decimal
            Console.Write("Ange ett decimaltal: ");
            userInput = Console.ReadLine();
            decimalNumber = Convert.ToDouble(userInput);

            // Round decimal to nearest integer
            roundedNumber = (int) Math.Round(decimalNumber);

            // Display results
            Console.Write("Decimaltalet " + decimalNumber +
                " avrundas till heltalet " + roundedNumber);
        }
    }
}
