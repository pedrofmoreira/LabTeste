using System;

namespace List04Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int i;
            int count = 1;

            for (i = 1; (i <= n); i++)
            {

                count = count * i;

            }
            Console.WriteLine(count);
        }
    }
    
}

/*
 * using System;

namespace uri1153 {
    class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++) {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}
*/
