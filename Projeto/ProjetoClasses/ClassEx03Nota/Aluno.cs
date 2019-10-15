
namespace ClassEx03Nota
{
    class Aluno
    {
        public string Nome;
        public double Not1;
        public double Not2;
        public double Not3;
        public double  Tri = 60.00;


        public double NotaFinal()
        {
            return Not1 + Not2 + Not3;
        }

        public double TriResultado()
        {
            return Tri - NotaFinal();
        }
        
    }
}

/*
 * namespace Course {
class Aluno {
public string Nome;
public double Nota1, Nota2, Nota3;
public double NotaFinal() {
return Nota1 + Nota2 + Nota3;
}
public bool Aprovado() {
if (NotaFinal() >= 60.0) {
return true;
}
else {
return false;
}
}
public double NotaRestante() {
if (Aprovado()) {
return 0.0;
}
else {
return 60.0 - NotaFinal();
}
}
}
}

*/