using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    internal class Product
    {
        public int ProductId { get; }
        public string Name { get; }
        public double Price { get; }

        public Product(int productId, string name, double price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }
    }
}
