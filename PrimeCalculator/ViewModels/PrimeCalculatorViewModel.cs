using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCalculator.ViewModels
{
    public class PrimeCalculatorViewModel : INotifyPropertyChanged
    {
        public int maxNumber { get; set; }

        private ObservableCollection<int> _primeNumbers;
        public ObservableCollection<int> PrimeNumbers
        {
            get
            {
                return _primeNumbers;
            }
            set
            {
                _primeNumbers = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PrimeNumbers)));
            }
        }

        public int PrimeNumberCount
        {
            get
            {
                return _primeNumbers != null ? _primeNumbers.Count() : 3;
            }
        }



        public PrimeCalculatorViewModel()
        {
            //maxNumber = 8;

            PrimeNumbers = new ObservableCollection<int>();
            //for (int i = 2; i < 97; i++)
            //{
            //    PrimeNumbers.Add(i);
            //}

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
