using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDProject;
using FluentAssertions;

namespace TDDProjectTest
{
    internal class WarehouseTests
    {
        [Test]
        public void AddLocationTest()
        {
            WarehouseInventory testHouse = new WarehouseInventory();
            testHouse.Locations.Count.Should().Be(0);

            testHouse.AddLocation();
            testHouse.Locations.Count().Should().Be(1);
            testHouse.Locations.ContainsKey(1).Should().BeTrue();
        }
        
        [Test]
        public void AddProductToLocationTest()
        {
            WarehouseInventory testHouse = new WarehouseInventory();
            testHouse.AddLocation();

            testHouse.AddProductToLocation(1, 1);
            testHouse.Locations[1].Values.Count.Should().Be(1);
            testHouse.Locations[1][1].Should().Be(1);

            testHouse.AddProductToLocation(1, 2, 2);
            testHouse.Locations[1][2].Should().Be(2);
        }

        [Test]
        public void AddProductToNonexistingLocationTest()
        {
            WarehouseInventory testHouse = new WarehouseInventory();
            testHouse.AddProductToLocation(1, 1);
            testHouse.Locations.Count.Should().Be(0);
        }

        [Test]
        public void AddProductToFullLocationTest()
        {
            WarehouseInventory testHouse = new WarehouseInventory();
            testHouse.AddLocation();
            testHouse.AddProductToLocation(1, 1, 64);
            testHouse.Locations[1][1].Should().Be(64);
            testHouse.AddProductToLocation(1, 1, 3);
            testHouse.Locations[1][1].Should().Be(64);
        }

        [Test]
        public void GetTotalProductsAtLocation()
        {
            WarehouseInventory testHouse = new WarehouseInventory();
            testHouse.GetTotalProductsAtLocation(1).Should().NotBe(5);
            testHouse.AddLocation();
            testHouse.AddProductToLocation(1, 1, 5);
            testHouse.GetTotalProductsAtLocation(1).Should().Be(5);

        }

        [Test]
        public void GetTotalProductsTest()
        {
            WarehouseInventory testHouse = new WarehouseInventory();
            testHouse.GetTotalNumberOfProducts().Should().Be(0);
            testHouse.AddLocation();
            testHouse.AddLocation();
            testHouse.AddProductToLocation(1, 1, 5);
            testHouse.AddProductToLocation(2, 2, 5);
            testHouse.GetTotalNumberOfProducts().Should().Be(10);
        }

        [Test]
        public void GetTotalProductsByIdTest()
        {
            WarehouseInventory testHouse = new WarehouseInventory();
            testHouse.AddLocation();
            testHouse.AddLocation();
            testHouse.AddProductToLocation(1, 1, 5);
            testHouse.AddProductToLocation(1, 2, 3);
            testHouse.AddProductToLocation(2, 2, 4);
            testHouse.GetTotalNumberOfProductsById(1).Should().Be(5);
            testHouse.GetTotalNumberOfProductsById(2).Should().Be(7);
        }

        [Test]
        public void GetAllLocationIdsTest()
        {
            WarehouseInventory testHouse = new WarehouseInventory();
            testHouse.AddLocation();
            testHouse.AddLocation();
            testHouse.AddLocation();

            List<int> expectedIds = [ 1, 2, 3 ];
            List<int> actualIds = testHouse.GetAllLocationIds();

            for (int i = 0; i < expectedIds.Count; i++)
            {
                actualIds[i].Should().Be(expectedIds[i]);
            }
        }

        [Test]
        public void GetAllProductIdsTest()
        {

        }
    }
}
