using System;
using System.Globalization;

namespace ClassExe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados atualizados: " + R);
           
        }
        
    }
}

/*
 * using System;
using System.Globalization;
namespace Course {
class Program {
static void Main(string[] args) {
Retangulo ret = new Retangulo();
Console.WriteLine("Entre a largura e altura do retângulo: ");
ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
}
}
}

    */