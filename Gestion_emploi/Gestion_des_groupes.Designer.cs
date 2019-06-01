﻿namespace Gestion_emploi
{
    partial class Gestion_des_groupes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_groupes));
            this.groupes_dataGridView = new System.Windows.Forms.DataGridView();
            this.nombreDeGroupes_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confirmer_button = new System.Windows.Forms.Button();
            this.filiere_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.niveau_numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.groupes_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreDeGroupes_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupes_dataGridView
            // 
            this.groupes_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupes_dataGridView.Location = new System.Drawing.Point(377, 61);
            this.groupes_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.groupes_dataGridView.MultiSelect = false;
            this.groupes_dataGridView.Name = "groupes_dataGridView";
            this.groupes_dataGridView.ReadOnly = true;
            this.groupes_dataGridView.RowTemplate.Height = 24;
            this.groupes_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupes_dataGridView.Size = new System.Drawing.Size(339, 205);
            this.groupes_dataGridView.TabIndex = 38;
            this.groupes_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groupes_dataGridView_CellClick);
            // 
            // nombreDeGroupes_numericUpDown
            // 
            this.nombreDeGroupes_numericUpDown.Location = new System.Drawing.Point(136, 126);
            this.nombreDeGroupes_numericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nombreDeGroupes_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nombreDeGroupes_numericUpDown.Name = "nombreDeGroupes_numericUpDown";
            this.nombreDeGroupes_numericUpDown.ReadOnly = true;
            this.nombreDeGroupes_numericUpDown.Size = new System.Drawing.Size(194, 20);
            this.nombreDeGroupes_numericUpDown.TabIndex = 45;
            this.nombreDeGroupes_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // confirmer_button
            // 
            this.confirmer_button.Location = new System.Drawing.Point(12, 164);
            this.confirmer_button.Name = "confirmer_button";
            this.confirmer_button.Size = new System.Drawing.Size(100, 45);
            this.confirmer_button.TabIndex = 44;
            this.confirmer_button.Text = "Confirmer";
            this.confirmer_button.UseVisualStyleBackColor = true;
            this.confirmer_button.Click += new System.EventHandler(this.Valider_button_Click);
            // 
            // filiere_comboBox
            // 
            this.filiere_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere_comboBox.FormattingEnabled = true;
            this.filiere_comboBox.Location = new System.Drawing.Point(136, 76);
            this.filiere_comboBox.Name = "filiere_comboBox";
            this.filiere_comboBox.Size = new System.Drawing.Size(194, 21);
            this.filiere_comboBox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Filiere:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre de groupes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Niveau:";
            // 
            // niveau_numericUpDown
            // 
            this.niveau_numericUpDown.Location = new System.Drawing.Point(136, 102);
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
            this.niveau_numericUpDown.Size = new System.Drawing.Size(194, 20);
            this.niveau_numericUpDown.TabIndex = 39;
            this.niveau_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Gestion_des_groupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 266);
            this.Controls.Add(this.nombreDeGroupes_numericUpDown);
            this.Controls.Add(this.confirmer_button);
            this.Controls.Add(this.filiere_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.niveau_numericUpDown);
            this.Controls.Add(this.groupes_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_des_groupes";
            this.Text = "Gestion_des_groupes";
            this.Load += new System.EventHandler(this.Gestion_des_groupes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupes_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nombreDeGroupes_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView groupes_dataGridView;
        private System.Windows.Forms.NumericUpDown nombreDeGroupes_numericUpDown;
        private System.Windows.Forms.Button confirmer_button;
        private System.Windows.Forms.ComboBox filiere_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown niveau_numericUpDown;
    }
}