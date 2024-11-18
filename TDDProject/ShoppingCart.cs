namespace TDDProject
{
    public class ShoppingCart
    {
        private Dictionary<string, double> items = new Dictionary<string, double>();

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
            return sum;
        }
    }
}
