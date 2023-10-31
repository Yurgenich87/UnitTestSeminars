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
        private Shop shop;
        private Product product1;
        private Product product2;

        [SetUp]
        public void SetUp()
        {
            Shop shop = new Shop();
            Cart cart = new Cart(shop);

            product1 = new Product(1, "Apple", 1.2, 10);
            product2 = new Product(2, "Banana", 1.8, 3);
        }

        [Test]
        public void TestCalculatorTotal()
        {
            cart.AddProductToCartById(1); // Добавить продукт с id 1
            cart.AddProductToCartById(2); // Добавить продукт с id 2
            double expectedTotal = 17.4;
            double actualTotal = cart.GetTotalPrice(); // Получить общую стоимость
            Assert.AreEqual(expectedTotal, actualTotal, "Стоимость корзины некорректная");
        }

    }
}