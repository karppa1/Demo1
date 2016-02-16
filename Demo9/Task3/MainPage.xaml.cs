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

namespace Task3
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

        int l,h,w,ikkuna,lasi;
        int karmi = 45;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            l = Convert.ToInt16(textBox.Text);
            h = Convert.ToInt16(textBox1.Text);
            w = Convert.ToInt16(textBox2.Text);

            ikkuna = l * h;
            lasi = (l - 2 * w) * (h - 2 * w);
            karmi = 2 * l + 2 * h;

            textBox3.Text = (ikkuna / 10).ToString() + " cm^2";
            textBox4.Text = (lasi / 10).ToString() + " cm^2";
            textBox5.Text = (karmi / 10).ToString() + " cm^2";
        }
    }
}
