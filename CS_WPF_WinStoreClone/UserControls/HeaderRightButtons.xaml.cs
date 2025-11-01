using System.Windows;
using System.Windows.Controls;

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// HeaderRightButtons.xaml 的交互逻辑
    /// </summary>
    public partial class HeaderRightButtons : UserControl
    {

        public delegate void OnDownloadButtonClick(object sender, RoutedEventArgs e);
        public event OnDownloadButtonClick HeaderRightButtonsDownloadButtonClick;

        public HeaderRightButtons()
        {
            InitializeComponent();
        }

        public void MouseDown_OutsideOfHeaderRightButtons()
        {
            if (!SearchTextBox.IsMouseOver)
            {
                SearchButton.Visibility = Visibility.Visible;
                SearchTextBox.Visibility = Visibility.Collapsed;
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed;
            SearchTextBox.Visibility = Visibility.Visible;
        }

        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonsDownloadButtonClick(sender, e);
        }


        private void DownloadsAndUpdatesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonsDownloadButtonClick(sender, e);
        }
    }
}
