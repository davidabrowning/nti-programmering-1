using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programbeskrivning:
 *      Användaren får skriva en siffra
 *      Användaren skriver en till siffra
 *      Presentera alternativ för användaren
 *      SWITCH
 *          Fall "Addera":
 *              Addera siffrorna
 *          Fall "Multiplicera":
 *              Multiplicera siffrorna
 *          Default:
 *              Visa felmeddelande
 *      Presentera resultatet
 */
namespace AktivitetsdiagramÖvning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int siffra1 = 0;
            int siffra2 = 0;
            int resultat = 0;
            int menyval = 0;
            Console.WriteLine("Skriv en siffra:");
            siffra1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv en siffra till:");
            siffra2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("[1] Addera");
            Console.WriteLine("[2] Multiplicera");
            menyval = Convert.ToInt32(Console.ReadLine());
            switch (menyval)
            {
                case 1:
                    resultat = siffra1 + siffra2;
                    break;
                case 2:
                    resultat = siffra1 * siffra2;
                    break;
                default:
                    Console.WriteLine("Oväntat indata");
                    break;
            }
            Console.WriteLine("Resultat: " + resultat);
        }
    }
}
