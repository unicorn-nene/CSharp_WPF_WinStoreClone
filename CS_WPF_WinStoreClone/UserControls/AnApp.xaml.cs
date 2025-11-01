using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WindowsStoreClone.UserControls
{
    /// <summary>
    /// AnApp.xaml 的交互逻辑
    /// </summary>
    public partial class AnApp : UserControl
    {
        public string AppName;
        public ImageSource AppImageSource;

        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;
        public AnApp()
        {
            InitializeComponent();

            // "*.png"表示只获取 PNG 文件
            // .ToList<string>(): 将返回的字符串数组转换为 List<string>
            List<string> filePaths =
                Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images", "*.png").ToList<string>();
            // StaticRandom.Next():是一个自定义的随机数生成器，返回 0 到 filePaths.Count-1 之间的随机数
            FileInfo myRandomFile =
                new FileInfo(filePaths[StaticRandom.Next(filePaths.Count)]);
            //myRandomFile.FullName: 获取文件的完整路径
            ProductImage.Source =
                new BitmapImage(new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));

            // Images/001-mail inbox app.png -> mail inbox app
            AppNameText.Text =
                (new CultureInfo("en-US", false).TextInfo).ToTitleCase(myRandomFile.FullName
                .Split('/').Last()     // 保留 '/' 之后的部分 001-mail inbox app.png
                .Split('-').Last()      // 保留 '-' 之后的部分 mail inbox app.png
                .Split('.').First());   // 保留 '.' 之前的部分 mail inbox app

            AppImageSource = ProductImage.Source;
            AppName = AppNameText.Text.ToString();
        }

        public AnApp(string inAppName, ImageSource inImageSource)
        {
            InitializeComponent();
            ProductImage.Source = inImageSource;
            AppNameText.Text = inAppName;
            AppImageSource = inImageSource;
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {
            AppClicked?.Invoke(this, e);
        }
    }
}
