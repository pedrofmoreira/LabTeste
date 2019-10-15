using System;
using System.Globalization;

namespace ClassEstEX01
{
    class Program
    {
        static void Main(string[] args)
        {
            double cot;            

            Console.WriteLine("Informe a cotação do dolar: ");
            cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar ");
            ConversorDeMoeda.quant = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("O Valor a ser pago é: " + ConversorDeMoeda.valor(cot).ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}

/*
 * using System;
using System.Globalization;
namespace Course {
class Program {
static void Main(string[] args) {
Console.Write("Qual é a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));
}
}

*/