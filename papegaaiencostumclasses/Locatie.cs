using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace papegaaiencostumclasses
{
    [Serializable]
    public class Locatie
    {
        private string NAAM;
        private List<Kooi> KOOIEN = new List<Kooi>();
        private bool TOEGANG = new bool();
        public string naam { get { return NAAM; } }
        public List<Kooi> kooien { get { return KOOIEN; } }
        public bool toegangpubliek { get { return TOEGANG; } }

        public void getsoorten(Locatie locatie)
        {
            List<Vogelsoort> Vogelsoorten = new List<Vogelsoort>();
            
            foreach (Kooi kooi in KOOIEN)
            {
                Vogelsoort vogelsoort = kooi.vogelsoort;
                if (Vogelsoorten.Contains(vogelsoort))
                {

                }
                else
                {
                    Vogelsoorten.Add(vogelsoort);
                }
                  
            }
            return Vogelsoorten;
        }


    }
}
