using System;
using System.Collections.Generic;
using System.Linq;
using UnitTest.Seminar2;

namespace UnitTest.Seminar2
{
    public class Cart
    {
        public List<Product> CartItems { get; } = new List<Product>(); // Корзина с продуктами

        private double TotalPrice;

        // При создании корзины нужно передать магазин
        private Shop shop;

        public Cart(Shop shop)
        {
            this.shop = shop;
        }

        // Метод для добавления продукта в корзину по его id
        public void AddProductToCartById(int id)
        {
            Product product = GetProductByProductID(id);

            AddToCart(product);

            Recalculate();
        }

        public void Recalculate() // Метод пересчитывает сумму покупки
        {
            TotalPrice = 0.0;
            foreach (Product p in CartItems)
            {
                TotalPrice += p.Price * p.Quantity;
            }
        }

        // Чтобы положить продукт в корзину, его нужно сначала найти в магазине
        private Product GetProductByProductID(int id)
        {
            Product product = new Product();

            List<Product> products = shop.GetProductsShop();
            foreach (Product prod in products)
            {
                if (prod.Id == id)
                {
                    product = prod;
                    break;
                }
            }
            if (id > shop.GetProductsShop().Count || id < 1)
            {
                throw new InvalidOperationException("Не найден продукт с id: " + id);
            }
            return product;
        }

        private void AddToCart(Product product)
        {
            Product productInCart = new Product(product.Id, product.Name, product.Price, 0);
            Product productInShop = shop.GetProductsShop()[product.Id - 1];

            if (productInShop.Quantity == 0)
            {
                Console.WriteLine("Этого товара нет в наличии");
                return;
            }

            // Изменяем кол-во в корзине +1
            if (HasContainedProduct(productInCart))
            {
                GetContainedProduct(productInCart).Quantity = GetContainedProduct(productInCart).Quantity + 1;
            }
            else
            {
                productInCart.Quantity = 1;
                CartItems.Add(productInCart);
            }
            Recalculate();
            // Изменяем кол-во в магазине -1
            shop.GetProductsShop()[product.Id - 1].Quantity = productInShop.Quantity - 1;
        }

        private bool HasContainedProduct(Product product)
        {
            foreach (Product cartItem in CartItems)
            {
                if (cartItem.Id == product.Id)
                    return true;
            }
            return false;
        }

        private bool HasContainedProductID(int id)
        {
            foreach (Product cartItem in CartItems)
            {
                if (cartItem.Id == id)
                    return true;
            }
            return false;
        }

        // Поиск продукта в корзине, если он был уже добавлен ранее
        private Product GetContainedProduct(Product product)
        {
            foreach (Product cartItem in CartItems)
            {
                if (cartItem.Id == product.Id)
                    return cartItem;
            }
            return null;
        }

        public void RemoveProductById(int id)
        {
            if (!HasContainedProductID(id))
            {
                throw new InvalidOperationException("В корзине не найден продукт с id: " + id);
            }

            // Изменяем кол-во в корзине -1
            Product prod = GetProductByProductID(id);
            if (HasContainedProduct(prod) && GetContainedProduct(prod).Quantity > 1)
            {
                GetContainedProduct(prod).Quantity = GetContainedProduct(prod).Quantity - 1;
            }
            else if (HasContainedProduct(prod) && GetContainedProduct(prod).Quantity == 1)
            {
                CartItems.Remove(GetContainedProduct(prod));
            }

            System.Threading.Thread.Sleep(70);

            Recalculate();

            // Изменяем кол-во в магазине +1
            Product productInShop = shop.GetProductsShop()[id - 1];
            shop.GetProductsShop()[id - 1].Quantity = productInShop.Quantity + 1;
        }

        public void PrintCartItems()
        {
            Console.WriteLine("Сейчас у вас в корзине:");
            Console.WriteLine("{0, -3}| {1, -20}| {2, -9}| {3, -3}", "ID", "Название", "Цена, р.", "Кол-во в корзине, шт.");
            foreach (Product prod in CartItems)
            {
                Console.WriteLine("{0, -3}| {1, -20}| {2, -9}| {3, -3}", prod.Id, prod.Name, prod.Price, prod.Quantity);
            }
            Console.WriteLine("Общая стоимость корзины: " + GetTotalPrice() + " р.");
            Console.WriteLine();
        }

        public double GetTotalPrice()
        {
            return TotalPrice;
        }
    }
}
