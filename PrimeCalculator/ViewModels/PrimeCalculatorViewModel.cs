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
        }
    }
}
