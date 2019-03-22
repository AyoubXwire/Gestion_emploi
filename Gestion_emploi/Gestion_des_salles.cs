﻿using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Gestion_emploi
{
    public partial class Gestion_des_salles : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Gestion_des_salles()
        {
            InitializeComponent();
        }

        private void Gestion_des_salles_Load(object sender, EventArgs e)
        {
            RemplirDataGridView();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT * FROM type_salle";
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());
                    type_comboBox.DisplayMember = "nom";
                    type_comboBox.ValueMember = "id";
                    type_comboBox.DataSource = dt;
                    
                }
            }

            RemplirDataGridView();



        }

        private void Vider_button_Click(object sender, EventArgs e)
        {
            nom_textBox.Clear();
            type_comboBox.Text = "";
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
                        command.CommandText = "INSERT INTO salle(nom, id_type_salle) VALUES(@nom, @id_type_salle)";

                        //he can add as many salles as he wants , then modify the types.(the name problem there is the name problem)
                        for (int i = 0; i < numericUpDown1.Value; i++)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@nom", i+1);
                            command.Parameters.AddWithValue("@id_type_salle", type_comboBox.SelectedValue);
                            command.ExecuteNonQuery();
                        }

                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Salle(s) a/sont ajouté");
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
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
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
            string confirmationMessage = nom_textBox.Text + " sera supprimé";
            if (MessageBox.Show(confirmationMessage, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
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
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT s.id, s.nom, t.nom as type FROM salle s JOIN type_salle t ON s.id_type_salle=t.id";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    salles_dataGridView.DataSource = binder;
                }
            }

            if(salles_dataGridView.Columns["id"] !=null)
                salles_dataGridView.Columns["id"].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
