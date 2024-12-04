using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programbeskrivning
 *  Skapa [minVektor] strängvektor med 5 element
 *  SÅ LÄNGE användaren inte avslutar programmet
 *      Presentera meny
 *      Spara användarens [menyval]
 *      VÄLJ fall ur [menyval]
 *          Fall 1:
 *              FÖR varje element i [minVektor]
 *                  Tilldela ett strängvärde till elementet
 *          Fall 2:
 *              FÖR varje element i [minVektor]
 *                  Skriv ut elementet
 *          Fall 3:
 *              Skapa en falsk bool [minBool]
 *              Användaren skriver ett sökord
 *              FÖR varje element  [minVektor]
 *                  OM sökord är samma som element
 *                      Skriv ut att sökningen lyckades
 *                      Sätt [minBool] till sann
 *              OM [minBool] är falsk
 *                  Skriv ut felmeddelande
 *          Fall 4:
 *              Avsluta programmet
 * 
 * Författare: David Browning
 * Mejl: david.a.browning@gmail.com
 */
namespace ÖvningVektorerOchSökning
{
    internal class Program
    {

        // Konstanter
        const int RYGGSÄCK_STORLEK = 5;
        const string MENYVAL_1 = "[1] Lägg till ett föremål (max 5)";
        const string MENYVAL_2 = "[2] Skriv ut alla föremål";
        const string MENYVAL_3 = "[3] Sök i ryggsäcken";
        const string MENYVAL_4 = "[4] Avsluta programmet";
        const string MENYINSTRUKTION_1 = "Föremål att lägga till: ";
        const string MENYINSTRUKTION_2 = "Ryggsäckens innehål:";
        const string BEKRÄFTELSE_FÖREMÅL_TILLAGD = "Ny föremål tillagd i ryggsäck: ";
        const string FELMEDDELANDE_MENYVAL_OGILTIG_FORMAT = "Ogiltigt menyvalformat. Visar menyn igen.";
        const string FELMEDDELANDE_MENYVAL_OGILTIGT_VÄRDE = "Ogiltigt menyvalvärde. Visar menyn igen.";
        const string FELMEDDELANDE_RYGGSÄCK_FULL = "Ryggsäck är full. Kan inte lägga till föremål.";
        const string FELMEDDELANDE_FÖREMÅL_OGILTIG_FORMAT = "Ogiltig föremålformat. Visar menyn igen.";
        static void Main(string[] args)
        {

            // Deklarera variabler
            string[] minVektor = new string[RYGGSÄCK_STORLEK]; // Håller användarens föremål
            int minVektorStorlek = 0; // Förvarar ryggsäckens nuvarande storlek
            bool körProgrammet = true; // Förvarar användarens önskan att köra programmet

            // Så länge användaren inte vill avsluta programmet
            while (körProgrammet)
            {
                // Presentera meny
                Console.WriteLine();
                Console.WriteLine(MENYVAL_1);
                Console.WriteLine(MENYVAL_2);
                Console.WriteLine(MENYVAL_3);
                Console.WriteLine(MENYVAL_4);

                // Spara användarens menyval
                if (Int32.TryParse(Console.ReadLine(), out int menyval) == false)
                {
                    Console.WriteLine(FELMEDDELANDE_MENYVAL_OGILTIG_FORMAT);
                    continue;
                }

                // Välj fall ur menyval
                switch (menyval)
                {

                    case 1:
                        if (minVektorStorlek == RYGGSÄCK_STORLEK)
                        {
                            Console.WriteLine(FELMEDDELANDE_RYGGSÄCK_FULL);
                        }
                        else
                        {
                            Console.Write(MENYINSTRUKTION_1);
                            string nyFöremål = Console.ReadLine().Trim();
                            if (nyFöremål.Length > 0)
                            {
                                minVektor[minVektorStorlek] = nyFöremål;
                                minVektorStorlek++;
                                Console.WriteLine(BEKRÄFTELSE_FÖREMÅL_TILLAGD + " " + nyFöremål);
                            } else
                            {
                                Console.WriteLine(FELMEDDELANDE_FÖREMÅL_OGILTIG_FORMAT);
                            }
                        }
                        break;

                    case 2:
                        int föremålNummer = 1;
                        Console.WriteLine(MENYINSTRUKTION_2);
                        foreach(string föremål in minVektor)
                        {
                            Console.WriteLine(föremålNummer + ". " + föremål);
                            föremålNummer++;
                        }
                        break;

                    case 3:
                        Console.WriteLine("Valde 3");
                        break;

                    case 4:
                        Console.WriteLine("Valde 4. Avslutar programmet.");
                        körProgrammet = false;
                        break;
                    default:
                        Console.WriteLine(FELMEDDELANDE_MENYVAL_OGILTIGT_VÄRDE);
                        break;
                }
            }

        }
    }
}
