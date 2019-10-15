/*using System;
using System.Globalization;

namespace ClassEX02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.WriteLine("Informe o nome do funcionário: ");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário do funcionário: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.Write("Funcionário: " + f.Nome + ", $ " + f.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: ", f.Nome + ", $ " );
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
            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);
            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}