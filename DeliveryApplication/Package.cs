namespace DeliveryApplication
{
    public abstract class Package
    {
        public string Name { get; private set; }
        public string SendersAddress { get; private set; }
        public string ReceiversAddress { get; private set; }

        public Package(string name, string sender, string receiver)
        {
            Name = name;
            SendersAddress = sender;
            ReceiversAddress = receiver;
        }

        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"Package from: {this.SendersAddress}\nTo: {this.ReceiversAddress}\nDelivery cost: {this.CalculateCost():C}\n";
        }
    }
}