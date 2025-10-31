using System.Windows.Controls;

namespace WindowsStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// Reviews.xaml 的交互逻辑
    /// </summary>
    public partial class Reviews : UserControl
    {
        public Reviews()
        {
            InitializeComponent();
            MainStackPanel.Children.Clear();
            for (int i = 0; i < 9; i++)
            {
                MainStackPanel.Children.Add(new AReview());
            }
        }
    }
}
