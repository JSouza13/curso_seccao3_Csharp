using System;
using System.Globalization;
using System.Collections.Generic;

namespace cursoSeccao3Csharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fornecedor fornecedor;
            Produto produto;

            fornecedor = new Fornecedor("Lojas Ltda", "Lojas@gmail.com", "3273-3837");
            produto = new Produto("Tv", 1000.00, fornecedor);

            Console.WriteLine(produto);

            Console.ReadLine();
        }
    }
}
