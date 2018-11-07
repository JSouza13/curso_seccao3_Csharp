using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno;            

            aluno = new Aluno();

            aluno.nome = Console.ReadLine();
            aluno.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno);

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + P);

            //Console.WriteLine();
            //Console.Write("Digite a quantidade de produtos que entraram no estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //P.realizarEntrada(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + P);

            //Console.WriteLine();
            //Console.Write("Digite a quantidade de produtos que saíram do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //P.realizarSaida(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + P);

            Console.ReadLine();
        }
    }
}
