using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// TopApps.xaml 的交互逻辑
    /// </summary>
    public partial class TopApps : UserControl
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnTopAppButtonClicked(object sender, RoutedEventArgs e);
        public event OnTopAppButtonClicked TopAppButtonClicked;
        public TopApps()
        {
            InitializeComponent();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            // /Images/TopAppIcons/85-Night castle.png
            string appName = (new CultureInfo("en-US", false).TextInfo).ToTitleCase
                (
                (sender as Image).Source.ToString()
                .Split('/').Last()
                .Split('-').Last()
                .Split('.').First()
                );
            AppClicked(new AnApp(appName, (sender as Image).Source), e);
        }

        private void TopAppsButton_Click(object sender, RoutedEventArgs e)
        {
            TopAppButtonClicked(sender, e);
        }
    }
}

