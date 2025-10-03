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

namespace AldagaiOrokorrak
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();

            izena.Text = Erabiltzailea.izena;
            abizena1.Text = Erabiltzailea.abizena1;
            abizena2.Text = Erabiltzailea.abizena2;
            dni.Text = Erabiltzailea.dni;
        }

        private void itxi(object sender, RoutedEventArgs e) => Close();
    }
}
