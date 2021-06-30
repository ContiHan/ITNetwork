using System;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej palindrom:");
            string userWord = Console.ReadLine();

            char[] userWordChars = userWord.ToCharArray();
            Array.Reverse(userWordChars);
            string userWordReverse = new string(userWordChars);

            if (userWord == userWordReverse)
            {
                Console.WriteLine("Ano, toto je palindrom.");
            }
            else
            {
                Console.WriteLine("Toto není palindrom.");
            }

            Console.ReadKey();
        }
    }
}
