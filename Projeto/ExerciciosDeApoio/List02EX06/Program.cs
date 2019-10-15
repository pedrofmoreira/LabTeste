using System;
using System.Globalization;

namespace List02EX06
{
    class Program
    {
        static void Main(string[] args)
        {
            double Intervalo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Intervalo >= 0 && Intervalo <= 25.00)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (Intervalo > 25.00 && Intervalo <= 50.00)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (Intervalo > 50.00 && Intervalo <= 75.00)
            {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (Intervalo > 75.00 && Intervalo <= 100.00)
            { 
                Console.WriteLine("Intervalo [75,100]");
            }
            else
            {
                Console.WriteLine("Fora do Intervalo");
                
            }
        }
    }
}

/*
 * using System;
using System.Globalization;

namespace uri1037 {
    class Program {
        static void Main(string[] args) {

            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (numero <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (numero <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (numero <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            }
            else {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}
*/

        
    

