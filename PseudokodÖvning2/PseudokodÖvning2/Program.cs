using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programbeskrivning:
 *      Börja räkna en [siffra] från 0
 *      SÅ LÄNGE [siffra] är under 100
 *          Addera 1 till [siffra]
 *      Säg till användaren att programmet har räknat klart
 */

namespace PseudokodÖvning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int siffra = 0;
            while (siffra < 100)
            {
                siffra++;
                Console.WriteLine("Siffra har ökat till " + siffra);
            }
            Console.WriteLine("Programmet har räknat klart.");
        }
    }
}
