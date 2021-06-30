using System;

namespace PoleNaplnit10Cisel
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 10 - i;
            }

            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
