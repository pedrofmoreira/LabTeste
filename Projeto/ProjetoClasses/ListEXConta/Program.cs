/*

using System;
using System.Globalization;

namespace ListEXConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta cont = new Conta();

            Console.Write("Entre o número da conta: ");
            cont.Nconta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o titular da conta: ");
            cont.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            cont.Dinicial = bool.Parse(Console.ReadLine());

            if (cont.Dinicial == true)
            {
                Console.Write("Entre com o depósito inicial: ");
                cont.Vdeposito = double.Parse(Console.ReadLine());
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine("Conta: " + cont.Nconta + ", Titular: " + cont.Nome + ", Saldo: $ " + cont.Saldo.ToString("f2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Dados da conta: ");
                Console.WriteLine("Conta: " + cont.Nconta + ", Titular: " + cont.Nome + ", Saldo: $ " + cont.Saldo.ToString("f2", CultureInfo.InvariantCulture));
            }

            Console.Write("Entre um valor para depósito: ");
            cont.Vdeposito = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Conta: " + cont.Nconta + ", Titular: " + cont.Nome + ", Saldo: $ " + cont.Saldo.ToString("f2", CultureInfo.InvariantCulture));

            Console.Write("Entre um valor para saque: ");

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Conta: " + cont.Nconta + ", Titular: " + cont.Nome + ", Saldo: $ " + cont.Saldo.ToString("f2", CultureInfo.InvariantCulture));


        }
    }
}
*/

using System;
using System.Globalization;

namespace ListEXConta
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine()); // variável temporária

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine(); // variável temporária

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
             Console.Write("Entre o valor do depósito inicial: ");
             double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  // variável temporária
                conta = new ContaBancaria(numero, titular, depositoInicial); // informar as variaveis temporárias que serão utilizadas.
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta");
            Console.WriteLine(conta);
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //outra variavel temporaria para ser utilizada no método
            conta.Deposito(quantia);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
         
            Console.Write("Entre um valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //outra variavel temporaria para ser utilizada no método
            conta.Saque(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);


        }
    } 
}
















