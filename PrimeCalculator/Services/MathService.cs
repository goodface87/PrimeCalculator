using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalculator.Services
{
    public static class MathService
    {
        /// <summary>
        ///     Will return an array of prime numbers from 2 up to the given integer (n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        //public static IEnumerable<int> CalculatePrimes(int n)
        //{
        //    if (n <= 1) return new int[0];
        //    var boolArr = new bool[n+1];
        //    var listOfPrimes = new List<int>();
        //    var squareRootOfN = Math.Sqrt(n);

        //    for (int i = 2; i <= n; i++)
        //    {
        //        if (boolArr[i] == false)
        //        {
        //            if (i <= squareRootOfN)
        //            {
        //                for (int j = i; j <= n; j += i)
        //                {
        //                    boolArr[j] = true;
        //                }
        //            }
        //            listOfPrimes.Add(i);
        //        } 
        //    }

        //    return listOfPrimes.ToArray();

        //}

        public static async Task<IEnumerable<int>> CalculatePrimesAsync(int n)
        {
            if (n <= 1) return new int[0];
            var boolArr = new bool[n + 1];
            var listOfPrimes = new List<int>();
            var squareRootOfN = Math.Sqrt(n);

            return await Task.Run(() =>
            {

                for (int i = 2; i <= n; i++)
                {
                    if (boolArr[i] == false)
                    {
                        if (i <= squareRootOfN)
                        {
                            for (int j = i; j <= n; j += i)
                            {
                                boolArr[j] = true;
                            }
                        }
                        listOfPrimes.Add(i);
                    }
                }

                return listOfPrimes.ToArray();
            });
        }

    }
}