using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;
using DataTable = Microsoft.Office.Interop.Excel.DataTable;
using System.Configuration;
using MaterialSkin.Controls;

namespace Gestion_emploi
{
    public partial class Import : MaterialForm
    {
        public Import()
        {
            InitializeComponent();
        }

        public string path;
        private DataSet ds;
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;



        private void Import_Load(object sender, EventArgs e)
        {
            
            ds = new DataSet();

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
                        comboBox2.ValueMember = "id";
                        comboBox2.DisplayMember = "nom";
                        comboBox2.DataSource = binder;
                        comboBox2.Text = "";
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
                        comboBox3.ValueMember = "id";
                        comboBox3.DisplayMember = "nom";
                        comboBox3.DataSource = binder;
                        comboBox3.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            dataGridView1.DataSource = null;

            using (OpenFileDialog ofd = new OpenFileDialog() {Filter = "Excel Workbook|*.xlsx", ValidateNames = true})
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(fs);

                    ds = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    if (ds != null)
                    {
                        for (int i = 0; i < ds.Tables.Count; i++)
                        {
                            comboBox1.Items.Add(ds.Tables[i].TableName);

                        }

                    }
                    

                }



            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[comboBox1.SelectedIndex];
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string nom;
            string mass_horaire;
            string niveau;


            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[6].Value != null)
                    nom = dataGridView1.Rows[i].Cells[6].Value.ToString();
                else
                    nom = "";

                mass_horaire = ((Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value)) +
                                (Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value))).ToString(); 

                if ( (Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value))> 0 && (Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value)) < 0)
                {
                    niveau = "1";
                }

                else if ((Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value)) < 0 && (Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value)) > 0)
                {
                    niveau = "2";
                }

                else
                {
                    niveau = "12";
                }

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        command.CommandText = "INSERT INTO module(nom, niveau, mass_horaire, id_metier, id_filiere) VALUES(@nom, @niveau ,@mass_horaire, @id_metier, @id_filiere)";
                        command.Parameters.AddWithValue("@nom",nom);
                        command.Parameters.AddWithValue("@niveau", niveau);
                        command.Parameters.AddWithValue("@mass_horaire",mass_horaire);
                        command.Parameters.AddWithValue("@id_metier",comboBox2.SelectedValue);
                        command.Parameters.AddWithValue("@id_filiere",comboBox3.SelectedValue);

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



            }





        }
    }
}
