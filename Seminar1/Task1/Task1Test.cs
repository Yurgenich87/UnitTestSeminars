using NUnit.Framework;

namespace Task1
{
    [TestFixture]
    public class Task1Test
    {
        [Test]
        public void TestMethod()
        {
            Assert.AreEqual(5, 2 + 3);
        }

        [SetUp]
        public void Setup()
        {
            // Инициализация ресурсов
        }

        [TearDown]
        public void Teardown()
        {
            // Очистка ресурсов
        }

        [OneTimeSetUp]
        public static void GlobalSetup()
        {
            // Инициализация
        }

        [OneTimeTearDown]
        public static void GlobalTeardown()
        {
            // Очистка
        }

        [Test]
        [Description("Тест суммирования")]
        public void TestSum()
        {
            Assert.AreEqual(5, 2 + 3);
        }

        // Если вы хотите отключить тест, вы можете просто закомментировать его атрибут Test.
        // Например:

        // [Test]
        // public void TestMethod()
        // {
        //     // этот тест не будет запущен
        // }
    }
}
