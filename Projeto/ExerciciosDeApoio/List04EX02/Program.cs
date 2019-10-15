using System;

namespace List04EX02
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int i;
            
            for (i = 1 ; i <= X; i++)
            {
                if( i % 2 != 0)
                {               
                Console.WriteLine(i);
                }
                
            }
            
        }
    }
}

/*
 * using System;

namespace uri1067 {
    class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

    */