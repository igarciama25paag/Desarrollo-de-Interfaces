using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EserlekuakLibrary
{
    /// <summary>
    /// Interaction logic for EserlekuaButton.xaml
    /// </summary>
    public partial class EserlekuaButton : UserControl
    {
        public bool Erreserbatuta { get; set; } = false;
        public bool Aukeratuta { get; set; } = false;
        public string Izena { get; set; } = string.Empty;
        public int LetraTamaina { get; set; } = 0;
        public int Tamaina { get; set; } = 0;

        public EserlekuaButton()
        {
            InitializeComponent();
            DataContext = this;
        }

        public EserlekuaButton(string izena, bool erreserbatuta, int tamaina)
        {
            InitializeComponent();
            DataContext = this;
            Izena = izena;
            Tamaina = tamaina;
            Erreserbatu(erreserbatuta);
        }

        private void EserlekuaClick(object sender, RoutedEventArgs e)
        {
            if(!Erreserbatuta) Aukeratu(!Aukeratuta);
        }

        private void Aukeratu(bool aukeratu)
        {
            Aukeratuta = aukeratu;
            if (Aukeratuta) eserlekua.Background = Brushes.LightGreen;
            else eserlekua.Background = Brushes.LightGray;
        }

        public void Erreserbatu(bool erreserbatu)
        {
            Erreserbatuta = erreserbatu;
            Aukeratu(false);
            IsEnabled = !Erreserbatuta;
        }
    }
}
