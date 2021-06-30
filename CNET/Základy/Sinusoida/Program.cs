using System;

namespace Sinusoida
{
    class Program
    {
        static void Main(string[] args)
        {
            // █
            int graphWidth = 80, graphHeigth = 25;

            Console.ForegroundColor = ConsoleColor.White;
            for (int x = 0; x < graphWidth; x++)
            {
                double sinus = ((Math.Sin(x / (graphWidth / (2 * Math.PI)))) * (graphHeigth / 2)) + (graphHeigth / 2);
                int y = (int)Math.Round(sinus);
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("██");
            }

            //for (int i = 0; i < canvas.GetLength(0); i++)
            //{
            //    double sinus = (Math.Sin(i / (canvas.GetLength(0) / (2 * Math.PI)))) * 12;
            //    int y = (int)Math.Round(sinus) + 13;
            //    Console.WriteLine($"{y}");
            //}

            Console.ReadKey();
        }
    }
}
