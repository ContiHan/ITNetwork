using System;

namespace characteristics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ahoj, jak se jmenuješ?");
            string name = Console.ReadLine();
            Console.WriteLine("Jaký jsi?");
            string ability = Console.ReadLine();
            Console.WriteLine(name + " je " + ability);
        }
        //static void Main()
        //{
        //    Print(new string[] { GetUserInput("Ahoj, jak se jmenuješ?: "), " je ",  GetUserInput("A jaký jsi?: ") });
        //    Console.ReadKey();
        //}

        ///// <summary>
        ///// Metoda vrací text od uživatele
        ///// </summary>
        ///// <param name="prompt">Textová výzva pro uživatele, nepovinný údaj</param>
        ///// <returns></returns>
        //static string GetUserInput(string prompt = "")
        //{
        //    Console.Write(prompt);
        //    return Console.ReadLine();
        //}

        ///// <summary>
        ///// Vypíše do konzole předané texty formou pole textů, lze předat proměnnou typu string array nebo ručně new string[] { string_var, "custom text" }
        ///// </summary>
        ///// <param name="args">předaný string array se vypíše do konzole na jeden řádek, nemá žádný oddělovač</param>
        //static void Print(string[] args)
        //{
        //    foreach (var arg in args)
        //    {
        //        Console.Write(arg);
        //    }
        //}
    }
}
