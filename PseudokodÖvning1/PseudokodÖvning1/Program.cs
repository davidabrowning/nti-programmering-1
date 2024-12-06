using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programbeskrivning:
 *      Fråga användaren vilket [år] de är född
 *      Subtrahera användarens [år] från nuvarande år
 *      Presentera för användaren hur gammal de är
 */

namespace PseudokodÖvning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år är du född?");
            string användarInput = Console.ReadLine();
            try
            {
                int år = Convert.ToInt32(användarInput);
                int ålder = 2024 - år;
                Console.WriteLine("Du är " + ålder + " år gammal.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ogiltigt år.");
            }
            Console.WriteLine("ENTER för att avsluta programmet.");
            Console.ReadLine();
        }
    }
}
