using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programbeskrivning:
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
 * Programförfattare:
 *  Namn: David Browning
 *  Mejl: david.a.browning@gmail.com
 */
namespace ÖvningVektorerOchSökning
{

    // ================================ KLASS =================================
    // Program. Innehåller Main.
    // ========================================================================
    internal class Program
    {

        // Konstanter
        const int RYGGSÄCK_STORLEK = 5;
        const string PROGRAMHÄLSNING = 
            "Välkommen till Vektorer och Sökning-programmet!";
        const string MENYVAL_1_DEL_1 = "[1] Lägg till ett föremål (";
        const string MENYVAL_1_DEL_2 = " av 5)";
        const string MENYVAL_2 = "[2] Skriv ut alla föremål";
        const string MENYVAL_3 = "[3] Sök i ryggsäcken";
        const string MENYVAL_4 = "[4] Avsluta programmet";
        const string MENYINSTRUKTION_1 = "Föremål att lägga till: ";
        const string MENYINSTRUKTION_2 = "Ryggsäckens innehål:";
        const string MENYINSTRUKTION_3 = "Sökord: ";
        const string MENYINSTRUKTION_4 = 
            "Avslutar programmet. Tack och hej då!";
        const string BEKRÄFTELSE_FÖREMÅL_TILLAGD = 
            "Ny föremål tillagd i ryggsäck: ";
        const string BEKRÄFTELSE_SÖKNING_LYCKADES = 
            "Sökningen lyckades! Sökord finns i ryggsäck.";
        const string FELMEDDELANDE_MENYVAL_OGILTIG_FORMAT = 
            "Ogiltigt menyvalformat. Visar menyn igen.";
        const string FELMEDDELANDE_MENYVAL_OGILTIGT_VÄRDE = 
            "Ogiltigt menyvalvärde. Visar menyn igen.";
        const string FELMEDDELANDE_RYGGSÄCK_FULL = 
            "Ryggsäck är full. Kan inte lägga till föremål.";
        const string FELMEDDELANDE_FÖREMÅL_OGILTIG_FORMAT = 
            "Ogiltig föremålformat. Visar menyn igen.";
        const string FELMEDDELANDE_SÖKNING_MISSLYCKADES = 
            "Sökningen misslyckades. Sökord finns inte i ryggsäck.";

        // =============================== METOD ==============================
        // Main. Start på programmet.
        // ====================================================================
        static void Main(string[] args)
        {

            // Deklarera variabler
            string[] minVektor = new string[RYGGSÄCK_STORLEK]; 
                // Håller användarens föremål
            int minVektorStorlek = 0; // Förvarar ryggsäckens nuvarande storlek
            bool körProgrammet = true;
            // Förvarar användarens önskan att köra programmet

            // Hälsa användaren
            Console.WriteLine(PROGRAMHÄLSNING);

            // Så länge användaren inte vill avsluta programmet
            while (körProgrammet)
            {
                // Presentera meny
                Console.WriteLine();
                Console.WriteLine(MENYVAL_1_DEL_1 + minVektorStorlek + 
                    MENYVAL_1_DEL_2);
                Console.WriteLine(MENYVAL_2);
                Console.WriteLine(MENYVAL_3);
                Console.WriteLine(MENYVAL_4);

                // Spara användarens menyval i variabeln [menyval]
                if (Int32.TryParse(Console.ReadLine(),
                    out int menyval) == false)
                {
                    Console.WriteLine(FELMEDDELANDE_MENYVAL_OGILTIG_FORMAT);
                    continue;
                }

                // Välj fall ur menyval
                switch (menyval)
                {

                    // ========================= FALL =========================
                    // Fall 1: Lägg till ett föremål.
                    // Om ryggsäck är full, skriv ut ett felmeddelande.
                    // Annars, användaren matar in en sträng. Om strängen inte
                    // är tom förvaras den som ny föremål i ryggsäcken.
                    // ========================================================
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

                    // ========================= FALL =========================
                    // Fall 2: Skriv ut alla föremål.
                    // Int-variabeln föremålNummer används för att visa en
                    // lista 1-5 av alla platser som finns i ryggsäcken.
                    // ========================================================
                    case 2:
                        int föremålNummer = 1;
                        Console.WriteLine(MENYINSTRUKTION_2);
                        foreach(string föremål in minVektor)
                        {
                            Console.WriteLine(föremålNummer + ". " + föremål);
                            föremålNummer++;
                        }
                        break;

                    // ========================= FALL =========================
                    // Fall 3: Sök i ryggsäcken.
                    // Användaren matar in en sträng som förvaras i variabeln
                    // [sökord].
                    // För varje element i ryggsäcken, skriv ut ett meddelande
                    // om elementet är lika med sökordet.
                    // Om sökordet inte finns i ryggsäcken, skriv ut ett
                    // felmeddelande.
                    // ========================================================
                    case 3:
                        bool minBool = false;
                        Console.Write(MENYINSTRUKTION_3);
                        string sökord = Console.ReadLine().Trim();
                        foreach (string föremål in minVektor)
                        {
                            if (föremål != null
                                && föremål.ToLower() == sökord.ToLower())
                            {
                                minBool = true;
                                Console.WriteLine(BEKRÄFTELSE_SÖKNING_LYCKADES);
                            }
                        }
                        if (minBool == false)
                        {
                            Console.WriteLine(FELMEDDELANDE_SÖKNING_MISSLYCKADES);
                        }
                        break;

                    // ========================= FALL =========================
                    // Fall 4: Avsluta programmet.
                    // Hälsa användaren hej då och avsluta programmet genom att
                    // sätta while-loopen kontrollvariabel [körProgrammet] till
                    // falsk.
                    // ========================================================
                    case 4:
                        Console.WriteLine(MENYINSTRUKTION_4);
                        körProgrammet = false;
                        break;

                    // ========================= FALL =========================
                    // Övriga fall.
                    // Skriv ut ett felmeddelande.
                    // ========================================================
                    default:
                        Console.WriteLine(FELMEDDELANDE_MENYVAL_OGILTIGT_VÄRDE);
                        break;
                }
            }

        }
    }
}
