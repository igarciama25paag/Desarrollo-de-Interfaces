using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtazaKudeatzailea
{
    public record Ataza(String izenburua, LehentasunMaila lehentasuna, DateTime mugaEguna, bool egoera);
}
