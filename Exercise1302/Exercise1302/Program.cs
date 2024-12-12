using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1302
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat nomi = new Cat();
            nomi.name = "Nomi";
            nomi.type = "Tabby";
            nomi.age = 10;

            Console.WriteLine("Intro:");
            Console.WriteLine(nomi);

            Console.WriteLine("Meow:");
            nomi.Meow();

            Console.WriteLine("Meow 10x:");
            nomi.Meow(10);
        }
    }

    public class Cat
    {
        public string name { get; set; }
        public string type { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", name, type, age);
        }

        public void Meow()
        {
            Console.WriteLine("{0} the {1} says \"Meow!\"", name, type.ToLower());
        }

        public void Meow(int antal)
        {
            for (int i = 0; i < antal; i++)
            {
                this.Meow();
            }
        }
    }
}
