// Felsökning: Byt ut "using system" mot "using System" (stor bokstav)
using System;

/*
 * Programbeskrivning:
 *  Slumpa ett tal 1-20
 *  SÅ LÄNGE användaren inte har gissat talet
 *      Användaren försöker gissa talet
 *      Skriv ut info om gissade talet är för litet eller för stort
 *
 * Författare: David Browning
 * Mejl: david.a.browning@gmail.com
 */
namespace Uppgift_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration av variabler

            // Skapar ett random objekt
            Random slumpat = new Random();

            // Felsökning: Byt ut "slumpat.Next();" mot "slumpat.Next(1, 21);"
            // så att metoden väljer sen siffra mellan 1-20
            // Anropar Next metoden för att skapa ett slumptal mellan 1 och 20
            int speltal = slumpat.Next(1, 21);

            // Variabel för att kontrollera om spelet ska fortsätta köras
            bool spela = true;
            
            // Felsökning: Byt ut "!spela" mot "spela" eftersom programmet ska
            // köras om variabeln spela är sann
            while (spela)
            {

                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");

                // Felsökning: Använd TryParse för att läsa in indata från
                // användaren utan att krascha
                bool giltigtVärde =
                    Int32.TryParse(Console.ReadLine(), out int tal);
                if (giltigtVärde == false)
                {
                    Console.WriteLine("\tDet inmatade talet måste vara en " +
                        "siffra, försök igen.");
                    continue;
                }

                if (tal < speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal +
                        " är för litet, försök igen.");
                }

                if (tal > speltal)
                {
                    // Felsökning: Lägg till +-tecken efter "tal" (syntaxfel)
                    Console.WriteLine("\tDet inmatade talet " + tal +
                        " är för stort, försök igen.");
                }

                // Felsökning: Byt ut "=" mot "==" i if-satsens villkor
                // Felsökning: Lägg till {} så att if-satsens kodblock håller
                // ihop
                if (tal == speltal)
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    spela = false;
                }
                
            }
        }
    }
}
