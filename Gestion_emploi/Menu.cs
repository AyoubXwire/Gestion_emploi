﻿using System;
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

        private void button5_Click(object sender, EventArgs e)
        {
            Affectation affectation = new Affectation();
            affectation.Show();
        }
    }
}
