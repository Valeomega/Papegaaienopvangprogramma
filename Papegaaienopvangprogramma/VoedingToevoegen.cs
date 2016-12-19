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
    public partial class VoedingToevoegen : Form
    {
        public VoedingToevoegen(REPO repo)
        {
            
            comboBoxVogelsoort.DataSource = repo.vogelsoorten;
            InitializeComponent();
            if(comboBoxVogelsoort.SelectedItem!= null)
            {
                Vogelsoort vogel = (Vogelsoort)comboBoxVogelsoort.SelectedItem;
                listBoxVoedinglijst.DataSource = vogel.VogelVastevoeding;
            }
        }

        private void buttonVoedseltoevoegen_Click(object sender, EventArgs e)
        {
            Voeding eten = new Voeding();
            eten.Naamvoedsel = textBox1.Text;
           // weeklyRecurrenceControlETENbijvullen.
        }
    }
}
