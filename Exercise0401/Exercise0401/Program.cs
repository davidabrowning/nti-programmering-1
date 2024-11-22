using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * UPPGIFT
 * Skapa ett program som ställer frågan "Är det fint väder?" Om användaren
 * svarar "j" skriver programmet "Vi går på picknick!" Annars händer ingenting.
 * 
 * PSUEDOKOD
 * Ställa frågan "Är det fint väder?"
 * Ta emot svaret
 * SWITCH svaret
 *  j eller J
 *      Skriva "Vi går på picknick!"
 *  n eller N
 *      Skriva "Vi stannar inne och läser en bok."
 *  default
 *      Skriva "Jag förstår inte."
 * SLUT SWITCH
 */

namespace Exercise0401
{
    internal class Program
    {
        // Initiera konstanter
        const string frågan = "Är det fint väder?";
        const string jaFörslag = "Vi går på picknick!";
        const string nejFörslag = "Vi stannar inne och läser en bok.";
        const string ogiltigtSvarMeddelande = "Jag förstår inte.";
        const string jaSvar = "j";
        const string nejSvar = "n";

        static void Main(string[] args)
        {
            // Initiera variabler
            string användarSvar = "";

            // Ställa frågan
            Console.WriteLine(frågan);

            // Ta emot svaret
            användarSvar = Console.ReadLine();
            användarSvar = användarSvar.ToLower();

            /*
            * SWITCH svaret
            *   j eller J
            *       Skriva "Vi går på picknick!"
            *   n eller N
            *       Skriva "Vi stannar inne och läser en bok."
            *   default
            *       Skriva "Jag förstår inte."
            * SLUT SWITCH
            */
            switch (användarSvar)
            {
                case (jaSvar):
                    Console.WriteLine(jaFörslag);
                    break;
                case (nejSvar):
                    Console.WriteLine(nejFörslag);
                    break;
                default:
                    Console.WriteLine(ogiltigtSvarMeddelande);
                    break;
            }
        }
    }
}
