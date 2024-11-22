using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * UPPGIFT
 * Skapa ett program som ställer frågan "Är det fint väder?" Om användaren
 * svarar "j" skriver programmet "Vi går på picknick!" Annars händer ingenting.
 * 
 * PSUEDOKOD
 * Ställ frågan "Är det fint väder?"
 * OM svaret är j SÅ
 *  Skriv "Vi går på picknick!"
 * ANNARS
 *  Skriva "Vi stannar inne och läser en bok."
 * SLUT OM
 */

namespace Exercise0401
{
    internal class Program
    {
        // Initiera konstanter
        const string frågan = "Är det fint väder?";
        const string jaFörslag = "Vi går på picknick!";
        const string nejFörslag = "Vi stannar inne och läser en bok.";
        const string jaSvar = "j";

        static void Main(string[] args)
        {
            // Initiera variabler
            string användarSvar = "";

            // Ställ frågan
            Console.WriteLine(frågan);

            // Ta emot svaret
            användarSvar = Console.ReadLine();
            användarSvar = användarSvar.ToLower();

            // OM svaret är j SÅ
            //  Skriva ut förslaget
            // SLUT OM
            if (användarSvar == jaSvar)
            {
                Console.WriteLine(jaFörslag);
            }
            else
            {
                Console.WriteLine(nejFörslag);
            }


        }
    }
}
