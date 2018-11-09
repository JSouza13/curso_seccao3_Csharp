using System.Globalization;
namespace cursoSeccao3Csharp
{
    class Produto
    {
        // Encapsulamento, essa forma é muito utilizada em Java
        private string nome;

        // Forma alternativa de encapsulamento, forma utilizada para tratar encapsulamento no c#
        public double preco {get; private set;}
        private int quantidadeEmEstoque;

        //Função ler um atributo para fora da classe
        public string getNome()
        {
            return this.nome;
        }

        // Permite alterar o atributo fora da minha classe
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public Produto(string nome, double preco, int quantidadeEmEstoque)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        // Sobrecarga de função  
        public Produto(string nome, double preco)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidadeEmEstoque = 0;
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
                + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
