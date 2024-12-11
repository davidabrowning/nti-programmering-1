using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// ================================ NAMESPACE =================================
// ExerciseListorOchMetoder. Presenterar användaren med en meny där användaren
// har möjlighet att:
//      1. Rulla valig tärning
//      2. Rulla valfri tärning (valfritt antal sidor)
//      3. Granska resultat
//      4. Rensa resultat
//      5. Sök igenom resultat
//      6. Sortera resultat
//      7. Avsluta programmet
// Författare: David Browning (david.a.browning@gmail.com).
// ============================================================================
namespace ExerciseListorOchMetoder
{

    // ================================ KLASS =================================
    // Program. Innehåller Main-metoden.
    // ========================================================================
    class Program
    {
        // Konstanter: Värden
        const int TÄRNING_MIN = 1;
        const int VANLIG_TÄRNING_MAX = 6;

        // Konstanter: Meddelanden
        const string PROGRAM_HÄLSNING = 
            "\n\tVälkommen till tärningsgeneratorn!";
        const string PROGRAM_HEJ_DÅ = 
            "\n\tTack för att du rullade tärning!";
        const string MENY_ALTERNATIV = 
            "\n\t[1] Rulla vanlig tärning (6 sidor)" +
            "\n\t[2] Rulla valfri tärning (valfritt antal sidor)" +
            "\n\t[3] Kolla vad du rullade" +
            "\n\t[4] Rensa antalet tärningar som rullats" +
            "\n\t[5] Sök igenom de rullade tärningarna" +
            "\n\t[6] Sortera de rullade tärningarna" +
            "\n\t[7] Avsluta";
        const string MENY_INSTRUKTION = 
            "\n\tVälj: ";
        const string FRÅGA_HUR_MÅNGA_SIDOR = 
            "\n\tHur många sidor ska finnas på tärningar du vill rulla: ";
        const string FRÅGA_HUR_MÅNGA_TÄRNINGAR = 
            "\n\tHur många tärningar vill du rulla: ";
        const string FRÅGA_VILKET_VÄRDE_SÖKS = 
            "\n\tVilket tärningsvärde söker du: ";
        const string RESULTAT_RUBRIK_TÄRNINGAR = 
            "\n\tRullade tärningar: ";
        const string RESULTAT_RUBRIK_MEDELVÄRDE = 
            "\n\tMedelvärdet på alla tärningsrull: ";
        const string RESULTAT_VÄRDE_HITTAT = 
            "\n\tSökt värde hittat ";
        const string RESULTAT_VÄRDE_EJ_HITTAT = 
            "\n\tSökt värde ej hittat i tärningar.";
        const string VARNING_OGILTIGT_MENYVAL = 
            "\n\tVälj 1-7 från menyn.";
        const string VARNING_INGA_SPARADE_TÄRNINGSRULL = 
            "\n\tDet finns inga sparade tärningsrull! ";

        // ============================== METOD ===============================
        // RullaTärning. Slumpar fram ett tal TÄRNING_MIN (1) min och parameter
        // antalSidor. Returnerar det slumpade int-värdet.
        // ====================================================================
        static int RullaTärning(Random slumpObjekt, int antalSidor)
        {
            int tal;
            tal = slumpObjekt.Next(TÄRNING_MIN, antalSidor + 1);
            return tal;
        }

        // ============================== METOD ===============================
        // RullaNågraTärningar. Frågar användaren hur många tärningar ska
        // rullas. Rullar då det antalet tärningar genom att ropa RullaTärning-
        // metoden. Returnerar ingenting.
        // ====================================================================
        static void RullaNågraTärningar(Random slump, List<int> tärningar,
            int antalSidor)
        {
            Console.Write(FRÅGA_HUR_MÅNGA_TÄRNINGAR);
            bool inmatning = int.TryParse(Console.ReadLine(),
                out int antalTärningar);
            if (inmatning)
            {
                for (int i = 0; i < antalTärningar; i++)
                {
                    tärningar.Add(RullaTärning(slump, antalSidor));
                }
            }
        }

        // ============================== METOD ===============================
        // RullaNågraVanligaTärningar. Rullar vanliga tärningar genom att
        // anropa RullaNågraTärningar-metoden med antalSidor parameter angiven
        // som VANLIG_TÄRNING_MAX (6). Returnerar ingenting.
        // ====================================================================
        static void RullaNågraVanligaTärningar(Random slump,
            List<int> tärningar)
        {
            RullaNågraTärningar(slump, tärningar, VANLIG_TÄRNING_MAX);
        }

        // ============================== METOD ===============================
        // RullaNågraValfriaTärningar. Frågar användaren hur många sidor
        // tärningarna ska ha. Rullar då dessa tärningar genom att anropa
        // RullaNågraTärningar-metoden med antalSidor parameter angiven
        // som användaren har uppgett. Returnerar ingenting.
        // ====================================================================
        static void RullaNågraValfriaTärningar(Random slump,
            List<int> tärningar)
        {
            Console.Write(FRÅGA_HUR_MÅNGA_SIDOR);
            bool inmatning = int.TryParse(Console.ReadLine(),
                out int antalSidor);
            if (inmatning && antalSidor >= TÄRNING_MIN)
            {
                RullaNågraTärningar(slump, tärningar, antalSidor);
            }
        }

        // ============================== METOD ===============================
        // KollaRulladeTärningar. Om det finns rullade tärningar, skriver ut
        // värden på rullade tärningar och räknar ut medelvärdet. Returnerar
        // ingenting.
        // ====================================================================
        static void KollaRulladeTärningar(List<int> tärningar)
        {
            int sum = 0; // Innehåller summa av tärningsrullningar
            int medelvärde = 0; // Innehåller medelvärde av tärningsrullar

            if (tärningar.Count <= 0)
            {
                Console.WriteLine(VARNING_INGA_SPARADE_TÄRNINGSRULL);
            }
            else
            {
                Console.WriteLine(RESULTAT_RUBRIK_TÄRNINGAR);
                foreach (int tärning in tärningar)
                {
                    // Skriv ut tärning och lägg till summan
                    Console.WriteLine("\t" + tärning);
                    sum += tärning;
                }

                // Räkna ut och skriv ut medelvärdet
                medelvärde = sum / tärningar.Count;
                Console.WriteLine(RESULTAT_RUBRIK_MEDELVÄRDE + medelvärde);
            }
        }

        // ============================== METOD ===============================
        // RensaTärningar. Rensare alla värden ur tärningar-listan. Returnerar
        // ingenting.
        // ====================================================================
        static void RensaTärningar(List<int> tärningar)
        {
            tärningar.Clear();
        }

        // ============================== METOD ===============================
        // SökTärningar. Ber användaren ange ett värde. Söker efter värdet
        // i tärningar-listan. Berättar för användaren om värdet hittats och
        // isåfall hur många gånger. Returnerar ingenting.
        // ====================================================================
        static void SökTärningar(List<int> tärningar)
        {
            Console.Write(FRÅGA_VILKET_VÄRDE_SÖKS);
            bool giltigInmatning = 
                Int32.TryParse(Console.ReadLine(), out int sökvärde);
            if (giltigInmatning)
            {
                int antalTräffar = 0;
                foreach (int tärning in tärningar)
                {
                    if (tärning == sökvärde)
                    {
                        antalTräffar++;
                    }
                }
                switch (antalTräffar)
                {
                    case 0:
                        Console.WriteLine(RESULTAT_VÄRDE_EJ_HITTAT);
                        break;
                    case 1:
                        Console.WriteLine(RESULTAT_VÄRDE_HITTAT + antalTräffar
                            + " gång.");
                        break;
                    default:
                        Console.WriteLine(RESULTAT_VÄRDE_HITTAT + antalTräffar
                            + " gånger.");
                        break;
                }
            }
        }

        // ============================== METOD ===============================
        // SorteraraTärningar. Sorterar tärningar-listan stigande med
        // bubbelsort. Returnerar ingenting.
        // ====================================================================
        static void SorteraTärningar(List<int> tärningar)
        {
            for (int i = 0; i < tärningar.Count; i++)
            {
                for (int j = 0; j < tärningar.Count - 1; j++)
                {
                    if (tärningar[j] > tärningar[j+1])
                    {
                        int byteStöd = tärningar[j];
                        tärningar[j] = tärningar[j + 1];
                        tärningar[j + 1] = byteStöd;
                    }
                }
            }
        }

        // ============================== METOD ===============================
        // TaEmotMenyVal. Ber användaren mata in ett menyval. Ropar relevanta
        // meny-metoden beroende på användarens val. Returnerar falskt ifall
        // användaren har valt [3] Avsluta, annars returnerar sant.
        // ====================================================================
        static bool TaEmotMenyVal(Random slump, List<int> tärningar)
        {
            bool kör = true;
            int val;
            int.TryParse(Console.ReadLine(), out val);

            switch (val)
            {
                case 1:
                    RullaNågraVanligaTärningar(slump, tärningar);
                    break;
                case 2:
                    RullaNågraValfriaTärningar(slump, tärningar);
                    break;
                case 3:
                    KollaRulladeTärningar(tärningar);
                    break;
                case 4:
                    RensaTärningar(tärningar);
                    break;
                case 5:
                    SökTärningar(tärningar);
                    break;
                case 6:
                    SorteraTärningar(tärningar);
                    break;
                case 7:
                    kör = false;
                    break;
                default:
                    Console.WriteLine(VARNING_OGILTIGT_MENYVAL);
                    break;
            }

            return kör;
        }

        // ============================== METOD ===============================
        // VisaMeny. Visar en meny där användaren kan rulla tärning eller
        // granska resultaten. Returnerar ingenting.
        // ====================================================================
        static void VisaMeny()
        {
            Random slump = new Random(); // Skapar Random för slumptal
            List<int> tärningar = new List<int>(); // Håller rullade tärningar

            bool kör = true;
            while (kör)
            {
                Console.WriteLine(MENY_ALTERNATIV);
                Console.Write(MENY_INSTRUKTION);
                kör = TaEmotMenyVal(slump, tärningar);
            }
        }

        // ============================== METOD ===============================
        // Main. Start på programmet. Hälsar användaren, ropar VisaMeny() och
        // säger hej då till användaren.
        // ====================================================================
        static void Main()
        {
            Console.WriteLine(PROGRAM_HÄLSNING);
            VisaMeny();
            Console.WriteLine(PROGRAM_HEJ_DÅ);
            Thread.Sleep(1000);
        }
    }
}
