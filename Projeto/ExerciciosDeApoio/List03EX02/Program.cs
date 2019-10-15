using System;

namespace List03EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coord = Console.ReadLine().Split(' ');
            int eixoX = int.Parse(coord[0]);
            int eixoY = int.Parse(coord[1]);

            while (eixoX != 0 && eixoX != 0)
            {
               
                if (eixoX > 0 && eixoY > 0)
                {

                    Console.WriteLine("Primeiro");
                }
                else if (eixoX > 0 && eixoY < 0)
                {

                    Console.WriteLine("Quarto");
                }
                else if (eixoX < 0 && eixoY < 0)
                {

                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Segundo");
                }
                coord = Console.ReadLine().Split(' ');
                eixoX = int.Parse(coord[0]);
                eixoY = int.Parse(coord[1]);
            }
        }
    }
}

/*
 * using System;

namespace uri1115 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }
        }
    }
}
*/
