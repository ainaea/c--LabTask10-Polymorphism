using System;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var savings1 = new SavingsAccount("Adebola Samson", 6700M, 0.12M);
            var savings2 = new SavingsAccount("Usman Danfodio", 9800M, 0.09M);
            var current1 = new CurrentAccount("Alex Ekpoma", 3900M);
            var current2 = new CurrentAccount("James Stuart", 9900M);

            Account[] allAccount = {savings1, savings2, current1, current2};

            foreach (var account in allAccount)
            {
                Console.WriteLine($"\nEnter amount to withdraw from {account.Name}: ");
                decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                account.Debit(withdraw);

                Console.WriteLine($"Enter amount to deposit into {account.Name}: ");
                decimal deposit = Convert.ToDecimal(Console.ReadLine());
                account.Credit(deposit);

                if (account is SavingsAccount)
                    {
                        SavingsAccount castedAccount = (SavingsAccount) account;
                        castedAccount.CalculateInterest();
                    }
                Console.WriteLine($"Balance from account.Balance is {account.Balance:C}");                    
                }

        }
    }
}
