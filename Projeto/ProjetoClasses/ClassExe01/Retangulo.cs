using System;
using System.Globalization;


namespace ClassExe01
{
    class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
        public override string ToString()
        {
            return

                "AREA =" + Area().ToString("F2", CultureInfo.InvariantCulture)
               + " "
               + "PERÍMETRO =" + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
               + " "
               + "DIAGONAL =" + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

/*
 * using System;
namespace Course {
class Retangulo {
public double Largura;
public double Altura;
public double Area() {
return Largura * Altura;
}
public double Perimetro() {
return 2 * (Largura + Altura);
}
public double Diagonal() {
return Math.Sqrt(Largura * Largura + Altura * Altura);
}
}
}
*/
  


