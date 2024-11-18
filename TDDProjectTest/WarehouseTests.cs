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
        public void GetTotalProductsTest()
        {

        }
    }
}
