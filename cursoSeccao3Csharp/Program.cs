using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto[] vet;
            double soma, media;
            int N;

            N = int.Parse(Console.ReadLine());
            vet = new Produto[N];

            for (int i = 0; i < N; i++)
            {
                string nome = Console.ReadLine();
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, valor);
            }

            soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma += vet[i].preco;
            }

            media = soma / N;

            Console.WriteLine("PREÇO MÉDIO = R$ " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
