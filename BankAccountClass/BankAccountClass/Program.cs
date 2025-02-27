namespace BankAccountClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount account1 = new BankAccount(-50);
            BankAccount account1 = new BankAccount(50);
            account1.ShowBalance();
            account1.Deposit(50);
            account1.Withdraw(30);
            account1.Withdraw(150);
        }
        class BankAccount
        {
            private decimal balance;

            public BankAccount(decimal Balance)
            {
                if (Balance >= 0)
                {
                    balance = Balance;
                }
                else
                {
                    Console.WriteLine("Balans menfi ola bilmez,0 teyin olundu.");
                    balance = 0;
                }
            }

            public void Deposit(decimal amount)
            {
                if (amount > 1)
                {
                    balance += amount;
                    Console.WriteLine($"Hesaba {amount} AZN elave olundu. Yeni balans: {balance} AZN-dir.");
                }
                else
                {
                    Console.WriteLine("Minimum 1 AZN!");
                }
            }

            public void Withdraw(decimal amount)
            {
                if (amount > 0)
                {
                    if (amount <= balance)
                    {
                        balance = balance - amount;
                        Console.WriteLine($"Hesabdan {amount} AZN cixarildi. Yeni balans: {balance} AZN-dir.");
                    }
                    else
                    {
                        Console.WriteLine("Balansda kifayet qeder mebleg yoxdur!");
                    }
                }
                else
                {
                    Console.WriteLine("Cixaris meblegi musbet olmalidir!");
                }
            }

            public void ShowBalance()
            {
                Console.WriteLine($"Cari balans: {balance} AZN-dir");
            }
        }
    }
}
