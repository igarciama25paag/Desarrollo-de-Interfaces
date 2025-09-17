using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ariketa1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_Operar(object sender, RoutedEventArgs e)
        {
            double op = (Double.Parse(n1.Text) + Double.Parse(n2.Text)*2 + Double.Parse(n3.Text)*3 + Double.Parse(n4.Text)*4)/4;
            res.Text = op.ToString();
        }

        private void BTN_Limpiar(object sender, RoutedEventArgs e)
        {
            n1.Text = null;
            n2.Text = null;
            n3.Text = null;
            n4.Text = null;
            res.Text = null;
        }

        private void BTN_Salir(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.-]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}