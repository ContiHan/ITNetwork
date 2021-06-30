using System;

namespace kruh
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.1415f;
            Console.WriteLine("Zadej poloměr kruhu (cm):");
            float radius = float.Parse(Console.ReadLine());
            Console.WriteLine("Obvod zadaného kruhu je: {0} cm", 2 * pi * radius);
            Console.WriteLine("Jeho obsah je {0} cm^2", pi * radius * radius);
            Console.ReadKey();
        }
    }
}
