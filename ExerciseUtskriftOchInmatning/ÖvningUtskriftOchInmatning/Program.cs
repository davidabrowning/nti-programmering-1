using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*
 * Instruktioner:
 *      1. Läsa in användarens för och efternamn och spara detta i variabler
 *      2. Hälsa användaren välkommen 
 *      3. Fråga användaren om deras ålder i år och spara detta i en variabel med lämplig datatyp
 *      4. Räkna ut antalet dagar personen har levt utifrån den angivna ålder (ålder multiplicerat med 365) och presentera detta.
 * 
 * Författare:
 *      David Browning
 *      david.a.browning@gmail.com
 */

namespace ÖvningUtskriftOchInmatning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialisera variabler
            string förnamn = "";            // Användarens förnamn
            string efternamn = "";          // Användarens efternamn
            string användarInmatning = "";  // Innehåller senaste inmatning när användaren matar in en string som konverteras till siffra
            int ålder = 0;                  // Användarens ålder räknad i år
            int dagar = 0;                  // Användarens ålder räknad i dagar

            // 1. Läsa in användarens för och efternamn och spara detta i variabler
            Console.Write("Var god och skriv ditt förnamn: ");
            förnamn = Console.ReadLine();
            Console.Write("Var god och skriv ditt efternamn: ");
            efternamn = Console.ReadLine();

            // 2. Hälsa användaren välkommen
            Console.WriteLine("Hej och välkommen, " + förnamn + " " + efternamn + "!");

            // 3. Fråga användaren om deras ålder i år och spara detta i en variabel med lämplig datatyp
            Console.Write("Hur många år gammal är du, " + förnamn + "? ");
            användarInmatning = Console.ReadLine();
            ålder = Convert.ToInt32(användarInmatning);

            // 4. Räkna ut antalet dagar personen har levt utifrån den angivna åldern (ålder multiplicerat med 365) och presentera detta.
            dagar = ålder * 365;
            Console.WriteLine("Tack! Utifrån din ålder har du levt åtminstone " + dagar + " dagar.");
        }
    }
}
