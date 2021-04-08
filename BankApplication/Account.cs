namespace BankApplication
{
    public abstract class Account
    {
        public string Name { get; private set; }
        private decimal balance;
        public Account(string name, decimal openingBalance)
        {
            Name = name;
            Balance = openingBalance;
        }
        public decimal Balance
        {
            get { return balance; }
            private set {
                if (value > 0)
                {
                    balance = value; 
                }else
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
        }

        public void Debit(decimal amount)
        {
            if (amount > 0 && amount < Balance)
            {
                Balance -= amount;
                System.Console.WriteLine($"Withdrawal of {amount:C} successful");
            }else
            {
                System.Console.WriteLine($"Withdrawal attempt of {amount:C} NOT successful");                
            }
            System.Console.WriteLine($"Current balance is {Balance:C}");

        }

        public void Credit(decimal amount)
        {
            if (amount > 0 )
            {
                Balance += amount;
                System.Console.WriteLine($"Deposit of {amount:C} successful");
            }else
            {
                System.Console.WriteLine($"Deposit attempt of {amount:C} NOT successful");                
            }
            System.Console.WriteLine($"Current balance is {Balance:C}");
        }
        
    }
}