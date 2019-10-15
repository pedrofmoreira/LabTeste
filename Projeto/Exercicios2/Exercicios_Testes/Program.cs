using System;
using System.Globalization;

namespace Exercicios_Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeComp = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem a sua casa?");
            int qt = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double prod = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura:");
            string[] info = Console.ReadLine().Split(' ');
            string nome = info[0];
            int idade = int.Parse(info[1]);
            double altura = double.Parse(info[2], CultureInfo.InvariantCulture);
            Console.WriteLine(nomeComp);
            Console.WriteLine(qt);            
            Console.WriteLine(prod.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }                  
    }
}
