using System;
using System.Collections.Generic;
using System.Linq;
using global::UnitTest.Seminar3.Homework3;
using NUnit.Framework;
using UnitTest.Seminar3.HomeWork3;

namespace UnitTest.Seminar3.Test
{
    

    namespace UnitTest.Seminar3.Coverage.Tests
    {
        [TestFixture]
        public class SomeServiceTests
        {
            [Test]
            public void FizzBuzz_MultipleOfThree_ReturnsFizz()
            {
                SomeService someService = new SomeService();
                string result = someService.FizzBuzz(3);
                Assert.AreEqual("Fizz", result);
            }

            [Test]
            public void FizzBuzz_MultipleOfFive_ReturnsBuzz()
            {
                SomeService someService = new SomeService();
                string result = someService.FizzBuzz(5);
                Assert.AreEqual("Buzz", result);
            }

            [Test]
            public void FizzBuzz_MultipleOfThreeAndFive_ReturnsFizzBuzz()
            {
                SomeService someService = new SomeService();
                string result = someService.FizzBuzz(15);
                Assert.AreEqual("FizzBuzz", result);
            }

            [Test]
            public void FizzBuzz_NotMultipleOfThreeOrFive_ReturnsNumberAsString()
            {
                SomeService someService = new SomeService();
                string result = someService.FizzBuzz(7);
                Assert.AreEqual("7", result);
            }
        }
    }

}
