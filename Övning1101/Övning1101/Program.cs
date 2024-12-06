using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

// ================================ NAMESPACE =================================
// Övning 11.01. Skapa en metod Hello() som tar en string-variabel som indata
// och skriver ut den texten ihop med ett annat meddelande. Författare: David
// Browning, david.a.browning@gmail.com.
// ============================================================================
namespace Övning1101
{

    // ================================ KLASS =================================
    // Program. Innehåller Main-metoden.
    // ========================================================================
    internal class Program
    {

        // ============================== METOD ===============================
        // Main. Start på programmet.
        // ====================================================================
        static void Main(string[] args)
        {
            string meddelande = GetInput();
            Hello(meddelande);
        }

        // ============================== METOD ===============================
        // GetInput. Tar inget indata. Ber användaren att skriva ett
        // meddelande och returnerar denna sträng.
        // ====================================================================
        private static string GetInput()
        {
            string instruktioner = "Skriv ett meddelande: ";
            string varningFörKort = "För kort! Försök igen.";

            Console.Write(instruktioner);
            string meddelande = Console.ReadLine();
            if (meddelande.Length > 5)
            {
                return meddelande;
            }
            else
            {
                Console.WriteLine(varningFörKort);
                return GetInput();
            }
        }

        // ============================== METOD ===============================
        // Hello. Tar en string-variabel som indata. Skriver ut den texten
        // ihop med ett annat meddelande. Returnerar ingenting.
        // ====================================================================
        private static void Hello(string meddelande)
        {
            string annatMeddelandeDel1 = "Hej! Tack för att du skrev \"";
            string annatMeddelandeDel2 = meddelande;
            string annatMeddelandeDel3 = "\"!";

            Console.WriteLine(annatMeddelandeDel1 + annatMeddelandeDel2
                + annatMeddelandeDel3);
        }
    }
}
