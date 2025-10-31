using System.Windows;
using System.Windows.Controls;

namespace WindowsStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Overview.xaml 的交互逻辑
    /// </summary>
    public partial class Overview : UserControl
    {
        public delegate void OnAppDetailsAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppDetailsAppClicked AppClicked;
        public Overview()
        {
            InitializeComponent();
            AppViewerInsideOwerviewTab.AppClicked += AppsViewerInsideOwerviewTab_AnAppClicked;
        }

        private void AppsViewerInsideOwerviewTab_AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked?.Invoke(sender, e);
        }
    }
}
