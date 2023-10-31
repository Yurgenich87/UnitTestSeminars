using NUnit.Framework;
using System;

namespace Task2
{
    [TestFixture]
    public class Task2Test
    {
        // Статический блок кода, который будет выполнен перед всеми тестами
        [OneTimeSetUp]
        public static void BeforeAll()
        {
            Console.WriteLine("Выполнение перед всеми тестами");
            // Инициализация глобальных ресурсов
        }

        // Блок кода, который будет выполнен после всех тестов
        [OneTimeTearDown]
        public static void AfterAll()
        {
            Console.WriteLine("Выполнение после всех тестов");
            // Освобождение глобальных ресурсов
        }

        // Блок кода, который будет выполнен перед каждым тестом
        [SetUp]
        public void BeforeEach()
        {
            Console.WriteLine("Выполнение перед каждым тестом");
            // Инициализация ресурсов для каждого теста
        }

        // Блок кода, который будет выполнен после каждого теста
        [TearDown]
        public void AfterEach()
        {
            Console.WriteLine("Выполнение после каждого теста");
            // Очистка ресурсов после каждого теста
        }

        // Основной тестовый метод
        [Test]
        [Description("Тест суммирования")]
        public void TestSum()
        {
            Console.WriteLine("Выполнение теста суммирования");
            int a = 2;
            int b = 3;
            int sum = a + b;
            Assert.AreEqual(5, sum);
        }

        // Отключенный тест
        [Test]
        [Ignore("Этот тест отключен и не будет выполнен")]
        public void DisabledTest()
        {
            Console.WriteLine("Этот тест отключен и не будет выполнен");
        }
    }
}
