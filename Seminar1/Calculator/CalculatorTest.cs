using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seminar1.Calculator;
using System;


namespace Seminar1.Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestCalculationWithIntegers()
        {
            Assert.AreEqual(8, Calculator.Calculation(2, 6, '+'));
            Assert.AreEqual(0, Calculator.Calculation(2, 2, '-'));
            Assert.AreEqual(14, Calculator.Calculation(2, 7, '*'));
            Assert.AreEqual(2, Calculator.Calculation(100, 50, '/'));

            // Проверка ожидаемого исключения
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                Calculator.Calculation(8, 4, '_');
            });
        }

        [TestMethod]
        public void TestSquareRootExtraction()
        {
            Assert.AreEqual(Math.Sqrt(169), Calculator.SquareRootExtraction(169));

            // Проверка ожидаемого исключения при попытке извлечения корня из отрицательного числа
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Calculator.SquareRootExtraction(-1);
            });
        }

        [TestMethod]
        public void TestCalculatingDiscount()
        {
            Assert.AreEqual(50, Calculator.CalculatingDiscount(100, 50));

            Assert.AreEqual(100, Calculator.CalculatingDiscount(100, 0));

            Assert.AreEqual(0, Calculator.CalculatingDiscount(100, 100));


            // Проверка ожидаемого исключения при некорректном размере скидки
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Calculator.CalculatingDiscount(100, -10);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                Calculator.CalculatingDiscount(100, 110);
            });
        }
    }
}

