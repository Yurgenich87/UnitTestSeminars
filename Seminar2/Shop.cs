using Seminar1.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar2
{
    public class Shop
    {
        // Список продуктов в магазине
        private readonly List<Product> productsShop;

        public Shop()
        {
        }

        // При создании магазина нужно передать ему список продуктов
        public Shop(List<Product> productsShop)
        {
            this.productsShop = productsShop;
        }

        // Метод для получения текущего списка продуктов
        public List<Product> GetProductsShop()
        {
            return productsShop;
        }
    }
}
