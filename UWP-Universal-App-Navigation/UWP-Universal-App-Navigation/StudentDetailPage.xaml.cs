using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Universal_App_Navigation.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Universal_App_Navigation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StudentDetailPage : Page
    {
        public StudentDetailPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var student = e.Parameter as Student;

            if(student != null)
            {
                tbId.Text = "ID: " + student.Id; // id khi này là int nhưng + với string sẽ tự thành string
                tbName.Text = "Name: " + student.Name;
                tbDateofBirth.Text = "Date Of Birth: " + student.DateOfBirth.ToString("dd/MM/yyyy");
            }
        }
    }
}
