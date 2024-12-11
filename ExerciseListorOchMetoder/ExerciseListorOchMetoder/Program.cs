using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// författare David Browning (david.a.browning@gmail.com)
namespace ExerciseListorOchMetoder
{

    // ================================ KLASS =================================
    // Program. Innehåller Main-metoden.
    // ========================================================================
    class Program
    {
        // Konstanter: Värden
        const int VANLIG_TÄRNING_MIN = 1;
        const int VANLIG_TÄRNING_MAX = 6;

        // Konstanter: Meddelanden
        const string PROGRAM_HÄLSNING = "\n\tVälkommen till tärningsgeneratorn!";
        const string PROGRAM_HEJ_DÅ = "\n\tTack för att du rullade tärning!";
        const string MENY_ALTERNATIV = "\n" + 
            "\t[1] Rulla tärning\n" +
            "\t[2] Kolla vad du rullade\n" +
            "\t[3] Avsluta";
        const string MENY_INSTRUKTION = "\tVälj: ";
        const string RULLA_HUR_MÅNGA_INSTRUKTION = "\n\tHur många tärningar vill du rulla: ";
        const string RESULTAT_RUBRIK_TÄRNINGAR = "\n\tRullade tärningar: ";
        const string RESULTAT_RUBRIK_MEDELVÄRDE = "\n\tMedelvärdet på alla tärningsrull: ";
        const string VARNING_OGILTIGT_MENYVAL = "\n\tVälj 1-3 från menyn.";
        const string VARNING_INGA_SPARADE_TÄRNINGSRULL = "\n\tDet finns inga sparade tärningsrull! ";

        // ============================== METOD ===============================
        // RullaTärning(Random slumpObjekt, int min, int max). Statisk metod
        // som slumpar fram ett tal mellan min och max. Returnerar det slumpade
        // int-värdet.
        // ====================================================================
        static int RullaTärning(Random slumpObjekt, int min, int max)
        {
            int tal;
            tal = slumpObjekt.Next(min, max + 1);
            return tal;
        }

        // ============================== METOD ===============================
        // RullaTärning(Random slumpObjekt). Slumpar fram ett tal mellan
        // VANLIG_TÄRNING_MIN (1) och VANLIG_TÄRNING_MAX (6). Returnerar det
        // slumpade int-värdet.
        // ====================================================================
        static int RullaTärning(Random slumpObjekt)
        {
            int tal;
            tal = RullaTärning(slumpObjekt, VANLIG_TÄRNING_MIN, VANLIG_TÄRNING_MAX);
            return tal;
        }

        // ============================== METOD ===============================
        // RullaNågraTärningar. Frågar användaren hur många tärningar ska 
        // rullas. Rullar tärningar genom att ropa RullaTärning-metoden. Sparar
        // resultaten i List<int> tärningar. Returnerar ingenting.
        // ====================================================================
        static void RullaNågraTärningar(Random slump, List<int> tärningar)
        {
            Console.Write(RULLA_HUR_MÅNGA_INSTRUKTION);
            bool inmatning = int.TryParse(Console.ReadLine(), out int antal);
            if (inmatning)
            {
                for (int i = 0; i < antal; i++)
                {
                    tärningar.Add(RullaTärning(slump));
                }
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
                    Console.WriteLine("\t" + tärning); // skriv ut tärning
                    sum += tärning; // lägg tärning till summa
                }
                medelvärde = sum / tärningar.Count; // räkna ut medelvärde
                Console.WriteLine(RESULTAT_RUBRIK_MEDELVÄRDE + medelvärde); // skriv ut medelvärde
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
                    RullaNågraTärningar(slump, tärningar);
                    break;
                case 2:
                    KollaRulladeTärningar(tärningar);
                    break;
                case 3:
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
            Random slump = new Random(); // Skapar en instans av klassen Random för vårt slumptal
            List<int> tärningar = new List<int>(); // listan för att spara våra rullade tärningar

            bool kör = true;
            while (kör)
            {
                Console.WriteLine(MENY_ALTERNATIV);
                Console.Write(MENY_INSTRUKTION);
                kör = TaEmotMenyVal(slump, tärningar);
            }
        }

        // ============================== METOD ===============================
        // Main.
        // Start på programmet. Hälsar användaren, ropar VisaMeny() och säger
        // hej då till användaren.
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
