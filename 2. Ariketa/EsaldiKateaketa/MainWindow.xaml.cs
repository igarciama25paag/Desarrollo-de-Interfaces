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

namespace EsaldiKateaketa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String esaldiOsoa = "";

        public MainWindow()
        {
            InitializeComponent();
            esaldia.Focus();
        }

        private void muntatu()
        {
            esaldiOsoa += esaldia.Text + " ";
            esaldia.Text = null;
            esaldia.Focus();
        }

        private void e1(object sender, RoutedEventArgs e)
        {
            muntatu();
            b1.IsEnabled = false;
            b2.IsEnabled = true;
        }

        private void e2(object sender, RoutedEventArgs e)
        {
            muntatu();
            b2.IsEnabled = false;
            b3.IsEnabled = true;
        }

        private void e3(object sender, RoutedEventArgs e)
        {
            muntatu();
            b3.IsEnabled = false;
            b4.IsEnabled = true;
        }

        private void e4(object sender, RoutedEventArgs e)
        {
            muntatu();
            b4.IsEnabled = false;
            b5.IsEnabled = true;
        }

        private void e5(object sender, RoutedEventArgs e)
        {
            muntatu();
            b5.IsEnabled = false;
            bbatu.IsEnabled = true;
        }

        private void batu(object sender, RoutedEventArgs e)
        {
            muntatu();
            bbatu.IsEnabled = false;
            esaldia.Text = esaldiOsoa;
        }

        private void garbitu(object sender, RoutedEventArgs e)
        {
            esaldia.Text = null;
            esaldiOsoa = "";
            b1.IsEnabled = true;
            b2.IsEnabled = false;
            b3.IsEnabled = false;
            b4.IsEnabled = false;
            b5.IsEnabled = false;
            bbatu.IsEnabled = false;
            esaldia.Focus();
        }

        private void itxi(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}