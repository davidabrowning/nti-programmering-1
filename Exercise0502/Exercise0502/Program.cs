using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * UPPGIFT
 * Skapa ett program där användaren får mata in valfritt tal up till 100.
 * Programmet skriver sedan ut alla tal, från talet som användaren matade in
 * upp till och med 100. Om man matar in ett tal som är stärre än 100 så stängs
 * programmet av direkt.
 * 
 * PSUEDOKOD
 * Skriva instruktioner
 * Ta emot användarsvar
 * Skriva ut alla tal
 */

namespace Exercise0502
{
    internal class Program
    {
        // Konstanter
        const string instruktioner = "Mata in ett tal: ";
        const string ogiltigtValMeddelande = "Jag förstår inte.";
        const int max = 100;

        static void Main(string[] args)
        {
            // Variabler
            string användarSvarSträng = "";
            int användarSvarTal = 0;

            // Skriva instruktioner
            Console.Write(instruktioner);

            // Ta emot användarsvar
            användarSvarSträng = Console.ReadLine();
            try
            {
                användarSvarTal = Convert.ToInt32(användarSvarSträng);
            }
            catch (Exception e)
            {
                Console.WriteLine(ogiltigtValMeddelande);
                användarSvarTal = 0;
            }

            // Skriva ut alla tal
            for (int i = användarSvarTal; i <= 100; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}
