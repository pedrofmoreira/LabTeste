using System;

namespace List04EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor para N para começar: ");
            int N = int.Parse(Console.ReadLine());
            int x = 0;
            int y = 0;
            int entrada = 0;
            int saida = 0;

            for(y=1;y<=N;y++)
            {
                Console.WriteLine("Digite um novo número:");
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    entrada += 1;
                }
                else
                {
                    saida += 1;
                }
            }
            Console.WriteLine(entrada + " in");
            Console.WriteLine(saida + " out");
        }
    }
}

/*
 * using System;

namespace uri1072 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int cont_in = 0;
            int cont_out = 0;

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    cont_in = cont_in + 1;
                }
                else {
                    cont_out = cont_out + 1;
                }
            }

            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");
        }
    }
}

    */