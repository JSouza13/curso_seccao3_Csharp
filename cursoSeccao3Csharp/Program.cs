using System;
using System.Globalization;
using System.Collections.Generic;

namespace cursoSeccao3Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("Tv", 900.00));
            lista.Add(new Produto("Aspirador", 400.00));
            lista.Add(new Produto("Telefone", 700.00));
            lista.Add(new Produto("Geladeira", 2000.00));

            int pos = lista.FindIndex(x => x.nome == "Aspirador");
            Console.WriteLine("Posição encontrada = " + pos);

            for(int i = 0; i<lista.Count;i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
