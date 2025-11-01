using MahApps.Metro.Controls;
using System.Windows;
using System.Windows.Controls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// DownloadsAndUpdates.xaml 的交互逻辑
    /// </summary>
    public partial class DownloadsAndUpdates : Page
    {
        public delegate void OnBackButtonClick(object sender, RoutedEventArgs e);
        public event OnBackButtonClick BackButtonClicked;
        public DownloadsAndUpdates()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }

        private void HamburgerMenuControl_OnItemInvoked(object sender, HamburgerMenuItemInvokedEventArgs args)
        {
            HamburgerMenuControl.Content = args.InvokedItem;
        }
    }
}
