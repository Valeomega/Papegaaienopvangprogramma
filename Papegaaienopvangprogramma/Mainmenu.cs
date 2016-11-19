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
        public Mainmenu()
        {
            InitializeComponent();
        }

        public REPO repoload = savingandloading.ReadFromJsonFile<REPO>("C:/papegaaieninfo");






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
            pape.Show();

        }      
    }
     }
    

