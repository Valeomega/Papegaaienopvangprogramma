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
           comboBoxVogelsoort.DataSource=reposhared.locaties.get 
        }
        static REPO reposhared;
        
        
    }
}
