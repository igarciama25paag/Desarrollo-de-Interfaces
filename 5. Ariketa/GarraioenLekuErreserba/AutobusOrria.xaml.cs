using EserlekuakLibrary;
using System.Collections;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;

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
        private readonly ObservableCollection<ErreserbaManager.Erreserba> erreserbakList;

        public AutobusOrria()
        {
            InitializeComponent();
            erreserbakList = ErreserbaManager.HartuAutobusErreserbak();
            erreserbak.ItemsSource = erreserbakList;

            for (int i = 0; i < eserlekuLength; i++)
            {
                StackPanel eserlekuPanel = new();
                eserlekuPanel.Orientation = Orientation.Horizontal;
                eserlekuak.Children.Add(eserlekuPanel);

                for (int j = 0; j < eserlekuLines; j++)
                {
                    if (j > 0) eserlekuPanel.Children.Add(new StackPanel() { Width = 50 });

                    for (int k = 0; k < eserlekuWidth; k++)
                    {
                        EserlekuaButton eser = new((eserlekuList.Count + 1).ToString(), false, 50);
                        eser.Margin = new Thickness(5);

                        foreach (ErreserbaManager.Erreserba erre in erreserbakList)
                            foreach (string izena in erre.Eserlekuak)
                                if (eser.Izena == izena) eser.Erreserbatu(true);

                        eserlekuList.Add(eser);
                        eserlekuPanel.Children.Add(eser);
                    }
                }
            }
        }

        private void Erreserbatu(object sender, RoutedEventArgs e)
        {
            ArrayList aukeratutakoEserlekuak = new();

            foreach(EserlekuaButton eserlekua in eserlekuList)
                if(eserlekua.Aukeratuta) aukeratutakoEserlekuak.Add(eserlekua);

            if (aukeratutakoEserlekuak.Count == 0)
                MessageBox.Show("Ez da eserlekurik aukeratu.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if(MessageBox.Show("Aukeratutako eserlekuak erreserbatu?",
                        "Eserlekuak erreserbatu",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                string izena = "Erreserba ";
                var izenak = new List<string>();
                foreach (EserlekuaButton eserlekua in aukeratutakoEserlekuak)
                {
                    eserlekua.Erreserbatu(true);
                    izenak.Add(eserlekua.Izena);
                    izena += " " + eserlekua.Izena;
                }
                erreserbakList.Add(new ErreserbaManager.Erreserba(izena, izenak));
                ErreserbaManager.GordeAutobusErreserbak(erreserbakList);
            }
        }

        private void ErreserbaEzabatu(object sender, RoutedEventArgs e)
        {
            if(erreserbak.SelectedIndex == -1)
                MessageBox.Show("Ez da erreserbarik aukeratu.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (MessageBox.Show("Aukeratutako erreserba ezabatu?",
                    "Eserleku erreserba kendu",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                int item = erreserbak.SelectedIndex;
                foreach (string eserlekuIzena in erreserbakList.ElementAt(item).Eserlekuak)
                    foreach (EserlekuaButton eserlekua in eserlekuList)
                        if (eserlekua.Izena == eserlekuIzena) eserlekua.Erreserbatu(false);

                erreserbakList.RemoveAt(item);
                ErreserbaManager.GordeAutobusErreserbak(erreserbakList);
            }
        }
    }
}
