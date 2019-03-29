using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_emploi
{
    public partial class Gestion_des_metiers : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Gestion_des_metiers()
        {
            InitializeComponent();
        }

        private void Gestion_des_metiers_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();
        }

        private void Vider_button_Click(object sender, EventArgs e)
        {
            nom_textBox.Text = "";
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            string confirmationMessage = nom_textBox.Text + " sera ajouté";
            if (MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "INSERT INTO metier(nom) VALUES(@nom)";
                        command.Parameters.AddWithValue("@nom", nom_textBox.Text);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Metier ajouté");
                        }
                        else
                        {
                            MessageBox.Show("erreur");
                        }
                    }
                }

                RemplirDataGridView();
            }
        }

        private void Modifier_button_Click(object sender, EventArgs e)
        {
            string confirmationMessage = metiers_dataGridView.CurrentRow.Cells["nom"].Value + " sera modifié";
            if (MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "update metier set nom = @nom WHERE id = @id";
                        command.Parameters.AddWithValue("@id", metiers_dataGridView.CurrentRow.Cells["id"].Value);
                        command.Parameters.AddWithValue("@nom", nom_textBox.Text);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Metier modifié");
                        }
                        else
                        {
                            MessageBox.Show("erreur");
                        }
                    }
                }

                RemplirDataGridView();
            }
        }

        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            string confirmationMessage = nom_textBox.Text + " sera supprimé";
            if (MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    // Remove all his formateurs with that metier
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM formateur WHERE id_metier = @id_metier";
                        command.Parameters.AddWithValue("@id_metier", metiers_dataGridView.CurrentRow.Cells["id"].Value);
                        command.ExecuteNonQuery();
                    }

                    // remove all modules with that metier
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM module WHERE id_metier = @id_metier";
                        command.Parameters.AddWithValue("@id_metier", metiers_dataGridView.CurrentRow.Cells["id"].Value);
                        command.ExecuteNonQuery();
                    }

                    // Remove metier
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM metier WHERE id = @id";
                        command.Parameters.AddWithValue("@id", metiers_dataGridView.CurrentRow.Cells["id"].Value);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Metier supprimé");
                        }
                        else
                        {
                            MessageBox.Show("erreur");
                        }
                    }
                }

                RemplirDataGridView();
            }
        }

        private void Metiers_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nom_textBox.Text = metiers_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
        }

        private void RemplirDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM metier";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        metiers_dataGridView.DataSource = binder;
                        metiers_dataGridView.Columns["id"].Visible = false;
                    }
                }
            }
        }
    }
}
