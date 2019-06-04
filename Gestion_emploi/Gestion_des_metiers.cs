using System;
using System.Configuration;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace Gestion_emploi
{
    public partial class Gestion_des_metiers : MaterialForm
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

        public Gestion_des_metiers()
        {
            InitializeComponent();
        }

        private void Gestion_des_metiers_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
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

        private void Modifier_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
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

        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            string confirmationMessage = "Supprimer un metier cause la suppression de tous ses formateurs, modules et affectations";
            if (MessageBox.Show(confirmationMessage, "Voulez-vous continuer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("", connection))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM metier";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
}
