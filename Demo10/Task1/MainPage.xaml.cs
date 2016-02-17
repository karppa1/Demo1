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

namespace Task1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";

            if ((bool)checkBox.IsChecked)
            {
                textBox.Text += checkBox.Content + " ";
            }

            if ((bool)checkBox1.IsChecked)
            {
                textBox.Text += checkBox1.Content + " ";
            }

            if ((bool)checkBox2.IsChecked)
            {
                textBox.Text += checkBox2.Content + " ";
            }

            if ((bool)checkBox3.IsChecked)
            {
                textBox.Text += checkBox3.Content + " ";
            }

            if ((bool)checkBox4.IsChecked)
            {
                textBox.Text += checkBox4.Content + " ";
            }
        }
    }
}
