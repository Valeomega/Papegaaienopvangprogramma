using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papegaaiencostumclasses
{
   public class Vogelsoort
    {
        public string Soortnaam { get; set; }
        public List<Vogelondersoort> ondersoorten { get; set; }
        public Voeding VogelVastevoeding { get; set; }
    }
}
