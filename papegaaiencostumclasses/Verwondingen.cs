using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papegaaiencostumclasses
{
    public class Verwondingen
    {
        public string locatieverwonding { get; set; }
        public string Infoverwonding { get; set; }
        public string oorzaak { get; set; }
        public DateTime date { get; set; }
        public Persoon waarnemer { get; set; }
    }
}
