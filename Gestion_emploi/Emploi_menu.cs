using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Emploi_menu : Form
    {
        public Emploi_menu()
        {
            InitializeComponent();
        }

        private void Emploi_menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emploi_du_temps emploi = new Emploi_du_temps();
            emploi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emploi_Formateur ef = new Emploi_Formateur();
            ef.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Emploi_Salle es = new Emploi_Salle();
            es.Show();
        }
    }
}
