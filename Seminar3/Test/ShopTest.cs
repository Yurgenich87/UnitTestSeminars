using System;
using System.Collections.Generic;
using NUnit.Framework;
using UnitTest.Seminar2;

namespace UnitTest.Seminar3.Test
{
    [TestFixture]
    public class ShopTest
    {
        private Shop shop;
        private Cart cart;

        [SetUp]
        public void Setup()
        {
            // Устанавливаем начальные условия для тестов.
            // Создаем магазин и корзину для каждого теста.
            shop = new Shop(GetProductsShop());
            cart = new Cart(shop);
        }

        // Метод GetProductsShop для получения списка продуктов.
        private List<Product> GetProductsShop()
        {
            return shop.GetProductsShop();
        }

        [Test]
        public void IncorrectProductSelectionCausesException([Values(-100, 100)] int id)
        {
            // Проверяем, что выбор некорректного продукта вызывает исключение.
            // Метод AddProductToCartById должен выбросить исключение типа Exception,
            // если передан некорректный ID продукта.
            Exception ex = Assert.Throws<Exception>(() => cart.AddProductToCartById(id));

            // Проверяем, что сообщение исключения соответствует ожидаемому.
            string expectedMessage = "Не найден продукт с id: " + id;
            string actualMessage = ex.Message;
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void IncorrectProductRemoveCausesException()
        {
            // Проверяем, что удаление некорректного продукта вызывает исключение.
            // Метод RemoveProductById должен выбросить исключение типа Exception,
            // если попытка удаления продукта, которого нет в корзине.
            int id = 1;

            Exception ex = Assert.Throws<Exception>(() => cart.RemoveProductById(id));

            // Проверяем, что сообщение исключения соответствует ожидаемому.
            string expectedMessage = "В корзине не найден продукт с id: " + id;
            string actualMessage = ex.Message;
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void PriceCartIsCorrectlyCalculatedExt()
        {
            // Проверяем, что корректное добавление и удаление продуктов
            // правильно пересчитывает итоговую стоимость корзины.
            // Мы добавляем продукт с ID 1 и затем удаляем его, и итоговая
            // стоимость корзины должна быть равна 0.
            cart.AddProductToCartById(1);
            cart.RemoveProductById(1);

            // Проверка итоговой стоимости корзины.
            Assert.AreEqual(0, cart.GetTotalPrice());
        }
    }
}
