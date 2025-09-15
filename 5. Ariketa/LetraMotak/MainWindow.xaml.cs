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

namespace LetraMotak
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

        private void verdana(object sender, RoutedEventArgs e)
        {
            if(probaTextua.FontFamily.Equals(new FontFamily("Verdana"))) {
                probaTextua.FontFamily = new FontFamily("Arial");
            } else
            {
                probaTextua.FontFamily = new FontFamily("Verdana");
            }
        }

        private void courier(object sender, RoutedEventArgs e)
        {
            if (probaTextua.FontFamily.Equals(new FontFamily("Courier new")))
            {
                probaTextua.FontFamily = new FontFamily("Arial");
            }
            else
            {
                probaTextua.FontFamily = new FontFamily("Courier new");
            }
        }

        private void negrita(object sender, RoutedEventArgs e)
        {
            if (probaTextua.FontWeight == FontWeights.Bold)
            {
                probaTextua.FontWeight = FontWeights.Light;
            } else
            {
                probaTextua.FontWeight = FontWeights.Bold;
            }
        }

        private void kursiba(object sender, RoutedEventArgs e)
        {
            if(probaTextua.FontStyle == FontStyles.Italic)
            {
                probaTextua.FontStyle = FontStyles.Normal;
            } else
            {
                probaTextua.FontStyle = FontStyles.Italic;
            }
        }

        private void tatxatu(object sender, RoutedEventArgs e)
        {
            if(probaTextua.TextDecorations == TextDecorations.Strikethrough)
            {
                probaTextua.TextDecorations = null;
            } else
            {
                probaTextua.TextDecorations = TextDecorations.Strikethrough;
            }
        }

        private void azpimarra(object sender, RoutedEventArgs e)
        {
            if(probaTextua.TextDecorations == TextDecorations.Underline)
            {
                probaTextua.TextDecorations = null;
            } else
            {
                probaTextua.TextDecorations = TextDecorations.Underline;
            }
        }

        private void txikitu(object sender, RoutedEventArgs e)
        {
            if(probaTextua.FontSize > 5)
            {
                probaTextua.FontSize--;
            }
        }

        private void handitu(object sender, RoutedEventArgs e)
        {
            if (probaTextua.FontSize < 20)
            {
                probaTextua.FontSize++;
            }
        }

        private void aukeratu(object sender, RoutedEventArgs e)
        {
            aukeraMezua.Text = "Textua " + textua.Text.Length + " karaktere ditu eta aukeratutako textua '" + textua.SelectedText + "' da.";
        }

        private void itxi(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}