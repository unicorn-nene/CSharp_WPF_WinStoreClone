using System.Windows;
using System.Windows.Controls;

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// HamburgerMenuHeader.xaml 的交互逻辑
    /// </summary>
    public partial class HamburgerMenuHeader : UserControl
    {

        public delegate void OnFilterMenuItemClicked(object sender, RoutedEventArgs e);
        public event OnFilterMenuItemClicked FilterMenuItemClicked;

        public delegate void OnSortByMenuItemClicked(object sender, RoutedEventArgs e);
        public event OnSortByMenuItemClicked SortByMenuItemClicked;
        public HamburgerMenuHeader()
        {
            InitializeComponent();
        }

        private void Filter_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FilterByTypeLabel.Content = (sender as MenuItem).Header.ToString();
            FilterMenuItemClicked(sender, e);
        }

        private void SortBy_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            SortByLabel.Content = (sender as MenuItem).Header.ToString();
            SortByMenuItemClicked(sender, e);
        }
    }
}
