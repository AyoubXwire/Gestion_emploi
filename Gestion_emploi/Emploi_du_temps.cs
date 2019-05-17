﻿using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Gestion_emploi
{
    public partial class Emploi_du_temps : Form
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Emploi_du_temps()
        {
            InitializeComponent();
        }

        List<Deelete_helper> items;
        string affectation = "";

        private void Emploi_du_temps_Load(object sender, EventArgs e)
        {
            RemplirListBoxes();
            RemplirEmploi();

            if (affectations_dataGridView.CurrentRow != null && affectations_dataGridView.CurrentRow.Cells[0].Value != null)
                Coloring(int.Parse(affectations_dataGridView.CurrentRow.Cells[0].Value.ToString()));
        }

        private string GetEmploiChaine(int id_affectation, int id_salle)
        {
            string salle;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select nom from salle where id = @id_salle";
                    command.Parameters.AddWithValue("@id_salle", id_salle);

                    salle = command.ExecuteScalar().ToString();
                }

                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select f.nom, m.nom from affectation a join module m on a.id_module = m.id join formateur f on a.id_formateur = f.id where a.id = @id_affectation";
                    command.Parameters.AddWithValue("@id_affectation", id_affectation);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        return reader[0].ToString() + " || " + reader[1].ToString() + " || " + salle;
                    }
                }
            }

            return "";
        }

        // Ajouter une seance dans l'emploi
        private void Ajouter_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        int affectation = int.Parse(affectations_dataGridView.CurrentRow.Cells["id"].Value.ToString());
                        int jour = ((int)emploi_dataGridView.CurrentCell.RowIndex) + 1;
                        int seance = emploi_dataGridView.CurrentCell.ColumnIndex;
                        int salle = int.Parse(salles_listBox.SelectedValue.ToString());

                        command.CommandText = "INSERT INTO emploi(id_affectation, id_jour, id_seance, id_salle, chaine) VALUES(@id_affectation, @id_jour, @id_seance, @id_salle, @chaine)";
                        command.Parameters.AddWithValue("@id_affectation", affectation);
                        command.Parameters.AddWithValue("@id_jour", jour);
                        command.Parameters.AddWithValue("@id_seance", seance);
                        command.Parameters.AddWithValue("@id_salle", salle);
                        command.Parameters.AddWithValue("@chaine", GetEmploiChaine(affectation, salle));

                        string validationResult = Validator(affectation, jour, seance, salle);

                        if (validationResult == "ok")
                        {
                            command.ExecuteNonQuery();

                            // Update the affectation nb_utilise
                            using (MySqlCommand command2 = new MySqlCommand("", connection))
                            {
                                command2.CommandText = "UPDATE affectation SET nb_utilise = nb_utilise+1 WHERE id = @id_affectation";
                                command2.Parameters.AddWithValue("@id_affectation", affectations_dataGridView.SelectedRows[0].Cells["id"].Value);

                                command2.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show(validationResult);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            Groupe_comboBox_SelectedIndexChanged(null, null);
            RemplirEmploi();

            if (affectations_dataGridView.CurrentRow != null && affectations_dataGridView.CurrentRow.Cells[0].Value != null)
                Coloring(int.Parse(affectations_dataGridView.CurrentRow.Cells[0].Value.ToString()));
        }

        // Supprimer une seance de l'emploi
        private void Supprimer_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    try
                    {
                        command.CommandText = "DELETE FROM emploi WHERE id_affectation = @id_affectation AND id_jour = @id_jour AND id_seance = @id_seance";

                        foreach (var item in items)
                        {
                            if (emploi_dataGridView.CurrentCell.Value.ToString() == item.chaine)
                            {
                                affectation = item.id.ToString();
                                break;
                            }

                        }
                        command.Parameters.AddWithValue("@id_affectation", affectation);
                        command.Parameters.AddWithValue("@id_jour", ((int)emploi_dataGridView.CurrentCell.RowIndex) + 1);
                        command.Parameters.AddWithValue("@id_seance", emploi_dataGridView.CurrentCell.ColumnIndex);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("seance introuvable");
                    }
                }

                // Update the affectation nb_utilise
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "UPDATE affectation SET nb_utilise = nb_utilise-1 WHERE id = @id_affectation";
                    command.Parameters.AddWithValue("@id_affectation", emploi_dataGridView.SelectedCells[0].Value);

                    command.ExecuteNonQuery();
                }
            }

            Groupe_comboBox_SelectedIndexChanged(null, null);
            RemplirEmploi();
        }

        // Coloring datagridview
        private void Coloring (int affectation)
        {
            for (int i = 0; i < emploi_dataGridView.Rows.Count; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (IsFormateurAvailable(affectation, i + 1, j) == false)
                        emploi_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                    else
                        emploi_dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        // Send the user a precise message
        private string Validator(int affectation, int jour, int seance, int salle)
        {
            string result = "contraints:";

            if(!IsFormateurAvailable(affectation, jour, seance))
            {
                result += " formateur indisponible";
            }
            if(!IsSalleAvailable(jour, seance, salle))
            {
                result += " salle indisponible";
            }
            if(!IsGroupeAvailable(affectation, jour, seance))
            {
                result += " groupe indisponible";
            }

            if(result == "contraints:")
            {
                return "ok";
            }
            else
            {
                return result;
            }
        }

        // Remplir affectations_dataGridView
        private void Groupe_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirAffectations();
            RemplirEmploi();
        }

        private void RemplirAffectations()
        {
            affectations_dataGridView.Rows.Clear();
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT a.id AS id, g.chaine AS groupe, m.nom AS module, f.nom AS formateur, a.nb_heures, a.nb_utilise FROM affectation a JOIN groupe g ON a.id_groupe = g.id JOIN module m ON a.id_module = m.id JOIN formateur f ON a.id_formateur = f.id WHERE a.id_groupe = @id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", groupe_comboBox.SelectedValue);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int nbSeances = (int)(float.Parse(reader["nb_heures"].ToString()) / 2.5f);
                        int nbUtilise = int.Parse(reader["nb_utilise"].ToString());

                        for (int i = nbUtilise; i < nbSeances; i++)
                        {
                            DataGridViewRow row = (DataGridViewRow)affectations_dataGridView.Rows[0].Clone();

                            row.Cells[0].Value = reader[0].ToString();
                            row.Cells[1].Value = reader[1].ToString();
                            row.Cells[2].Value = reader[2].ToString();
                            row.Cells[3].Value = reader[3].ToString();

                            affectations_dataGridView.Rows.Add(row);
                        }

                        affectations_dataGridView.Columns["id"].Visible = false;
                    }
                }
            }
        }

        private void RemplirEmploi()
        {
            emploi_dataGridView.Rows.Clear();
            InitializeEmploi();
            items = new List<Deelete_helper>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT e.chaine, id_jour, id_seance , id_affectation FROM emploi e JOIN affectation a ON e.id_affectation = a.id JOIN module m ON m.id = a.id_module WHERE id_groupe = @id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", groupe_comboBox.SelectedValue);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int jour = int.Parse(reader[1].ToString()) - 1;
                            int seance = int.Parse(reader[2].ToString());

                            emploi_dataGridView.Rows[jour].Cells[seance].Value = reader[0].ToString();
                            items.Add(new Deelete_helper((int)reader[3], reader[0].ToString()));
                            
                        }
                    }
                }
            }
        }

        // Set up emploi table
        private void InitializeEmploi()
        {
            DataGridViewRow lundiRow = (DataGridViewRow)emploi_dataGridView.Rows[0].Clone();
            lundiRow.Cells[0].Value = "lundi";
            emploi_dataGridView.Rows.Add(lundiRow);

            DataGridViewRow mardiRow = (DataGridViewRow)emploi_dataGridView.Rows[0].Clone();
            mardiRow.Cells[0].Value = "mardi";
            emploi_dataGridView.Rows.Add(mardiRow);

            DataGridViewRow mercrediRow = (DataGridViewRow)emploi_dataGridView.Rows[0].Clone();
            mercrediRow.Cells[0].Value = "mercredi";
            emploi_dataGridView.Rows.Add(mercrediRow);

            DataGridViewRow jeudiRow = (DataGridViewRow)emploi_dataGridView.Rows[0].Clone();
            jeudiRow.Cells[0].Value = "jeudi";
            emploi_dataGridView.Rows.Add(jeudiRow);

            DataGridViewRow vendrediRow = (DataGridViewRow)emploi_dataGridView.Rows[0].Clone();
            vendrediRow.Cells[0].Value = "vendredi";
            emploi_dataGridView.Rows.Add(vendrediRow);

            DataGridViewRow samediRow = (DataGridViewRow)emploi_dataGridView.Rows[0].Clone();
            samediRow.Cells[0].Value = "samedi";
            emploi_dataGridView.Rows.Add(samediRow);
        }

        private void RemplirListBoxes()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, chaine FROM groupe";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        groupe_comboBox.DataSource = binder;
                        groupe_comboBox.ValueMember = "id";
                        groupe_comboBox.DisplayMember = "chaine";
                        groupe_comboBox.Text = "";
                    }
                }

                // Remplir salles_listBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT s.id ,CONCAT(s.nom , ' (' , t.nom , ' )') as nom FROM salle s join type_salle t on s.id = t.id";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        salles_listBox.ValueMember = "id";
                        salles_listBox.DisplayMember ="nom";
                        salles_listBox.DataSource = binder;
                    }
                }
            }
        }
 
        // Check formateur availability
        public bool IsFormateurAvailable(int affectation , int jour , int seance)
        {            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select * from emploi e join affectation a on e.id_affectation = a.id where a.id_formateur = (select id_formateur from affectation where id = @affectation) and id_jour = @jour and id_seance = @seance";
                    command.Parameters.AddWithValue("@affectation", affectation);
                    command.Parameters.AddWithValue("@jour", jour);
                    command.Parameters.AddWithValue("@seance", seance);

                    MySqlDataReader reader = command.ExecuteReader();

                    return !reader.HasRows;
                }
            }
        }

        // Check groupe availability
        public bool IsGroupeAvailable(int affectation, int jour, int seance)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select * from emploi e join affectation a on e.id_affectation = a.id where a.id_groupe = (select id_groupe from affectation where id = @affectation) and id_jour = @jour and id_seance = @seance";
                    command.Parameters.AddWithValue("@affectation", affectation);
                    command.Parameters.AddWithValue("@jour", jour);
                    command.Parameters.AddWithValue("@seance", seance);

                    MySqlDataReader reader = command.ExecuteReader();

                    return !reader.HasRows;
                }
            }
        }

        // Check salle availability
        public bool IsSalleAvailable(int jour, int seance, int salle)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "select * from emploi where id_jour = @jour and id_seance = @seance and id_salle = @salle";
                    command.Parameters.AddWithValue("@jour", jour);
                    command.Parameters.AddWithValue("@seance", seance);
                    command.Parameters.AddWithValue("@salle", salle);

                    MySqlDataReader reader = command.ExecuteReader();

                    return !reader.HasRows;
                }
            }
        }

        private void Emploi_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    try
                    {
                        int affectation = int.Parse(emploi_dataGridView.CurrentCell.Value.ToString());
                        int jour = ((int)emploi_dataGridView.CurrentCell.RowIndex) + 1;
                        int seance = emploi_dataGridView.CurrentCell.ColumnIndex;

                        command.CommandText = "select id_salle from emploi where id_affectation = @affectation and id_jour = @jour and id_seance = @seance";
                        command.Parameters.AddWithValue("@affectation", affectation);
                        command.Parameters.AddWithValue("@jour", jour);
                        command.Parameters.AddWithValue("@seance", seance);
                    
                        salles_listBox.SelectedValue = command.ExecuteScalar();
                    }
                    catch{}
                }
            }
        }

        private void Affectations_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(affectations_dataGridView.CurrentRow.Cells[0].Value != null)
            Coloring(int.Parse(affectations_dataGridView.CurrentRow.Cells[0].Value.ToString()));
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "delete from emploi where id_affectation in (select id from affectation  where id = id_affectation) and (select id_groupe from affectation where id = id_affectation) in (select id_groupe from affectation where id = @affectation)";
                    command.Parameters.AddWithValue("@affectation", groupe_comboBox.SelectedValue);

                    if(MessageBox.Show("vous etes sur?","confirmation",MessageBoxButtons.YesNo) == DialogResult.Yes)
                        command.ExecuteNonQuery();
                    
                    
                }

                // Update the affectation nb_utilise
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "UPDATE affectation SET nb_utilise = 0 WHERE id_groupe = @id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", groupe_comboBox.SelectedValue);

                    command.ExecuteNonQuery();
                }

                RemplirAffectations();
                RemplirEmploi();
            }
        }

    }
}
