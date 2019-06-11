using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Gestion_emploi
{
    public partial class Gestion_des_modules : MaterialForm
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

        public Gestion_des_modules()
        {
            InitializeComponent();
        }

        private void Gestion_des_modules_Load(object sender, EventArgs e)
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
                            metier_comboBox.ValueMember = "id";
                            metier_comboBox.DisplayMember = "nom";
                            metier_comboBox.DataSource = binder;
                            metier_comboBox.Text = "";
                        } 
                    }
                }

                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM filiere";
                   
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            BindingSource binder = new BindingSource();
                            binder.DataSource = reader;
                            filiere_comboBox.ValueMember = "id";
                            filiere_comboBox.DisplayMember = "nom";
                            filiere_comboBox.DataSource = binder;
                            filiere_comboBox.Text = "";
                        } 
                    }
                }
            }

            RemplirDataGridView();
        }

        private void Module_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            metier_comboBox.Text = module_dataGridView.CurrentRow.Cells["metier"].Value.ToString();
            nom_textBox.Text = module_dataGridView.CurrentRow.Cells["nom"].Value.ToString();
            niveau_numericUpDown.Value = (int)module_dataGridView.CurrentRow.Cells["niveau"].Value;
            mass_horaire_numericUpDown.Value = (int)module_dataGridView.CurrentRow.Cells["mass_horaire"].Value;
            filiere_comboBox.Text = module_dataGridView.CurrentRow.Cells["filiere"].Value.ToString();
        }

        private void Nouveau_button_Click(object sender, EventArgs e)
        {
            nom_textBox.Clear();
            metier_comboBox.Text = "";
            mass_horaire_numericUpDown.Value = 0;
            filiere_comboBox.SelectedIndex = -1;
        }

        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES(@nom, @niveau ,@mass_horaire, @id_metier, @id_filiere)";
                    command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    command.Parameters.AddWithValue("@mass_horaire", mass_horaire_numericUpDown.Value);
                    command.Parameters.AddWithValue("@id_metier", metier_comboBox.SelectedValue);
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);

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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                if (module_dataGridView.CurrentRow!=null)
                {
                    using (SqlCommand command = new SqlCommand("", connection))
                    {
                        command.CommandText = "update module set nom = @nom , niveau = @niveau , mass_horaire = @mass_horaire ,id_metier = @id_metier, id_filiere = @id_filiere WHERE id = @id";
                        command.Parameters.AddWithValue("@id", module_dataGridView.CurrentRow.Cells["id"].Value);
                        command.Parameters.AddWithValue("@nom", nom_textBox.Text);
                        command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                        command.Parameters.AddWithValue("@mass_horaire", mass_horaire_numericUpDown.Value);
                        command.Parameters.AddWithValue("@id_metier", metier_comboBox.SelectedValue);
                        command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("le Module a été bien modifié");
                            //update date_fin in affectation

                            Gestion_des_seances seances = new Gestion_des_seances();
                            using (SqlCommand command2 = new SqlCommand("", connection))
                            {
                                command2.CommandText = "select id from affectation where id_module = @module";
                                command2.Parameters.AddWithValue("@module", module_dataGridView.CurrentRow.Cells["id"].Value);

                                using (SqlDataReader reader = command2.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        seances.UpdateDateFin(int.Parse(reader[0].ToString()));
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("erreur");
                        }
                    } 
                }
            }
            
            RemplirDataGridView();
        }

        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            string confirmationMessage = "Supprimer un module cause la suppression de tous ses affectations";
            if (MessageBox.Show(confirmationMessage, "Voulez-vous continuer?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (module_dataGridView.CurrentRow!=null)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        // Remove all his affectations
                        using (SqlCommand command = new SqlCommand("", connection))
                        {
                            command.CommandText = "DELETE FROM affectation WHERE id_module = @id_module";
                            command.Parameters.AddWithValue("@id_module", module_dataGridView.CurrentRow.Cells["id"].Value);
                            command.ExecuteNonQuery();
                        }

                        // Remove module
                        using (SqlCommand command = new SqlCommand("", connection))
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
                }

                RemplirDataGridView();
            }
        }

        private void RemplirDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT m.id, m.nom, m.niveau, m.mass_horaire, me.nom as metier, f.nom as filiere FROM module m JOIN metier me ON m.id_metier = me.id JOIN filiere f ON m.id_filiere = f.id";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            BindingSource binder = new BindingSource();
                            binder.DataSource = reader;
                            module_dataGridView.DataSource = binder;
                            module_dataGridView.Columns["id"].Visible = false;
                        }
                    }
                   
                }
            }
        }
    }
}
