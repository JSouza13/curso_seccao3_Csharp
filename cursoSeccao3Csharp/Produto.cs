﻿using System.Globalization;
namespace cursoSeccao3Csharp
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidadeEmEstoque;

        public double valorTotalEmEstoque()
        {
            return preco * quantidadeEmEstoque;
        }

        public void realizarEntrada(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque + quantidade;
        }

        public void realizarSaida(int quantidade)
        {
            quantidadeEmEstoque = quantidadeEmEstoque - quantidade;
        }

        //Sobrecarregar o método ToString para retornar uma String do meu Objeto
        public override string ToString()
        {
            return nome
                + ", R$ "
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + quantidadeEmEstoque
                + " unidades, Total: R$ "
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}