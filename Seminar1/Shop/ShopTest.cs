using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seminar1.Shop;
using System;
using System.Collections.Generic;

namespace Seminar1.Shop
{
    [TestClass]
    public class ShopTest
    {
        [TestMethod]
        public void TestShopStoresCorrectProducts()
        {
            // Arrange
            List<Product> expectedProducts = new List<Product>
            {
                new Product { Title = "Product 1", Cost = 10 },
                new Product { Title = "Product 2", Cost = 20 },
                new Product { Title = "Product 3", Cost = 15 }
            };

            Shop shop = new Shop();
            shop.Products = expectedProducts;

            // Act
            List<Product> actualProducts = shop.Products;

            // Assert
            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }

        [TestMethod]
        public void TestGetMostExpensiveProduct()
        {
            // Arrange
            List<Product> products = new List<Product>
            {
                new Product { Title = "Product A", Cost = 30 },
                new Product { Title = "Product B", Cost = 25 },
                new Product { Title = "Product C", Cost = 35 }
            };

            Shop shop = new Shop();
            shop.Products = products;

            // Act
            Product mostExpensive = shop.GetMostExpensiveProduct();

            // Assert
            Assert.AreEqual("Product C", mostExpensive.Title);
            Assert.AreEqual(35, mostExpensive.Cost);
        }

        [TestMethod]
        public void TestSortProductsByPrice()
        {
            // Arrange
            List<Product> products = new List<Product>
            {
                new Product { Title = "Product X", Cost = 20 },
                new Product { Title = "Product Y", Cost = 10 },
                new Product { Title = "Product Z", Cost = 30 }
            };

            Shop shop = new Shop();
            shop.Products = products;

            // Act
            List<Product> sortedProducts = shop.SortProductsByPrice();

            // Assert
            Assert.AreEqual("Product Y", sortedProducts[0].Title);
            Assert.AreEqual("Product X", sortedProducts[1].Title);
            Assert.AreEqual("Product Z", sortedProducts[2].Title);
        }
    }
}
