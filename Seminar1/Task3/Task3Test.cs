using System;
using NUnit.Framework;

namespace Task3
{
    [TestFixture]
    public class Task3Test
    {
        [Test]
        public void TestAssertions()
        {
            // Примеры использования NUnit для проверки утверждений

            // Создаем строку для тестирования
            string text = "Hello, World";

            // Проверяем, что строка не равна null
            Assert.IsNotNull(text);

            // Проверяем, что строка начинается с "Hello"
            Assert.IsTrue(text.StartsWith("Hello"));

            // Проверяем, что строка заканчивается на "World"
            Assert.IsTrue(text.EndsWith("World"));

            // Проверяем, что строка содержит подстроку "lo, W"
            Assert.IsTrue(text.Contains("lo, W"));
        }

        public static void Main(string[] args)
        {
            int x = -1;
            // Проверяем, что x неотрицательно с использованием оператора assert
            Assert.GreaterOrEqual(x, 0, "x должно быть неотрицательным");
            Console.WriteLine("Программа продолжает выполнение");
        }
    }
}
