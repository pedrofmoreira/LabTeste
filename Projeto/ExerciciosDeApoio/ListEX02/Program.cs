using System;
using System.Globalization;

namespace Lista_EXE02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRADA:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = (pi * (Math.Pow(raio, 2)));
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
/*
 using System;
using System.Globalization;

namespace uri1002 {
    class Program {
        static void Main(string[] args) {

            double R, A, pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            A = pi * R * R;

            Console.WriteLine("A=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
*/