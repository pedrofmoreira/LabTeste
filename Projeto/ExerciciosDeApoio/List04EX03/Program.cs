/* using System;
using System.Globalization;

namespace List04EX03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] M = Console.ReadLine().Split(' ');


            double MP1;
            double MP2;
            double MP3;


            for (int i = 1; i <= N; i++)
            {
                if (i == 1)
                {
                    double Ent1 = double.Parse(M[0], CultureInfo.InvariantCulture);
                    double Ent2 = double.Parse(M[1], CultureInfo.InvariantCulture);
                    double Ent3 = double.Parse(M[2], CultureInfo.InvariantCulture);
                    MP1 = ((Ent1 * 2) + (Ent2 * 3) + (Ent3 * 5)) / (2 + 3 + 5);
                    Console.WriteLine("O Valor da primeira saída é: " + MP1.ToString("F1"));
                    Console.WriteLine();
                }
                else if (i == 2)
                {
                    double Ent1 = double.Parse(M[0], CultureInfo.InvariantCulture);
                    double Ent2 = double.Parse(M[1], CultureInfo.InvariantCulture);
                    double Ent3 = double.Parse(M[2], CultureInfo.InvariantCulture);
                    MP2 = ((Ent1 * 2) + (Ent2 * 3) + (Ent3 * 5)) / (2 + 3 + 5);
                    Console.WriteLine("O Valor da primeira saída é: " + MP2.ToString("F1"));
                    Console.WriteLine();
                }
                else
                {
                    double Ent1 = double.Parse(M[0], CultureInfo.InvariantCulture);
                    double Ent2 = double.Parse(M[1], CultureInfo.InvariantCulture);
                    double Ent3 = double.Parse(M[2], CultureInfo.InvariantCulture);
                    MP3 = ((Ent1 * 2) + (Ent2 * 3) + (Ent3 * 5)) / (2 + 3 + 5);
                    Console.WriteLine("O Valor da primeira saída é: " + MP3.ToString("F1"));
                    Console.WriteLine();
                }
            }

        }
    }
}
*/
using System;
using System.Globalization;

namespace uri1079
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                string[] line = Console.ReadLine().Split(' ');
                double a = double.Parse(line[0], CultureInfo.InvariantCulture);
                double b = double.Parse(line[1], CultureInfo.InvariantCulture);
                double c = double.Parse(line[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}