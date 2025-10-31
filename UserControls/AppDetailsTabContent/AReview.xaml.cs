using MiscUtil;
using System.Collections.Generic;
using System.Windows.Controls;

namespace WindowsStoreClone.UserControls.AppDetailsTabContent
{
    /// <summary>
    /// AReview.xaml 的交互逻辑
    /// </summary>
    public partial class AReview : UserControl
    {
        List<string> Names;
        public AReview()
        {
            InitializeComponent();

            Names = new List<string>() { "Viktoria", "Mike", "Zoltan", "Maria", "Daniel", "Danney" };

            string reviewerName = Names[StaticRandom.Next(Names.Count)];
            ReviewNameLabel.Content = reviewerName;
            AvatarLabel.Content = reviewerName[0];
            NumofStarsLabel.Content = GetRandomNumOfStarts();
            ReviewTitle.Content = GetReviewTitleBasedOnStars(NumofStarsLabel.Content.ToString());
        }

        private string GetRandomNumOfStarts()
        {
            string content = "";
            for (int i = 0; i < StaticRandom.Next(1, 6); i++)
            {
                content += "⭐";
            }
            return content;
        }

        private string GetReviewTitleBasedOnStars(string inStars)
        {
            string retStr = "";
            if (inStars.Length >= 4)
            {
                retStr = "This app is really awesome";
            }
            else if (inStars.Length == 3)
            {
                retStr = "This app is all right";
            }
            else
            {
                retStr = "This app is poor";
            }
            return retStr;
        }
    }
}
