using System.IO;
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

namespace IrudiakEtaComboBox
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

        private void comboImgs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    img1.Source = new BitmapImage(new Uri("/img/esqueleto_diabolico.jpg", UriKind.Relative));
                    img2.Source = null;
                    img3.Source = null;
                    break;
                case 1:
                    img1.Source = null;
                    img2.Source = new BitmapImage(new Uri("/img/esqueleto_diabolico1.jpg", UriKind.Relative));
                    img3.Source = null;
                    break;
                default:
                    img1.Source = null;
                    img2.Source = null;
                    img3.Source = new BitmapImage(new Uri("/img/esqueleto_diabolico2.jpg", UriKind.Relative));
                    break;
            }
        }

        private void irudia1Bai(object sender, RoutedEventArgs e) => img4.Source = new BitmapImage(new Uri("/img/esqueleto_diabolico3.jpg", UriKind.Relative));
        private void irudia1Ez(object sender, RoutedEventArgs e) => img4.Source = null;
        private void irudia2Bai(object sender, RoutedEventArgs e) => img5.Source = new BitmapImage(new Uri("/img/esqueleto_diabolico4.jpg", UriKind.Relative));
        private void irudia2Ez(object sender, RoutedEventArgs e) => img5.Source = null;
        private void irudia3Bai(object sender, RoutedEventArgs e) => img6.Source = new BitmapImage(new Uri("/img/esqueleto_diabolico5.jpg", UriKind.Relative));
        private void irudia3Ez(object sender, RoutedEventArgs e) => img6.Source = null;

        private void itxi(object sender, RoutedEventArgs e) => Close();
    }
}