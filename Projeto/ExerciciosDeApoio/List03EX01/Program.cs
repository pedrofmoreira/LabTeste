using System;

namespace List03EX01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma senha:");
            int x = int.Parse(Console.ReadLine());
            
            while (x != 2002)    
            {               
             Console.WriteLine("Senha inválida");
             x = int.Parse(Console.ReadLine());
             }
             Console.WriteLine("Acesso Permitido");
        }
    }
}

/*
 * using System;

namespace uri1114 {
    class Program {
        static void Main(string[] args) {

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}

    */