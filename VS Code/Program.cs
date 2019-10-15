using System;
using System.Globalization;
namespace VS_Code
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("ENTRADA:");
            double v = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double raio = v;
            double pi = 3.14159;
            double area = (pi * (Math.Pow(raio, 2)));
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
