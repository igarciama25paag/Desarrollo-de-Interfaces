using System.Data;
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

namespace Kalkulagailua
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

        private void b0(object sender, RoutedEventArgs e)
        {
            if(kal.Text != "0" && int.TryParse(kal.Text.Last() + "", out int numero)) kal.Text += 0;
        }

        private void b1(object sender, RoutedEventArgs e) => idatzi("1");

        private void b2(object sender, RoutedEventArgs e) => idatzi("2");

        private void b3(object sender, RoutedEventArgs e) => idatzi("3");

        private void b4(object sender, RoutedEventArgs e) => idatzi("4");

        private void b5(object sender, RoutedEventArgs e) => idatzi("5");

        private void b6(object sender, RoutedEventArgs e) => idatzi("6");

        private void b7(object sender, RoutedEventArgs e) => idatzi("7");

        private void b8(object sender, RoutedEventArgs e) => idatzi("8");

        private void b9(object sender, RoutedEventArgs e) => idatzi("9");

        private void bdot(object sender, RoutedEventArgs e) => symbol(".");

        private void gei(object sender, RoutedEventArgs e) => symbol("+");

        private void ken(object sender, RoutedEventArgs e) => symbol("-");

        private void bid(object sender, RoutedEventArgs e) => symbol("*");

        private void zat(object sender, RoutedEventArgs e) => symbol("/");

        private void hon(object sender, RoutedEventArgs e) => symbol("%");

        private void idatzi(String t)
        {
            if (kal.Text == "0") kal.Text = t;
            else kal.Text += t;
        }

        private void symbol(String symbol)
        {
            if (kal.Text != "0")
                if(int.TryParse(kal.Text.Last() + "", out int numero)) idatzi(symbol);
                else kal.Text = kal.Text.Substring(0, kal.Text.Length - 1) + symbol;
        }

        private void ebatzi(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.TryParse(kal.Text.Last() + "", out int numero))
                    kal.Text = new DataTable().Compute(kal.Text, "").ToString().Replace(",", ".");
            }
            catch
            {
                kal.Text = null;
            }
        }

        private void clear(object sender, RoutedEventArgs e) => kal.Text = "0";

        private void clearElement(object sender, RoutedEventArgs e)
        {
            if (kal.Text != "0")
            {
                char[] symbols = {'+','-','*','/'};
                int n = kal.Text.Length-1;
                while (n > 0 && !symbols.Contains(kal.Text[n])) n--;
                kal.Text = kal.Text.Substring(0, n);
                if (kal.Text == "") kal.Text = "0";
            }
        }
    }
}