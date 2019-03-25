using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Gestion_emploi
{
    public partial class Gestion_des_modules : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;
        int id;

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
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        metier_comboBox.ValueMember = "id";
                        metier_comboBox.DisplayMember = "nom";
                        metier_comboBox.DataSource = binder;
                        metier_comboBox.Text = "";
                    }
                }

                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM filiere";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        filieres_listBox.ValueMember = "id";
                        filieres_listBox.DisplayMember = "nom";
                        filieres_listBox.DataSource = binder;
                        filieres_listBox.Text = "";
                    }
                }
            }
        }

        private void Module_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metier_comboBox.Text = module_dataGridView.CurrentRow.Cells["metier"].Value.ToString();
            nom_textBox.Text = module_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
            niveau_numericUpDown.Value = (int)module_dataGridView.CurrentRow.Cells["niveau"].Value;
            mass_horaire_numericUpDown.Value = (int)module_dataGridView.CurrentRow.Cells["mass_horaire"].Value;
            filieres_listBox.SelectedIndex = -1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select nom from filiere where id in (select id_filiere from module_filiere where id_module = @id_module)";
                    command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells[0].Value);
                    using (MySqlDataReader dr = command.ExecuteReader())
                    {                                                 
                        while (dr.Read())
                        {
                            filieres_listBox.SetSelected(filieres_listBox.FindStringExact(dr[0].ToString()), true);
                        }
                    }
                }
            }
        }

        private void Nouveau_button_Click(object sender, EventArgs e)
        {
            nom_textBox.Clear();
            metier_comboBox.Text = "";
            mass_horaire_numericUpDown.Value = 0;
            filieres_listBox.SelectedIndex = -1;
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Add the module to db
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

                // Get the added module's id
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select id from module where nom = @nom";
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    id = (int)command.ExecuteScalar();
                }

                // Add the module_filiere in db
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO module_filiere(id_module,id_filiere) VALUES(@id_module, @id_filiere)";
                    
                    for (int i = 0; i < filieres_listBox.Items.Count; i++)
                    {
                        if (filieres_listBox.GetSelected(i))
                        { 
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id_module", id);
                            command.Parameters.AddWithValue("@id_filiere", filieres_listBox.SelectedValue);
                            command.ExecuteNonQuery();

                            filieres_listBox.SetSelected(i, false); 
                        }
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
                // Update the module
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

                // Delete the module's rows from module_filiere
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "DELETE FROM module_filiere WHERE id_module = @id_module";
                    command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells["id"].Value);
                    command.ExecuteNonQuery();
                }

                // Add the selected filieres to module_filiere
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO module_filiere(id_module,id_filiere) VALUES(@id_module, @id_filiere)";

                    for (int i = 0; i < filieres_listBox.Items.Count; i++)
                    {
                        if (filieres_listBox.GetSelected(i))
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells["id"].Value);
                            command.Parameters.AddWithValue("@id_filiere", filieres_listBox.SelectedValue);
                            command.ExecuteNonQuery();

                            filieres_listBox.SetSelected(i, false);
                        }
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
                // Remove all module_filiere
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "DELETE FROM module_filiere WHERE id_module = @id_module";
                    command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells["id"].Value);
                    command.ExecuteNonQuery();
                }

                // Remove all its affectations
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "DELETE FROM affectation WHERE id_module = @id_module";
                    command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells["id"].Value);
                    command.ExecuteNonQuery();
                }

                // Remove the module
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
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        module_dataGridView.DataSource = binder;
                        module_dataGridView.Columns["id"].Visible = false;
                    }
                }
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select nom from filiere where id in (select id_filiere from module_filiere where id_module = @id_module)";

                    foreach (DataGridViewRow row in module_dataGridView.Rows)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@id_module", row.Cells[0].Value);

                        using (MySqlDataReader dr = command.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }
    }
}
