using System;

namespace IntervalyDvojice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte levou mez 1. intervalu:");
            int left1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte pravou mez 1. intervalu:");
            int right1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte levou mez 2. intervalu:");
            int left2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte pravou mez 2. intervalu:");
            int right2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Dvojice čísel, jejichž součet leží v některém z intervalů:");
            Console.WriteLine("(1. číslo je z prvního intervalu a 2. z druhého intervalu)");

            int min = 0, max = 0;
            if (left1 <= left2)
            {
                min = left1;
            }
            else
            {
                min = left2;
            }

            if (right1 >= right2)
            {
                max = right1;
            }
            else
            {
                max = right2;
            }

            for (int i = left1; i <= right1; i++)
            {
                for (int j = left2; j <= right2; j++)
                {
                    if (i + j >= min && i + j <= max)
                    {
                        Console.Write("[{0};{1}], ", i, j);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
