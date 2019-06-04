namespace Gestion_emploi
{
    partial class Gestion_des_seances
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_seances));
            this.seances_dataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupes_listBox = new System.Windows.Forms.ListBox();
            this.formateurs_listBox = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nbHeuresFormateur_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nbHeuresGroupe_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nbHeures_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.appliquerNbHeures_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateDebut_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.appliquerDateDebut_button = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.avancement_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.appliquerAvancement_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seances_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbHeures_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avancement_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // seances_dataGridView
            // 
            this.seances_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seances_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seances_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seances_dataGridView.Location = new System.Drawing.Point(0, 355);
            this.seances_dataGridView.Name = "seances_dataGridView";
            this.seances_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seances_dataGridView.Size = new System.Drawing.Size(1127, 352);
            this.seances_dataGridView.TabIndex = 0;
            this.seances_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Seances_dataGridView_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Groupes:";
            // 
            // groupes_listBox
            // 
            this.groupes_listBox.FormattingEnabled = true;
            this.groupes_listBox.Location = new System.Drawing.Point(80, 45);
            this.groupes_listBox.Name = "groupes_listBox";
            this.groupes_listBox.Size = new System.Drawing.Size(153, 199);
            this.groupes_listBox.TabIndex = 82;
            this.groupes_listBox.SelectedIndexChanged += new System.EventHandler(this.Groupes_listBox_SelectedIndexChanged);
            // 
            // formateurs_listBox
            // 
            this.formateurs_listBox.FormattingEnabled = true;
            this.formateurs_listBox.Location = new System.Drawing.Point(80, 45);
            this.formateurs_listBox.Name = "formateurs_listBox";
            this.formateurs_listBox.Size = new System.Drawing.Size(153, 199);
            this.formateurs_listBox.TabIndex = 80;
            this.formateurs_listBox.SelectedIndexChanged += new System.EventHandler(this.Formateurs_listBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 81;
            this.label8.Text = "Formateurs:";
            // 
            // nbHeuresFormateur_textBox
            // 
            this.nbHeuresFormateur_textBox.Enabled = false;
            this.nbHeuresFormateur_textBox.Location = new System.Drawing.Point(168, 19);
            this.nbHeuresFormateur_textBox.Name = "nbHeuresFormateur_textBox";
            this.nbHeuresFormateur_textBox.Size = new System.Drawing.Size(65, 20);
            this.nbHeuresFormateur_textBox.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Nombre d\'heures par semaine:";
            // 
            // nbHeuresGroupe_textBox
            // 
            this.nbHeuresGroupe_textBox.Enabled = false;
            this.nbHeuresGroupe_textBox.Location = new System.Drawing.Point(168, 19);
            this.nbHeuresGroupe_textBox.Name = "nbHeuresGroupe_textBox";
            this.nbHeuresGroupe_textBox.Size = new System.Drawing.Size(65, 20);
            this.nbHeuresGroupe_textBox.TabIndex = 86;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nbHeuresFormateur_textBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.formateurs_listBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 255);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formateurs";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nbHeuresGroupe_textBox);
            this.groupBox2.Controls.Add(this.groupes_listBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(262, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 255);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Groupes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Nombre d\'heures par semaine:";
            // 
            // nbHeures_numericUpDown
            // 
            this.nbHeures_numericUpDown.DecimalPlaces = 1;
            this.nbHeures_numericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nbHeures_numericUpDown.Location = new System.Drawing.Point(166, 20);
            this.nbHeures_numericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nbHeures_numericUpDown.Name = "nbHeures_numericUpDown";
            this.nbHeures_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nbHeures_numericUpDown.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "nombre d\'heures par semaine:";
            // 
            // appliquerNbHeures_button
            // 
            this.appliquerNbHeures_button.Location = new System.Drawing.Point(312, 13);
            this.appliquerNbHeures_button.Name = "appliquerNbHeures_button";
            this.appliquerNbHeures_button.Size = new System.Drawing.Size(183, 31);
            this.appliquerNbHeures_button.TabIndex = 93;
            this.appliquerNbHeures_button.Text = "Appliquer";
            this.appliquerNbHeures_button.UseVisualStyleBackColor = true;
            this.appliquerNbHeures_button.Click += new System.EventHandler(this.AppliquerNbHeures_button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.appliquerNbHeures_button);
            this.groupBox3.Controls.Add(this.nbHeures_numericUpDown);
            this.groupBox3.Location = new System.Drawing.Point(585, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(520, 75);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateDebut_dateTimePicker);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.appliquerDateDebut_button);
            this.groupBox5.Location = new System.Drawing.Point(585, 84);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(520, 58);
            this.groupBox5.TabIndex = 97;
            this.groupBox5.TabStop = false;
            // 
            // dateDebut_dateTimePicker
            // 
            this.dateDebut_dateTimePicker.Location = new System.Drawing.Point(86, 20);
            this.dateDebut_dateTimePicker.Name = "dateDebut_dateTimePicker";
            this.dateDebut_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDebut_dateTimePicker.TabIndex = 94;
            this.dateDebut_dateTimePicker.Value = new System.DateTime(2019, 4, 5, 11, 56, 28, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "date debut:";
            // 
            // appliquerDateDebut_button
            // 
            this.appliquerDateDebut_button.Location = new System.Drawing.Point(312, 16);
            this.appliquerDateDebut_button.Name = "appliquerDateDebut_button";
            this.appliquerDateDebut_button.Size = new System.Drawing.Size(183, 31);
            this.appliquerDateDebut_button.TabIndex = 93;
            this.appliquerDateDebut_button.Text = "Appliquer";
            this.appliquerDateDebut_button.UseVisualStyleBackColor = true;
            this.appliquerDateDebut_button.Click += new System.EventHandler(this.AppliquerDateDebut_button_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.avancement_numericUpDown);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.appliquerAvancement_button);
            this.groupBox6.Location = new System.Drawing.Point(585, 263);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(520, 75);
            this.groupBox6.TabIndex = 95;
            this.groupBox6.TabStop = false;
            // 
            // avancement_numericUpDown
            // 
            this.avancement_numericUpDown.DecimalPlaces = 1;
            this.avancement_numericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.avancement_numericUpDown.Location = new System.Drawing.Point(166, 22);
            this.avancement_numericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.avancement_numericUpDown.Name = "avancement_numericUpDown";
            this.avancement_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.avancement_numericUpDown.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Avancement";
            // 
            // appliquerAvancement_button
            // 
            this.appliquerAvancement_button.Location = new System.Drawing.Point(312, 13);
            this.appliquerAvancement_button.Name = "appliquerAvancement_button";
            this.appliquerAvancement_button.Size = new System.Drawing.Size(183, 31);
            this.appliquerAvancement_button.TabIndex = 93;
            this.appliquerAvancement_button.Text = "Appliquer";
            this.appliquerAvancement_button.UseVisualStyleBackColor = true;
            this.appliquerAvancement_button.Click += new System.EventHandler(this.AppliquerAvancement_button_Click);
            // 
            // Gestion_des_seances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 707);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seances_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_des_seances";
            this.Text = "Gestion_des_seances";
            this.Load += new System.EventHandler(this.Gestion_des_seances_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seances_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbHeures_numericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avancement_numericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView seances_dataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox groupes_listBox;
        private System.Windows.Forms.ListBox formateurs_listBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nbHeuresFormateur_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nbHeuresGroupe_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nbHeures_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button appliquerNbHeures_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateDebut_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button appliquerDateDebut_button;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button appliquerAvancement_button;
        private System.Windows.Forms.NumericUpDown avancement_numericUpDown;
    }
}