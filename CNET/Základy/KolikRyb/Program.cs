using System;

namespace KolikRyb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolik ryb si dáš k večeři?");
            int fishQuantity = int.Parse(Console.ReadLine());
            for (int i = 0; i < fishQuantity; i++)
            {
                Console.WriteLine("<° )))-<");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
