using System;

namespace KvadratickaRovnice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte postupně koeficienty a,b,c kvadratické rovnice ax^2+bx+c=0 :");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double dis = b * b - 4 * a * c;

            if (a == 0)
            {
                Console.WriteLine("Není kvadratická rovnice");
            }
            else if (dis < 0)
            {
                Console.WriteLine("Neexistuje řešení v oblasti reálných čísel");
            }
            else if (dis == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Rovnice má jeden kořen x = {0}", x);
            }
            else if (dis > 0)
            {
                double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                double x2 = (-b - Math.Sqrt(dis)) / (2 * a);
                Console.WriteLine("Rovnice má 2 reálné kořeny x1 = {0}, x2 = {1}", x1, x2);
            }

            
            Console.ReadLine();
        }
    }
}
