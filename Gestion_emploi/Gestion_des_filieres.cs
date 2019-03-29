﻿using System;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_emploi
{
    public partial class Gestion_des_filieres : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Gestion_des_filieres()
        {
            InitializeComponent();
        }

        private void Gestion_des_filieres_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();

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
        }

        private void Secteur_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select f.id, f.nom, s.nom as secteur FROM filiere f JOIN secteur s ON f.id_secteur = s.id WHERE id_secteur=@id_secteur";
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
                        command.CommandText = "INSERT INTO filiere(nom) VALUES(@nom)";
                        command.Parameters.AddWithValue("@nom", nom_textBox.Text);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Filiere ajouté");
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
            string confirmationMessage = filieres_dataGridView.CurrentRow.Cells["nom"].Value + " sera modifié";
            if (MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "update filiere set nom = @nom WHERE id = @id";
                        command.Parameters.AddWithValue("@id", filieres_dataGridView.CurrentRow.Cells["id"].Value);
                        command.Parameters.AddWithValue("@nom", nom_textBox.Text);

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Filiere modifié");
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
                        command.Parameters.AddWithValue("@id_metier", filieres_dataGridView.CurrentRow.Cells["id"].Value);
                        command.ExecuteNonQuery();
                    }

                    // remove all modules with that metier
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM module WHERE id_metier = @id_metier";
                        command.Parameters.AddWithValue("@id_metier", filieres_dataGridView.CurrentRow.Cells["id"].Value);
                        command.ExecuteNonQuery();
                    }

                    // Remove metier
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "DELETE FROM metier WHERE id = @id";
                        command.Parameters.AddWithValue("@id", filieres_dataGridView.CurrentRow.Cells["id"].Value);
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
                    command.CommandText = "select f.id, f.nom, s.nom as secteur FROM filiere f JOIN secteur s ON f.id_secteur = s.id";
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
