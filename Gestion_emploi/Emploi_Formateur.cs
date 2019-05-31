using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin.Controls;

namespace Gestion_emploi
{
    public partial class Emploi_Formateur : MaterialForm
    {
        public Emploi_Formateur()
        {
            InitializeComponent();
        }
        readonly string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        private void Emploi_Formateur_Load(object sender, EventArgs e)
        {
            RemplirListBoxes();
           

        }

        private void RemplirListBoxes()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT * FROM Formateur";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        groupe_comboBox.DataSource = binder;
                        groupe_comboBox.ValueMember = "id";
                        groupe_comboBox.DisplayMember = "nom";
                        groupe_comboBox.Text = "";
                    }
                }
            }


        }

        private void RemplirEmploi(string formateur)
        {
            emploi_dataGridView.Rows.Clear();
            InitializeEmploi();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT e.chaine, id_jour, id_seance, id_affectation FROM emploi e JOIN affectation a ON e.id_affectation = a.id JOIN module m ON m.id = a.id_module WHERE id_formateur = @formateur";
                    command.Parameters.AddWithValue("@formateur", formateur);

                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int jour = int.Parse(reader[1].ToString()) - 1;
                            int seance = int.Parse(reader[2].ToString());

                            emploi_dataGridView.Rows[jour].Cells[seance].Value = reader[0].ToString();
                        }
                    }
                }
            }
        }

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

        private void groupe_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupe_comboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RemplirEmploi(groupe_comboBox.SelectedValue.ToString());
        }
    }
}
