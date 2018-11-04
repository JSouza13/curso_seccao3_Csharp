using System;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario funcionario;
            double aumento;

            funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            funcionario.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(funcionario);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.aumentarSalario(aumento);
            Console.WriteLine(funcionario);

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
