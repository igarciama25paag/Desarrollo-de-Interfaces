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

namespace ErabiltzailePasahitza
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
            if(user.Text == "Informatika" && pass.Password == "1234")
            {
                mezua.Text = "Ongi etorri Sistemara, " + user.Text;
            } else
            {
                mezua.Text = "Identifikatu gabeko erabiltzailea";
            }
        }

        private void garbitu(object sender, RoutedEventArgs e)
        {
            user.Text = null;
            pass.Password = null;
            mezua.Text = null;
        }

        private void itxi(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}