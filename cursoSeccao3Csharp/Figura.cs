using System;

namespace cursoSeccao3Csharp
{
    // Super Classe
    abstract class Figura
    {

        public string cor { get; set; }

        public Figura(string cor)
        {
            this.cor = cor;
        }

        public abstract double area();
        public abstract double perimetro();
    }
}
