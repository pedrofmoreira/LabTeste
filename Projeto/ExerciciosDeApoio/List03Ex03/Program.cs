using System;

namespace List03Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um Código de combustível");
            int C = int.Parse(Console.ReadLine());
            int Alcool = 0;
            int Gasolina = 0;
            int Diesel = 0;

            while(C <= 4 )            
            {              
            if (C == 1)
            {
                Alcool +=1;                
            }
            else if (C == 2)
            {
                Gasolina += 1;         
            }
            else if (C == 3)
            {
                    Diesel += 1;                  
            }
            else
            {
                    Console.WriteLine("Fim");
            }
                Console.WriteLine("Favor Digitar um novo código: ");
                C = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ácool: " + Alcool);
            Console.WriteLine("Gasolina: " + Gasolina);
            Console.WriteLine("Diesel: " + Diesel);
            Console.WriteLine("Muito Obrigado");
        }
    }
}
/*
 * using System;

namespace uri1134 {
    class Program {
        static void Main(string[] args) {

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4) {
                if (tipo == 1) {
                    alcool = alcool + 1;
                }
                else if (tipo == 2) {
                    gasolina = gasolina + 1;
                }
                else if (tipo == 3) {
                    diesel = diesel + 1;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
 * */
