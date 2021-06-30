using System;

namespace AsciiTabulka
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[256];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = i;
            }

            Console.WriteLine("ASCII tabulka");
            Console.WriteLine("=============");
            foreach (var number in sequence)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(number + ":");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write((char)number + "\t");
            }
            Console.ReadKey();
        }
    }
}
