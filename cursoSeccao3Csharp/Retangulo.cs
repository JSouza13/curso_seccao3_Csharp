using System.Globalization;

namespace cursoSeccao3Csharp
{
    // Retangulo é uma sub classe de Figura
    class Retangulo : Figura
    {
        public double largura { get; set; }
        public double altura { get; set; }

        // ": base ()" chama automaticamente o contrutor da classe pai
        public Retangulo(double largura, double altura) //: base(cor)
        {
            this.largura = largura;
            this.altura = altura;
        }

        // Sobre posição do metodo area da Classe Figura
        public double area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return 2*(largura*altura);
        }
    }
}
