using System;
using NUnit.Framework;


namespace UnitTest.Seminar1.Task5
{
    [TestFixture]
    public class MVSCalculatorTest
    {
        private MVSCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new MVSCalculator();
        }

        [Test]
        public void TestAddition()
        {
            int result = calculator.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestSubtraction()
        {
            int result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestMultiplication()
        {
            int result = calculator.Multiply(2, 5);
            Assert.AreEqual(10, result);
        }

        
        [Test]
        public void TestDivisionByZero()
        {
            Assert.Throws<ArgumentException>(() => calculator.Divide(5, 0));
        }



        [TearDown]
        public void TearDown()
        {
            // Освобождение ресурсов, если это необходимо
        }
    }
}