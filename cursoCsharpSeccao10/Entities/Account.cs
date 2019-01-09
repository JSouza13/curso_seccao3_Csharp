
namespace cursoCsharpSeccao10
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        // A palavra "virtual" é utilizada para identificar
        // que aquela função pode ser sobreescrita.
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0; 
        }
       
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
