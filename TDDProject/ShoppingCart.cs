namespace TDDProject
{
    public class ShoppingCart
    {
        private Dictionary<string, double> items = new Dictionary<string, double>();

        public double Discount { get; private set; } = 0;

        public void AddItem(string item, double price)
        {
            if (price < 0.01) return;
            if (price >= double.MaxValue) return;

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
            if (items.Count == 0) return 0;

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
            if (discount < 0) {Discount = 0; return;}
            if (discount > 1) {Discount = 1; return;}
            Discount = discount;
        }
    }
}
