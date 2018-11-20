using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    class Tela
    {
        // Metodo Estático, ou seja, ele existe independentemente de instanciar o objeto.
        public static Retangulo lerRetangulo()
        {
            Console.Write("Largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            return new Retangulo(largura, altura);
        }

        // Metodo Estático, ou seja, ele existe independentemente de instanciar o objeto.
        public static Triangulo lerTriangulo()
        {
            Console.Write("Lado A: ");
            double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado B: ");
            double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Lado C: ");
            double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            return new Triangulo(ladoA, ladoB, ladoC);
        }
    }
}
