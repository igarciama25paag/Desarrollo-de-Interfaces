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

namespace GarraioenLekuErreserba
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new AutobusOrria());
        }

        private void Autobusa(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AutobusOrria());
        }

        private void Trena(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TrenOrria());
        }

        private void Hegazkina(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HegazkinOrria());
        }
    }
}