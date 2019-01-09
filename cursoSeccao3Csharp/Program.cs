using System;
using System.Collections.Generic;
using System.Globalization;

namespace cursoSeccao3Csharp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Limite de saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta novaConta = new Conta(numero, titular, limite);

            Console.Write("\nInforme um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            novaConta.depositar(valorDeposito);
            Console.WriteLine("Novo saldo = R$ " + novaConta.saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("\nInforme um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Tenta executar o bloco
            try
            {
                novaConta.sacar(valorSaque);
                Console.WriteLine("Novo saldo = R$ " + novaConta.saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            // Se acontecer algum erro, ele captura e retorna a mensagem
            catch (OperacaoException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
