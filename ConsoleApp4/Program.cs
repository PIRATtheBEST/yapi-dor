using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d, x1, x2;
            Console.WriteLine("введите числа a,b,c");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ваше уравнение:" + a + "x^2+" + b + "x+" + "c");
            d = b ^ 2 - 4 * a * c;
            x1 = Convert.ToDouble(-b + Math.Sqrt(d));
            x2 = Convert.ToDouble(-b - Math.Sqrt(d));

            Console.WriteLine("ваши корни:" + x1 + "и" + x1);
            Console.ReadKey();


        }
    }
}
