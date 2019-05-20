using MySql.Data.MySqlClient;
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

namespace Gestion_emploi
{
    public partial class emplois_extract : Form
    {
        public emplois_extract()
        {
            InitializeComponent();
        }
        readonly string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void emplois_extract_Load(object sender, EventArgs e)
        {
            RemplirListBoxes();


        }


        private void RemplirEmploi(string groupe)
        {
            emploi_dataGridView.Rows.Clear();
            InitializeEmploi(emploi_dataGridView);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT e.chaine, id_jour, id_seance , id_affectation FROM emploi e JOIN affectation a ON e.id_affectation = a.id JOIN module m ON m.id = a.id_module WHERE id_groupe = @id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", groupe);

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

        private void InitializeEmploi(DataGridView dv)
        {
            DataGridViewRow lundiRow = (DataGridViewRow)dv.Rows[0].Clone();
            lundiRow.Cells[0].Value = "lundi";
            dv.Rows.Add(lundiRow);

            DataGridViewRow mardiRow = (DataGridViewRow)dv.Rows[0].Clone();
            mardiRow.Cells[0].Value = "mardi";
            dv.Rows.Add(mardiRow);

            DataGridViewRow mercrediRow = (DataGridViewRow)dv.Rows[0].Clone();
            mercrediRow.Cells[0].Value = "mercredi";
            dv.Rows.Add(mercrediRow);

            DataGridViewRow jeudiRow = (DataGridViewRow)dv.Rows[0].Clone();
            jeudiRow.Cells[0].Value = "jeudi";
            dv.Rows.Add(jeudiRow);

            DataGridViewRow vendrediRow = (DataGridViewRow)dv.Rows[0].Clone();
            vendrediRow.Cells[0].Value = "vendredi";
            dv.Rows.Add(vendrediRow);

            DataGridViewRow samediRow = (DataGridViewRow)dv.Rows[0].Clone();
            samediRow.Cells[0].Value = "samedi";
            dv.Rows.Add(samediRow);
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
                        listBox2.DataSource = binder;
                        listBox2.ValueMember = "id";
                        listBox2.DisplayMember = "chaine";
                        listBox2.Text = "";
                    }
                }

                // Remplir salles_listBox
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT * FROM filiere";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        listBox1.ValueMember = "id";
                        listBox1.DisplayMember = "nom";
                        listBox1.DataSource = binder;
                    }
                }
            }
        }

        private void RemplirGroup()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, chaine FROM groupe where id_filiere = @filiere";
                    command.Parameters.AddWithValue("@filiere", listBox1.SelectedValue);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        listBox2.DataSource = binder;
                        listBox2.ValueMember = "id";
                        listBox2.DisplayMember = "chaine";
                        listBox2.Text = "";
                    }
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirGroup();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox2.SelectedIndex>0)
            RemplirEmploi(listBox2.SelectedValue.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (emploi_dataGridView.Rows.Count > 0)
            {

                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < emploi_dataGridView.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = emploi_dataGridView.Columns[i - 1].HeaderText;
                }



                for (int i = 0; i < emploi_dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (emploi_dataGridView.Rows[i].Cells[j].Value == null)
                            xcelApp.Cells[i + 2, j + 1] = "";
                        else
                            xcelApp.Cells[i + 2, j + 1] = emploi_dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;
            }
        }
    }
}
