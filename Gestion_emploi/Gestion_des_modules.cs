using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Gestion_des_modules : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Gestion_des_modules()
        {
            InitializeComponent();
        }

        private void Gestion_des_modules_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM metier";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    metier_comboBox.DataSource = binder;
                    metier_comboBox.ValueMember = "id";
                    metier_comboBox.DisplayMember = "nom";
                    metier_comboBox.Text = "";
                }
            }
        }

        private void Module_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metier_comboBox.Text = module_dataGridView.CurrentRow.Cells["metier"].Value.ToString();
            nom_textBox.Text = module_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
            niveau_numericUpDown.Value = (int)module_dataGridView.CurrentRow.Cells["niveau"].Value;
            mass_horaire_numericUpDown.Value = (int)module_dataGridView.CurrentRow.Cells["mass_horaire"].Value;
        }

        private void Nouveau_button_Click(object sender, EventArgs e)
        {
            nom_textBox.Clear();
            metier_comboBox.Text = "";
            mass_horaire_numericUpDown.Value = 0;
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO module(nom, niveau, mass_horaire,id_metier) VALUES(@nom, @niveau ,@mass_horaire, @id_metier)";
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    command.Parameters.AddWithValue("@mass_horaire", mass_horaire_numericUpDown.Value);
                    command.Parameters.AddWithValue("@id_metier", metier_comboBox.SelectedValue);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Le Module a été bien ajouté");
                    }
                    else
                    {
                        MessageBox.Show("erreur");
                    }
                }
            }

            RemplirDataGridView();
        }

        private void Modifier_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "update module set nom = @nom , niveau = @niveau , mass_horaire = @mass_horaire ,id_metier = @id_metier WHERE id = @id";
                    command.Parameters.AddWithValue("@id", module_dataGridView.CurrentRow.Cells["id"].Value);
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    command.Parameters.AddWithValue("@mass_horaire", mass_horaire_numericUpDown.Value);
                    command.Parameters.AddWithValue("@id_metier", metier_comboBox.SelectedValue);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("le Module a été bien modifié");
                    }
                    else
                    {
                        MessageBox.Show("erreur");
                    }
                }
            }

            RemplirDataGridView();
        }

        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "DELETE FROM module_filiere WHERE id_module = @id_module";
                    command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells["id"].Value);
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "DELETE FROM module WHERE id = @id";
                    command.Parameters.AddWithValue("@id", module_dataGridView.CurrentRow.Cells["id"].Value);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("le module a été bien supprimé");
                    }
                    else
                    {
                        MessageBox.Show("erreur");
                    }
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
                    command.CommandText = "SELECT m.id, m.nom, m.niveau, m.mass_horaire, me.nom as metier FROM module m JOIN metier me ON m.id_metier = me.id";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    module_dataGridView.DataSource = binder;
                }
            }
            module_dataGridView.Columns["id"].Visible = false;
        }
    }
}
