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
        
        public PrimeCalculatorViewModel()
        {
            PrimeNumbers = new ObservableCollection<int>();  
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
