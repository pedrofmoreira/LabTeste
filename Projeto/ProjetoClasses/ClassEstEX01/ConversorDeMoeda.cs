using System;
using System.Collections.Generic;
using System.Text;

namespace ClassEstEX01
{
    class ConversorDeMoeda
    {
        public static double IOF = 6.00;
        public static double quant;

        public static double valor(double cot)
        {
            return quant * cot + quant * cot * IOF / 100.00 ;
        }
    }
}

/*
 * namespace Course {
class ConversorDeMoeda {
public static double Iof = 6.0;
public static double DolarParaReal(double quantia, double cotacao) {
double total = quantia * cotacao;
return total + total * Iof / 100.0;
}
}
}
*/