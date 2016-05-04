using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Engine_Calc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            namaMenu.Text = "Home";
            lain.Navigate(typeof(home));
            ApplicationView.PreferredLaunchViewSize = new Size(200, 300);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }


        private void menu_Click(object sender, RoutedEventArgs e)
        {
            buka.IsPaneOpen = !buka.IsPaneOpen;
        }

        private void icon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cc.IsSelected) {
                lain.Navigate(typeof(CC));
                namaMenu.Text = "Engine Displacement";
            }

            if (cr.IsSelected) {
                lain.Navigate(typeof(CR));
                namaMenu.Text = "Compression Ratio";
            }


        }
    }
}
