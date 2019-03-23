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
                        metier_comboBox.DataSource = binder;
                        metier_comboBox.ValueMember = "id";
                        metier_comboBox.DisplayMember = "nom";
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
                        listBox1.DataSource = binder;
                        listBox1.ValueMember = "id";
                        listBox1.DisplayMember = "nom";
                        listBox1.Text = "";
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

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select nom from filiere where id in (select id_filiere from module_filiere where id_module = @id_module)";
                    command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells[0].Value);
                    using (MySqlDataReader dr = command.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            listBox2.Items.Clear();
                            
                            while (dr.Read())
                            {
                                listBox2.Items.Add(dr[0].ToString());
                            }
                        }
                        else
                        {
                            listBox2.Items.Clear();
                            MessageBox.Show("y a pa d'affections pour ce module");
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

                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select id from module where nom = @nom";
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    id = (int)command.ExecuteScalar();
                }

                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO module_filiere(id_module,id_filiere) VALUES(@id_module, @id_filiere)";
                    
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.GetSelected(i))
                        { 
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@id_module", id);
                            command.Parameters.AddWithValue("@id_filiere", listBox1.SelectedValue);
                            command.ExecuteNonQuery();

                            listBox1.SetSelected(i, false); 
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


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO module_filiere(id_module,id_filiere) VALUES(@id_module, @id_filiere)";

                    if(module_dataGridView.CurrentRow.DefaultCellStyle.BackColor == Color.Red) { 
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            if (listBox1.GetSelected(i))
                            {
                                command.Parameters.Clear();
                                command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells[0].Value);
                                command.Parameters.AddWithValue("@id_filiere", listBox1.SelectedValue);
                                command.ExecuteNonQuery();
                    
                                listBox1.SetSelected(i, false);
                            }
                        }
                    }
                    else
                    {
                        if (listBox1.Items.Count == listBox2.Items.Count)
                        {
                            MessageBox.Show("ce module est affecter a tous les filiere");
                        }
                        else { 
                            using (MySqlCommand command2 = new MySqlCommand("", connection))
                            {
                                command2.CommandText = "select id_module , id_filiere from module_filiere where id_module =@id_module and id_filiere =@id_filiere";
                            
                                for (int i = 0; i < listBox1.Items.Count; i++)
                                {
                                    if (listBox1.GetSelected(i))
                                    {
                                        command2.Parameters.Clear();
                                        command2.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells[0].Value);
                                        command2.Parameters.AddWithValue("@id_filiere", listBox1.SelectedValue);

                                        using (MySqlDataReader dr = command2.ExecuteReader())
                                        {
                                            if (!dr.HasRows)
                                            {
                                                dr.Close();
                                                using (MySqlCommand command3 = new MySqlCommand("",connection))
                                                {
                                                    command3.CommandText = "INSERT INTO module_filiere(id_module,id_filiere) VALUES(@id_module, @id_filiere)";
                                                    command3.Parameters.Clear();
                                                    command3.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells[0].Value);
                                                    command3.Parameters.AddWithValue("@id_filiere", listBox1.SelectedValue);
                                                    command3.ExecuteNonQuery();
                                                }
                                            }
                                        }
                                        
                                        listBox1.SetSelected(i, false);
                                    }
                                }
                            }
                        }
                    }
                } 
            }

            RemplirDataGridView();
        }
    }
}
