using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  UPPGIFT
 *  Skapa ett program som skriver ut alla tal mellan 1 och 20
 */

namespace Exercise0501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
