﻿using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WindowsStoreClone.UserControls.HamburgerMenuViews
{
    /// <summary>
    /// HamburgerMenuApp.xaml 的交互逻辑
    /// </summary>
    public partial class HamburgerMenuApp : UserControl
    {
        public List<string> AppNames;
        public List<string> AppTypes;
        public string AppName;
        public DateTime Purchased;
        public string Type;
        public HamburgerMenuApp()
        {
            InitializeComponent();

            AppTypes = new List<string>()
            {
                "Apps",
                "Games",
                "Movies",
                "Avatars",
            };

            List<string> filepaths = Directory.GetFiles
                (Environment.CurrentDirectory + @"\..\..\Images\MiniIcons", "*.png").ToList<string>();
            FileInfo myRandomFile = new FileInfo(filepaths[StaticRandom.Next(filepaths.Count)]);

            AppImage.Source = new BitmapImage(new Uri(myRandomFile.FullName, UriKind.RelativeOrAbsolute));
            AppNameLabel.Content = (new CultureInfo("en-US", false).TextInfo).ToTitleCase
                (
                AppImage.Source.ToString()
                .Split('/').Last()
                .Split('.').First()
                .Split('-').Last()
                .Split('.').First()
                );
            AppName = AppNameLabel.Content.ToString();

            Type = AppTypes[StaticRandom.Next(AppTypes.Count)];
            Purchased = new DateTime(2025, 1, StaticRandom.Next(4, DateTime.Now.Day + 1));
            PurchaseLabel.Content = "Purchased " + Purchased.ToString("d");
        }
    }
}
