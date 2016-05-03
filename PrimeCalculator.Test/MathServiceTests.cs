using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PrimeCalculator.Services;

namespace PrimeCalculator.Test
{
    [TestClass]
    public class MathServiceTests
    {
        [TestMethod]
        public void CalculatePrimes_GivenInteger_ReturnArrayOfPrimes()
        {
            //setup
            int n = 8;

            //act
            var actual = MathService.CalculatePrimes(n);

            //assert
            var expected = new int[] { 2, 3, 5, 7 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculatePrimes_GivenThirty_ReturnArrayOfPrimes()
        {
            //setup
            int n = 30;

            //act
            var actual = MathService.CalculatePrimes(n);

            //assert
            var expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            CollectionAssert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CalculatePrimes_GivenPositiveIntegerLessThan2_ReturnEmptyArray()
        {
            //setup
            int n = 1;

            //act
            var actual = MathService.CalculatePrimes(n);

            //assert
            var expected = new int[] { };
            CollectionAssert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void CalculatePrimes_GivenNegativeInteger_ReturnEmptyArray()
        {
            //setup
            int n = -89;

            //act
            var actual = MathService.CalculatePrimes(n);

            //assert
            var expected = new int[] { };
            CollectionAssert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void CalculatePrimes_GivenInteger2_ReturnArrayWithJust2()
        {
            //setup
            int n = 2;

            //act
            var actual = MathService.CalculatePrimes(n);

            //assert
            var expected = new int[] { 2 };
            CollectionAssert.AreEqual(actual, expected);
        }
    }



}
