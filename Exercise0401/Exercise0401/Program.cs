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
 * SLUT OM
 */

namespace Exercise0401
{
    internal class Program
    {
        // Initiera konstanter
        const string frågan = "Är det fint väder?";
        const string förslag = "Vi går på picknick!";
        const string jaSvar = "j";

        static void Main(string[] args)
        {
            // Initiera variabler
            string användarSvar = "";

            // Ställ frågan
            Console.WriteLine(frågan);

            // OM svaret är j SÅ
            //  Skriva ut förslaget
            // SLUT OM
            användarSvar = Console.ReadLine();
            if (användarSvar == jaSvar)
            {
                Console.WriteLine(förslag);
            }

        }
    }
}
