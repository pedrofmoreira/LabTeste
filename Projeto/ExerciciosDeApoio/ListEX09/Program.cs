using System;

namespace ListEX09
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] vet = Console.ReadLine().Split(" ");
            int Hin = int.Parse(vet[0]);
            int Hfin = int.Parse(vet[1]);
            int Total = 0;
            if (Hfin <= 12)
            {
                Total = 24 + (Hfin - Hin);
            }
            else
            {
                Total = Hfin - Hin;
            }
            Console.WriteLine("O Jogo Durou " + Total + " Horas");
        }
    }
}

/*
 * using System;

namespace uri1046 {
    class Program {
        static void Main(string[] args) {

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal) {
                duracao = horaFinal - horaInicial;
            }
            else {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
 * 
 */
