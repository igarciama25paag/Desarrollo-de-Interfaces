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

namespace AldagaiOrokorrak
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

        private void sartu(object sender, RoutedEventArgs e)
        {
            Erabiltzailea.izena = izena.Text;
            Erabiltzailea.abizena1 = abizena1.Text;
            Erabiltzailea.abizena2 = abizena2.Text;
            Erabiltzailea.dni = dni.Text;
        }

        private void kargatuEtaIkusi(object sender, RoutedEventArgs e) => new Window1().ShowDialog();

        private void itxi(object sender, RoutedEventArgs e) => Close();
    }
}