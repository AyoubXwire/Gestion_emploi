using System;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_emploi
{
    public partial class Gestion_des_groupes : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;
        string[] lettres = new string[] { "A", "B", "C", "D", "E", "F" };

        public Gestion_des_groupes()
        {
            InitializeComponent();
        }

        private void Gestion_des_groupes_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();

            // Remplir Filiere_comboBox
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

        private void Groupes_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filiere_comboBox.Text = groupes_dataGridView.CurrentRow.Cells["filiere"].Value.ToString();
            niveau_numericUpDown.Value = int.Parse(groupes_dataGridView.CurrentRow.Cells["niveau"].Value.ToString());
            nombreDeGroupes_numericUpDown.Value = int.Parse(groupes_dataGridView.CurrentRow.Cells["nombre"].Value.ToString());
        }

        private void Valider_button_Click(object sender, EventArgs e)
        {
            // Get the count of the specified groupe from the db
            int count;
            int wanted = int.Parse(nombreDeGroupes_numericUpDown.Value.ToString());
            int commandOutput = 0;
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT count(id) FROM groupe WHERE id_filiere=@id_filiere AND niveau=@niveau";
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    command.Parameters.AddWithValue("@id_filiere", int.Parse(filiere_comboBox.SelectedValue.ToString()));
                    count = int.Parse(command.ExecuteScalar().ToString());
                }
            }

            if (count == 0) // If groupe doesnt exist insert normally
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        for (int i = 0; i < wanted; i++)
                        {
                            command.CommandText = "INSERT INTO groupe (nom, niveau, id_filiere, chaine) VALUES (@nom, @niveau, @id_filiere, @chaine)";
                            command.Parameters.AddWithValue("@nom", lettres[i]);
                            command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                            command.Parameters.AddWithValue("@id_filiere", int.Parse(filiere_comboBox.SelectedValue.ToString()));
                            command.Parameters.AddWithValue("@chaine", filiere_comboBox.Text + niveau_numericUpDown.Value.ToString() + lettres[i]);

                            commandOutput += command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                    }
                }
                MessageBox.Show(commandOutput.ToString() + " groupes ajoutés");
            }
            else if (count > wanted) // Delete the additional groupes
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        for (int i = wanted; i < count; i++)
                        {
                            command.CommandText = "DELETE FROM groupe WHERE chaine=@chaine";
                            command.Parameters.AddWithValue("@chaine", filiere_comboBox.Text + niveau_numericUpDown.Value.ToString() + lettres[i]);

                            commandOutput += command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                    }
                }
                MessageBox.Show(commandOutput.ToString() + " groupes supprimés");
            }
            else if (count < wanted) // Insert the missing groupes
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        for (int i = count; i < wanted; i++)
                        {
                            command.CommandText = "INSERT INTO groupe (nom, niveau, id_filiere, chaine) VALUES (@nom, @niveau, @id_filiere, @chaine)";
                            command.Parameters.AddWithValue("@nom", lettres[i]);
                            command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                            command.Parameters.AddWithValue("@id_filiere", int.Parse(filiere_comboBox.SelectedValue.ToString()));
                            command.Parameters.AddWithValue("@chaine", filiere_comboBox.Text + niveau_numericUpDown.Value.ToString() + lettres[i]);

                            commandOutput += command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                    }
                }
                MessageBox.Show(commandOutput.ToString() + " groupes ajoutés");
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
                    command.CommandText = "SELECT F.nom as filiere, niveau, count(G.id) as nombre FROM groupe G JOIN filiere F ON G.id_filiere = F.id GROUP BY id_filiere, niveau ORDER BY F.nom, niveau";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        groupes_dataGridView.DataSource = binder;
                        groupes_dataGridView.Columns["id"].Visible = false;
                    }
                }
            }
        }
    }
}
