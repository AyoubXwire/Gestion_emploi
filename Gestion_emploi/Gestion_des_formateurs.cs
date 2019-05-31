using System;
using System.Configuration;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MySql.Data.MySqlClient;

namespace Gestion_emploi
{
    public partial class Gestion_des_formateurs : MaterialForm
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Gestion_des_formateurs()
        {
            InitializeComponent();
        }

        private void Gestion_des_formateurs_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();
        }

        private void Nouveau_button_Click(object sender, EventArgs e)
        {
            nom_textBox.Clear();
            prenom_textBox.Clear();
            metier_comboBox.Text = "";
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO formateur(nom, prenom, id_metier) VALUES(@nom, @prenom, @id_metier)";
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    command.Parameters.AddWithValue("@prenom", prenom_textBox.Text);
                    command.Parameters.AddWithValue("@id_metier", metier_comboBox.SelectedValue);

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Formateur ajouté");
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
                    command.CommandText = "update formateur set nom = @nom , prenom = @prenom ,id_metier = @id_metier WHERE id = @id";
                    command.Parameters.AddWithValue("@id", formateurs_dataGridView.CurrentRow.Cells["id"].Value);
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    command.Parameters.AddWithValue("@prenom", prenom_textBox.Text);
                    command.Parameters.AddWithValue("@id_metier", int.Parse(metier_comboBox.SelectedValue.ToString()));

                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Formateur modifié");
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
            string confirmationMessage = "Supprimer un formateur cause la suppression de tous ses affectations";
            if (MessageBox.Show(confirmationMessage, "Voulez-vous continuer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Remove formateur
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM formateur WHERE id = @id";
                        command.Parameters.AddWithValue("@id", formateurs_dataGridView.CurrentRow.Cells["id"].Value);
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Formateur supprimé");
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

        private void Formateurs_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nom_textBox.Text = formateurs_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
            prenom_textBox.Text = formateurs_dataGridView.CurrentRow.Cells["prenom"].Value.ToString();
            metier_comboBox.Text = formateurs_dataGridView.CurrentRow.Cells["metier"].Value.ToString();

            nom_label.Text = formateurs_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
            prenom_label.Text = formateurs_dataGridView.CurrentRow.Cells["prenom"].Value.ToString();
            metier_label.Text = formateurs_dataGridView.CurrentRow.Cells["metier"].Value.ToString();
        }

        private void RemplirDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT F.id, F.nom, F.prenom, M.nom AS metier, nb_heures_total FROM formateur F JOIN metier M ON F.id_metier = M.id";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        formateurs_dataGridView.DataSource = binder;
                        formateurs_dataGridView.Columns["id"].Visible = false;
                    }
                }
            }
        }
    }
}
