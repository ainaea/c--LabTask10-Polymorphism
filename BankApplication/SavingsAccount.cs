namespace BankApplication
{
    public class SavingsAccount : Account
    {
        private decimal interestRate;

        public SavingsAccount(string name, decimal openingBalance, decimal interestRate) : base(name, openingBalance)
        {
            InterestRate = interestRate;
        }
        public decimal InterestRate
        {
            get { return interestRate; }
            private set {
                    if (value > 0 && value <1)
                    {
                        interestRate = value; 
                    }else
                    {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
        }

        public void CalculateInterest()
        {
            System.Console.Write("Interest paid as ");
            this.Credit( InterestRate * Balance );
        }
        
    }
}