using System.Windows;
using System.Windows.Controls;

namespace _01_WpfBasic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {this.DescriptionText.Text}"); // 字符串插值
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldChechbox.IsChecked =
            this.AssemblyChechbox.IsChecked =
            this.PlasmaChechbox.IsChecked =
            this.LaserChechbox.IsChecked =
            this.PurchaseChechbox.IsChecked =
            this.LatheCheckbox.IsChecked =
            this.DrillCheckbox.IsChecked =
            this.FoldCheckbox.IsChecked =
            this.RollCheckbox.IsChecked =
            this.SawCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropdown_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            this.NoteText.Text = (string)value.Content;
        }

        private void SupplierName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassTextBox.Text = this.SupplierName.Text;
        }
    }
}
