using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System.Threading;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Esimerkki5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ThreadPoolTimer PeriodicTimer;
        private Random rand;
        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();            
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("StartButton thread id: " + Environment.CurrentManagedThreadId);

            TimeSpan period = TimeSpan.FromSeconds(1);
            PeriodicTimer = ThreadPoolTimer.CreatePeriodicTimer(ElapsedHander, period, DestroyedHandler);
        }
        private async void ElapsedHander(ThreadPoolTimer timer)
        {
            Debug.WriteLine("ElapsedHander thread id: " + Environment.CurrentManagedThreadId);

            // get random number
            double number = rand.NextDouble();
            // update UI
            await Dispatcher.RunAsync(CoreDispatcherPriority.High,
                () =>
                {
                    // UI components can be accessed within this scope
                    Debug.WriteLine("ElapsedHander after => thread id: " + Environment.CurrentManagedThreadId);
                    textBlock.Text = "Random number : " + number.ToString("0.0000");
                });
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            PeriodicTimer.Cancel();
        }
        private async void DestroyedHandler(ThreadPoolTimer timer)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.High,
            () =>
            {
                // UI components can be accessed within this scope.
                textBlock.Text = "PeriodicApp Timer Stopped!";
            });
        }
    }
}
