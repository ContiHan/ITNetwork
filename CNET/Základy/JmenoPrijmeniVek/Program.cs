using System;

namespace JmenoPrijmeniVek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej jméno:");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine("Zadej příjmení:");
            string surname = Console.ReadLine().ToUpper();
            Console.WriteLine("Zadej svůj věk:");
            int age = int.Parse(Console.ReadLine()) + 1;
            Console.WriteLine(name + " " + surname);
            Console.WriteLine("Za rok ti bude " + age + " let.");
            Console.ReadKey();
        }
    }
}
