using PrimeCalculator.Services;
using PrimeCalculator.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
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
            this.DataContext = new PrimeCalculatorViewModel();
            this.InitializeComponent();
        }

        private async void btnCalculatePrimes_Click(object sender, RoutedEventArgs e)
        {
            if (progressRingCalculatingPrimes.IsActive) return;
            var model = (PrimeCalculatorViewModel)this.DataContext;
            progressRingCalculatingPrimes.IsActive = true;
            model.PrimeNumbers = new ObservableCollection<int>();
            var primeNumbers = await MathService.CalculatePrimesAsync(model.maxNumber);
            progressRingCalculatingPrimes.IsActive = false;
            model.PrimeNumbers = new ObservableCollection<int>(primeNumbers);

        }

        private void OnKeyDownHandler(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
            {
                btnCalculatePrimes_Click(sender, e);
            }
        }

        private void OnTextChangingHandler(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            //Remove non-numeric characters
            var regexNonDigits = new Regex(@"[^\d]+");
            sender.Text = regexNonDigits.Replace(sender.Text, "");
        }
    }
}
