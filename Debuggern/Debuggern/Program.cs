using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuggern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange nummer: ");
            string str = Console.ReadLine();
            int key = Convert.ToInt32(str);
            double dbl = Convert.ToDouble(key);
            Console.Write("Som dubbel: " + dbl);
        }
    }
}
