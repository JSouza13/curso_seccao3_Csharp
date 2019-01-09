
namespace cursoSeccao3Csharp
{
    internal class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; private set; }
        public double limiteDeSaque { get; set; }

        public Conta(int numero, string titular, double limiteDeSaque)
        {
            this.numero = numero;
            this.titular = titular;
            this.limiteDeSaque = limiteDeSaque;
            saldo = 0.0;
        }

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public void sacar(double valor)
        {
            if (saldo < valor)
            {
                throw new OperacaoException("Não há saldo suficiente! Saque cancelado.");
            }
            else if (valor > limiteDeSaque)
            {
                throw new OperacaoException("Valor do saque é superior ao limite da conta! Saque cancelado.");
            }
            else
            {
                saldo -= valor;
            }
        }
    }
}
