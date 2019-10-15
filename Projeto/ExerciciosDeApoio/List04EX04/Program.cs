using System;
using System.Globalization;

namespace List04EX04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());


            for (int i = 1; i <= N; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                double a = int.Parse(x[0], CultureInfo.InvariantCulture);
                double b = int.Parse(x[1], CultureInfo.InvariantCulture);

                if (b == 0)
                {
                    Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    Console.WriteLine("Saída: " + (a / b).ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }
}


/*
 * using System;
using System.Globalization;

namespace uri1116 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0) {
                    Console.WriteLine("divisao impossivel");
                }
                else {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture);
                }
            }
        }
    }
}
*/
