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

namespace LagunLista
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

        private void gehitu(object sender, RoutedEventArgs e)
        {
            if (lagunBerria.Text != "")
            {
                ListBoxItem lbi = new ListBoxItem();
                lbi.Content = lagunBerria.Text;
                lagunLista.Items.Add(lbi);
                lagunBerria.Text = null;
            }
            else
                MessageBox.Show("Ez da lagunik sartu", "Elementu errorea", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void ezabatu(object sender, RoutedEventArgs e)
        {
            if (lagunLista.SelectedItem != null)
                lagunLista.Items.Remove(lagunLista.SelectedItem);
            else
                MessageBox.Show("Ez da lagunik hautatu", "Elementu errorea", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void listaEzabatu(object sender, RoutedEventArgs e) => lagunLista.Items.Clear();

        private void itxi(object sender, RoutedEventArgs e) => Close();

        private void lagunBatAukeratu(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem lbi = (sender as ListBox).SelectedItem as ListBoxItem;
            if (lbi != null)
                autatutakoLaguna.Text = lbi.Content.ToString();
            else
                autatutakoLaguna.Text = null;
        }
    }
}