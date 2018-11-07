using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    class Aluno
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;

        public double notaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public double diferencaNota()
        {
            return 60 - notaFinal();
        }

        public string Status()
        {
            if (notaFinal() > 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO" + "\nFALTARAM " + diferencaNota().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }
        }

        //Sobrecarregar o método ToString para retornar uma String do meu Objeto
        public override string ToString()
        {
            return "NOTA FINAL = "
                + notaFinal().ToString("F2", CultureInfo.InvariantCulture)
                + "\n"
                + Status();
        }
    }
}
