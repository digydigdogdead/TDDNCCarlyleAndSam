using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class WarehouseInventory
    {
        public Dictionary<int, Dictionary<int, int>> Locations { get; } = new Dictionary<int, Dictionary<int, int>>();

        public int GetTotalNumberOfProducts() { return 0; }
        public void AddLocation()
        {
            int newLocationId = Locations.Count + 1;
            Locations.Add(newLocationId, new Dictionary<int, int>());
        }

        public void AddProductToLocation(int locationId, int productId, int quantity = 1 )
        {

        }

    }
}
