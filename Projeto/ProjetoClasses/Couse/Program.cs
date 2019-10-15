/*using System;

namespace Couse
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa A, B, H, M;

            A = new Pessoa();
            B = new Pessoa();
            H = new Pessoa();
            M = new Pessoa();


            A.A = int.Parse(Console.ReadLine());
            B.B = int.Parse(Console.ReadLine());
            M.M = Console.ReadLine();
            H.H = Console.ReadLine();

            if (A.A > B.B)
            {
                Console.WriteLine(M.M);
            }
            else
            {
                Console.WriteLine(H.H);
            }

        }
    }
}
*/

using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());
            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + p2.Nome);
            }
        }
    }
}