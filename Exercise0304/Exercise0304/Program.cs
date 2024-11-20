using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ASSIGNMENT DESCRIPTION
 * Låt användaren mata in namnet på två personer. Programmet ska sedan skriva
 * ut en kort berättelse om dessa två personer.
 */

namespace Exercise0304
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string name1;
            string name2;

            // Ask user for names
            Console.Write("Please enter person 1's name: ");
            name1 = Console.ReadLine();
            Console.Write("Please enter person 2's name: ");
            name2 = Console.ReadLine();

            // Print the story
            Console.Write(name1 + " and " + name2 + " met at the grocery "
                + "store. " + name2 + " asked " + name1 + " if they lived in "
                + "the area.");
        }
    }
}
