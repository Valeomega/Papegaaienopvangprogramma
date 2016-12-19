using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using papegaaiencostumclasses;

namespace Papegaaienopvangprogramma
{
    public partial class Hoofdsoorttoevoegen : Mainmenu
    {
        public REPO repoload = new REPO();
        static List<Vogelondersoort> list = new List<Vogelondersoort>();
        public Hoofdsoorttoevoegen(REPO repo)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vogelondersoort vogelonder = new Vogelondersoort();
            vogelonder.Naam = textBox1naamondersoort.Text;
            listBox1.Items.Add(vogelonder);
            list.Add(vogelonder);
            
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            Vogelsoort vogel = new Vogelsoort();
            vogel.Soortnaam = textBoxVOGELSOORTNAAM.Text;
            vogel.ondersoorten = list;
            repoload.vogelsoorten.Add(vogel);
            
           
        }
        public REPO getrepo()
        {
            return repoload;
        }
        
    }
}
