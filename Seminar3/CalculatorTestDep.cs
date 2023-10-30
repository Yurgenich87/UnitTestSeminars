using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTest.Seminar3
{
    

    [TestFixture]
    public class CalculatorTestDep
    {
        [Test]
        public void TestAddition()
        {
            int result = Calculator.Calculation(2, 6, '+');
            Assert.AreEqual(8, result);
        }

        [Test]
        public void TestSubtraction()
        {
            int result = Calculator.Calculation(2, 2, '-');
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMultiplication()
        {
            int result = Calculator.Calculation(2, 7, '*');
            Assert.AreEqual(14, result);
        }

        [Test]
        public void TestDivision()
        {
            int result = Calculator.Calculation(100, 50, '/');
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestInvalidOperator()
        {
            Assert.Throws<InvalidOperationException>(() => Calculator.Calculation(8, 4, '_'));
        }

        [Test]
        public void TestSquareRootExtraction()
        {
            double result = Calculator.SquareRootExtraction(25);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestInvalidSquareRootExtraction()
        {
            Assert.Throws<InvalidOperationException>(() => Calculator.SquareRootExtraction(-1));
        }

        [Test]
        public void TestDiscountCalculation()
        {
            double result = Calculator.CalculatingDiscount(1000, 25);
            Assert.AreEqual(750, result);
        }

        [Test]
        public void TestNegativePurchaseAmount()
        {
            Assert.Throws<ArithmeticException>(() => Calculator.CalculatingDiscount(-1000, 25));
        }

        [Test]
        public void TestNegativeDiscount()
        {
            Assert.Throws<ArithmeticException>(() => Calculator.CalculatingDiscount(1000, -10));
        }

        [Test]
        public void TestDiscountOutOfRange()
        {
            Assert.Throws<ArithmeticException>(() => Calculator.CalculatingDiscount(1000, 101));
        }
    }

}
