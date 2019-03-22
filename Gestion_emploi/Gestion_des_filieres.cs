using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Gestion_des_filieres : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Gestion_des_filieres()
        {
            InitializeComponent();
        }

        private void Gestion_des_filieres_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select f.nom as filiere, m.nom as module from module_filiere mf JOIN module m ON mf.id_module=m.id JOIN filiere f ON mf.id_filiere=f.id ORDER BY id_filiere";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        dataGridView1.DataSource = binder;
                        dataGridView1.Columns["id"].Visible = false;
                    }
                }
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
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
        }

        private void Filiere_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select f.nom as filiere, m.nom as module, m.niveau as niveau from module_filiere mf JOIN module m ON mf.id_module=m.id JOIN filiere f ON mf.id_filiere=f.id WHERE id_filiere=@id_filiere ORDER BY id_filiere";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        dataGridView1.DataSource = binder;
                        dataGridView1.Columns["id"].Visible = false;
                    }
                }
            }
        }
    }
}
