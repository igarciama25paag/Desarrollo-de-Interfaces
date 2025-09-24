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
    /// Interaction logic for DatakEzberdinduWindow.xaml
    /// </summary>
    public partial class DatakEzberdinduWindow : Window
    {
        private String result;
        private int fase = 1;
        private DateTime data1, data2;

        public DatakEzberdinduWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            input.Focus();
        }

        private void ados(object sender, RoutedEventArgs e)
        {
            if (fase == 1)
            {
                if (DateTime.TryParse(input.Text, out data1))
                {
                    input.Text = null;
                    fase = 2;
                    textua.Text = "Sartu bigarren data:";
                    input.Focus();
                }
                else
                    MessageBox.Show("Formatu ezegokia", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (fase == 2)
            {
                if (DateTime.TryParse(input.Text, out data2))
                {
                    result = data1.ToShortDateString() + "-tik " + data2.ToShortDateString() + "-ra " + Math.Abs((data1 - data2).Days) + " egun daude.";
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
