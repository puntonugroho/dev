using System;
using System.Collections.Generic;
using System.Globalization;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Engine_Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CR : Page
    {
        public CR()
        {
            this.InitializeComponent();
        }

        public double cylinder { get; private set; }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            double bore, stroke, vc, hasil;
            double phi = double.Parse("3.14", CultureInfo.InvariantCulture.NumberFormat);
            bore = double.Parse(boreText.Text, CultureInfo.InvariantCulture.NumberFormat);
            stroke = double.Parse(strokeText.Text, CultureInfo.InvariantCulture.NumberFormat);
            vc = double.Parse(silinderText.Text, CultureInfo.InvariantCulture.NumberFormat);

            hasil = Math.Round(((((phi/4)*(bore * bore))*stroke)+vc)/vc,1);
            hasilnya.Text = hasil.ToString(hasilnya.Text);
            cr.Text = "1:";
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            boreText.Text = "";
            strokeText.Text = "";
            silinderText.Text = "";
            hasilnya.Text = "";
            cr.Text = "";
        }
    }
}
