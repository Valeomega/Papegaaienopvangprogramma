using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using papegaaiencostumclasses;


namespace Papegaaienopvangprogramma
{
    public partial class Mainmenu : Form
    {
        public REPO repoload = new REPO();
        public Mainmenu()
        {
           
            InitializeComponent();
            try
            {
                repoload = savingandloading.ReadFromJsonFile<REPO>("C:/papegaaieninfo"); }
            catch { repoload = new REPO(); }
        }

        







        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
           savingandloading.WriteToJsonFile<REPO>("C:/papegaaieninfo", repoload, true);
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        { REPO repo = new REPO();
            repo = repoload;
        }
         private void nieuwePapegaaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Papegaaitoevoegen pape = new Papegaaitoevoegen(repoload);
            pape.ShowDialog();
            this.repoload = pape.reposhared;
        }

        private void hoofdSoortToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoofdsoorttoevoegen form = new Hoofdsoorttoevoegen(repoload);
            form.ShowDialog();
            
            
        }

        private void ondersoortToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Indpendantondersoort form = new Indpendantondersoort(repoload);
            form.Show();
            this.repoload = form.repoload;
        }



        private void soortInfoAanpasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vogelsoorteninfoaanpassen form = new Vogelsoorteninfoaanpassen(repoload);
            this.repoload = form.repo;
        }

        private void toevoegenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VoedingToevoegen form = new VoedingToevoegen(repoload);
        }

        private void aanpassenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void afdrukkenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bewerkingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
     }
    

