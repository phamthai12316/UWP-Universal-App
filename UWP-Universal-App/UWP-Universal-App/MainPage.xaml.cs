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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Universal_App
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

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StackPanelDemo));
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GridDemo));
        }

        private void btnScrollView_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ScrollViewDemo));
        }

        private void btnRelativePage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RelativePage));
        }

        private void btnSplitViewPage_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SplitViewPage));
        }

        private async void btnOpenContentDialog_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog1 dialog1 = new ContentDialog1();
            var result = await dialog1.ShowAsync();
            switch (result)
            {
                case ContentDialogResult.None:
                    break;
                case ContentDialogResult.Primary:
                    break;
                case ContentDialogResult.Secondary:
                    break;
                default:
                break;
            } 
        }
    }
}

