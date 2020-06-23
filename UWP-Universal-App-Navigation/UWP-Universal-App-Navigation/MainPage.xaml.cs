using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using UWP_Universal_App_Navigation.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Universal_App_Navigation
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

        private async void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
         
            var id = txtId.Text;
            var name = txtName.Text;
            var dateOfBirth = dpDateofBirth.Date.DateTime;

            string message = string.Empty;

            if (id == "")
            {
                message += "Id must not empty\n";
            }
            Regex regex = new Regex(@"^[\d]+$");
            if (!regex.IsMatch(id))
            {
                message += "Id must a number!\n";
            }
            if (name == "")
            {
                message += "Name must not empty\n";
            }
            if (dpDateofBirth.SelectedDate == null) // vì sao k phải biến, vì giá trị của biến là giá trị của control sẽ k có null, nên phải thêm select vói biến
            {
                message += "Date of birth not empty";
            }
            if (dpDateofBirth.SelectedDate > DateTime.Now)
            {
                message += "Date of birth cant cannot be greater than current time";
            }
            if (message != string.Empty)
            {
                MessageDialog dialog = new MessageDialog(message);
                await dialog.ShowAsync();
            }
            else
            {
                Student student = new Student()
                {
                    Id = int.Parse(id),
                    Name = name,
                    DateOfBirth = dateOfBirth
                };

                Frame.Navigate(typeof(StudentDetailPage), student);
            }

        }
    }
}
