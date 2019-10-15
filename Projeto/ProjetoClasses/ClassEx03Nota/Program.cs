using System;
using System.Globalization;

namespace ClassEx03Nota
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno A = new Aluno();
                        
            Console.WriteLine("Informe o Nome do Aluno");
            A.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três Notas: ");
            A.Not1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            A.Not2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.Not3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (A.NotaFinal() >= 60.00)
            {
                Console.WriteLine("NOTA FINAL: " + A.NotaFinal().ToString("F2"),CultureInfo.InvariantCulture);
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL: " + A.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM: " + A.TriResultado().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");

            }
            
        }
    }
}


/*
 * 
 using System;
using System.Globalization;
namespace Course {
class Program {
static void Main(string[] args) {
Aluno aluno = new Aluno();
Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno:");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("NOTA FINAL = "
+ aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
if (aluno.Aprovado()) {
Console.WriteLine("APROVADO");
}

    */