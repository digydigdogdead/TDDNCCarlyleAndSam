using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDProject;
using FluentAssertions;

namespace TDDProjectTest
{
    internal class ShoppingCartTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void AddItemAndGetTotalPriceTest()
        {
            ShoppingCart testCart = new ShoppingCart();

            testCart.AddItem("egg", 20);
            testCart.AddItem("bread", 10);

            testCart.GetTotalPrice().Should().Be(30);
        }
    }
}
