using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        private static char klawisz;
        public static void Legenda()
        {
            Console.WriteLine("Co chcesz zrobić");
            Console.WriteLine("A - dodaj tv");
            Console.WriteLine("B - dodaj komputer");
            Console.WriteLine("C1 - polacz");
            Console.WriteLine("C2 - podziel");
            Console.WriteLine("D - napraw");
            Console.WriteLine("E - napraw po numerze seryjnym");
            Console.WriteLine("X - wyjscie z aplikacji");
        }
        public static void Wczytajklawisz()
        {
            klawisz = Convert.ToChar(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Legenda();
            Wczytajklawisz();
            Console.ReadKey();
        }
    }
}
