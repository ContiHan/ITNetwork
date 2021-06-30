using System;
using System.Linq;

namespace ZeleninaOvoce
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vegetable = { "zelí", "okurka", "rajče", "paprika", "ředkev", "mrkev", "brokolice" };
            string[] fruit = { "jablko", "hruška", "pomeranč", "jahoda", "banán", "kiwi", "malina" };
            
            int loopCount = 0;
            do
            {
                Console.WriteLine("Zadej název libovolného ovoce nebo zeleniny:");
                string userInput = Console.ReadLine();
                loopCount++;

                if (vegetable.Contains(userInput.ToLower()))
                {
                    Console.WriteLine("Zadal jsi zeleninu");
                }
                else if (fruit.Contains(userInput.ToLower()))
                {
                    Console.WriteLine("Zadal jsi ovoce");
                }
                else
                {
                    Console.WriteLine("Tvoje slovo nemám v seznamu");
                }
                Console.WriteLine("Přeješ si zadat další slovo? (ano/ne)");
            } while (Console.ReadLine() == "ano");
            Console.WriteLine("Zadal jsi {0} slov", loopCount);

            Console.ReadKey();
        }
    }
}
