using System.Windows;
using System.Windows.Controls;

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// AppDetailsTtileAndBackground.xaml 的交互逻辑
    /// </summary>
    public partial class AppDetailsTtileAndBackground : UserControl
    {
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;

        public AppDetailsTtileAndBackground()
        {
            InitializeComponent();
        }

        private void Back_Btn(object sender, RoutedEventArgs e)
        {
            // BackButtonClicked(sender, e);
            // 触发事件
            BackButtonClicked?.Invoke(sender, e);
        }
    }
}
