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
using Windows.Web.Syndication;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Esimerkki2
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

        private const string feedURI = "http://www.iltalehti.fi/rss/uutiset.xml";
        private async void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Uri uri = new Uri(feedURI);
                SyndicationClient client = new SyndicationClient();
                client.BypassCacheOnRetrieve = true;

                SyndicationFeed feed = await client.RetrieveFeedAsync(uri);

                foreach(SyndicationItem item in feed.Items)
                {
                    textBlock.Text += item.Title.Text + " : " + item.PublishedDate.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                textBlock.Text = "Following exception has happend: " + ex.ToString();
            }            
        }
    }
}
