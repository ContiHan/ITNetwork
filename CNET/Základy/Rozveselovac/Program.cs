using System;

namespace Rozveselovac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej text k rozveselení:");
            string sentences = Console.ReadLine();

            string[] emojis = new string[] { " :)", " :D", " :P" };

            int iSentences = 0, iEmojis = 0;
            while (iSentences < sentences.Length)
            {
                switch (sentences[iSentences])
                {
                    case '.':
                        sentences = sentences.Remove(iSentences, 1);
                        sentences = sentences.Insert(iSentences, emojis[iEmojis]);
                        iSentences++;
                        iEmojis++;
                        break;
                    case '!':
                    case '?':
                        iSentences++;
                        sentences = sentences.Insert(iSentences, emojis[iEmojis]);
                        iEmojis++;
                        break;
                }

                if (iEmojis >= emojis.Length)
                {
                    iEmojis = 0;
                }
                iSentences++;
            }

            Console.WriteLine("Rozveselený text: " + sentences);

            Console.ReadKey();
        }
    }
}
