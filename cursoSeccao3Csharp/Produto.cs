using System.Globalization;
namespace cursoSeccao3Csharp
{
    class Produto
    {
        // Encapsulamento
        public string nome { get; private set; }
        // Forma alternativa de encapsulamento
        public double preco { get; private set; }
        public int quantidadeEmEstoque { get; private set; }
        public Fornecedor fornecedor { get; private set; }

        ////Função ler um atributo para fora da classe
        //public string getNome()
        //{
        //    return this.nome;
        //}

        //// Permite alterar o atributo fora da minha classe
        //public void setNome(string nome)
        //{
        //    this.nome = nome;
        //}

        public Produto(string nome, double preco, int quantidadeEmEstoque, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
            this.fornecedor = fornecedor;
        }

        // Sobrecarga do construtor 
        public Produto(string nome, double preco, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.preco = preco;
            quantidadeEmEstoque = 0;
            this.fornecedor = fornecedor;
        }

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
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + ", Fornecedor: "
                + fornecedor;
        }
    }
}
