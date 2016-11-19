using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papegaaiencostumclasses
{
   public class Kuur
    {
        public Medicatie medicatie { get; set; }
        public DateTime Tijdaanbrengmedicatie { get; set; }
        public decimal Dosering { get; set; }
        public string Extrainfo { get; set; }
    }
}
