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

namespace UWP_Universal_App_Assigment_3_Frame
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Financial));
            titlePage.Text = "Financial";
            btnBack.Visibility = Visibility.Collapsed;
        }

        private void btnHumburger_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                btnBack.Visibility = Visibility.Visible;
            }
           
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                var page = MyFrame.Content as Page;
                if(page.Name == "Food")
                {
                    titlePage.Text = "Food";
                } else
                {
                    titlePage.Text = "Financial";
                }
            }
            else
            {
                btnBack.Visibility = Visibility.Collapsed;
            }
        }

        private void btnFinancial_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Financial));
        }

        private void btnFood_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Food));
        }

        private void listBoxHumberger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                btnBack.Visibility = Visibility.Visible;
            }
            else
            {
                btnBack.Visibility = Visibility.Collapsed;
            }
            if (Financial.IsSelected)
            {
                MyFrame.Navigate(typeof(Financial));
                titlePage.Text = "Financial";
            }
            if (Food.IsSelected)
            {
                MyFrame.Navigate(typeof(Food));
                titlePage.Text = "Food";
            }

        }
    }
}
