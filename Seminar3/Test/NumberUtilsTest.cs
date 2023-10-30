using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTest.Seminar3.HomeWork3;


namespace UnitTest.Seminar3.Test
{


    [TestFixture]
    public class NumberUtilsTest
    {
        [TestFixture]
        public class NumberUtilsTests
        {
            [Test]
            public void TestEvenNumber()
            {
                bool result = NumberUtils.evenOddNumber(4);
                Assert.IsTrue(result, "Ожидалось, что 4 - четное число.");
            }

            [Test]
            public void TestOddNumber()
            {
                bool result = NumberUtils.evenOddNumber(7);
                Assert.IsFalse(result, "Ожидалось, что 7 - нечетное число.");
            }
        }

        [Test]
        public void TestNumberInInterval()
        {
            bool result = NumberUtils.numberInInterval(50);
            Assert.IsTrue(result, "Ожидалось, что 50 попадает в интервал (25;100).");
        }

        [Test]
        public void TestNumberBelowInterval()
        {
            bool result = NumberUtils.numberInInterval(10);
            Assert.IsFalse(result, "Ожидалось, что 10 не попадает в интервал (25;100).");
        }

        [Test]
        public void TestNumberAboveInterval()
        {
            bool result = NumberUtils.numberInInterval(150);
            Assert.IsFalse(result, "Ожидалось, что 150 не попадает в интервал (25;100).");
        }

    }
}