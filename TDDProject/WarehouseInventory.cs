using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject
{
    public class WarehouseInventory
    {
        public const int MaxSize = 64;

        public Dictionary<int, Dictionary<int, int>> Locations { get; } = new Dictionary<int, Dictionary<int, int>>();

        public void AddLocation()
        {
            int newLocationId = Locations.Count + 1;
            Locations.Add(newLocationId, new Dictionary<int, int>());
        }

        public void AddProductToLocation(int locationId, int productId, int quantity = 1 )
        {
            // check if location doesn't exists

            if (!Locations.ContainsKey(locationId))
            {
                return;
            }

            int totalItemCount = GetTotalProductsAtLocation(locationId);

            if ( totalItemCount +  quantity > MaxSize )
            {
                return;
            }

            if (Locations[locationId].ContainsKey(productId))
            {
                Locations[locationId][productId] += quantity;
            } 
            else
            {
                Locations[locationId].Add(productId, quantity);
            }
        }

        public int GetTotalProductsAtLocation(int locationId)
        {
            if (!Locations.ContainsKey(locationId))
            {
                return 0;
            }

            int totalItemCount = 0;
            foreach (int count in Locations[locationId].Values)
            {
                totalItemCount += count;
            }

            return totalItemCount;
        }

        public int GetTotalNumberOfProducts()
        {       
            int totalItemCount = 0;
            for (int i = 1; i < Locations.Count + 1; i++)
            {
                totalItemCount += GetTotalProductsAtLocation(i);
            }
            return totalItemCount;
        }

        public int GetTotalNumberOfProductsById(int productId)
        {
            int totalItemCount = 0;
            for ( int i = 1; i< Locations.Count + 1; i++)
            {
                if ( Locations[i].ContainsKey(productId))
                {
                    totalItemCount += Locations[i][productId];
                }
            }

            return totalItemCount;
        }

        public List<int> GetAllLocationIds()
        {
            return Locations.Keys.ToList();
        }
    }
}
