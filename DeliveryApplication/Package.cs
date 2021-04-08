namespace DeliveryApplication
{
    public abstract class Package
    {
        public string Name { get; private set; }
        public string SendersAddress { get; private set; }
        public string ReceiversAddress { get; private set; }

        private int weight;
        public Package(string name, string sender, string receiver, int weight)
        {
            Name = name;
            SendersAddress = sender;
            ReceiversAddress = receiver;
            Weight = weight;
        }
        public int Weight
        {
            get { return weight; }
            set {
                if (value > 0)
                {
                     weight = value; 
                }else
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
        }
        

        public abstract decimal CalculateCost();

        public override string ToString()
        {
            return $"Package from: {this.SendersAddress}\nTo: {this.ReceiversAddress}\nDelivery cost: {this.CalculateCost():C}\n";
        }
    }
}