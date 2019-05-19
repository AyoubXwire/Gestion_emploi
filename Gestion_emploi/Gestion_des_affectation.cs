using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Gestion_des_affectation : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;
        bool isIndexChangedBlocked = false;

        public Gestion_des_affectation()
        {
            InitializeComponent();
        }

        private void Affectation_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Remplir filiere_comboBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM filiere";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        filiere_comboBox.DataSource = binder;
                        filiere_comboBox.ValueMember = "id";
                        filiere_comboBox.DisplayMember = "nom";
                        filiere_comboBox.Text = "";
                    }
                }
            }

            RemplirListBoxesDeFiltre();
        }

        private void Choisir_button_Click(object sender, EventArgs e)
        {
            // Groupes of the selected filiere & niveau
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, chaine FROM groupe WHERE id_filiere=@id_filiere AND niveau=@niveau";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    groupe_listBox.ValueMember = "id";
                    groupe_listBox.DisplayMember = "chaine";
                    groupe_listBox.DataSource = binder;
                }
            }
        }

        private void Groupe_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (isIndexChangedBlocked) // To make sure looping through groupes doesn't trigger the event
            {
                return;
            }

            // Modules that the selected groupes can study excluding the ones they already study (the ones already affected to them)
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM module WHERE id_filiere=@id_filiere AND niveau=@niveau AND id NOT IN (SELECT id_module FROM affectation WHERE id_groupe=@id_groupe)";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    command.Parameters.AddWithValue("@id_groupe", groupe_listBox.SelectedValue);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        module_listBox.ValueMember = "id";
                        module_listBox.DisplayMember = "nom";
                        module_listBox.DataSource = binder;
                    }
                    else
                    {
                        module_listBox.DataSource = null;
                    }
                }
            }
        }

        private void Module_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Formateurs that can teach the selected module
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    if (filtre_checkBox.Checked)
                    {
                        command.CommandText = "SELECT id, nom FROM formateur WHERE id_metier IN (SELECT id_metier FROM module WHERE id=@id_module)";
                        command.Parameters.AddWithValue("@id_module", module_listBox.SelectedValue);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            BindingSource binder = new BindingSource();
                            binder.DataSource = reader;
                            formateur_listBox.ValueMember = "id";
                            formateur_listBox.DisplayMember = "nom";
                            formateur_listBox.DataSource = binder;
                        }
                        else
                        {
                            formateur_listBox.DataSource = null;
                        }
                    }
                    else
                    {
                        command.CommandText = "SELECT id, nom FROM formateur";
                        command.Parameters.AddWithValue("@id_module", module_listBox.SelectedValue);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            BindingSource binder = new BindingSource();
                            binder.DataSource = reader;
                            formateur_listBox.ValueMember = "id";
                            formateur_listBox.DisplayMember = "nom";
                            formateur_listBox.DataSource = binder;
                        }
                        else
                        {
                            formateur_listBox.DataSource = null;
                        }
                    }
                }
            }
        }

        private void Affecter_button_Click(object sender, EventArgs e)
        {
            int commandOutput = 0;

            // Add affectaions to db
            isIndexChangedBlocked = true;
            for (int i = 0; i < groupe_listBox.Items.Count; i++)
            {
                if (groupe_listBox.GetSelected(i))
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand("", connection))
                        {
                            command.CommandText =
                            "INSERT INTO affectation(id_formateur, id_module, id_groupe, nb_heures) VALUES(@id_formateur, @id_module, @id_groupe, @nb_heures)";
                            command.Parameters.AddWithValue("@id_formateur", formateur_listBox.SelectedValue);
                            command.Parameters.AddWithValue("@id_module", module_listBox.SelectedValue);
                            command.Parameters.AddWithValue("@id_groupe", groupe_listBox.SelectedValue);
                            // Get mass_horaire
                            float nbHeuresParSemaine;
                            using (MySqlCommand command2 = new MySqlCommand("", connection))
                            {
                                command2.CommandText = "SELECT mass_horaire FROM module WHERE id=@id_module";
                                command2.Parameters.AddWithValue("@id_module", module_listBox.SelectedValue);
                                nbHeuresParSemaine = CalculerNombreHeures(float.Parse(command2.ExecuteScalar().ToString()));
                            }
                            command.Parameters.AddWithValue("@nb_heures", nbHeuresParSemaine);

                            commandOutput += command.ExecuteNonQuery();
                        }
                    }

                    // Update nb_heures_total of the groupe
                    UpdateNombreHeuresDuGroupe((int)groupe_listBox.SelectedValue);
                    groupe_listBox.SetSelected(i, false);
                }
            }
            isIndexChangedBlocked = false;

            // Update nb_heures_total of the formateur
            if (formateur_listBox.SelectedValue !=null)
            UpdateNombreHeuresDuFormateur((int)formateur_listBox.SelectedValue);

            MessageBox.Show(commandOutput.ToString() + " affectations ajoutées");
            RemplirListBoxesDeFiltre();
            Choisir_button_Click(null, null);
        }

        private float CalculerNombreHeures(float massHoraire)
        {
            return (float)Math.Ceiling(massHoraire / 35 / 2.5f) * 2.5f;
        }

        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            // Get id of the selected affectation in affectations_dataGridView
            // Delete the affectation from db by its id
            int commandOutput = 0;
            foreach (DataGridViewRow row in affectations_dataGridView.SelectedRows)
            {
                int id_formateur = (int)row.Cells["id_formateur"].Value;
                int id_groupe = (int)row.Cells["id_groupe"].Value;
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM affectation WHERE id=@id";
                        command.Parameters.AddWithValue("@id", row.Cells["id"].Value);

                        commandOutput += command.ExecuteNonQuery();
                    }
                }

                // Update nb_heures of the formateur & groupe
                UpdateNombreHeuresDuFormateur(id_formateur);
                UpdateNombreHeuresDuGroupe(id_groupe);
            }

            MessageBox.Show(commandOutput.ToString() + " affectations supprimées");
            RemplirListBoxesDeFiltre();
            Choisir_button_Click(null, null);
        }

        private void Formateurs_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get nb_heures_total from formateur
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT nb_heures_total FROM formateur WHERE id=@id";
                    command.Parameters.AddWithValue("@id", formateurs_listBox.SelectedValue);
                    nbrHeuresFormateur_textBox.Text = command.ExecuteScalar().ToString();
                }
            }

            RemplirDataGridViewParFormateur((int)formateurs_listBox.SelectedValue);
        }

        private void Groupes_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get nb_heures_total from groupe
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT nb_heures_total FROM groupe WHERE id=@id";
                    command.Parameters.AddWithValue("@id", groupes_listBox.SelectedValue);
                    nbrHeuresGroupe_textBox.Text = command.ExecuteScalar().ToString();
                }
            }

            RemplirDataGridViewParGroupe((int)groupes_listBox.SelectedValue);
        }

        private void Filtre_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            Module_listBox_SelectedIndexChanged(null, null);
        }

        private void UpdateNombreHeuresDuFormateur(int id_formateur)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "UPDATE formateur SET nb_heures_total=(SELECT SUM(mass_horaire) FROM module m JOIN affectation a ON m.id=a.id_module WHERE id_formateur=@id_formateur) WHERE id=@id_formateur";
                    command.Parameters.AddWithValue("@id_formateur", id_formateur);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void UpdateNombreHeuresDuGroupe(int id_groupe)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "UPDATE groupe SET nb_heures_total=(SELECT SUM(mass_horaire) FROM module m JOIN affectation a ON m.id=a.id_module WHERE id_groupe=@id_groupe) WHERE id=@id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", id_groupe);
                    command.ExecuteNonQuery();
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

        private void RemplirDataGridViewParGroupe(int id_groupe)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    //here you have the 3 id's of formateur,module,and groupe , all of them hidden if you need'em , only module name and group name are shown
                    command.CommandText = "SELECT g.chaine as groupe, m.nom as module, f.nom as formateur, a.id , a.id_formateur , a.id_module , a.id_groupe from affectation a join groupe g on a.id_groupe = g.id join module m on a.id_module = m.id JOIN formateur f ON f.id=a.id_formateur where id_groupe=@id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", id_groupe);
                    MySqlDataReader reader = command.ExecuteReader();
                    // if no affectations, the gridView will be empty
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        affectations_dataGridView.DataSource = binder;

                        // Hide the id columns
                        affectations_dataGridView.Columns["id"].Visible = false;
                        affectations_dataGridView.Columns["id_formateur"].Visible = false;
                        affectations_dataGridView.Columns["id_module"].Visible = false;
                        affectations_dataGridView.Columns["id_groupe"].Visible = false;
                    }
                    else
                    {
                        affectations_dataGridView.DataSource = null;
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
                    //here you have the 3 id's of formateur,module,and groupe , all of them hidden if you need'em , only module name and group name are shown
                    command.CommandText = "SELECT g.chaine as groupe, m.nom as module, m.mass_horaire as mass_horaire, a.id , a.id_formateur , a.id_module , a.id_groupe from affectation a join groupe g on a.id_groupe = g.id join module m on a.id_module = m.id where id_formateur=@id_formateur";
                    command.Parameters.AddWithValue("@id_formateur", id_formateur);
                    MySqlDataReader reader = command.ExecuteReader();
                    // if no affectations, the gridView will be empty
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        affectations_dataGridView.DataSource = binder;

                        // Hide the id columns
                        affectations_dataGridView.Columns["id"].Visible = false;
                        affectations_dataGridView.Columns["id_formateur"].Visible = false;
                        affectations_dataGridView.Columns["id_module"].Visible = false;
                        affectations_dataGridView.Columns["id_groupe"].Visible = false;
                    }
                    else
                    {
                        affectations_dataGridView.DataSource = null;
                    }
                }
            }
        }
    }
}

