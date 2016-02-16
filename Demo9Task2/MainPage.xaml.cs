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

namespace Demo9Task2
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

        double tulos;        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            tulos = Convert.ToDouble(textBox.Text);
            tulos = tulos / 5.94573;            
            textBlock.Text = tulos.ToString("0.00");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            tulos = Convert.ToDouble(textBox.Text);
            tulos = tulos * 5.94573;
            textBlock.Text = tulos.ToString("0.00");
        }
    }
}
