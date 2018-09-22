using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите числа a,b,c");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ваше уравнение:" + a + "x^2+" + b + "x+" + "c");
            double d;
            d = b ^ 2 - 4 * a * c;
            if (d < 0) 
                Console.WriteLine("d=" + d + " следовательно решений нет");
            else if(d > 0)
            {
                    double x1 , x2;
                    x1 = (-b + Math.Sqrt(d))/2*a;
                    x2 = (-b - Math.Sqrt(d))/2*a;
                x1 = int.TryParse(x1);
                    Console.WriteLine("ваши корни:" + x1 + " и " + x1);
            }
            else if  (!(d < 0) && !(d > 0))
            {
                double x;               
                x = -b / 2 * a;
                Console.WriteLine("ваш корень:" + x);
            }

            Console.ReadKey();        
        }
    }
}
