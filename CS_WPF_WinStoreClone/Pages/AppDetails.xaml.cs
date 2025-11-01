using System.Windows;
using System.Windows.Controls;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// AppDetails.xaml 的交互逻辑
    /// </summary>
    public partial class AppDetails : Page
    {

        public delegate void OnAppDetailsAnotherAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppDetailsAnotherAppClicked AppClicked;

        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;


        public AppDetails(AnApp inApp)
        {
            InitializeComponent();

            AppDetailsTitleAndBackgroundUC.AppNameLabel.Content = inApp.AppName;
            AppDetailsTitleAndBackgroundUC.AppImage.Source = inApp.AppImageSource;
            AppDetailsTitleAndBackgroundUC.BackButtonClicked += AppDetailsTitleAndBackgroundUC_BackButtonClicked;

            OverviewTabUC.AppClicked += OverviewTabUC_AppClicked;
        }

        private void OverviewTabUC_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked?.Invoke(sender, e);
        }

        private void AppDetailsTitleAndBackgroundUC_BackButtonClicked(object sender, RoutedEventArgs e)
        {
            BackButtonClicked?.Invoke(sender, e);
        }
    }
}
