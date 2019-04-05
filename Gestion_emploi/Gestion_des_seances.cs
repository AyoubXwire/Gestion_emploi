using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Gestion_emploi
{
    public partial class Gestion_des_seances : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;
        string remplirPar = "";

        public Gestion_des_seances()
        {
            InitializeComponent();
        }

        private void Gestion_des_seances_Load(object sender, EventArgs e)
        {
            RemplirListBoxesDeFiltre();
        }

        private void Formateurs_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirDataGridViewParFormateur((int) formateurs_listBox.SelectedValue);

            // Nombre heures par semaine
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT SUM(nb_heures) FROM affectation WHERE id_formateur=@id_formateur";
                    command.Parameters.AddWithValue("@id_formateur", formateurs_listBox.SelectedValue);

                    nbHeuresFormateur_textBox.Text = command.ExecuteScalar().ToString();
                }
            }
        }

        private void Groupes_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirDataGridViewParGroupe((int) groupes_listBox.SelectedValue);

            // Nombre heures par semaine
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT SUM(nb_heures) FROM affectation WHERE id_groupe=@id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", groupes_listBox.SelectedValue);

                    nbHeuresGroupe_textBox.Text = command.ExecuteScalar().ToString();
                }
            }
        }

        private void RemplirDataGridViewParGroupe(int id_groupe)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText =
                        "SELECT a.id, g.chaine as groupe, m.nom as module, f.nom as formateur, m.mass_horaire, a.nb_heures as heures_par_semaine, a.nb_heures_rates, a.avancement, a.date_debut, a.date_fin, nb_semaines FROM affectation a join groupe g on a.id_groupe = g.id join module m on a.id_module = m.id join formateur f on f.id=a.id_formateur WHERE a.id_groupe=@id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", id_groupe);
                    MySqlDataReader reader = command.ExecuteReader();
                    // if no affectations, the gridView will be empty
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        seances_dataGridView.DataSource = binder;

                        // Hide the id columns
                        seances_dataGridView.Columns["id"].Visible = false;
                    }
                    else
                    {
                        seances_dataGridView.DataSource = null;
                    }
                }
            }

            ColorerDataGridView();
            remplirPar = "groupe";
        }

        private void RemplirDataGridViewParFormateur(int id_formateur)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText =
                        "SELECT a.id, g.chaine as groupe, m.nom as module, f.nom as formateur, m.mass_horaire, a.nb_heures as heures_par_semaine, a.nb_heures_rates, a.avancement, a.date_debut, a.date_fin, nb_semaines FROM affectation a join groupe g on a.id_groupe = g.id join module m on a.id_module = m.id join formateur f on f.id=a.id_formateur WHERE a.id_formateur=@id_formateur";
                    command.Parameters.AddWithValue("@id_formateur", id_formateur);
                    MySqlDataReader reader = command.ExecuteReader();
                    // if no affectations, the gridView will be empty
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        seances_dataGridView.DataSource = binder;

                        // Hide the id columns
                        seances_dataGridView.Columns["id"].Visible = false;
                    }
                    else
                    {
                        seances_dataGridView.DataSource = null;
                    }
                }
            }

            ColorerDataGridView();
            remplirPar = "formateur";
        }

        private void ColorerDataGridView()
        {
            foreach (DataGridViewRow row in seances_dataGridView.Rows)
            {
                if(row.Cells["date_debut"].Value.ToString() != "")
                {
                    row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                }
            }
        }

        private void RemplirListBoxesDeFiltre()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Remplir formateurs_listBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM formateur";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        formateurs_listBox.ValueMember = "id";
                        formateurs_listBox.DisplayMember = "nom";
                        formateurs_listBox.DataSource = binder;
                    }
                }

                // Remplir groupes_listBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, chaine FROM groupe";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        groupes_listBox.ValueMember = "id";
                        groupes_listBox.DisplayMember = "chaine";
                        groupes_listBox.DataSource = binder;
                    }
                }
            }
        }

        private void Seances_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(seances_dataGridView.CurrentRow.Cells["heures_par_semaine"].Value.ToString() != "")
            {
                nbHeures_numericUpDown.Value = Convert.ToDecimal(seances_dataGridView.CurrentRow.Cells["heures_par_semaine"].Value);
            }

            if(seances_dataGridView.CurrentRow.Cells["nb_heures_rates"].Value.ToString() != "")
            {
                nbHeuresRates_numericUpDown.Value = Convert.ToDecimal(seances_dataGridView.CurrentRow.Cells["nb_heures_rates"].Value);
            }

            if(seances_dataGridView.CurrentRow.Cells["date_debut"].Value.ToString() != "")
            {
                dateDebut_dateTimePicker.Value = Convert.ToDateTime(seances_dataGridView.CurrentRow.Cells["date_debut"].Value);
            }
        }

        private void AppliquerNbHeures_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    int counter = 0;
                    command.CommandText = "UPDATE affectation set nb_heures = @nb_heures where id = @id";

                    for (int i = 0; i < seances_dataGridView.RowCount; i++)
                    {
                        if (seances_dataGridView.Rows[i].Selected)
                        { 
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@nb_heures", nbHeures_numericUpDown.Value);
                            command.Parameters.AddWithValue("@id", (int)seances_dataGridView.Rows[i].Cells["id"].Value);
                            counter += command.ExecuteNonQuery();

                            UpdateDateFin((int)seances_dataGridView.Rows[i].Cells["id"].Value);
                        }
                    }

                    if (counter > 0)
                    {
                        MessageBox.Show("nombre d'heures modifié pour " + counter.ToString() + " affectation");
                    }

                    if (remplirPar == "groupe")
                    {
                        Formateurs_listBox_SelectedIndexChanged(null, null);
                        Groupes_listBox_SelectedIndexChanged(null, null);
                        RemplirDataGridViewParGroupe((int)groupes_listBox.SelectedValue);
                    }
                    else if (remplirPar == "formateur")
                    {
                        Groupes_listBox_SelectedIndexChanged(null, null);
                        Formateurs_listBox_SelectedIndexChanged(null, null);
                        RemplirDataGridViewParFormateur((int)formateurs_listBox.SelectedValue);
                    }
                }
            }
        }

        private void NbHeuresRates_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    int counter = 0;
                    command.CommandText = "UPDATE affectation set nb_heures_rates = @nb_heures_rates where id = @id";

                    for (int i = 0; i < seances_dataGridView.RowCount; i++)
                    {
                        if (seances_dataGridView.Rows[i].Selected)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@nb_heures_rates", nbHeuresRates_numericUpDown.Value);
                            command.Parameters.AddWithValue("@id", (int)seances_dataGridView.Rows[i].Cells["id"].Value);
                            counter += command.ExecuteNonQuery();

                            UpdateDateFin((int)seances_dataGridView.Rows[i].Cells["id"].Value);
                        }
                    }

                    if (counter > 0)
                    {
                        MessageBox.Show("nombre d'heures ratées modifié pour " + counter.ToString() + " affectation");
                    }

                    if (remplirPar == "groupe")
                    {
                        Formateurs_listBox_SelectedIndexChanged(null, null);
                        Groupes_listBox_SelectedIndexChanged(null, null);
                        RemplirDataGridViewParGroupe((int)groupes_listBox.SelectedValue);
                    }
                    else if (remplirPar == "formateur")
                    {
                        Groupes_listBox_SelectedIndexChanged(null, null);
                        Formateurs_listBox_SelectedIndexChanged(null, null);
                        RemplirDataGridViewParFormateur((int)formateurs_listBox.SelectedValue);
                    }
                }
            }
        }

        private void AppliquerDateDebut_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    int counter = 0;
                    command.CommandText = "UPDATE affectation set date_debut = @date_debut where id = @id";

                    for (int i = 0; i < seances_dataGridView.RowCount; i++)
                    {
                        if (seances_dataGridView.Rows[i].Selected)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@date_debut", dateDebut_dateTimePicker.Value.Date);
                            command.Parameters.AddWithValue("@id", (int)seances_dataGridView.Rows[i].Cells["id"].Value);
                            counter += command.ExecuteNonQuery();

                            UpdateDateFin((int)seances_dataGridView.Rows[i].Cells["id"].Value);
                        }
                    }

                    if (counter > 0)
                    {
                        MessageBox.Show("date debut modifié pour " + counter.ToString() + " affectation");
                    }

                    if (remplirPar == "groupe")
                    {
                        Formateurs_listBox_SelectedIndexChanged(null, null);
                        Groupes_listBox_SelectedIndexChanged(null, null);
                        RemplirDataGridViewParGroupe((int)groupes_listBox.SelectedValue);
                    }
                    else if (remplirPar == "formateur")
                    {
                        Groupes_listBox_SelectedIndexChanged(null, null);
                        Formateurs_listBox_SelectedIndexChanged(null, null);
                        RemplirDataGridViewParFormateur((int)formateurs_listBox.SelectedValue);
                    }
                }
            }
        }

        private void UpdateDateFin(int id_affectation)
        {
            int massHoraire = 0;
            float heuresRates = 0f;
            float heuresParSemaine = 0f;
            DateTime dateDebut = DateTime.Now;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT m.mass_horaire, a.nb_heures_rates, a.nb_heures, a.date_debut FROM affectation a JOIN module m ON a.id_module = m.id WHERE a.id = @id";
                    command.Parameters.AddWithValue("@id", id_affectation);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        massHoraire = (int)reader[0];
                        heuresRates = (float)reader[1];
                        heuresParSemaine = (float)reader[2];

                        if(reader[3].ToString() == "")
                        {
                            return;
                        }
                        dateDebut = (DateTime)reader[3];
                    }
                }
            }

            TimeSpan ts = DateTime.Now.Date - dateDebut.Date;
            float avancement = ((ts.Days / 7) * heuresParSemaine) - heuresRates;

            int nbrSemaines = (int)Math.Ceiling((massHoraire + heuresRates) / heuresParSemaine);

            DateTime dateFinPrevu = dateDebut.AddDays(nbrSemaines * 7);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    int counter = 0;
                    command.CommandText = "UPDATE affectation set date_fin = @date_fin, nb_semaines = @nb_semaines, avancement = @avancement where id = @id";
                    command.Parameters.AddWithValue("@date_fin", dateFinPrevu.Date);
                    command.Parameters.AddWithValue("@nb_semaines", nbrSemaines);
                    command.Parameters.AddWithValue("@avancement", avancement);
                    command.Parameters.AddWithValue("@id", id_affectation);
                    counter += command.ExecuteNonQuery();
                }
            }
        }
    }
}
