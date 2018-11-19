using System.Globalization;

namespace cursoSeccao3Csharp
{
    // Retangulo é uma sub classe de Figura
    class Retangulo : Figura
    {
        public double largura { get; set; }
        public double altura { get; set; }

        public Retangulo(double largura, double altura, string cor) : base(cor)
        {
            this.largura = largura;
            this.altura = altura;
        }

        // Sobre posição do metodo area da Classe Figura
        public override double area()
        {
            return largura * altura;
        }

        public override double perimetro()
        {
            return 2*(largura*altura);
        }
    }
}
