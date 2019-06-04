using System;
using System.Configuration;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SqlClient;

namespace Gestion_emploi
{
    public partial class Gestion_des_salles : MaterialForm
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

        public Gestion_des_salles()
        {
            InitializeComponent();
        }

        private void Gestion_des_salles_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM type_salle";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            BindingSource binder = new BindingSource();
                            binder.DataSource = reader;
                            type_comboBox.DataSource = binder;
                            type_comboBox.ValueMember = "id";
                            type_comboBox.DisplayMember = "nom";
                            type_comboBox.Text = "";
                        }
                    }
                    
                }
            }

            type_comboBox.Text = "";
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            string confirmationMessage = nom_textBox.Text + " sera ajouté";
            if (MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("", connection))
                    {
                        command.CommandText = "INSERT INTO salle(nom, id_type_salle) VALUES(@nom, @id_type_salle)";
                        command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                        command.Parameters.AddWithValue("@id_type_salle", type_comboBox.SelectedValue);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Salle ajouté");
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
            string confirmationMessage = nom_textBox.Text + " sera modifié";
            if (MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("", connection))
                    {
                        command.CommandText = "update salle set nom = @nom ,id_type_salle = @id_type_salle WHERE id = @id";
                        command.Parameters.AddWithValue("@id", salles_dataGridView.CurrentRow.Cells["id"].Value);
                        command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                        command.Parameters.AddWithValue("@id_type_salle", int.Parse(type_comboBox.SelectedValue.ToString()));

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Salle modifié");
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
            string confirmationMessage = "Supprimer une salle cause la suppression de tous ses seances dans l'emploi du temps";
            if (MessageBox.Show(confirmationMessage, "Voulez-vous continuer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM salle WHERE id = @id";
                        command.Parameters.AddWithValue("@id", salles_dataGridView.CurrentRow.Cells["id"].Value);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Salle supprimé");
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

        private void Salles_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nom_textBox.Text = salles_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
            type_comboBox.Text = salles_dataGridView.CurrentRow.Cells["type"].Value.ToString();
        }

        private void RemplirDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT s.id, s.nom, t.nom as type FROM salle s JOIN type_salle t ON s.id_type_salle=t.id";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            BindingSource binder = new BindingSource();
                            binder.DataSource = reader;
                            salles_dataGridView.DataSource = binder;
                            salles_dataGridView.Columns["id"].Visible = false;
                        }
                    }
                    
                }
            }
        }
    }
}
