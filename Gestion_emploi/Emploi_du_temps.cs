using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_emploi
{
    public partial class Emploi_du_temps : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;

        public Emploi_du_temps()
        {
            InitializeComponent();
        }

        private void Emploi_du_temps_Load(object sender, EventArgs e)
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
            }
        }

        private void Groupe_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT a.id, g.chaine AS groupe, m.nom AS module, f.nom AS formateur, a.nb_heures FROM affectation a JOIN groupe g ON a.id_groupe = g.id JOIN module m ON a.id_module = m.id JOIN formateur f ON a.id_formateur = f.id WHERE a.id_groupe = @id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", groupe_comboBox.SelectedValue);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int nbSeances = (int)(float.Parse(reader["nb_heures"].ToString()) / 2.5f);

                        for (int i = 0; i < nbSeances; i++)
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
    }
}
