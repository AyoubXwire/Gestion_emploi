using MaterialSkin.Controls;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
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
    public partial class Emploi_extract : MaterialForm
    {
        readonly string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

        public Emploi_extract()
        {
            InitializeComponent();
        }

        private void Emplois_extract_Load(object sender, EventArgs e)
        {
            RemplirListBoxes();
        }

        private void RemplirEmploi(string groupe)
        {
            emploi_dataGridView.Rows.Clear();
            InitializeEmploi(emploi_dataGridView);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT e.chaine_Groupe, id_jour, id_seance, id_affectation FROM emploi e JOIN affectation a ON e.id_affectation = a.id JOIN module m ON m.id = a.id_module WHERE id_groupe = @id_groupe";
                    command.Parameters.AddWithValue("@id_groupe", groupe);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
        }

        private void RemplirEmploiFormateur(string formateur)
        {
            emploi_dataGridView.Rows.Clear();
            InitializeEmploi(emploi_dataGridView);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT e.chaine_formateur, id_jour, id_seance, id_affectation FROM emploi e JOIN affectation a ON e.id_affectation = a.id JOIN module m ON m.id = a.id_module WHERE id_formateur = @id_formateur";
                    command.Parameters.AddWithValue("@id_formateur", formateur);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, chaine FROM groupe";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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

                // Remplir salles_filiere
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT * FROM filiere";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
                // Remplir formateur listBox
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT * FROM Formateur";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            BindingSource binder = new BindingSource();
                            binder.DataSource = reader;
                            listBox3.ValueMember = "id";
                            listBox3.DisplayMember = "nom";
                            listBox3.DataSource = binder;
                        }
                    }
                  
                }
            }
        }

        private void RemplirGroup()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, chaine FROM groupe where id_filiere = @filiere";
                    command.Parameters.AddWithValue("@filiere", listBox1.SelectedValue);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirGroup();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            RemplirEmploi(listBox2.SelectedValue.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void exporter_button_Click(object sender, EventArgs e)
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
                
                xcelApp.Columns.ColumnWidth = 36;
                xcelApp.Columns.RowHeight = 30;

                Range chartRange;
                chartRange = xcelApp.get_Range("a1", "e7");
                foreach (Range cell in chartRange.Cells)
                {
                    cell.BorderAround2();
                    cell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    cell.VerticalAlignment = XlHAlign.xlHAlignCenter;
                    cell.Font.Size = 12;
                }

                chartRange = xcelApp.get_Range("a1", "e1");
                chartRange.Cells.Font.Bold = true;
                chartRange.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);

                chartRange = xcelApp.get_Range("a1", "a7");
                chartRange.Cells.Font.Bold = true;
                chartRange.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                chartRange = xcelApp.get_Range("c9", "c9");
                chartRange.Font.Bold = true;
                chartRange.Font.Size = 12;
                chartRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                chartRange.VerticalAlignment = XlHAlign.xlHAlignCenter;

                chartRange.Value = listBox2.GetItemText(listBox2.SelectedItem);
                xcelApp.Visible = true;
            }
        }

        //check if the emploi is full with data
        public bool IsFull()
        {
            bool Is = false;
            foreach (DataGridViewRow row in emploi_dataGridView.Rows)
            {
                for (int i = 1; i < 5; i++)
                {
                    if (row.Cells[i].Value != null)
                        Is = true;
                }
            }

            return Is;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox2.BeginUpdate();

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                listBox2.SetSelected(i, true);


                if (IsFull())
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);
                    xcelApp.Columns.ColumnWidth = 100;


                    for (int ii = 1; ii < emploi_dataGridView.Columns.Count + 1; ii++)
                    {
                        xcelApp.Cells[1, ii] = emploi_dataGridView.Columns[ii - 1].HeaderText;
                    }

                    for (int ii = 0; ii < emploi_dataGridView.Rows.Count; ii++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (emploi_dataGridView.Rows[ii].Cells[j].Value == null)
                                xcelApp.Cells[ii + 2, j + 1] = "";
                            else
                                xcelApp.Cells[ii + 2, j + 1] = emploi_dataGridView.Rows[ii].Cells[j].Value.ToString();
                        }
                    }

                    xcelApp.Columns.ColumnWidth = 36;
                    xcelApp.Columns.RowHeight = 30;

                    Range chartRange;
                    chartRange = xcelApp.get_Range("a1", "e7");
                    foreach (Range cell in chartRange.Cells)
                    {
                        cell.BorderAround2();
                        cell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        cell.VerticalAlignment = XlHAlign.xlHAlignCenter;
                        cell.Font.Size = 12;
                    }

                    chartRange = xcelApp.get_Range("a1", "e1");
                    chartRange.Cells.Font.Bold = true;
                    chartRange.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);

                    chartRange = xcelApp.get_Range("a1", "a7");
                    chartRange.Cells.Font.Bold = true;
                    chartRange.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);


                    chartRange = xcelApp.get_Range("c9", "c9");
                    chartRange.Font.Bold = true;
                    chartRange.Font.Size = 12;
                    chartRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    chartRange.VerticalAlignment = XlHAlign.xlHAlignCenter;

                    chartRange.Value = listBox2.GetItemText(listBox2.SelectedItem);
                    xcelApp.Visible = true;
                }


            }

            listBox2.EndUpdate();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirEmploiFormateur(listBox3.SelectedValue.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
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

                xcelApp.Columns.ColumnWidth = 36;
                xcelApp.Columns.RowHeight = 30;

                Range chartRange;
                chartRange = xcelApp.get_Range("a1", "e7");
                foreach (Range cell in chartRange.Cells)
                {
                    cell.BorderAround2();
                    cell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    cell.VerticalAlignment = XlHAlign.xlHAlignCenter;
                    cell.Font.Size = 12;
                }

                chartRange = xcelApp.get_Range("a1", "e1");
                chartRange.Cells.Font.Bold = true;
                chartRange.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);

                chartRange = xcelApp.get_Range("a1", "a7");
                chartRange.Cells.Font.Bold = true;
                chartRange.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);
                chartRange = xcelApp.get_Range("c9", "c9");
                chartRange.Font.Bold = true;
                chartRange.Font.Size = 12;
                chartRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                chartRange.VerticalAlignment = XlHAlign.xlHAlignCenter;

                chartRange.Value = listBox3.GetItemText(listBox3.SelectedItem);
                xcelApp.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.BeginUpdate();

            for (int i = 0; i < listBox3.Items.Count; i++)
            {
                listBox3.SetSelected(i, true);


                if (IsFull())
                {
                    Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                    xcelApp.Application.Workbooks.Add(Type.Missing);
                    xcelApp.Columns.ColumnWidth = 100;


                    for (int ii = 1; ii < emploi_dataGridView.Columns.Count + 1; ii++)
                    {
                        xcelApp.Cells[1, ii] = emploi_dataGridView.Columns[ii - 1].HeaderText;
                    }

                    for (int ii = 0; ii < emploi_dataGridView.Rows.Count; ii++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (emploi_dataGridView.Rows[ii].Cells[j].Value == null)
                                xcelApp.Cells[ii + 2, j + 1] = "";
                            else
                                xcelApp.Cells[ii + 2, j + 1] = emploi_dataGridView.Rows[ii].Cells[j].Value.ToString();
                        }
                    }

                    xcelApp.Columns.ColumnWidth = 36;
                    xcelApp.Columns.RowHeight = 30;

                    Range chartRange;
                    chartRange = xcelApp.get_Range("a1", "e7");
                    foreach (Range cell in chartRange.Cells)
                    {
                        cell.BorderAround2();
                        cell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                        cell.VerticalAlignment = XlHAlign.xlHAlignCenter;
                        cell.Font.Size = 12;
                    }

                    chartRange = xcelApp.get_Range("a1", "e1");
                    chartRange.Cells.Font.Bold = true;
                    chartRange.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);

                    chartRange = xcelApp.get_Range("a1", "a7");
                    chartRange.Cells.Font.Bold = true;
                    chartRange.Cells.Interior.Color = ColorTranslator.ToOle(Color.LightGray);


                    chartRange = xcelApp.get_Range("c9", "c9");
                    chartRange.Font.Bold = true;
                    chartRange.Font.Size = 12;
                    chartRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    chartRange.VerticalAlignment = XlHAlign.xlHAlignCenter;

                    chartRange.Value = listBox3.GetItemText(listBox3.SelectedItem);
                    xcelApp.Visible = true;
                }


            }

            listBox3.EndUpdate();
        }
    }
}
