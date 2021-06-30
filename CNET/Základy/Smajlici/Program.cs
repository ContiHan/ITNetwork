using System;

namespace Smajlici
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej smajlíka:");
            string emoticon = Console.ReadLine();

            switch (emoticon)
            {
                case ":-)":
                    Console.WriteLine("Tvůj smajlík je veselý");
                    break;
                case ":-(":
                    Console.WriteLine("Tvůj smajlík je smutný");
                    break;
                case ":-*":
                    Console.WriteLine("Tvůj smajlík je zamilovaný");
                    break;
                case ":-P":
                case ":P":
                    Console.WriteLine("Tvůj smajlík je s vyplazeným jazykem");
                    break;
                default:
                    Console.WriteLine("Tvůj smajlík je neznámý");
                    break;
            }

            Console.ReadKey();
        }
    }
}
