﻿using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int qte;
            Produto P;

            P = new Produto();

            Console.WriteLine("Digite as informações do Produto: ");
            Console.Write("Nome: ");
            P.nome = Console.ReadLine();
            Console.Write("Preço: ");
            P.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            P.quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarEntrada(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

            Console.WriteLine();
            Console.Write("Digite a quantidade de produtos que saíram do estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarSaida(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P);

            Console.ReadLine();
        }
    }
}
