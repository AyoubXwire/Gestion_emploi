using System;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Gestion_des_formateurs formateurs = new Gestion_des_formateurs();
            formateurs.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Gestion_des_groupes groupes = new Gestion_des_groupes();
            groupes.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Gestion_des_modules modules = new Gestion_des_modules();
            modules.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Gestion_des_filieres filieres = new Gestion_des_filieres();
            filieres.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Gestion_des_metiers metiers = new Gestion_des_metiers();
            metiers.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Gestion_des_salles salles = new Gestion_des_salles();
            salles.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Gestion_des_affectation affectation = new Gestion_des_affectation();
            affectation.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Gestion_des_seances seances = new Gestion_des_seances();
            seances.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Emploi_du_temps emploi = new Emploi_du_temps();
            emploi.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Import i = new Import();
            i.Show();
        }
    }
}
