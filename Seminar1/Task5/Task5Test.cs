using System;
using NUnit.Framework;

namespace UnitTest.Seminar1.Task5
{
    [TestFixture]
    public class MathUtilsTest
    {
        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(0, 5, 0)]
        [TestCase(-2, -4, 8)]
        [TestCase(10, -2, -20)]
        
        public void TestMultiply(int a, int b, int expectedResult)
        {
            int result = MathUtils.Multiply(a, b);
            Assert.AreEqual(expectedResult, result, "Некорректное умножение");
        }
    }
}