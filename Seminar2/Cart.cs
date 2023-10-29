using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Seminar2
{
    public class Cart
    {
        private List<Product> cartItems = new List<Product>() ;

        // Добавление товара в корзину
        public void AddItems(Product product)
        {
            cartItems.Add(product);
        }

        // Удаление товара из корзины
        public void RemoveItems(Product product)
        {
            cartItems.Remove(product);
        }

        // Расчет общей суммы товаров в корзине
        public double CalculateTotal()
        {
            double total = 0.0;
            foreach (Product item in cartItems)
            {
                total += item.GetPrice() * item.GetQuantity();
            }
            return total;
        }
    }
}
