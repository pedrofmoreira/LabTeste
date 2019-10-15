using System;
using System.Globalization;

namespace ListEXE04
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Informe seu número:");
          int numbFun = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de horas:");
            double horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da hora:");
            double valorH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salario = horas * valorH;
            Console.WriteLine("O salário do funcionário é: U$ " + salario.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}

/*
 using System;
using System.Globalization;

namespace uri1008 {
    class Program {
        static void Main(string[] args) {

            int numero, horas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
 */
