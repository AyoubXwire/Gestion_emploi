﻿namespace Gestion_emploi
{
    partial class Affectation
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
            this.affectations_dataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // affecter_button
            // 
            this.affecter_button.Location = new System.Drawing.Point(16, 245);
            this.affecter_button.Margin = new System.Windows.Forms.Padding(2);
            this.affecter_button.Name = "affecter_button";
            this.affecter_button.Size = new System.Drawing.Size(75, 33);
            this.affecter_button.TabIndex = 65;
            this.affecter_button.Text = "Affecter";
            this.affecter_button.UseVisualStyleBackColor = true;
            this.affecter_button.Click += new System.EventHandler(this.Affecter_button_Click);
            // 
            // affectations_dataGridView
            // 
            this.affectations_dataGridView.AllowUserToAddRows = false;
            this.affectations_dataGridView.AllowUserToDeleteRows = false;
            this.affectations_dataGridView.AllowUserToResizeColumns = false;
            this.affectations_dataGridView.AllowUserToResizeRows = false;
            this.affectations_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.affectations_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.affectations_dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.affectations_dataGridView.Location = new System.Drawing.Point(0, 292);
            this.affectations_dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.affectations_dataGridView.MultiSelect = false;
            this.affectations_dataGridView.Name = "affectations_dataGridView";
            this.affectations_dataGridView.ReadOnly = true;
            this.affectations_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.affectations_dataGridView.Size = new System.Drawing.Size(600, 250);
            this.affectations_dataGridView.TabIndex = 64;
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
            // Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 542);
            this.Controls.Add(this.groupe_listBox);
            this.Controls.Add(this.choisir_button);
            this.Controls.Add(this.niveau_numericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.affecter_button);
            this.Controls.Add(this.affectations_dataGridView);
            this.Controls.Add(this.module_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formateur_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filiere_comboBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Affectation";
            this.Text = "Affectation";
            this.Load += new System.EventHandler(this.Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button affecter_button;
        private System.Windows.Forms.DataGridView affectations_dataGridView;
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
    }
}