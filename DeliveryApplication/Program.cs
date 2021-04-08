using System;

namespace DeliveryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Package[] packages = {new OvernightPackage("Ade Adeayo", "68, Atan, Ota", "56, Kuto, Abeokuta", 15), new OvernightPackage("Samson Michael", "12, Ojo, Ibadan", "256, Saki", 2), new TwoDayPackage("Salahudeen Mustapha", "8, Ota, Ogun State", "56, Ojo, Ibadan, Oyo State", 30),  new TwoDayPackage("Fagbemi Faleye", "78, Adewole Estate, Ilorin, Kwara State", "23, Ojo, Ibadan, Oyo State", 5)}; 

            decimal totalCost = 0.0M;
            foreach (var package in packages)
            {
                Console.WriteLine(package);
                totalCost += package.CalculateCost();
            }
            Console.WriteLine($"Cost of all packages: {totalCost:C}");
        }
    }
}
