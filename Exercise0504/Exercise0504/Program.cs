using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise0504
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            do
            {
                Console.WriteLine("Är vi framme snart? ");
                str = Console.ReadLine();
            } while (str == "n");
        }
    }
}
