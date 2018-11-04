using System.Globalization;

namespace cursoSeccao3Csharp
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public double area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return (largura + altura) * 2;
        }

        public double diagonal()
        {
            return System.Math.Sqrt((largura * largura) + (altura * altura));
        }

        //Sobrecarregar o método ToString para retornar uma String do meu Objeto
        public override string ToString()
        {
            return "AREA: "
                + area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERIMETRO: "
                + perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL: "
                + diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
