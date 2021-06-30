using System;

namespace RikankaLahve
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                if (i > 4)
                {
                    Console.WriteLine("{0} zelených láhví stojí na stole a jedna láhev spadne", i);
                }
                else if (i > 1)
                {
                    Console.WriteLine("{0} zelené láhve stojí na stole a jedna láhev spadne", i);
                }
                else
                {
                    Console.WriteLine("{0} zelená láhev stojí na stole a jedna láhev spadne", i);
                }
            }

            Console.ReadKey();
        }
    }
}
