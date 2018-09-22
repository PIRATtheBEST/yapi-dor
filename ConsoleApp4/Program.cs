using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите числа a,b,c");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ваше уравнение:" + a + "x^2+" + b + "x+" + "c");
            double d = b ^ 2 - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("d<0 (" + d + ") следовательно решений нет");
            }
            else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a, x2 = (-b - Math.Sqrt(d)) / 2 * a;
                x1 = Math.Round(x1, 2);

                x2 = Math.Round(x2, 2);

                Console.WriteLine("ваши корни:" + x1 + " и " + x1);
            }
            else
            {
                double x = -b / 2 * a;
                x = Math.Round(x, 2);
                Console.WriteLine("ваш корень:" + x);
            }

            Console.ReadKey();
        }
    }
}
