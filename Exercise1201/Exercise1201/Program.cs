using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1201
{
    internal class Program
    {

        // Konstanter
        const int ANTAL_NAMN = 5;
        const int NAMN_LÄNGD_MIN = 2;

        // METOD: Tar emot ett nytt namn
        static string BeOmEttNamn(int nuvarandeIndex)
        {
            string nyttNamn = "";
            while (nyttNamn.Length < 2)
            {
                Console.Write("\tMata in ett namn (minst 2 bokstaver): ");
                nyttNamn = Console.ReadLine();
            }
            return nyttNamn;
        }

        // METOD: Matar in alla nya namn
        static void MataInNamn(string[] allaNamn)
        {
            for (int i = 0; i < allaNamn.Length; i++)
            {
                allaNamn[i] = BeOmEttNamn(i);
            }
        }

        // METOD: Skriver ut alla namn
        static void SkrivUtNamn(string[] allaNamn)
        {
            Console.WriteLine("\n\tAlla namn:");
            for (int i = 0; i < allaNamn.Length; i++)
            {
                Console.WriteLine("\t" + (i + 1) + ". " + allaNamn[i]);
            }
        }

        // METOD: Skriver ut utbytemenys val
        static void SkrivUtUtbyteMenyVal()
        {
            Console.Write("\tSkriv nummer på namn att byta ut eller Q för att avsluta programmet: ");
        }

        // METOD: Visar meny där användaren kan byta ut ett namn
        static void VisaUtbyteMeny(string[] allaNamn)
        {
            bool kör = true;
            while (kör)
            {
                SkrivUtNamn(allaNamn);
                SkrivUtUtbyteMenyVal();
                string inmatning = Console.ReadLine();
                
                // Om användaren vill avsluta
                if (inmatning.ToLower() == "q")
                {
                    kör = false;
                    break;
                }

                // Om giltigt val
                bool ärHeltal = Int32.TryParse(inmatning, out int heltal);
                if (ärHeltal && heltal > 0 && heltal <= allaNamn.Length)
                {
                    allaNamn[heltal - 1] = BeOmEttNamn(heltal);
                } else
                {
                    Console.WriteLine("\tOgiltigt val.");
                }
            }
        }

        // METOD: Main, start på programmet
        static void Main(string[] args)
        {
            string[] allaNamn = new string[5];

            MataInNamn(allaNamn);
            VisaUtbyteMeny(allaNamn);
        }
    }
}
