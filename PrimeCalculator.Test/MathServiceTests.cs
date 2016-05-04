using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PrimeCalculator.Services;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeCalculator.Test
{
    [TestClass]
    public class MathServiceTests
    {
        [TestMethod]
        public async Task CalculatePrimes_GivenInteger_ReturnArrayOfPrimes()
        {
            //setup
            int n = 8;

            //act
            var actual = await MathService.CalculatePrimesAsync(n);

            //assert
            var expected = new int[] { 2, 3, 5, 7 };
            CollectionAssert.AreEqual(actual.ToList(), expected);
        }

        [TestMethod]
        public async Task CalculatePrimes_GivenThirty_ReturnArrayOfPrimes()
        {
            //setup
            int n = 30;

            //act
            var actual = await MathService.CalculatePrimesAsync(n);

            //assert
            var expected = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            CollectionAssert.AreEqual(actual.ToList(), expected);
        }

        [TestMethod]
        public async Task CalculatePrimes_GivenPositiveIntegerLessThan2_ReturnEmptyArray()
        {
            //setup
            int n = 1;

            //act
            var actual = await MathService.CalculatePrimesAsync(n);

            //assert
            var expected = new int[] { };
            CollectionAssert.AreEqual(actual.ToList(), expected);
        }


        [TestMethod]
        public async Task CalculatePrimes_GivenNegativeInteger_ReturnEmptyArray()
        {
            //setup
            int n = -89;

            //act
            var actual = await MathService.CalculatePrimesAsync(n);

            //assert
            var expected = new int[] { };
            CollectionAssert.AreEqual(actual.ToList(), expected);
        }


        [TestMethod]
        public async Task CalculatePrimes_GivenInteger2_ReturnArrayWithJust2()
        {
            //setup
            int n = 2;

            //act
            var actual = await MathService.CalculatePrimesAsync(n);

            //assert
            var expected = new int[] { 2 };
            CollectionAssert.AreEqual(actual.ToList(), expected);
        }
    }



}
