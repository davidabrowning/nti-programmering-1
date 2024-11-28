using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter an integer:");
                bool success = int.TryParse(Console.ReadLine(), out int number);
                if (success)
                {
                    Console.WriteLine($"Converted to {number}");
                    break;
                }
                else
                {
                    Console.WriteLine("Unable to convert.");
                }
            }
        }
    }
}
