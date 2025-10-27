using System.Windows;

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