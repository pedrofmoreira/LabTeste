using System;
using System.Globalization;

namespace List02Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] quad = Console.ReadLine().Split(' ');
            double x = double.Parse(quad[0],CultureInfo.InvariantCulture);
            double y = double.Parse(quad[1],CultureInfo.InvariantCulture);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Saída: Q1");
            } 
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Saída: Q4");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Saída: Q3");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Saída: Q2");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
/*
 * using System;
using System.Globalization;

namespace uri1041 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
    }
}

    */