using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalculator.ViewModels
{
    public class PrimeCalculatorViewModel
    {
        public int maxNumber { get; set; }
        public IEnumerable<int> PrimeNumbers { get; set; }

        public PrimeCalculatorViewModel()
        {
            maxNumber = 8;

            var primeNumbers = new List<int>();
            for (int i = 2; i < 17; i++)
            {
                primeNumbers.Add(i);
            }

            PrimeNumbers = primeNumbers;

        }
    }
}
