﻿namespace Gestion_emploi
{
    partial class Emploi_du_temps
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupe_comboBox = new System.Windows.Forms.ComboBox();
            this.emploi_dataGridView = new System.Windows.Forms.DataGridView();
            this.Jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.affectations_dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.salles_listBox = new System.Windows.Forms.ListBox();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.exporter_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.formateur_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.salle_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emploi_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Groupe:";
            // 
            // groupe_comboBox
            // 
            this.groupe_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupe_comboBox.FormattingEnabled = true;
            this.groupe_comboBox.Location = new System.Drawing.Point(67, 70);
            this.groupe_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupe_comboBox.Name = "groupe_comboBox";
            this.groupe_comboBox.Size = new System.Drawing.Size(138, 21);
            this.groupe_comboBox.TabIndex = 58;
            this.groupe_comboBox.SelectedIndexChanged += new System.EventHandler(this.Groupe_comboBox_SelectedIndexChanged);
            // 
            // emploi_dataGridView
            // 
            this.emploi_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.emploi_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emploi_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jour,
            this.Seance1,
            this.Seance2,
            this.Seance3,
            this.Seance4});
            this.emploi_dataGridView.Location = new System.Drawing.Point(511, 150);
            this.emploi_dataGridView.MultiSelect = false;
            this.emploi_dataGridView.Name = "emploi_dataGridView";
            this.emploi_dataGridView.ReadOnly = true;
            this.emploi_dataGridView.Size = new System.Drawing.Size(644, 382);
            this.emploi_dataGridView.TabIndex = 60;
            this.emploi_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Emploi_dataGridView_CellClick);
            // 
            // Jour
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Jour.DefaultCellStyle = dataGridViewCellStyle2;
            this.Jour.HeaderText = "jour";
            this.Jour.Name = "Jour";
            this.Jour.ReadOnly = true;
            this.Jour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Seance1
            // 
            this.Seance1.HeaderText = "seance1";
            this.Seance1.Name = "Seance1";
            this.Seance1.ReadOnly = true;
            this.Seance1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Seance2
            // 
            this.Seance2.HeaderText = "seance2";
            this.Seance2.Name = "Seance2";
            this.Seance2.ReadOnly = true;
            this.Seance2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Seance3
            // 
            this.Seance3.HeaderText = "seance3";
            this.Seance3.Name = "Seance3";
            this.Seance3.ReadOnly = true;
            this.Seance3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Seance4
            // 
            this.Seance4.HeaderText = "seance4";
            this.Seance4.Name = "Seance4";
            this.Seance4.ReadOnly = true;
            this.Seance4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Seances:";
            // 
            // affectations_dataGridView
            // 
            this.affectations_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.affectations_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.affectations_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.groupe,
            this.module,
            this.formateur,
            this.date_debut,
            this.date_fin});
            this.affectations_dataGridView.Location = new System.Drawing.Point(12, 150);
            this.affectations_dataGridView.MultiSelect = false;
            this.affectations_dataGridView.Name = "affectations_dataGridView";
            this.affectations_dataGridView.ReadOnly = true;
            this.affectations_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.affectations_dataGridView.Size = new System.Drawing.Size(494, 382);
            this.affectations_dataGridView.TabIndex = 63;
            this.affectations_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Affectations_dataGridView_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // groupe
            // 
            this.groupe.HeaderText = "groupe";
            this.groupe.Name = "groupe";
            this.groupe.ReadOnly = true;
            // 
            // module
            // 
            this.module.HeaderText = "module";
            this.module.Name = "module";
            this.module.ReadOnly = true;
            // 
            // formateur
            // 
            this.formateur.HeaderText = "formateur";
            this.formateur.Name = "formateur";
            this.formateur.ReadOnly = true;
            // 
            // date_debut
            // 
            this.date_debut.HeaderText = "date_debut";
            this.date_debut.Name = "date_debut";
            this.date_debut.ReadOnly = true;
            // 
            // date_fin
            // 
            this.date_fin.HeaderText = "date_fin";
            this.date_fin.Name = "date_fin";
            this.date_fin.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Emploi:";
            // 
            // salles_listBox
            // 
            this.salles_listBox.FormattingEnabled = true;
            this.salles_listBox.Location = new System.Drawing.Point(14, 569);
            this.salles_listBox.Name = "salles_listBox";
            this.salles_listBox.Size = new System.Drawing.Size(191, 173);
            this.salles_listBox.TabIndex = 65;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(511, 608);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(121, 78);
            this.ajouter_button.TabIndex = 71;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(638, 608);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(121, 78);
            this.supprimer_button.TabIndex = 72;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(765, 608);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(121, 78);
            this.reset_button.TabIndex = 73;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // exporter_button
            // 
            this.exporter_button.Location = new System.Drawing.Point(1021, 608);
            this.exporter_button.Name = "exporter_button";
            this.exporter_button.Size = new System.Drawing.Size(121, 78);
            this.exporter_button.TabIndex = 74;
            this.exporter_button.Text = "Exporter";
            this.exporter_button.UseVisualStyleBackColor = true;
            this.exporter_button.Click += new System.EventHandler(this.Exporter_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 538);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 75;
            this.checkBox1.Text = "Tous";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // formateur_comboBox
            // 
            this.formateur_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formateur_comboBox.FormattingEnabled = true;
            this.formateur_comboBox.Location = new System.Drawing.Point(334, 70);
            this.formateur_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.formateur_comboBox.Name = "formateur_comboBox";
            this.formateur_comboBox.Size = new System.Drawing.Size(138, 21);
            this.formateur_comboBox.TabIndex = 76;
            this.formateur_comboBox.SelectedIndexChanged += new System.EventHandler(this.Formateur_comboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Formateur:";
            // 
            // salle_button
            // 
            this.salle_button.Location = new System.Drawing.Point(1021, 73);
            this.salle_button.Name = "salle_button";
            this.salle_button.Size = new System.Drawing.Size(121, 47);
            this.salle_button.TabIndex = 78;
            this.salle_button.Text = "Disponibilié des salles";
            this.salle_button.UseVisualStyleBackColor = true;
            this.salle_button.Click += new System.EventHandler(this.Salle_button_Click);
            // 
            // Emploi_du_temps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 782);
            this.Controls.Add(this.salle_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formateur_comboBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.exporter_button);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.salles_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.affectations_dataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emploi_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupe_comboBox);
            this.Name = "Emploi_du_temps";
            this.Text = "Emploi_du_temps";
            this.Load += new System.EventHandler(this.Emploi_du_temps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploi_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupe_comboBox;
        private System.Windows.Forms.DataGridView emploi_dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView affectations_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn module;
        private System.Windows.Forms.DataGridViewTextBoxColumn formateur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox salles_listBox;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance4;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_fin;
        private System.Windows.Forms.Button exporter_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox formateur_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button salle_button;
    }
}