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

namespace FormulaFormularioa
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        public SubWindow(double n)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            zenbakia.Text = n.ToString();
        }

        private void garbitu(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }

        private void itxi(object sender, RoutedEventArgs e) => Close();
    }
}
