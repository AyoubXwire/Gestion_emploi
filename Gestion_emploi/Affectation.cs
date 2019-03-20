using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Affectation : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Affectation()
        {
            InitializeComponent();
        }

        private void Affectation_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM filiere";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    filiere_comboBox.ValueMember = "id";
                    filiere_comboBox.DisplayMember = "nom";
                    filiere_comboBox.DataSource = binder;
                }
            }
        }

        private void Choisir_button_Click(object sender, EventArgs e)
        {
            // Groupes
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

            // Modules
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT m.id, m.nom FROM module m JOIN module_filiere mf ON m.id=mf.id_module JOIN filiere f ON f.id=mf.id_filiere WHERE id_filiere=@id_filiere AND niveau=@niveau";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    module_listBox.ValueMember = "id";
                    module_listBox.DisplayMember = "nom";
                    module_listBox.DataSource = binder;
                }
            }

            // Formateurs
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM formateur WHERE id_metier IN (SELECT m.id_metier FROM module m JOIN module_filiere mf ON m.id=mf.id_module JOIN filiere f ON f.id=mf.id_filiere WHERE id_filiere=@id_filiere)";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    formateur_listBox.ValueMember = "id";
                    formateur_listBox.DisplayMember = "nom";
                    formateur_listBox.DataSource = binder;
                }
            }
        }

        private void Module_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Formateurs
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM formateur WHERE id_metier IN (SELECT m.id_metier FROM module m JOIN module_filiere mf ON m.id=mf.id_module JOIN filiere f ON f.id=mf.id_filiere WHERE m.id=@id)";
                    command.Parameters.AddWithValue("@id", module_listBox.SelectedValue);
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    formateur_listBox.ValueMember = "id";
                    formateur_listBox.DisplayMember = "nom";
                    formateur_listBox.DataSource = binder;
                }
            }
        }

        private void Affecter_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupe_listBox.Items.Count; i++)
            {
                if (groupe_listBox.GetSelected(i))
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand("", connection))
                        {
                            command.CommandText = "INSERT INTO affectation(id_formateur, id_module, id_groupe) VALUES(@id_formateur, @id_module, @id_groupe)";
                            command.Parameters.AddWithValue("@id_formateur", formateur_listBox.SelectedValue);
                            command.Parameters.AddWithValue("@id_module", module_listBox.SelectedValue);
                            command.Parameters.AddWithValue("@id_groupe", groupe_listBox.SelectedValue);
                            if(command.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Affectation ajoutée");
                            }
                            else
                            {
                                MessageBox.Show("erreur");
                            }
                        }
                    }

                    groupe_listBox.SetSelected(i, false);
                }
            }

            RemplirDataGridView();
        }

        private void RemplirDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT a.id, g.chaine as groupe, m.nom as module, f.nom as formateur FROM affectation a JOIN formateur f ON a.id_formateur=f.id JOIN module m ON a.id_module=m.id JOIN groupe g ON a.id_groupe=g.id ORDER BY g.id";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    affectations_dataGridView.DataSource = binder;
                }
            }

            affectations_dataGridView.Columns["id"].Visible = false;
        }
    }
}

