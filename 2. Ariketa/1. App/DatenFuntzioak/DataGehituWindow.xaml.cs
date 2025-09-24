using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DatenFuntzioak
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class DataGehituWindow : Window
    {
        private String result;
        private int fase = 1, hil;
        private DateTime data;

        public DataGehituWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            input.Focus();
        }

        private void ados(object sender, RoutedEventArgs e)
        {
            if (fase == 1)
            {
                if (DateTime.TryParse(input.Text, out data))
                {
                    input.Text = null;
                    fase = 2;
                    textua.Text = "Sartu gehitu nahi diren hilabete kopurua:";
                    input.Focus();
                }
                else
                    MessageBox.Show("Formatu ezegokia", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (fase == 2)
            {
                if (Int32.TryParse(input.Text, out hil))
                {
                    result = "Hasierako data: " + data.ToShortDateString() + ", Gehitutako hilabeteak: " + hil + ", Data berria: " + data.AddMonths(hil).ToShortDateString();
                    DialogResult = true;
                }
                else
                    MessageBox.Show("Formatu ezegokia", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void itxi(object sender, RoutedEventArgs e) => Close();

        public String getResult() => result;
    }
}
