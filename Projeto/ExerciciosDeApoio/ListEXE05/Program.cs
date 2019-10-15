using System;
using System.Globalization;

namespace ListEXE05
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] vect = Console.ReadLine().Split(' ');
            int cod = int.Parse(vect[0]);
            int num = int.Parse(vect[1]);
            double valor = double.Parse(vect[2], CultureInfo.InvariantCulture);

            string[] vect2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vect2[0]);
            int num2 = int.Parse(vect2[1]);
            double valor2 = double.Parse(vect2[2], CultureInfo.InvariantCulture);  
            
            double subtotal = num * valor;
            double subtotal2 = num2 * valor2;
            double total = subtotal + subtotal2; 
            
            Console.WriteLine("O Valor a pagar é: R$ "+ total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

/*
 using System;
using System.Globalization;

namespace uri1010 {
    class Program {
        static void Main(string[] args) {

            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
 */
