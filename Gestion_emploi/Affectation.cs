using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Gestion_emploi
{
    public partial class Affectation : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["mysqlConnection"].ConnectionString;
        bool isIndexChangedBlocked = false;

        public Affectation()
        {
            InitializeComponent();
        }

        private void Affectation_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM filiere";
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        BindingSource binder = new BindingSource();
                        binder.DataSource = reader;
                        filiere_comboBox.DataSource = binder;
                        filiere_comboBox.ValueMember = "id";
                        filiere_comboBox.DisplayMember = "nom";
                        filiere_comboBox.Text = "";
                    }
                }

                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText = "SELECT id, nom FROM formateur";
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    listBox1.ValueMember = "id";
                    listBox1.DisplayMember = "nom";
                    listBox1.DataSource = binder;
                }
            }

            RemplirDataGridView(-1);


        }

        private void Choisir_button_Click(object sender, EventArgs e)
        {
            RemplirDataGridView(-1);

            // Groupes
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText =
                        "SELECT id, chaine FROM groupe WHERE id_filiere=@id_filiere AND niveau=@niveau";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    groupe_listBox.ValueMember = "id";
                    groupe_listBox.DisplayMember = "chaine";
                    groupe_listBox.DataSource = binder;
                }
            }
        }

        private void Module_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Formateurs
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText =
                        "SELECT id, nom FROM formateur WHERE id_metier IN (SELECT m.id_metier FROM module m JOIN module_filiere mf ON m.id=mf.id_module JOIN filiere f ON f.id=mf.id_filiere WHERE m.id=@id_module)";
                    command.Parameters.AddWithValue("@id_module", module_listBox.SelectedValue);
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    formateur_listBox.ValueMember = "id";
                    formateur_listBox.DisplayMember = "nom";
                    formateur_listBox.DataSource = binder;
                }
            }
        }

        private void Groupe_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isIndexChangedBlocked)
            {
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("", connection))
                {
                    command.CommandText =
                        "SELECT m.id, m.nom FROM module m JOIN module_filiere mf ON m.id=mf.id_module JOIN filiere f ON f.id=mf.id_filiere WHERE id_filiere=@id_filiere AND niveau=@niveau AND id_module NOT IN (SELECT id_module FROM affectation WHERE id_groupe=@id_groupe);";
                    command.Parameters.AddWithValue("@id_filiere", filiere_comboBox.SelectedValue);
                    command.Parameters.AddWithValue("@niveau", niveau_numericUpDown.Value);
                    command.Parameters.AddWithValue("@id_groupe", groupe_listBox.SelectedValue);
                    BindingSource binder = new BindingSource();
                    binder.DataSource = command.ExecuteReader();
                    module_listBox.ValueMember = "id";
                    module_listBox.DisplayMember = "nom";
                    module_listBox.DataSource = binder;
                }
            }
        }

        private void Affecter_button_Click(object sender, EventArgs e)
        {
            int commandOutput = 0;

            for (int i = 0; i < groupe_listBox.Items.Count; i++)
            {
                if (groupe_listBox.GetSelected(i))
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        using (MySqlCommand command = new MySqlCommand("", connection))
                        {
                            command.CommandText =
                            "INSERT INTO affectation(id_formateur, id_module, id_groupe) VALUES(@id_formateur, @id_module, @id_groupe)";
                            command.Parameters.AddWithValue("@id_formateur", formateur_listBox.SelectedValue);
                            command.Parameters.AddWithValue("@id_module", module_listBox.SelectedValue);
                            command.Parameters.AddWithValue("@id_groupe", groupe_listBox.SelectedValue);

                            commandOutput += command.ExecuteNonQuery();
                        }
                    }

                    isIndexChangedBlocked = true;
                    groupe_listBox.SetSelected(i, false);
                }
            }

            MessageBox.Show(commandOutput.ToString() + " affectations ajoutés");
            isIndexChangedBlocked = false;

            RemplirDataGridView(-1);

        }
      




        private void RemplirDataGridView(int id_formateur)
        {
            //sometimes we need to send an id , from listbox cause we can't filter with binder since it's not global , so when i need an id , i will send it , when i need full data i send -1
            if (id_formateur < 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        //here you have the 3 id's of formateur,module,and groupe , all of them hidden if you need'em , only module name and group name are shown

                        command.CommandText = "SELECT g.nom as groupe, m.nom as module , a.id , a.id_formateur , a.id_module , a.id_groupe from affectation a join groupe g on a.id_groupe = g.id join module m on a.id_module = m.id ";
                        BindingSource binder = new BindingSource();
                        binder.DataSource = command.ExecuteReader();

                        dataGridView1.DataSource = binder;
                    }
                }
            }
            else if (id_formateur >= 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("", connection))
                    {
                        //here you have the 3 id's of formateur,module,and groupe , all of them hidden if you need'em , only module name and group name are shown

                        command.CommandText = "SELECT g.nom as groupe, m.nom as module , a.id , a.id_formateur , a.id_module , a.id_groupe from affectation a join groupe g on a.id_groupe = g.id join module m on a.id_module = m.id where id_formateur = " + id_formateur;
                        BindingSource binder = new BindingSource();
                        binder.DataSource = command.ExecuteReader();

                        dataGridView1.DataSource = binder;
                    }

                    int mass_horaire = 0;
                    if (dataGridView1.Rows.Count > 0 && listBox1.Items.Count > 0)
                    {
                        using (MySqlCommand command = new MySqlCommand("", connection))
                        {
                            //here you have the 3 id's of formateur,module,and groupe , all of them hidden if you need'em , only module name and group name are shown
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                command.CommandText = "SELECT mass_horaire from module where id = " + dataGridView1.Rows[i].Cells[2].Value;
                                int horaire = (int)command.ExecuteScalar();
                                mass_horaire += horaire;
                            }

                        }

                        textBox1.Text = mass_horaire.ToString();

                    }
                }

            }

            if (dataGridView1.Rows.Count != 0 && dataGridView1.Columns["id"] != null && dataGridView1.Columns["id_formateur"] != null)
            {
                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["id_formateur"].Visible = false;
                dataGridView1.Columns["id_module"].Visible = false;
                dataGridView1.Columns["id_groupe"].Visible = false;

            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirDataGridView((int)listBox1.SelectedValue);
        }
    }
}

