using PrimeCalculator.Services;
using PrimeCalculator.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PrimeCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            var primeCalculatorViewModel = new PrimeCalculatorViewModel();
            this.DataContext = primeCalculatorViewModel;
            this.InitializeComponent();
        }

        private async void btnCalculatePrimes_Click(object sender, RoutedEventArgs e)
        {
            var model = (PrimeCalculatorViewModel)this.DataContext;
            progressRingCalculatingPrimes.IsActive = true;
            model.PrimeNumbers = new ObservableCollection<int>();
            var primeNumbers = await MathService.CalculatePrimesAsync(model.maxNumber);
            progressRingCalculatingPrimes.IsActive = false;
            model.PrimeNumbers = new ObservableCollection<int>(primeNumbers);

        }
    }
}
