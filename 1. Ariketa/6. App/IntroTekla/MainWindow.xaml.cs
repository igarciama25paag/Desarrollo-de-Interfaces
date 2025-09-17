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

namespace IntroTekla
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

        private void enter1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                t2.Text = t1.Text;
                t1.Text = null;
            }
        }

        private void enter2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                t3.Text = t2.Text;
                t2.Text = null;
            }
        }

        private void enter3(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                t1.Text = t3.Text;
                t3.Text = null;
            }
        }

        private void garbitu(object sender, RoutedEventArgs e)
        {
            t1.Text = null;
            t2.Text = null;
            t3.Text = null;
        }

        private void itxi(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}