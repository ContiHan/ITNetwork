using System;

namespace KontrolaDelkyJmena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej své jméno:");
            string name = Console.ReadLine();
            if (name.Length >= 3 && name.Length <= 10)
            {
                Console.WriteLine("Normální jméno.");
            }
            else
            {
                Console.WriteLine("Máš moc krátké nebo moc dlouhé jméno!");
            }

            Console.ReadKey();
        }
    }
}
