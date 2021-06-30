using System;

namespace VigenerovaSifra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte text k zašifrování: ");
            string userWord = Console.ReadLine();
            Console.Write("Zadejte heslo: ");
            string userPassword = Console.ReadLine();

            const byte asciiOffset = 96;

            char[] userWordChars = userWord.ToCharArray();
            char[] userPasswordChars = userPassword.ToCharArray();
            char[] cryptedWord = new char[userWordChars.Length];


            for (int i = 0; i < userWordChars.Length; i++)
            {
                int iPassword = i % userPasswordChars.Length;
                int asciiValue = (userWordChars[i] + userPasswordChars[iPassword] - asciiOffset);
                if (asciiValue > 122)
                {
                    cryptedWord[i] = (char)(asciiValue - 26);
                }
                else
                {
                    cryptedWord[i] = (char)asciiValue;
                }
            }

            foreach (var c in cryptedWord)
            {
                Console.Write(c);
            }

            Console.ReadKey();
        }
    }
}
