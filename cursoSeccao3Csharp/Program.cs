using System;
using System.Globalization;
using System.Collections.Generic;

namespace cursoSeccao3Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras você vai digitar? ");
            int numeroFiguras = int.Parse(Console.ReadLine());

            for(int i =1; i<=numeroFiguras;i++)
            {
                Console.Write("Figura " + i + " - triângulo ou retângulo (t/r)? ");
                char escolhaFigura = char.Parse(Console.ReadLine());
                if(escolhaFigura == 'r' || escolhaFigura == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Figura figura = new Retangulo(largura, altura, "Preto");
                    lista.Add(figura);
                }
                else
                {
                    Console.Write("Lado A: ");
                    double ladoA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado B: ");
                    double ladoB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Lado C: ");
                    double ladoC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Figura figura = new Triangulo(ladoA, ladoB, ladoC, "Azul");
                    lista.Add(figura);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Áreas das figuras: ");
            for(int i=1; i<=numeroFiguras; i++)
            {
                Console.WriteLine("Figura " + i + ": " + lista[i-1].area());
            }
            Console.ReadLine();
        }
    }
}
