namespace Patterns
{
    public class CarInfo
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public CarInfo(string brand, string model, int amount, double price)
        {
            Brand = brand;
            Model = model;
            Amount = amount;
            Price = price;
        }
    }
}
