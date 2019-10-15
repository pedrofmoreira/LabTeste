using System;

namespace ListEXE03
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Informe o Valor para A:");
           int A = int.Parse(Console.ReadLine());
           Console.WriteLine("Informe o Valor para B:");
           int B = int.Parse(Console.ReadLine());
           Console.WriteLine("Informe o Valor para C:");
           int C = int.Parse(Console.ReadLine());
           Console.WriteLine("Informe o Valor para D:");
           int D = int.Parse(Console.ReadLine());
           int DIFERENCA = (A * B - C * D);
           Console.WriteLine("A Diferença é: " + DIFERENCA);
        }
    }
}

/*
 using System;

namespace uri1007 {
    class Program {
        static void Main(string[] args) {

            int A, B, C, D, dif;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine("DIFERENCA = " + dif);
        }
    }
}
*/