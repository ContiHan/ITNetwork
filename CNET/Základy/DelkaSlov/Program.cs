using System;

namespace DelkaSlov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte delší slovo:");
            string longerWord = Console.ReadLine();
            Console.WriteLine("Zadejte kratší slovo:");
            string shorterWord = Console.ReadLine();
            int lengthDifference = longerWord.Length - shorterWord.Length;
            Console.WriteLine("Slova se liší délkou o {0} znaků", lengthDifference);
            Console.ReadKey();
        }
    }
}
