using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0,  c = -4.0;
            double delta = Math.Pow(b,2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            
            Console.WriteLine("O valor de x1 é: " + x1);
            Console.WriteLine("O valor de x2 é: " + x2);

        }
    }
}
