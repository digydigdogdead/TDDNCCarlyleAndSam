using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDProject;
using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

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

        [Test]
        public void ApplyDiscountTest()
        {
            ShoppingCart testCart = new ShoppingCart();
            testCart.AddItem("egg", 20);
            testCart.AddItem("bread", 80);

            testCart.ApplyDiscount(0.2);
            testCart.GetTotalPrice().Should().Be(80);

            testCart.ApplyDiscount(0.5);
            testCart.GetTotalPrice().Should().Be(50);
        }
    }
}
