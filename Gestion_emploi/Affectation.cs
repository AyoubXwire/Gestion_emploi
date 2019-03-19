using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Affectation : Form
    {
        string connectionString = "server=localhost;database=emploi_du_temps;uid=root;pwd=xwire";

        public Affectation()
        {
            InitializeComponent();
        }

        private void Affectation_Load(object sender, EventArgs e)
        {
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

        private void Filiere_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Groupes
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, chaine FROM groupe WHERE id_filiere=@id_filiere";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
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
                    command.CommandText = "SELECT m.id, m.nom FROM module m JOIN module_filiere mf ON m.id=mf.id_module JOIN filiere f ON f.id=mf.id_filiere WHERE id_filiere=@id_filiere";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
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
    }
}
