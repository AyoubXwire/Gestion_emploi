using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Gestion_emploi
{
    public partial class Affectation : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;
        bool isIndexChangedBlocked = false;

        public Affectation()
        {
            InitializeComponent();
        }

        private void Affectation_Load(object sender, EventArgs e)
        {
            nbrHeures_textBox.Enabled = false;
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

        private void Choisir_button_Click(object sender, EventArgs e)
        {
            // Groupes of the selected filiere & niveau
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText =
                        "SELECT id, chaine FROM groupe WHERE id_filiere=@id_filiere AND niveau=@niveau";
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
                    command.CommandText =
                        "SELECT m.id, m.nom FROM module m JOIN module_filiere mf ON m.id=mf.id_module JOIN filiere f ON f.id=mf.id_filiere WHERE id_filiere=@id_filiere AND niveau=@niveau AND id_module NOT IN (SELECT id_module FROM affectation WHERE id_groupe=@id_groupe);";
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
                    command.CommandText =
                        "SELECT id, nom FROM formateur WHERE id_metier IN (SELECT m.id_metier FROM module m JOIN module_filiere mf ON m.id=mf.id_module JOIN filiere f ON f.id=mf.id_filiere WHERE m.id=@id_module)";
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
                            "INSERT INTO affectation(id_formateur, id_module, id_groupe) VALUES(@id_formateur, @id_module, @id_groupe)";
                            command.Parameters.AddWithValue("@id_formateur", formateur_listBox.SelectedValue);
                            command.Parameters.AddWithValue("@id_module", module_listBox.SelectedValue);
                            command.Parameters.AddWithValue("@id_groupe", groupe_listBox.SelectedValue);

                            commandOutput += command.ExecuteNonQuery();
                        }
                    }

                    groupe_listBox.SetSelected(i, false);
                }
            }
            isIndexChangedBlocked = false;

            // Update nb_heures of the formateur
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText =
                    "UPDATE formateur SET nb_heures=(SELECT SUM(mass_horaire) FROM module m JOIN affectation a ON m.id=a.id_module WHERE id_formateur=@id_formateur) WHERE id=@id_formateur";
                    command.Parameters.AddWithValue("@id_formateur", formateur_listBox.SelectedValue);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show(commandOutput.ToString() + " affectations ajoutés");
        }

        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            // Get id of the selected affectation in affectations_dataGridView
            // Delete the affectation from db by its id
            // Update nb_heures of the formateur
        }

        private void Formateurs_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get nb_heures from formateur
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT nb_heures FROM formateur WHERE id=@id";
                    command.Parameters.AddWithValue("@id", formateurs_listBox.SelectedValue);
                    nbrHeures_textBox.Text = command.ExecuteScalar().ToString();
                }
            }

            RemplirDataGridViewParFormateur((int)formateurs_listBox.SelectedValue);
        }

        private void Groupes_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirDataGridViewParGroupe((int)groupes_listBox.SelectedValue);
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

