using System.Windows;

namespace AtazaKudeatzailea
{
    /// <summary>
    /// Interaction logic for AtazaBerriaDialog.xaml
    /// </summary>
    public partial class AtazaBerriaDialog : Window
    {
        public Ataza result { get; set; }
        public AtazaBerriaDialog()
        {
            InitializeComponent();
            lehentasuna.ItemsSource = Enum.GetValues(typeof(LehentasunMaila));
        }
        private void sortu(object sender, RoutedEventArgs e)
        {
            if (izenburua.Text != String.Empty)
            {
                if (lehentasuna.SelectedItem != null)
                {
                    DateTime eguna;
                    if (DateTime.TryParse(mugaEguna.Text, out eguna) && eguna >= DateTime.Today)
                    {
                        result = new Ataza(izenburua.Text, (LehentasunMaila)lehentasuna.SelectedItem, eguna, false);
                        DialogResult = true;
                    }
                    else
                        MessageBox.Show("Data ez da gaurkoa baino handiagoa", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                } else
                    MessageBox.Show("Ez da lehentasun-mailarik aukeratu", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            } else
                MessageBox.Show("Ez da izenbururik sartu", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void itxi(object sender, RoutedEventArgs e) => DialogResult = false;

    }
}
