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
    public partial class Papegaaitoevoegen : Form
    {
        public Papegaaitoevoegen(REPO repo)
        {
            
            InitializeComponent();
            reposhared = repo;
            comboBoxVogelsoort.DataSource = reposhared.vogelsoorten;
            comboBoxVogelsoort.DataSource.GetType();
            comboBoxOndersoort.DataSource = reposhared.vogelondersoorten;
            if(comboBoxVogelsoort.SelectedItem != null)
            {
                Vogelsoort selected;
                foreach(Vogelsoort vogel in reposhared.vogelsoorten)
                {
                    if(vogel.Equals(comboBoxVogelsoort.SelectedItem))
                    {
                        selected = vogel;
                        comboBoxOndersoort.DataSource = selected.ondersoorten;
                    }
                }
            }
        }
        static REPO reposhared;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Papegaai pape = new Papegaai();
            pape.naam = textBoxNaam.Text;
            pape.soort = comboBoxVogelsoort.SelectedValue; // CONVERSION SHITE :( god dammit

           
        }
    }
}
