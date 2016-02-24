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

using Esimerkki2.Model;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Esimerkki2
{
    public sealed partial class MainPage : Page
    {
        // define view model from UI
        public EmployeeViewModel ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();

            // initialize view model
            this.ViewModel = new EmployeeViewModel();
        }

        // show selected employees name below list view
        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Employee employee = (Employee)e.ClickedItem;
            ResultTextBlock.Text = "Selected employee: " + employee.Firstname + " " + employee.Lastname;
        }
    }
}
