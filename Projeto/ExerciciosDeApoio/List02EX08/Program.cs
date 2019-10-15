/*using System;
using System.Globalization;

namespace List02EX08
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double TX8 = 0.08;
            double TX18 = 0.18;
            double TX28 = 0.28;
            double Rend02 = 3000.00 - 2000.00;
            double Rend03 = 4500.00 - 3000.00;
            double Rend04 = 4500.00;
                                                  
            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if (salario >= 2000.01 && salario < 3000.00)
            {
                salario = (salario - Rend02) * TX8;
                Console.WriteLine(salario.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 3000.01 && salario < 4500.00)
            {
                salario = ((salario - Rend03) * TX18);
                Console.WriteLine(salario.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 4500.00)
            {   
                salario = (salario -Rend04)* TX28;
                                             
                Console.WriteLine(salario.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Valor Incorreto");
            }
        }
    }
}
*/
using System;
using System.Globalization;

namespace uri1051
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto;
            if (salario <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.0)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0)
            {
                imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}