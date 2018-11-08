using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            int qte;
            Produto P;

            CultureInfo culture = new CultureInfo("us");

            Console.WriteLine("Digite os dados do produto: ");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");            
            double preco = Convert.ToDouble(Console.ReadLine(), culture);

            Console.Write("Quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            P = new Produto(nome, preco, quantidade);

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
