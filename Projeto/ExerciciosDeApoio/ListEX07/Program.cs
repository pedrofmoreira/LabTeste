using System;

namespace ListEX07
{
    class Program
    {
        static void Main(string[] args)
        {
           int X = int.Parse(Console.ReadLine());
            if (X % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
        }
    }
}

/*
 using System;

namespace cond02 {
    class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            if (N % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }
        }
    }
}
 */
