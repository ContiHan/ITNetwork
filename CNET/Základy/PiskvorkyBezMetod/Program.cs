using System;

namespace Piskvorky
{
    class Program
    {
        static void Main(string[] args)
        {
            // hrací deska pro piškvorky
            string[,] gameboard = new string[9, 9];

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
                Console.Clear();

                // mezera pro odsazení značení sloupců
                Console.Write(" 123456789");
                Console.WriteLine();
                for (int y = 0; y < gameboard.GetLength(1); y++)
                {
                    Console.Write(y + 1);
                    for (int x = 0; x < gameboard.GetLength(0); x++)
                    {
                        Console.Write(gameboard[x, y]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                // hraje hráč s kolečky
                if (oPlayer)
                {
                    Console.WriteLine("Na řadě je hráč s kolečky");

                    int x = -1, y = -1;
                    bool inputRepeat = true;
                    while (inputRepeat)
                    {
                        Console.Write("Zadej pozici X kam chceš táhnout: ");
                        while (int.TryParse(Console.ReadLine(), out x) == false)
                        {
                            Console.Write("Zadej prosím celé číslo: ");
                        }

                        Console.Write("Zadej pozici Y kam chceš táhnout: ");
                        while (int.TryParse(Console.ReadLine(), out y) == false)
                        {
                            Console.Write("Zadej prosím celé číslo: ");
                        }

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
                    }

                    x--;
                    y--;

                    gameboard[x, y] = "O";

                    // row check
                    string rowCheck = "";
                    for (int i = 0; i < gameboard.GetLength(0); i++)
                    {
                        rowCheck += gameboard[i, y];
                    }

                    // column check
                    string columnCheck = "";
                    for (int j = 0; j < gameboard.GetLength(1); j++)
                    {
                        columnCheck += gameboard[x, j];
                    }

                    // slash check
                    string slashCheck = "";
                    if (x == y)
                    {
                        for (int i = 0; i < gameboard.GetLength(0); i++)
                        {
                            slashCheck += gameboard[i, i];
                        }
                    }
                    else if (x < y)
                    {
                        int offsetY = y - x;
                        for (int i = 0; i < gameboard.GetLength(0) - offsetY; i++)
                        {
                            slashCheck += gameboard[i, i + offsetY];
                        }
                    }
                    else
                    {
                        int offsetX = x - y;
                        for (int i = 0; i < gameboard.GetLength(0) - offsetX; i++)
                        {
                            slashCheck += gameboard[i + offsetX, i];
                        }
                    }

                    // backslash check
                    string backslashCheck = "";
                    int rowLen = gameboard.GetLength(0);
                    int columnLen = gameboard.GetLength(1);
                    int sumOfAxis = x + y;
                    if (x == rowLen - 1 - y)
                    {
                        for (int i = rowLen - 1; i >= 0; i--)
                        {
                            backslashCheck += gameboard[i, rowLen - 1 - i];
                        }
                    }
                    else if (x < rowLen - 1 - y)
                    {
                        for (int i = sumOfAxis; i >= 0; i--)
                        {
                            backslashCheck += gameboard[i, sumOfAxis - i];
                        }
                    }
                    else
                    {
                        for (int i = rowLen - 1; i > sumOfAxis - columnLen; i--)
                        {
                            backslashCheck += gameboard[i, sumOfAxis - i];
                        }
                    }

                    string winO = "OOOOO";

                    if (rowCheck.Contains(winO) || columnCheck.Contains(winO) || slashCheck.Contains(winO) || backslashCheck.Contains(winO))
                    {
                        Console.Clear();

                        // mezera pro odsazení značení sloupců
                        Console.Write(" 123456789");
                        Console.WriteLine();
                        for (int j = 0; j < gameboard.GetLength(1); j++)
                        {
                            Console.Write(j + 1);
                            for (int i = 0; i < gameboard.GetLength(0); i++)
                            {
                                Console.Write(gameboard[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Vyhrál hráč s kolečky");
                        gameContinues = false;
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
                        Console.Write("Zadej pozici X kam chceš táhnout: ");
                        while (int.TryParse(Console.ReadLine(), out x) == false)
                        {
                            Console.Write("Zadej prosím celé číslo: ");
                        }

                        Console.Write("Zadej pozici Y kam chceš táhnout: ");
                        while (int.TryParse(Console.ReadLine(), out y) == false)
                        {
                            Console.Write("Zadej prosím celé číslo: ");
                        }

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
                    }

                    x--;
                    y--;

                    gameboard[x, y] = "X";

                    // row check
                    string rowCheck = "";
                    for (int i = 0; i < gameboard.GetLength(0); i++)
                    {
                        rowCheck += gameboard[i, y];
                    }

                    // column check
                    string columnCheck = "";
                    for (int j = 0; j < gameboard.GetLength(1); j++)
                    {
                        columnCheck += gameboard[x, j];
                    }

                    // slash check
                    string slashCheck = "";
                    if (x == y)
                    {
                        for (int i = 0; i < gameboard.GetLength(0); i++)
                        {
                            slashCheck += gameboard[i, i];
                        }
                    }
                    else if (x < y)
                    {
                        int offsetY = y - x;
                        for (int i = 0; i < gameboard.GetLength(0) - offsetY; i++)
                        {
                            slashCheck += gameboard[i, i + offsetY];
                        }
                    }
                    else
                    {
                        int offsetX = x - y;
                        for (int i = 0; i < gameboard.GetLength(0) - offsetX; i++)
                        {
                            slashCheck += gameboard[i + offsetX, i];
                        }
                    }

                    // backslash check
                    string backslashCheck = "";
                    int rowLen = gameboard.GetLength(0);
                    int columnLen = gameboard.GetLength(1);
                    int sumOfAxis = x + y;
                    if (x == rowLen - 1 - y)
                    {
                        for (int i = rowLen - 1; i >= 0; i--)
                        {
                            backslashCheck += gameboard[i, rowLen - 1 - i];
                        }
                    }
                    else if (x < rowLen - 1 - y)
                    {
                        for (int i = sumOfAxis; i >= 0; i--)
                        {
                            backslashCheck += gameboard[i, sumOfAxis - i];
                        }
                    }
                    else
                    {
                        for (int i = rowLen - 1; i > sumOfAxis - columnLen; i--)
                        {
                            backslashCheck += gameboard[i, sumOfAxis - i];
                        }
                    }

                    string winX = "XXXXX";

                    if (rowCheck.Contains(winX) || columnCheck.Contains(winX) || slashCheck.Contains(winX) || backslashCheck.Contains(winX))
                    {
                        Console.Clear();

                        // mezera pro odsazení značení sloupců
                        Console.Write(" 123456789");
                        Console.WriteLine();
                        for (int j = 0; j < gameboard.GetLength(1); j++)
                        {
                            Console.Write(j + 1);
                            for (int i = 0; i < gameboard.GetLength(0); i++)
                            {
                                Console.Write(gameboard[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine("Vyhrál hráč s křížky");
                        gameContinues = false;
                    }

                    oPlayer = true;
                    xPlayer = false;
                }

                int spaces = 0;
                for (int j = 0; j < gameboard.GetLength(1); j++)
                {
                    for (int i = 0; i < gameboard.GetLength(0); i++)
                    {
                        if (gameboard[i, j] == " ")
                        {
                            spaces++;
                        }
                    }
                }

                if (spaces == 0)
                {
                    gameContinues = false;
                    Console.WriteLine("Remíza.");
                }
            }

            Console.ReadKey();
        }
    }
}
