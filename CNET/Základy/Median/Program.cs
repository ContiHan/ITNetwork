using System;
using System.Linq;

namespace Median
{
    class Program
    {
        static void Main(string[] args)
        {
            // vstup od uživatele, definice velikosti pole
            Console.WriteLine("Zadej počet čísel:");
            int numberQuantity = int.Parse(Console.ReadLine());

            // vytvoření dvou polí, jedno pro načtení čísel od uživatele a druhé pro seřazení
            int[] numbers = new int[numberQuantity];
            int[] sortedNumbers = new int[numberQuantity];

            // naplnění pole čísly od uživatele
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Zadej {0}. číslo: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // překopírování hodnot do pole, které se bude řadit
            Array.Copy(numbers, sortedNumbers, numbers.Length);

            // samotné řazení pole
            Array.Sort(sortedNumbers);

            // výpočet mediánu
            int median = sortedNumbers[sortedNumbers.Length / 2];

            //Console.WriteLine(median);

            // vypsání odchylky čísel od mediánu
            foreach (var number in numbers)
            {
                Console.WriteLine("{0} se od mediánu odchyluje o {1}", number, number - median);
            }



            Console.ReadKey();
        }
    }
}
