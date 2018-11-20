using System;

namespace cursoSeccao3Csharp
{
    // Triangulo é uma sub classe de Figura
    internal class Triangulo : Figura
    {
        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }

        // ": base ()" chama automaticamente o contrutor da classe pai
        public Triangulo(double ladoA, double ladoB, double ladoC) //: base(cor)   
        {
            this.ladoA = ladoA;
            this.ladoB = ladoB;
            this.ladoC = ladoC;
        }

        // Sobre posição do metodo area da Classe Figura
        public double area()
        {
            double p = (ladoA + ladoB + ladoC) / 2.0;
            return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC));
        }

        public double perimetro()
        {
            return ladoA + ladoB + ladoC;
        }
    }
}
