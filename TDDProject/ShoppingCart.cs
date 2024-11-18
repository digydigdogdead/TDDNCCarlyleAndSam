namespace TDDProject
{
    public class ShoppingCart
    {
        private Dictionary<string, double> items = new Dictionary<string, double>();

        public double Discount { get; private set; } = 0;

        public void AddItem(string item, double price)
        {
            if (items.ContainsKey(item))
            {
                items[item] += price;
            }
            else
            {
                items.Add(item, price);
            }
        }

        public double GetTotalPrice() 
        {
            double sum = 0;
            foreach (var price in items.Values)
            {
                sum += price;
            }
            double reduction = 1 - Discount;
            return sum * reduction;
        }

        public void ApplyDiscount(double discount) 
        {
            Discount = discount;
        }
    }
}
