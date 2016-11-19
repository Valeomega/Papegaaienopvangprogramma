using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papegaaiencostumclasses
{
    public class Medischonderzoek
    {
       public List<Verwondingen> lijstmetalleklachten { get; set; }
        public DateTime datum { get; set; }
        public string klacht { get; set; }
    }
}
