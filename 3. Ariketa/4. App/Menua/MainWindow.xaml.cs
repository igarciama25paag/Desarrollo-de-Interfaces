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

namespace Menua
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

        private void itxi(object sender, RoutedEventArgs e) => Close();

        private void delete(object sender, RoutedEventArgs e) => textBox.SelectedText = String.Empty;
        private void arial(object sender, RoutedEventArgs e) => textBox.FontFamily = new FontFamily("Arial");
        private void courier(object sender, RoutedEventArgs e) => textBox.FontFamily = new FontFamily("Courier");
        private void impact(object sender, RoutedEventArgs e) => textBox.FontFamily = new FontFamily("Impact");
        private void symbol(object sender, RoutedEventArgs e) => textBox.FontFamily = new FontFamily("Symbol");
    }
}