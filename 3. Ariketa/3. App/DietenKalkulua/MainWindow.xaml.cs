using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DietenKalkulua
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void totalaAldatu(object sender, TextChangedEventArgs e)
        {
            double N = 0, result;
            if (Double.TryParse(gosaria.Text, out result)) N += result;
            if (Double.TryParse(bazkaria.Text, out result)) N += result;
            if (Double.TryParse(afaria.Text, out result)) N += result;
            if (Double.TryParse(km.Text, out result)) N += result * 0.25;
            if (Double.TryParse(bidaiOrduak.Text, out result)) N += result * 18;
            if (Double.TryParse(lanOrduak.Text, out result)) N += result * 42;
            total.Text = N.ToString() + " €";
        }

        private void gosariaOn(object sender, RoutedEventArgs e) => gosaria.Text = "3";
        private void gosariaOff(object sender, RoutedEventArgs e) => gosaria.Text = string.Empty;
        private void bazkariaOn(object sender, RoutedEventArgs e) => bazkaria.Text = "9";
        private void bazkariaOff(object sender, RoutedEventArgs e) => bazkaria.Text = string.Empty;
        private void afariaOn(object sender, RoutedEventArgs e) => afaria.Text = "15.5";
        private void afariaOff(object sender, RoutedEventArgs e) => afaria.Text = string.Empty;

        private void garbitu(object sender, RoutedEventArgs e)
        {
            gosariaCheck.IsChecked = false;
            bazkariaCheck.IsChecked = false;
            afariaCheck.IsChecked = false;
            km.Text = string.Empty;
            bidaiOrduak.Text = string.Empty;
            lanOrduak.Text = string.Empty;
        }

        private void itxi(object sender, RoutedEventArgs e) => Close();
    }
}