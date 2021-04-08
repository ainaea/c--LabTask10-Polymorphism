namespace DeliveryApplication
{
    public class OvernightPackage : Package
    {
        // static int duration = 1;
        public OvernightPackage(string name, string sender, string receiver, int weight) : base(name, sender, receiver, weight)
        {}

        public override decimal CalculateCost()
        {
            return 15.0M + Weight * 0.08M;
        }
    }
}