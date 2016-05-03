
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PrimeCalculator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalculator.Tests.Services
{
    [TestClass]
    public class CalculatePrimesTests
    {
        [TestMethod]
        public void CalculatePrimes_GivenInteger_ReturnListOfPrimes()
        {
            //setup
            int n = 8;

            //act
            var actual = MathService.CalculatePrimes(n);

            //assert
            var expected = new int[] { 2, 3, 5, 7 };
            Assert.AreEqual(actual, expected);
        }
    }
}
