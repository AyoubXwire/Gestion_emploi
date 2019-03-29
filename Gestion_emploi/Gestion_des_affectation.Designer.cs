namespace Gestion_emploi
{
    partial class Gestion_des_affectation
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
            this.affecter_button = new System.Windows.Forms.Button();
            this.module_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formateur_listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filiere_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.niveau_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.choisir_button = new System.Windows.Forms.Button();
            this.groupe_listBox = new System.Windows.Forms.ListBox();
            this.affectations_dataGridView = new System.Windows.Forms.DataGridView();
            this.formateurs_listBox = new System.Windows.Forms.ListBox();
            this.nbrHeures_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupes_listBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filtre_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // affecter_button
            // 
            this.affecter_button.Location = new System.Drawing.Point(17, 248);
            this.affecter_button.Margin = new System.Windows.Forms.Padding(2);
            this.affecter_button.Name = "affecter_button";
            this.affecter_button.Size = new System.Drawing.Size(86, 48);
            this.affecter_button.TabIndex = 65;
            this.affecter_button.Text = "Affecter";
            this.affecter_button.UseVisualStyleBackColor = true;
            this.affecter_button.Click += new System.EventHandler(this.Affecter_button_Click);
            // 
            // module_listBox
            // 
            this.module_listBox.FormattingEnabled = true;
            this.module_listBox.Location = new System.Drawing.Point(176, 73);
            this.module_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.module_listBox.Name = "module_listBox";
            this.module_listBox.Size = new System.Drawing.Size(250, 160);
            this.module_listBox.TabIndex = 63;
            this.module_listBox.SelectedIndexChanged += new System.EventHandler(this.Module_listBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Module:";
            // 
            // formateur_listBox
            // 
            this.formateur_listBox.FormattingEnabled = true;
            this.formateur_listBox.Location = new System.Drawing.Point(434, 73);
            this.formateur_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.formateur_listBox.Name = "formateur_listBox";
            this.formateur_listBox.Size = new System.Drawing.Size(151, 160);
            this.formateur_listBox.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Groupe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Formateur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Filiere:";
            // 
            // filiere_comboBox
            // 
            this.filiere_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere_comboBox.FormattingEnabled = true;
            this.filiere_comboBox.Location = new System.Drawing.Point(51, 10);
            this.filiere_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.filiere_comboBox.Name = "filiere_comboBox";
            this.filiere_comboBox.Size = new System.Drawing.Size(138, 21);
            this.filiere_comboBox.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 67;
            this.label5.Text = "niveau:";
            // 
            // niveau_numericUpDown
            // 
            this.niveau_numericUpDown.Location = new System.Drawing.Point(260, 11);
            this.niveau_numericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.niveau_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.niveau_numericUpDown.Name = "niveau_numericUpDown";
            this.niveau_numericUpDown.ReadOnly = true;
            this.niveau_numericUpDown.Size = new System.Drawing.Size(104, 20);
            this.niveau_numericUpDown.TabIndex = 68;
            this.niveau_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // choisir_button
            // 
            this.choisir_button.Location = new System.Drawing.Point(388, 6);
            this.choisir_button.Margin = new System.Windows.Forms.Padding(2);
            this.choisir_button.Name = "choisir_button";
            this.choisir_button.Size = new System.Drawing.Size(47, 26);
            this.choisir_button.TabIndex = 69;
            this.choisir_button.Text = "Choisir";
            this.choisir_button.UseVisualStyleBackColor = true;
            this.choisir_button.Click += new System.EventHandler(this.Choisir_button_Click);
            // 
            // groupe_listBox
            // 
            this.groupe_listBox.FormattingEnabled = true;
            this.groupe_listBox.Location = new System.Drawing.Point(17, 73);
            this.groupe_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupe_listBox.Name = "groupe_listBox";
            this.groupe_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.groupe_listBox.Size = new System.Drawing.Size(151, 160);
            this.groupe_listBox.TabIndex = 70;
            this.groupe_listBox.SelectedIndexChanged += new System.EventHandler(this.Groupe_listBox_SelectedIndexChanged);
            // 
            // affectations_dataGridView
            // 
            this.affectations_dataGridView.AllowUserToAddRows = false;
            this.affectations_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.affectations_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.affectations_dataGridView.Location = new System.Drawing.Point(233, 22);
            this.affectations_dataGridView.Name = "affectations_dataGridView";
            this.affectations_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.affectations_dataGridView.ShowCellErrors = false;
            this.affectations_dataGridView.ShowRowErrors = false;
            this.affectations_dataGridView.Size = new System.Drawing.Size(328, 292);
            this.affectations_dataGridView.TabIndex = 71;
            // 
            // formateurs_listBox
            // 
            this.formateurs_listBox.FormattingEnabled = true;
            this.formateurs_listBox.Location = new System.Drawing.Point(74, 45);
            this.formateurs_listBox.Name = "formateurs_listBox";
            this.formateurs_listBox.Size = new System.Drawing.Size(153, 121);
            this.formateurs_listBox.TabIndex = 72;
            this.formateurs_listBox.SelectedIndexChanged += new System.EventHandler(this.Formateurs_listBox_SelectedIndexChanged);
            // 
            // nbrHeures_textBox
            // 
            this.nbrHeures_textBox.Enabled = false;
            this.nbrHeures_textBox.Location = new System.Drawing.Point(102, 19);
            this.nbrHeures_textBox.Name = "nbrHeures_textBox";
            this.nbrHeures_textBox.Size = new System.Drawing.Size(125, 20);
            this.nbrHeures_textBox.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Nombre d\'heures:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 76;
            this.label8.Text = "Formateurs:";
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(107, 248);
            this.supprimer_button.Margin = new System.Windows.Forms.Padding(2);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(86, 48);
            this.supprimer_button.TabIndex = 77;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "Groupes:";
            // 
            // groupes_listBox
            // 
            this.groupes_listBox.FormattingEnabled = true;
            this.groupes_listBox.Location = new System.Drawing.Point(74, 180);
            this.groupes_listBox.Name = "groupes_listBox";
            this.groupes_listBox.Size = new System.Drawing.Size(153, 134);
            this.groupes_listBox.TabIndex = 78;
            this.groupes_listBox.SelectedIndexChanged += new System.EventHandler(this.Groupes_listBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nbrHeures_textBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.affectations_dataGridView);
            this.groupBox1.Controls.Add(this.groupes_listBox);
            this.groupBox1.Controls.Add(this.formateurs_listBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(17, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 318);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations";
            // 
            // filtre_checkBox
            // 
            this.filtre_checkBox.AutoSize = true;
            this.filtre_checkBox.Checked = true;
            this.filtre_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.filtre_checkBox.Location = new System.Drawing.Point(531, 56);
            this.filtre_checkBox.Name = "filtre_checkBox";
            this.filtre_checkBox.Size = new System.Drawing.Size(53, 17);
            this.filtre_checkBox.TabIndex = 81;
            this.filtre_checkBox.Text = "Filtres";
            this.filtre_checkBox.UseVisualStyleBackColor = true;
            this.filtre_checkBox.CheckedChanged += new System.EventHandler(this.Filtre_checkBox_CheckedChanged);
            // 
            // Gestion_des_affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 629);
            this.Controls.Add(this.filtre_checkBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.groupe_listBox);
            this.Controls.Add(this.choisir_button);
            this.Controls.Add(this.niveau_numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.affecter_button);
            this.Controls.Add(this.module_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formateur_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filiere_comboBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_des_affectation";
            this.Text = "Affectation";
            this.Load += new System.EventHandler(this.Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button affecter_button;
        private System.Windows.Forms.ListBox module_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox formateur_listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filiere_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown niveau_numericUpDown;
        private System.Windows.Forms.Button choisir_button;
        private System.Windows.Forms.ListBox groupe_listBox;
        private System.Windows.Forms.DataGridView affectations_dataGridView;
        private System.Windows.Forms.ListBox formateurs_listBox;
        private System.Windows.Forms.TextBox nbrHeures_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox groupes_listBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox filtre_checkBox;
    }
}