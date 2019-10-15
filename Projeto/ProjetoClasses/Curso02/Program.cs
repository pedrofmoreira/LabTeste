/*

using System;
using System.Globalization;

namespace Curso02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;

            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("informe o Nome do Funcionário 1:");
            x.N = Console.ReadLine();
            Console.WriteLine("informe o Salário do Funcionário 1:");
            x.S = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("informe o Nome do Funcionário 2:");
            y.N = Console.ReadLine();
            Console.WriteLine("informe o Salário do Funcionário 2:");
            y.S = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O Salário Médio é: " + ((x.S + y.S) /2).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

*/
using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double media = (f1.Salario + f2.Salario) / 2.0;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}