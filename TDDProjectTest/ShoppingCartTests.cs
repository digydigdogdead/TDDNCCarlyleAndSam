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

            // Tests that an empty cart has no price.
            testCart.GetTotalPrice().Should().Be(0);


            // Tests normal use-case:
            testCart.AddItem("egg", 20);
            testCart.AddItem("bread", 10);

            testCart.GetTotalPrice().Should().Be(30);
        }

        [Test]
        public void AddItemAndGetTotalPriceExtremesTest()
        {
            ShoppingCart testCart = new ShoppingCart();
            // Tests that a negative item cannot be added:
            testCart.AddItem("the void", -2893);
            testCart.GetTotalPrice().Should().Be(0);

            // Tests that a extravagantly expensive item cannot be added:
            testCart.AddItem("thing", double.MaxValue + 1);
            testCart.GetTotalPrice().Should().Be(0);

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
