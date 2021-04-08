namespace DeliveryApplication
{
    public class OvernightPackage : Package
    {
        public OvernightPackage(string name, string sender, string receiver) : base(name, sender, receiver)
        {}

        public override decimal CalculateCost()
        {
            return 5.0M;
        }
    }
}