namespace DeliveryApplication
{
    public class TwoDayPackage : Package
    {
        public TwoDayPackage(string name, string sender, string receiver) : base(name, sender, receiver)
        {}
        public override decimal CalculateCost()
        {
            return 7.50M;
        }
    }
}