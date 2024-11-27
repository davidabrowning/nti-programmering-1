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
 *          Lägg till ett föremål
 *              Läs in nytt föremål från användaren
 *              Om nytt föremål är tomt, break ur switch-sats
 *              Om ryggsäcken redan innehåller åtminstone ett föremål,
 *                  lägg till ett kommatecken
 *              Lägg till föremål i ryggsäck
 *      Fall 2:
 *          Skriv ut innehållet
 *      Fall 3:
 *          Rensa innehållet
 *      Fall 4:
 *          Avsluta programmet
 *      Fall default:
 *          Skriv ut felmeddelande
 *  SLUT SWITCH
 * SLUT SÅ LÄNGE
 * 
 * Author: David Browning
 * Email: david.a.browning@gmail.com
*/
namespace Ryggsäcken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Deklarera variabler
            bool körProgrammet = true;
            string innehåll = "";

            // Skriva ut en hälsning
            Console.WriteLine("Välkommen till ryggsäcken!");

            // Så länge användaren inte avslutar programmet
            while (körProgrammet)
            {
                // Visa menyval
                Console.WriteLine();
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
                    // 1. Lägg till ett föremål
                    // Läs in nytt föremål från användaren
                    // Om nytt föremål är tomt, break ur switch-sats
                    // Om ryggsäcken redan innehåller åtminstone ett föremål,
                    //      lägg till ett kommatecken
                    // Lägg till föremål i ryggsäck
                    case "1":
                        Console.Write("Föremål att lägga till: ");
                        string föremål = Console.ReadLine();
                        föremål = föremål.Trim();
                        if (föremål.Length == 0)
                        {
                            Console.WriteLine(
                                "Tomt föremål.Visar upp menyn igen."
                            );
                            break;
                        }
                        if (innehåll.Length > 0)
                        {
                            innehåll += ", ";
                        }
                        innehåll += föremål;
                        Console.WriteLine(föremål + " tillagt.");
                        break;

                    // 2. Skriv ut innehållet
                    case "2":
                        if (innehåll.Length == 0)
                        {
                            Console.WriteLine("Innehåll: (tomt)");
                        }
                        else
                        {
                            Console.WriteLine("Innehåll: " + innehåll);
                        }
                        break;

                    // 3. Rensa innehållet
                    case "3":
                        innehåll = "";
                        Console.WriteLine("Innehåll rensat!");
                        break;

                    // 4. Avsluta programmet
                    case "4":
                        Console.WriteLine(
                            "Avslutar programmet. Tack och hej då!"
                        );
                        körProgrammet = false;
                        break;

                    // Övrigt
                    default:
                        Console.WriteLine(
                            "Oväntat indata. Visar upp menyn igen."
                        );
                        break;
                }
            }
        }
    }
}
