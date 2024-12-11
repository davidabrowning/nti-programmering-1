using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// författare David Browning (david.a.browning@gmail.com)
namespace ExerciseListorOchMetoder
{
    class Program
    {
        // detta är en statisk metod med en int som ett returvärde
        // metoden tar en parameter i form av ett random objekt av
        // randomklassen
        static int RullaTärning(Random slumpObjekt)
        {
            // här ska du skapa kod som slumpar fram ett tal
            // mellan 1 och 6, så att metoden "rullar" en 6 sidig
            // tärning när vi kallar på den

            // metoden ska sedan returnera det rullade värdet

            int min = 1; // minvärde på tärningen
            int max = 6; // maxvärde på tärningen
            int tal = 0; // håller resultat när tärningen rullas
            
            // räkna ut ett slumpvärde mellan min och max
            tal = slumpObjekt.Next(min, max + 1);

            // returnera resulterande värde
            return tal;
        }

        static void Main()
        {
            Random slump = new Random(); // Skapar en instans av klassen Random för vårt slumptal
            List<int> tärningar = new List<int>(); // listan för att spara våra rullade tärningar

            Console.WriteLine("\n\tVälkommen till tärningsgeneratorn!");

            bool kör = true;
            while (kör)
            {
                Console.WriteLine("\n\t[1] Rulla tärning\n" +
                    "\t[2] Kolla vad du rullade\n" +
                    "\t[3] Avsluta");
                Console.Write("\tVälj: ");
                int val;
                int.TryParse(Console.ReadLine(), out val);

                switch (val)
                {
                    case 1:
                        Console.Write("\n\tHur många tärningar vill du rulla: ");
                        bool inmatning = int.TryParse(Console.ReadLine(), out int antal);

                        if (inmatning)
                        {
                            for (int i = 0; i < antal; i++)
                            {
                                // här kallar vi på metoden RullaTärning
                                // och sparar det returnerade värdet i 
                                // listan tärningar
                                tärningar.Add(RullaTärning(slump));
                            }
                        }
                        break;
                    case 2:
                        int sum = 0; // Skapar en int som ska innehålla medelvärdet av alla tärningsrullningar.
                        if (tärningar.Count <= 0)
                        {
                            Console.WriteLine("\n\tDet finns inga sparade tärningsrull! ");
                        }
                        else
                        {
                            Console.WriteLine("\n\tRullade tärningar: ");
                            foreach (int tärning in tärningar)
                            {
                                // skriv ut tärning
                                Console.WriteLine("\t" + tärning);

                                // lägg tärning till summa
                                sum += tärning;
                            }

                            // räkna ut medelvärde
                            // obs!  jag använder inte decimaler, då tärningar ändå bara har hela sidor
                            int medelvärde = sum / tärningar.Count;

                            // skriv ut medelvärde
                            Console.WriteLine("\n\tMedelvärdet på alla tärningsrull: " + medelvärde); // Här ska medelvärdet skrivas ut
                        }

                        break;
                    case 3:
                        Console.WriteLine("\n\tTack för att du rullade tärning!");
                        Thread.Sleep(1000);
                        kör = false;
                        break;
                    default:
                        Console.WriteLine("\n\tVälj 1-3 från menyn.");
                        break;
                }
            }
        }
    }
}
