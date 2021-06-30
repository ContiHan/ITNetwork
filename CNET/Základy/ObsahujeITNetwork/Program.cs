using System;

namespace ObsahujeITNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej řetězec:");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput.ToLower().Contains("itnetwork"));

            Console.ReadKey();
        }
    }
}
