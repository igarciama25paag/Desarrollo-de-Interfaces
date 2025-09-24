using System.DirectoryServices.ActiveDirectory;
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

namespace DatenFuntzioak
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

        private void exekutatu(object sender, RoutedEventArgs e)
        {
            orain.Text = DateTime.Now.ToString();
            gaur.Text = DateTime.Now.ToShortDateString();
            gaurkoOrdua.Text = DateTime.Now.ToLongTimeString();
        }

        private void dataGehituClick(object sender, MouseEventArgs e)
        {
            DataGehituWindow galderaLehioa = new DataGehituWindow();
            if(galderaLehioa.ShowDialog() == true)
                dataGehitu.Text = galderaLehioa.getResult();
        }

        private void datakEzberdinduClick(object sender, MouseEventArgs e)
        {
            DatakEzberdinduWindow galderaLehioa = new DatakEzberdinduWindow();
            if (galderaLehioa.ShowDialog() == true)
                datakEzberdindu.Text = galderaLehioa.getResult();
        }

        private void garbitu(object sender, RoutedEventArgs e)
        {
            orain.Text = null;
            gaur.Text = null;
            gaurkoOrdua.Text = null;
            dataGehitu.Text = null;
            datakEzberdindu.Text = null;
        }

        private void itxi(object sender, RoutedEventArgs e) => Close();
    }
}