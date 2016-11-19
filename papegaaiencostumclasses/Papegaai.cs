using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papegaaiencostumclasses
{
    
   public class Papegaai
    {
        public string naam { get; set; }
        public Vogelsoort soort { get; set; }
        public Vogelondersoort ondersoort { get; set; }
        public bool Sex { get; set; }
        public Persoon peter { get; set; }
        public Persoon meter { get; set; }
        public Medisch MEDISCHINFO { get; set; }
        public ID id { get; set; }
        public bool aanafwezig { get; set; }
        public string infoderafwezigheid { get; set; }
        public Persoon addoptant { get; set; }

    }
}
