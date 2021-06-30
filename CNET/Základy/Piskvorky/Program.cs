using System;

namespace Piskvorky
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("Red");
            //Console.ForegroundColor = ConsoleColor.DarkRed;
            //Console.WriteLine("DarkRed");
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Blue");
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine("DarkBlue");
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Cyan");
            //Console.ForegroundColor = ConsoleColor.DarkCyan;
            //Console.WriteLine("DarkCyan");
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Green");
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine("DarkGreen");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("Magenta");
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //Console.WriteLine("DarkMagenta");
            //Console.ReadKey();




            // hrací deska pro piškvorky
            string[,] gameboard = new string[9, 5];

            // naplnění pole mezerami
            for (int j = 0; j < gameboard.GetLength(1); j++)
            {
                for (int i = 0; i < gameboard.GetLength(0); i++)
                {
                    gameboard[i, j] = " ";
                }
            }

            // definování, který hráč hraje a jestli hra běží
            bool xPlayer = false;
            bool oPlayer = true;
            bool gameContinues = true;

            // smyčka samotné hry
            while (gameContinues)
            {
                PrintGameboard(gameboard);

                // hraje hráč s kolečky
                if (oPlayer)
                {
                    Console.WriteLine("Na řadě je hráč s kolečky");

                    int x = -1, y = -1;
                    bool inputRepeat = true;
                    while (inputRepeat)
                    {
                        x = GetAxis("X");
                        y = GetAxis("Y");
                        inputRepeat = PlayCheck(gameboard, x, y, inputRepeat);
                    }

                    gameboard[x - 1, y - 1] = "O";

                    if (WinCheck(x - 1, y - 1, gameboard, "OOOO"))
                    {
                        gameContinues = GameOverNotice(gameboard, "Vyhrál hráč s kolečky");
                    }

                    xPlayer = true;
                    oPlayer = false;
                }

                // hraje hráč s křížky
                else if (xPlayer)
                {
                    Console.WriteLine("Na řadě je hráč s křížky");

                    int x = -1, y = -1;
                    bool inputRepeat = true;
                    while (inputRepeat)
                    {
                        x = GetAxis("X");
                        y = GetAxis("Y");
                        inputRepeat = PlayCheck(gameboard, x, y, inputRepeat);
                    }

                    gameboard[x - 1, y - 1] = "X";

                    if (WinCheck(x - 1, y - 1, gameboard, "XXXX"))
                    {
                        gameContinues = GameOverNotice(gameboard, "Vyhrál hráč s křížky");
                    }

                    oPlayer = true;
                    xPlayer = false;
                }

                if (FullGameboardCheck(gameboard))
                {
                    gameContinues = GameOverNotice(gameboard, "Remíza.");
                }
            }

            Console.ReadKey();
        }

        private static bool PlayCheck(string[,] gameboard, int x, int y, bool inputRepeat)
        {
            if (x > 0 && x <= gameboard.GetLength(0) &&
                y > 0 && y <= gameboard.GetLength(1) &&
                gameboard[x - 1, y - 1] == " ")
            {
                inputRepeat = false;
            }
            else
            {
                Console.WriteLine("Neplatná pozice, zadej ji prosím znovu.");
            }

            return inputRepeat;
        }

        private static bool GameOverNotice(string[,] gameboard, string message)
        {
            bool gameContinues;
            PrintGameboard(gameboard);
            Console.WriteLine(message);
            gameContinues = false;
            return gameContinues;
        }

        /// <summary>
        /// Vyzve k zadání celého čísla. Dokud není zadáno celé číslo, výzva pokračuje. Povinný parametr je text (písmeno), které ve výzvě značí, kterou osu požadujeme
        /// </summary>
        /// <param name="axis">Popis osy, pro kterou žádáme číslo</param>
        /// <returns>Vrací celé číslo</returns>
        private static int GetAxis(string axis)
        {
            int userAxis;
            Console.Write("Zadej pozici {0} kam chceš táhnout: ", axis);
            while (int.TryParse(Console.ReadLine(), out userAxis) == false)
            {
                Console.Write("Zadej prosím celé číslo: ");
            }

            return userAxis;
        }

        /// <summary>
        /// vypíše do konzole čistou obrazovku s herní deskou a aktualizovaným zadání posledního tahu
        /// </summary>
        /// <param name="gameboard">hrací deska, kterou chceme vypsat do konzole</param>
        private static void PrintGameboard(string[,] gameboard)
        {
            Console.Clear();

            // mezera pro odsazení značení sloupců
            Console.Write(" ");

            // číslené označení sloupců
            for (int x = 0; x < gameboard.GetLength(0); x++)
            {
                Console.Write(x + 1);
            }

            Console.WriteLine();

            for (int y = 0; y < gameboard.GetLength(1); y++)
            {
                Console.Write(y + 1);
                for (int x = 0; x < gameboard.GetLength(0); x++)
                {
                    if (gameboard[x, y] == "X")
                    {
                        PrintColorSymbol(ConsoleColor.DarkRed, 'X');
                    }
                    else if (gameboard[x, y] == "O")
                    {
                        PrintColorSymbol(ConsoleColor.DarkCyan, 'O');
                    }
                    else
                    {
                        Console.Write(gameboard[x, y]);
                    }
                    if (x == gameboard.GetLength(0) - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        
        /// <summary>
        /// Přebarví požadovaný znak na jinou konzolovou barvu
        /// </summary>
        /// <param name="color">konzolová barva</param>
        /// <param name="symbol">znak k přebarvení</param>
        private static void PrintColorSymbol(ConsoleColor color, char symbol)
        {
            ConsoleColor previousColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ForegroundColor = previousColor;
        }

        private static string RowCheck(int axisY, string[,] gameboard)
        {
            string rowCheck = "";
            for (int x = 0; x < gameboard.GetLength(0); x++)
            {
                rowCheck += gameboard[x, axisY];
            }
            return rowCheck;
        }

        private static string ColumnCheck(int axisX, string[,] gameboard)
        {
            string columnCheck = "";
            for (int y = 0; y < gameboard.GetLength(1); y++)
            {
                columnCheck += gameboard[axisX, y];
            }
            return columnCheck;
        }

        private static string SlashCheck(int axisX, int axisY, string[,] gameboard)
        {
            string slashCheck = "";
            if (axisX == axisY)
            {
                for (int x = 0; x < gameboard.GetLength(0); x++)
                {
                    slashCheck += gameboard[x, x];
                }
            }
            else if (axisX < axisY)
            {
                int offsetY = axisY - axisX;
                for (int x = 0; x < gameboard.GetLength(0) - offsetY; x++)
                {
                    slashCheck += gameboard[x, x + offsetY];
                }
            }
            else
            {
                int offsetX = axisX - axisY;
                for (int x = 0; x < gameboard.GetLength(0) - offsetX; x++)
                {
                    slashCheck += gameboard[x + offsetX, x];
                }
            }
            return slashCheck;
        }

        private static string BackslashCheck(int axisX, int axisY, string[,] gameboard)
        {
            string slashCheck = "";
            int rowLen = gameboard.GetLength(0);
            int columnLen = gameboard.GetLength(1);
            int sumOfAxis = axisX + axisY;
            if (axisX == rowLen - 1 - axisY)
            {
                for (int x = rowLen - 1; x >= 0; x--)
                {
                    slashCheck += gameboard[x, rowLen - 1 - x];
                }
            }
            else if (axisX < rowLen - 1 - axisY)
            {
                for (int x = sumOfAxis; x >= 0; x--)
                {
                    slashCheck += gameboard[x, sumOfAxis - x];
                }
            }
            else
            {
                for (int x = rowLen - 1; x > sumOfAxis - columnLen; x--)
                {
                    slashCheck += gameboard[x, sumOfAxis - x];
                }
            }
            return slashCheck;
        }

        private static bool WinCheck(int x, int y, string[,] gameboard, string line)
        {
            if (RowCheck(y, gameboard).Contains(line) || 
                ColumnCheck(x, gameboard).Contains(line) || 
                SlashCheck(x, y, gameboard).Contains(line) ||
                BackslashCheck(x, y, gameboard).Contains(line))
            {
                return true;
            }
            return false;
        }

        private static bool FullGameboardCheck(string[,] gameboard)
        {
            for (int j = 0; j < gameboard.GetLength(1); j++)
            {
                for (int i = 0; i < gameboard.GetLength(0); i++)
                {
                    if (gameboard[i, j] == " ")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
