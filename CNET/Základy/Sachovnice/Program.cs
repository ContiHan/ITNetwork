using System;

namespace Sachovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            char[,] chessboard = new char[16, 8];
            // █

            for (int j = 0; j < chessboard.GetLength(1); j++)
            {
                for (int i = 0; i < chessboard.GetLength(0); i++)
                {
                    if ((i % 4 == 0 || i % 4 == 1) && j % 2 == 0)
                    {
                        chessboard[i, j] = '█';
                    }
                    else if ((i % 4 == 2 || i % 4 == 3) && j % 2 == 1)
                    {
                        chessboard[i, j] = '█';
                    }
                    else
                    {
                        chessboard[i, j] = ' ';
                    }
                }
            }

            for (int j = 0; j < chessboard.GetLength(1); j++)
            {
                for (int i = 0; i < chessboard.GetLength(0); i++)
                {
                    Console.Write(chessboard[i, j]);
                    if (i == chessboard.GetLength(0) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
