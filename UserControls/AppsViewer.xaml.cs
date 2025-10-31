using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// AppsViewer.xaml 的交互逻辑
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        List<AnApp> PresentedApps;

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public AppsViewer()
        {
            InitializeComponent();

            PresentedApps = new List<AnApp>();
            AppsList.ItemsSource = PresentedApps;
            for (int i = 0; i < 9; i++)
            {
                AnApp curr = new AnApp();
                curr.AppClicked += Curr_AppClicked;
                PresentedApps.Add(curr);
            }
        }

        private void Curr_AppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        // 当点击向左滚动按钮时，视图会立即向左移动相当于4个应用项目宽度的距离。3个当前屏幕加下一个屏幕的第一个应用
        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)PresentedApps.First().ActualWidth + 2 * (int)PresentedApps.First().Margin.Left;
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset - 4 * widthOfOneApp);
        }
        // 当点击向左滚动按钮时，视图会立即向右移动相当于4个应用项目宽度的距离。3个当前屏幕加下一个屏幕的第一个应用
        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)PresentedApps.First().ActualWidth + 2 * (int)PresentedApps.First().Margin.Left;
            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 4 * widthOfOneApp);
        }

        // 当滚动鼠标滚轮时，如果鼠标位于内层 ScrollViewer 上，它会拦截滚轮事件，导致外层的 ScrollViewer 无法滚动。
        // 为了改善这种体验，我们需要 手动把滚轮事件“转发”给外层控件，这就是这个函数要做的事
        // 当用户在内层滚动区域（比如 AppsScrollView）滚动鼠标滚轮时，拦截这个事件，然后手动把它转发给父控件，让外层的滚动区域来响应。
        //private void AppsScrollView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        //{
        //    // 拦截事件,不再继续冒泡传播
        //    e.Handled = true;

        //    // 构造新的鼠标滚轮对象
        //    var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
        //    eventArg.Source = sender;

        //    // 获取父控件
        //    // obejct没有父类, Control 是 WPF 中绝大数控件的基类
        //    // UIElement类可以手动触发事件(函数)
        //    var parent = ((Control)sender).Parent as UIElement;

        //    // 手动触发新事件,把新事件发送给父控件
        //    if (parent != null)
        //    {
        //        parent.RaiseEvent(eventArg);
        //    }
        //}
        private void AppsScrollView_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            e.Handled = true;

            var controlSender = sender as Control;
            if (controlSender == null)
                return;  // 如果不是 Control，就不做处理，避免崩溃

            var parent = controlSender.Parent as UIElement;
            if (parent != null)
            {
                var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta)
                {
                    RoutedEvent = UIElement.MouseWheelEvent,
                    Source = sender
                };
                parent.RaiseEvent(eventArg);
            }
        }

    }
}
