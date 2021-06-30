using System;

namespace mocnitel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej číslo k umocnění:");
            int number = int.Parse(Console.ReadLine());
            number *= number;
            Console.WriteLine("Výsledek: " + number);
            Console.ReadKey();
        }
    }
}
