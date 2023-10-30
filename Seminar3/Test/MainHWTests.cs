using System;
using NUnit.Framework;
using UnitTest.Seminar3.HomeWork3;

namespace UnitTest.Seminar3.Test
{
    [TestFixture]
    public class MainHWTests
    {
        [Test]
        public void IsEven_WithEvenNumber_ReturnsTrue()
        {
            // Arrange
            MainHW mainHW = new MainHW();

            // Act
            bool result = mainHW.IsEven(10);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsEven_WithOddNumber_ReturnsFalse()
        {
            // Arrange
            MainHW mainHW = new MainHW();

            // Act
            bool result = mainHW.IsEven(7);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void IsInInterval_WithNumberInRange_ReturnsTrue()
        {
            // Arrange
            MainHW mainHW = new MainHW();

            // Act
            bool result = mainHW.IsInInterval(50);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsInInterval_WithNumberOutsideRange_ReturnsFalse()
        {
            // Arrange
            MainHW mainHW = new MainHW();

            // Act
            bool result = mainHW.IsInInterval(10);

            // Assert
            Assert.IsFalse(result);
        }
    }

}
