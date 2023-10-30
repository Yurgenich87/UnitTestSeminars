using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTest.Seminar3.Test
{
    

    [TestFixture]
    public class TestDrivenDevelopment
    {
        [Test]
        public void RedGreenRefactorExample()
        {
            // Red: Начнем с написания теста, который еще не прошел (ожидаем несоответствие)
            int expectedResult = 10;
            int actualResult = SomeFunctionToBeImplemented();
            Assert.AreNotEqual(expectedResult, actualResult);

            // Green: Реализуем минимальное необходимое, чтобы сделать тест проходящим
            actualResult = 10; // Просто установим значение, чтобы тест прошел
            Assert.AreEqual(expectedResult, actualResult);

            // Refactor: Оптимизируем код, делаем его лучше, но при этом убеждаемся, что тесты все еще проходят
            // Например, улучшаем SomeFunctionToBeImplemented и проверяем, что тест проходит после изменений
            actualResult = ImprovedFunction();
            Assert.AreEqual(expectedResult, actualResult);
        }

        private int SomeFunctionToBeImplemented()
        {
            // Здесь реализация функции, которую вы хотите протестировать
            return 10;
        }

        private int ImprovedFunction()
        {
            // Улучшенная реализация функции
            return 10;
        }
    }

}
