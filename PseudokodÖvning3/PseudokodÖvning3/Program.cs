using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programbeskrivning:
 *      Fråga användaren om de vill höra ett skämt
 *      Spara användarens [svar]
 *      OM användarens [svar] är Ja
 *          Berätta ett skämt
 *      ANNARS
 *          Avsluta programmet
 */

namespace PseudokodÖvning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vill du höra ett skämt?");
            string svar = Console.ReadLine();
            if (svar == "Ja")
            {
                Console.WriteLine("Jag berättar ett skämt...");
            }
            else
            {
                Console.WriteLine("Programmet avslutar.");
            }
        }
    }
}
