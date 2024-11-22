using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0603
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            do
            {
                Console.WriteLine("Mät vattnet. Hur många grader är det nu?");
                string str = Console.ReadLine();
                temp = Convert.ToInt32(str);
            } while (temp < 100);

            Console.WriteLine("Nu kokar det!");
        }
    }
}
