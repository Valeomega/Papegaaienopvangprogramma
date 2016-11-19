using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papegaaiencostumclasses
{
   public class Medisch
    {
        public Kuur Vastemedicatie { get; set; }
        public List<Kuur> tijdelijkemedicaite { get; set; }
        public Medischonderzoek KLACHTENVOGEL { get; set; }
    }
}
