using System;

namespace PrumerZnamky
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Výpočet průměru známek");
            Console.WriteLine("Zadejte známky oddělené čárkou:");
            string userInput = Console.ReadLine();
            string[] grades = userInput.Split(',');

            int sumGrades = 0;
            foreach (var i in grades)
            {
                sumGrades += int.Parse(i);
            }

            Console.WriteLine("Průměr: " + (double)sumGrades / grades.Length);

            Console.ReadKey();
        }
    }
}
