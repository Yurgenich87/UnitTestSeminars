using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnitTest.Seminar2;

namespace UnitTest.Seminar2
{

    [TestFixture]
    public class CartTest
    {

        private Cart cart;
        private Product product1;
        private Product product2;

        [SetUp]
        public void SetUp()
        {
            cart = new Cart();
            product1 = new Product(1, "Apple", 1.2, 10);
            product2 = new Product(2, "Banana", 1.8, 3);
        }

        [Test]
        public void TestCalculatorTotal()
        {
            cart.AddItems(product1);
            cart.AddItems(product2);
            double expectedTotal = 17.4;
            double actualTotal = cart.CalculateTotal();
            Assert.AreEqual(expectedTotal, actualTotal, "Стоимость корзины неккоректная");
        }
    }
}