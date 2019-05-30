using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Gestion_emploi
{
    public partial class Gestion_des_filieres : MaterialForm
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

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
                    command.CommandText = "SELECT id, nom FROM secteur";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        secteur_comboBox.DataSource = binder;
                        secteur_comboBox.ValueMember = "id";
                        secteur_comboBox.DisplayMember = "nom";
                        secteur_comboBox.Text = "";
                    }
                }
            }

            RemplirDataGridView();
        }

        private void Secteur_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirDataGridView();
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO filiere(nom) VALUES(@nom)";
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Filiere ajoutée");
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
                    command.CommandText = "update filiere set nom = @nom WHERE id = @id";
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    command.Parameters.AddWithValue("@id", filieres_dataGridView.CurrentRow.Cells["id"].Value);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Filiere modifiée");
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
            string confirmationMessage = "Supprimer une filiere cause la suppression de tous ses groupes, modules et affectations";
            if (MessageBox.Show(confirmationMessage, "Voulez-vous continuer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM filiere WHERE id = @id";
                        command.Parameters.AddWithValue("@id", filieres_dataGridView.CurrentRow.Cells["id"].Value);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Filiere supprimée");
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

        private void Filieres_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nom_textBox.Text = filieres_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
        }

        private void RemplirDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select f.id, f.nom, s.nom as secteur FROM filiere f JOIN secteur s ON f.id_secteur = s.id WHERE s.id = @id_secteur";
                    command.Parameters.AddWithValue("@id_secteur", secteur_comboBox.SelectedValue);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        filieres_dataGridView.DataSource = binder;
                        filieres_dataGridView.Columns["id"].Visible = false;
                    }
                }
            }
        }
    }
}
