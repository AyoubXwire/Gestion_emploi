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
            this.majAvancementSelectionne_button = new System.Windows.Forms.Button();
            this.majTousLesAvancements_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nbHeuresRates_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateDebut_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.appliquerDateDebut_button = new System.Windows.Forms.Button();
            this.nbHeuresRates_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seances_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbHeures_numericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbHeuresRates_numericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // seances_dataGridView
            // 
            this.seances_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seances_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seances_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seances_dataGridView.Location = new System.Drawing.Point(0, 261);
            this.seances_dataGridView.Name = "seances_dataGridView";
            this.seances_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seances_dataGridView.Size = new System.Drawing.Size(1030, 394);
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
            this.groupes_listBox.Size = new System.Drawing.Size(153, 121);
            this.groupes_listBox.TabIndex = 82;
            this.groupes_listBox.SelectedIndexChanged += new System.EventHandler(this.Groupes_listBox_SelectedIndexChanged);
            // 
            // formateurs_listBox
            // 
            this.formateurs_listBox.FormattingEnabled = true;
            this.formateurs_listBox.Location = new System.Drawing.Point(80, 45);
            this.formateurs_listBox.Name = "formateurs_listBox";
            this.formateurs_listBox.Size = new System.Drawing.Size(153, 121);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 192);
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
            this.groupBox2.Location = new System.Drawing.Point(262, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 192);
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
            this.groupBox3.Location = new System.Drawing.Point(512, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 58);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            // 
            // majAvancementSelectionne_button
            // 
            this.majAvancementSelectionne_button.Location = new System.Drawing.Point(824, 12);
            this.majAvancementSelectionne_button.Name = "majAvancementSelectionne_button";
            this.majAvancementSelectionne_button.Size = new System.Drawing.Size(183, 46);
            this.majAvancementSelectionne_button.TabIndex = 94;
            this.majAvancementSelectionne_button.Text = "MAJ avancement selectionné";
            this.majAvancementSelectionne_button.UseVisualStyleBackColor = true;
            // 
            // majTousLesAvancements_button
            // 
            this.majTousLesAvancements_button.Location = new System.Drawing.Point(527, 12);
            this.majTousLesAvancements_button.Name = "majTousLesAvancements_button";
            this.majTousLesAvancements_button.Size = new System.Drawing.Size(183, 46);
            this.majTousLesAvancements_button.TabIndex = 95;
            this.majTousLesAvancements_button.Text = "MAJ tous les avancements";
            this.majTousLesAvancements_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "nombre d\'heures ratées:";
            // 
            // nbHeuresRates_numericUpDown
            // 
            this.nbHeuresRates_numericUpDown.DecimalPlaces = 1;
            this.nbHeuresRates_numericUpDown.Increment = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nbHeuresRates_numericUpDown.Location = new System.Drawing.Point(166, 30);
            this.nbHeuresRates_numericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nbHeuresRates_numericUpDown.Name = "nbHeuresRates_numericUpDown";
            this.nbHeuresRates_numericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nbHeuresRates_numericUpDown.TabIndex = 96;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nbHeuresRates_button);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.nbHeuresRates_numericUpDown);
            this.groupBox4.Location = new System.Drawing.Point(512, 127);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 69);
            this.groupBox4.TabIndex = 95;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateDebut_dateTimePicker);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.appliquerDateDebut_button);
            this.groupBox5.Location = new System.Drawing.Point(12, 197);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(494, 58);
            this.groupBox5.TabIndex = 97;
            this.groupBox5.TabStop = false;
            // 
            // dateDebut_dateTimePicker
            // 
            this.dateDebut_dateTimePicker.Location = new System.Drawing.Point(73, 19);
            this.dateDebut_dateTimePicker.Name = "dateDebut_dateTimePicker";
            this.dateDebut_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDebut_dateTimePicker.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 92;
            this.label4.Text = "date debut:";
            // 
            // appliquerDateDebut_button
            // 
            this.appliquerDateDebut_button.Location = new System.Drawing.Point(298, 13);
            this.appliquerDateDebut_button.Name = "appliquerDateDebut_button";
            this.appliquerDateDebut_button.Size = new System.Drawing.Size(183, 31);
            this.appliquerDateDebut_button.TabIndex = 93;
            this.appliquerDateDebut_button.Text = "Appliquer";
            this.appliquerDateDebut_button.UseVisualStyleBackColor = true;
            // 
            // nbHeuresRates_button
            // 
            this.nbHeuresRates_button.Location = new System.Drawing.Point(312, 23);
            this.nbHeuresRates_button.Name = "nbHeuresRates_button";
            this.nbHeuresRates_button.Size = new System.Drawing.Size(183, 31);
            this.nbHeuresRates_button.TabIndex = 98;
            this.nbHeuresRates_button.Text = "Appliquer";
            this.nbHeuresRates_button.UseVisualStyleBackColor = true;
            this.nbHeuresRates_button.Click += new System.EventHandler(this.NbHeuresRates_button_Click);
            // 
            // Gestion_des_seances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 655);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.majTousLesAvancements_button);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.majAvancementSelectionne_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.seances_dataGridView);
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
            ((System.ComponentModel.ISupportInitialize)(this.nbHeuresRates_numericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.Button majTousLesAvancements_button;
        private System.Windows.Forms.Button majAvancementSelectionne_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbHeuresRates_numericUpDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateDebut_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button appliquerDateDebut_button;
        private System.Windows.Forms.Button nbHeuresRates_button;
    }
}