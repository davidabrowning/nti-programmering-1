using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Programbeskrivning
 *  Börja räkna från 0
 *  SÅ LÄNGE [räknare] är under 100
 *      Öka [räknare] med 1
 */
namespace AktivitetsdiagramÖvning1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int räknare = 0;
            while (räknare < 100)
            {
                int gammaltVärde = räknare;
                räknare++;
                Console.WriteLine(
                    "räknare ökas från " + gammaltVärde +" till " + räknare
                );
            }
        }
    }
}
