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
    public partial class Vogelsoorteninfoaanpassen : Form
    { public REPO repo;
        private Vogelsoort vogel = new Vogelsoort();
        public Vogelsoorteninfoaanpassen(REPO Repo)
        {
            InitializeComponent();
            comboBoxHoofdsoorten.DataSource = Repo.vogelsoorten;
            this.repo = Repo;
            if(comboBoxHoofdsoorten.SelectedItem!= null)
            {
                vogel = (Vogelsoort)comboBoxHoofdsoorten.SelectedItem;
                listBoxVogelondersoorten.DataSource = vogel.ondersoorten;
            }
        }

        private void buttonDoorvoeren_Click(object sender, EventArgs e)
        {
            Vogelondersoort ondersoort = (Vogelondersoort)listBoxVogelondersoorten.SelectedItem;
            

        }
    }
}
