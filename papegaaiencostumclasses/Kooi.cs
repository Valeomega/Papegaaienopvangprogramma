using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papegaaiencostumclasses
{
    [Serializable]
    public class Kooi
    {
        public int Kooinr { get; set; }
        public Vogelsoort vogelsoort { get; set; }
        public Vogelondersoort ondersoortras { get; set; }
        public List<Papegaai> papegaaienindekooi { get; set; }
        public bool qarantaine { get; set; }
        public bool mobileofvast { get; set; }
        public bool bezetofniet { get; set; }
        public List<Persoon> kooisponsor { get; set; }
    }
}
