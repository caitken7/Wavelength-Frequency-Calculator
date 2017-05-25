using System;
using System.Collections.Generic;
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

namespace Frequency___Wavelength_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        //Wavelength Calculation
        private void calcWavelength_Click(object sender, RoutedEventArgs e)
        {
            var ans1 = 343.2 / float.Parse(inputFrequency.Text);
            ans1 = (Math.Round(ans1, 2));
            outputWavelength.Text = ans1.ToString();
        }

        //Frequency Calculation
        private void calcFrequency_Click(object sender, RoutedEventArgs e)
        {
            var ans2 = 343.2 / float.Parse(inputWavelength.Text);
            ans2 = (Math.Round(ans2, 2));
            outputFrequency.Text = ans2.ToString();
        }

        //Speed of Sound Calculation
        private void calcSpeed_Click(object sender, RoutedEventArgs e)
        {
            
           var ans3 = 331.4 + 0.6 * ((double.Parse(inputTemperature.Text) - 32) * 5 / 9);
            ans3 = (Math.Round(ans3, 2));
            outputSpeed.Text = ans3.ToString();
        }


    }
}
