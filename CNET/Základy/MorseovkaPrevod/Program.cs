using System;

namespace MorseovkaPrevod
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] letters = alphabet.ToCharArray();

            string[] morseChars =
            {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....",
                "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
                "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
            };
            string morseCode = "";

            Console.WriteLine("Zadejte zprávu k zakódování:");
            string userInput = Console.ReadLine().ToLower();

            foreach (var c in userInput)
            {
                int index = Array.IndexOf(letters, c);
                if (index >= 0)
                {
                    morseCode = morseCode + morseChars[index] + " ";
                }
            }

            Console.Write("Zakódovaná zpráva: " + morseCode);

            Console.ReadKey();
        }
    }
}
