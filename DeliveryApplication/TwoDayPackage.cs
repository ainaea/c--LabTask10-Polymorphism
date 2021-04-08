namespace DeliveryApplication
{
    public class TwoDayPackage : Package
    {
        // static int duration = 2;
        public TwoDayPackage(string name, string sender, string receiver, int weight) : base(name, sender, receiver, weight)
        {}
        public override decimal CalculateCost()
        {
            return 7.50M + Weight * 0.05M;
        }
    }
}