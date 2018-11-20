using System;
using System.Collections.Generic;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Quantas figuras você vai digitar? ");
            int numeroFiguras = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numeroFiguras; i++)
            {
                Console.Write("Figura " + i + " - triângulo ou retângulo (t/r)? ");
                char escolhaFigura = char.Parse(Console.ReadLine());
                if (escolhaFigura == 'r' || escolhaFigura == 'R')
                {
                    // Métodos estáticos
                    Figura figura = Tela.lerRetangulo();
                    lista.Add(figura);
                }
                else
                {
                    // Métodos estáticos
                    Figura figura = Tela.lerTriangulo();
                    lista.Add(figura);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Áreas das figuras: ");
            for (int i = 1; i <= numeroFiguras; i++)
            {
                Console.WriteLine("Figura " + i + ": " + lista[i - 1].area().ToString("F1", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }
    }
}
