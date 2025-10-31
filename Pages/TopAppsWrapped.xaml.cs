using System.Windows;
using System.Windows.Controls;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone.Pages
{
    /// <summary>
    /// TopAppsWrapped.xaml 的交互逻辑
    /// </summary>
    public partial class TopAppsWrapped : Page
    {


        public delegate void OnAnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAnAppClicked AnAppClicked;
        public delegate void OnBackButtonClicked(object sender, RoutedEventArgs e);
        public event OnBackButtonClicked BackButtonClicked;
        public TopAppsWrapped()
        {
            InitializeComponent();

            for (int i = 0; i < 20; ++i)
            {
                AnApp currAnApp = new AnApp();
                currAnApp.AppClicked += Curr_AnAppClicked;
                TopAppsWrappedPageMainWrapPanel.Children.Add(currAnApp);
            }
        }

        private void Curr_AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AnAppClicked?.Invoke(sender, e);
        }



        private void TopAppWrappedPageMainSV_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (e.VerticalChange > 0)
            {
                int adjustment = 400;
                if (e.VerticalOffset + e.ViewportHeight + adjustment >= e.ExtentHeight)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        AnApp currAnApp = new AnApp();
                        currAnApp.AppClicked += Curr_AnAppClicked;
                        TopAppsWrappedPageMainWrapPanel.Children.Add(currAnApp);
                    }
                }
            }
        }

        private void Back_Btn(object sender, RoutedEventArgs e)
        {
            BackButtonClicked(sender, e);
        }
    }
}
