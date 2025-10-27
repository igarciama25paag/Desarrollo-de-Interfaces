using System.Collections;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace GarraioenLekuErreserba
{
    internal static class ErreserbaManager
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        private static readonly string AUTOBUSA_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "erreserbak", "autobusa.json");
        private static readonly string TRENA_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "erreserbak", "trena.json");
        private static readonly string HEGAZKINA_FILE = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "erreserbak", "hegazkina.json");

        internal record Erreserba(string Izena, List<string> Eserlekuak);

        public static ObservableCollection<Erreserba> HartuAutobusErreserbak()
        {
             return JsonSerializer.Deserialize<ObservableCollection<Erreserba>>(File.ReadAllText(AUTOBUSA_FILE));
        }
        public static ObservableCollection<Erreserba> HartuTrenErreserbak()
        {
            return JsonSerializer.Deserialize<ObservableCollection<Erreserba>>(File.ReadAllText(TRENA_FILE));
        }
        public static ObservableCollection<Erreserba> HartuHegazkinErreserbak()
        {
            return JsonSerializer.Deserialize<ObservableCollection<Erreserba>>(File.ReadAllText(HEGAZKINA_FILE));
        }

        public static void GordeAutobusErreserbak(ObservableCollection<Erreserba> erreserbak)
        {
            File.WriteAllText(AUTOBUSA_FILE, JsonSerializer.Serialize(erreserbak, options));
        }
        public static void GordeTrenErreserbak(ObservableCollection<Erreserba> erreserbak)
        {
            File.WriteAllText(TRENA_FILE, JsonSerializer.Serialize(erreserbak, options));
        }
        public static void GordeHegazkinErreserbak(ObservableCollection<Erreserba> erreserbak)
        {
            File.WriteAllText(HEGAZKINA_FILE, JsonSerializer.Serialize(erreserbak, options));
        }
    }
}
