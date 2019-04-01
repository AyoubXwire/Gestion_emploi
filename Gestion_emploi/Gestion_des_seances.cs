using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Gestion_des_seances : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

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
                        "SELECT a.id, g.chaine as groupe, m.nom as module, f.nom as formateur, m.mass_horaire, a.nb_heures as heures_par_semaines, a.avancement FROM affectation a join groupe g on a.id_groupe = g.id join module m on a.id_module = m.id join formateur f on f.id=a.id_formateur WHERE a.id_groupe=@id_groupe";
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
        }

        private void RemplirDataGridViewParFormateur(int id_formateur)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText =
                        "SELECT a.id, g.chaine as groupe, m.nom as module, f.nom as formateur, m.mass_horaire, a.nb_heures as heures_par_semaines, a.avancement FROM affectation a join groupe g on a.id_groupe = g.id join module m on a.id_module = m.id join formateur f on f.id=a.id_formateur WHERE a.id_formateur=@id_formateur";
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Remplir formateurs_listBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "UPDATE affectation set nb_heures = @nb_heures where id = @id";
                    if (seances_dataGridView.CurrentRow != null)
                    {
                         command.Parameters.AddWithValue("@nb_heures", numericUpDown1.Value);
                         command.Parameters.AddWithValue("@id", (int)seances_dataGridView.CurrentRow.Cells["id"].Value);
                    }
                    int counter = 0;
                    for (int i = 0; i < seances_dataGridView.RowCount; i++)
                    {
                        if (seances_dataGridView.Rows[i].Selected)
                        { 
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@nb_heures", numericUpDown1.Value);
                            command.Parameters.AddWithValue("@id", (int)seances_dataGridView.Rows[i].Cells["id"].Value);
                        }
                        if (command.ExecuteNonQuery() > 0)
                        {
                            counter++;
                        }
                        
                    }

                    if (counter > 0)
                    {
                        MessageBox.Show("les nombres d'heures sont bien modifié");
                    }

                    RemplirDataGridViewParGroupe((int)groupes_listBox.SelectedValue);


                }
            }
        }

        private void seances_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown1.Value = Convert.ToInt32(seances_dataGridView.CurrentRow.Cells["heures_par_semaines"].Value);
            nbHeuresFormateur_textBox.Text = seances_dataGridView.CurrentRow.Cells["heures_par_semaines"].Value.ToString();
        }
    }
}
