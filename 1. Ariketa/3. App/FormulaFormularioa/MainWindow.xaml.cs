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

namespace FormulaFormularioa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int z, z1, z2, z3, z4;
        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            zenbakia.Focus();
        }

        private void aldatu()
        {
            z++;
            etiketa.Text = "Zenbakia " + (z+1);
            zenbakia.Text = null;
            zenbakia.Focus();
        }

        private void hurrengoa(object sender, RoutedEventArgs e)
        {
            switch(z)
            {
                case 0: 
                    z1 = Int32.Parse(zenbakia.Text);
                    aldatu();
                    break;
                case 1: 
                    z2 = Int32.Parse(zenbakia.Text);
                    aldatu();
                    break;
                case 2: 
                    z3 = Int32.Parse(zenbakia.Text);
                    aldatu();
                    break;
                default:
                    z4 = Int32.Parse(zenbakia.Text);
                    new SubWindow((z1 + (z1 * z2) + (z2 * z3) + (z3 * z4)) / 4).Show();
                    Close();
                    break;
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            e.Handled = Regex.IsMatch(e.Text, "[^0-9]+");
        }

        private void itxi(object sender, RoutedEventArgs e) => Close();
    }
}