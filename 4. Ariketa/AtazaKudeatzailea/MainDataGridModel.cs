using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Xml.Linq;

namespace AtazaKudeatzailea
{
    class MainDataGridModel
    {
        public ObservableCollection<Ataza> atazak { get; set; }
        public MainDataGridModel()
        {
            atazak = new ObservableCollection<Ataza>();
            if(!File.Exists("Atazak.xml"))
                new XDocument(
                    new XElement("Atazak")
                ).Save("Atazak.xml");

            AtazakKargatu();
        }
        public void AtazaGehitu(Ataza ataza) => atazak.Add(ataza);
        public void AtazaEzabatu(Ataza ataza) => atazak.Remove(ataza);
        public void AtazakKargatu()
        {
            foreach (var atz in XDocument.Load("Atazak.xml").Root
                                .Elements("Ataza")
                                .Select(a => new Ataza(
                                    a.Element("Izenburua")?.Value ?? "",
                                    (LehentasunMaila)Enum.Parse(typeof(LehentasunMaila), a.Element("Lehentasuna")?.Value ?? "Baxua"),
                                    DateTime.Parse(a.Element("Muga-eguna")?.Value ?? DateTime.MinValue.ToString()),
                                    bool.Parse(a.Element("Egoera")?.Value ?? "false"))
                                )
                                .ToList())
                atazak.Add(atz);
        }
        public void AtazakGorde()
        {
            new XDocument(
                new XElement("Atazak",
                    atazak.Select(a =>
                        new XElement("Ataza",
                            new XElement("Izenburua", a.izenburua),
                            new XElement("Lehentasuna", a.lehentasuna),
                            new XElement("Muga-eguna", a.mugaEguna.ToShortDateString()),
                            new XElement("Egoera", a.egoera)
                        )
                    )
                )
            ).Save("Atazak.xml");
        }
    }
}
