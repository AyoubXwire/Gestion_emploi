using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Emploi_du_temps : Form
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Emploi_du_temps()
        {
            InitializeComponent();
        }

        private void Emploi_du_temps_Load(object sender, EventArgs e)
        {
            RemplirListBoxes();
            RemplirEmploi();
        }
        
        // Ajouter une seance dans l'emploi
        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO emploi(id_affectation, id_jour, id_seance, id_salle) VALUES(@id_affectation, @id_jour, @id_seance, @id_salle)";
                    command.Parameters.AddWithValue("@id_affectation", affectations_dataGridView.SelectedRows[0].Cells["id"].Value);
                    command.Parameters.AddWithValue("@id_jour", jours_listBox.SelectedValue);
                    command.Parameters.AddWithValue("@id_seance", seances_listBox.SelectedValue);
                    command.Parameters.AddWithValue("@id_salle", salles_listBox.SelectedValue);

                    command.ExecuteNonQuery();
                }

                // Update the affectation nb_utilise
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "UPDATE affectation SET nb_utilise = nb_utilise+1 WHERE id = @id_affectation";
                    command.Parameters.AddWithValue("@id_affectation", affectations_dataGridView.SelectedRows[0].Cells["id"].Value);

                    command.ExecuteNonQuery();
                }
            }

            Groupe_comboBox_SelectedIndexChanged(null, null);
            RemplirEmploi();
        }

        // Remplir affectations_dataGridView
        private void Groupe_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            affectations_dataGridView.Rows.Clear();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT a.id AS id, g.chaine AS groupe, m.nom AS module, f.nom AS formateur, a.nb_heures, a.nb_utilise FROM affectation a JOIN groupe g ON a.id_groupe = g.id JOIN module m ON a.id_module = m.id JOIN formateur f ON a.id_formateur = f.id WHERE a.id_groupe = @id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", groupe_comboBox.SelectedValue);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int nbSeances = (int)(float.Parse(reader["nb_heures"].ToString()) / 2.5f);
                        int nbUtilise = int.Parse(reader["nb_utilise"].ToString());

                        for (int i = nbUtilise; i < nbSeances; i++)
                        {
                            DataGridViewRow row = (DataGridViewRow)affectations_dataGridView.Rows[0].Clone();

                            row.Cells[0].Value = reader[0].ToString();
                            row.Cells[1].Value = reader[1].ToString();
                            row.Cells[2].Value = reader[2].ToString();
                            row.Cells[3].Value = reader[3].ToString();

                            affectations_dataGridView.Rows.Add(row);
                        }

                        affectations_dataGridView.Columns["id"].Visible = false;
                    }
                }
            }
        }

        private void RemplirEmploi()
        {

        }

        private void RemplirListBoxes()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, chaine FROM groupe";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        groupe_comboBox.DataSource = binder;
                        groupe_comboBox.ValueMember = "id";
                        groupe_comboBox.DisplayMember = "chaine";
                        groupe_comboBox.Text = "";
                    }
                }

                // Remplir jours_listBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM jour";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        jours_listBox.ValueMember = "id";
                        jours_listBox.DisplayMember = "nom";
                        jours_listBox.DataSource = binder;
                    }
                }

                // Remplir seances_listBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM seance";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        seances_listBox.ValueMember = "id";
                        seances_listBox.DisplayMember = "nom";
                        seances_listBox.DataSource = binder;
                    }
                }

                // Remplir salles_listBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM salle";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        salles_listBox.ValueMember = "id";
                        salles_listBox.DisplayMember = "nom";
                        salles_listBox.DataSource = binder;
                    }
                }
            }
        }
    }
}
