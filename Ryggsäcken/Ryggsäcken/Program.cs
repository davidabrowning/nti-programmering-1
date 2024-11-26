using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

/*
 * PROGRAMBESKRIVNING
 * SÅ LÄNGE användaren inte avslutar programmet
 *  Visa menyval
 *  Användaren gör ett menyval
 *  SWITCH menyval
 *      Fall 1:
 *          Be användaren skriva ett värde
 *          Spara strängvärde
 *      Fall 2:
 *          Skriv ut innehållet
 *      Fall 3:
 *          Nollställ
 *      Fall 4:
 *          Avsluta programmaet
 *      Fall default:
 *          Skriv ut felmeddelande
 *  SLUT SWITCH
 * SLUT SÅ LÄNGE
*/
namespace Ryggsäcken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler
            bool avslutaProgrammet = false;

            // Skriva ut en hälsning
            Console.WriteLine("Välkommen till ryggsäcken!");

            // Så länge användaren inte avslutar programmet
            while (avslutaProgrammet == false)
            {
                // Visa menyval
                Console.WriteLine("[1] Lägg till ett föremål");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Rensa innehållet");
                Console.WriteLine("[4] Avsluta");
                Console.Write("Välj: ");

                // Användaren gör ett menyval
                string menyval = Console.ReadLine();

                // Switch menyval
                switch(menyval)
                {
                    case "1":
                        Console.WriteLine("Lägger till...");
                        break;
                    case "2":
                        Console.WriteLine("Skriver ut...");
                        break;
                    case "3":
                        Console.WriteLine("Renser...");
                        break;
                    case "4":
                        Console.WriteLine("Avslutar programmet. Tack och hej då!");
                        avslutaProgrammet = true;
                        break;
                    default:
                        Console.WriteLine("Oväntat indata. Visar upp menyn igen.");
                        break;
                }
            }
        }
    }
}
