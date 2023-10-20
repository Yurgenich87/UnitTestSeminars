using Seminar1.Shop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Seminar1.Shop
{
    public class Shop
    {
        private List<Product> products;

        // Геттеры, сеттеры:
        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        // Метод должен вернуть отсортированный по возрастанию по цене список продуктов
        public List<Product> SortProductsByPrice()
        {
            if (products != null)
            {
                List<Product> sortedProducts = products.OrderBy(p => p.Cost).ToList();
                return sortedProducts;
            }
            else
            {
                return null;
            }
        }

        // Метод должен вернуть самый дорогой продукт
        public Product GetMostExpensiveProduct()
        {
            if (products != null && products.Count > 0)
            {
                Product mostExpensive = products.OrderByDescending(p => p.Cost).First();
                return mostExpensive;
            }
            else
            {
                return null;
            }
        }
    }
}
