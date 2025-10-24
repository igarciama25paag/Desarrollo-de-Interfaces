using EserlekuakLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GarraioenLekuErreserba
{
    /// <summary>
    /// Interaction logic for AutobusOrria.xaml
    /// </summary>
    public partial class AutobusOrria : Page
    {
        private readonly int eserlekuLines = 2;
        private readonly int eserlekuWidth = 1;
        private readonly int eserlekuLength = 5;
        private readonly ArrayList eserlekuList = new();
        private readonly ObservableCollection<Erreserba> erreserbakList = new();

        public AutobusOrria()
        {
            InitializeComponent();
            erreserbak.ItemsSource = erreserbakList;

            for (int i = 0; i < eserlekuLines; i++)
            {
                if (i > 0) eserlekuak.Children.Add(new StackPanel() { Width = 50 });

                for(int j = 0; j < eserlekuWidth; j++)
                {
                    StackPanel eserlekuPanel = new();
                    eserlekuak.Children.Add(eserlekuPanel);

                    for(int k = 0; k < eserlekuLength; k++)
                    {
                        EserlekuaButton e = new((eserlekuList.Count + 1).ToString(), false, 50);
                        e.Margin = new Thickness(5);
                        eserlekuList.Add(e);
                        eserlekuPanel.Children.Add(e);
                    }
                }
            }
        }

        private void Erreserbatu(object sender, RoutedEventArgs e)
        {
            ArrayList aukeratutakoEserlekuak = new();

            foreach(EserlekuaButton eserlekua in eserlekuList)
                if(eserlekua.Aukeratuta) aukeratutakoEserlekuak.Add(eserlekua);

            if (MessageBox.Show("Aukeratutako eserlekuak erreserbatu?",
                        "Eserlekuak erreserbatu",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                String izena = "Err." + erreserbakList.Count + ":";
                foreach (EserlekuaButton eserlekua in aukeratutakoEserlekuak)
                {
                    eserlekua.Erreserbatu(true);
                    izena += " " + eserlekua.Izena;
                }
                erreserbakList.Add(new Erreserba(izena, aukeratutakoEserlekuak));
            }
        }

        private void ErreserbaEzabatu(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Aukeratutako erreserba ezabatu?",
                    "Eserleku erreserba kendu",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                int item = erreserbak.SelectedIndex;
                foreach(EserlekuaButton eserlekua in erreserbakList.ElementAt(item).Eserlekuak)
                    eserlekua.Erreserbatu(false);
                erreserbakList.RemoveAt(item);
            }
        }
    }
}
