using System;

namespace ListEXE06
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = int.Parse(Console.ReadLine());
               if (x >=0) {
                Console.WriteLine("NÃO NEGATIVO");
                          }
               else
               {           
                Console.WriteLine("NEGATIVO");
                }
        }
    }
}

/*
 using System;

namespace cond01 {
    class Program {
        static void Main(string[] args) {


            int N = int.Parse(Console.ReadLine());

            if (N < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }
        }
    }
}
 */
