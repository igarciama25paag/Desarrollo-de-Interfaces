using System.Windows;

namespace AtazaKudeatzailea
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainDataGridModel dataGridModel => (MainDataGridModel)DataContext;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void berria(object sender, RoutedEventArgs e)
        {
            AtazaBerriaDialog dialog = new AtazaBerriaDialog();
            dialog.ShowDialog();
            if (dialog.DialogResult == true)
            {
                dataGridModel.AtazaGehitu(dialog.result);
                dataGridModel.AtazakGorde();
            }
        }

        private void editatu(object sender, RoutedEventArgs e)
        {
            atazaGrid.IsReadOnly = !atazaGrid.IsReadOnly;
            dataGridModel.AtazakGorde();
        }

        private void ezabatu(object sender, RoutedEventArgs e)
        {
            dataGridModel.AtazaEzabatu((Ataza)atazaGrid.SelectedItem);
            dataGridModel.AtazakGorde();
        }

        private void irten(object sender, RoutedEventArgs e) => Close();
    }
}