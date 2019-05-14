namespace Gestion_emploi
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
            this.label3 = new System.Windows.Forms.Label();
            this.salles_listBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jours_listBox = new System.Windows.Forms.ListBox();
            this.seances_listBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.supprimer_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emploi_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
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
            this.groupe_comboBox.Location = new System.Drawing.Point(67, 11);
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
            this.emploi_dataGridView.Location = new System.Drawing.Point(437, 77);
            this.emploi_dataGridView.MultiSelect = false;
            this.emploi_dataGridView.Name = "emploi_dataGridView";
            this.emploi_dataGridView.ReadOnly = true;
            this.emploi_dataGridView.Size = new System.Drawing.Size(721, 447);
            this.emploi_dataGridView.TabIndex = 60;
            // 
            // Jour
            // 
            this.Jour.HeaderText = "jour";
            this.Jour.Name = "Jour";
            this.Jour.ReadOnly = true;
            // 
            // Seance1
            // 
            this.Seance1.HeaderText = "seance1";
            this.Seance1.Name = "Seance1";
            this.Seance1.ReadOnly = true;
            // 
            // Seance2
            // 
            this.Seance2.HeaderText = "seance2";
            this.Seance2.Name = "Seance2";
            this.Seance2.ReadOnly = true;
            // 
            // Seance3
            // 
            this.Seance3.HeaderText = "seance3";
            this.Seance3.Name = "Seance3";
            this.Seance3.ReadOnly = true;
            // 
            // Seance4
            // 
            this.Seance4.HeaderText = "seance4";
            this.Seance4.Name = "Seance4";
            this.Seance4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
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
            this.formateur});
            this.affectations_dataGridView.Location = new System.Drawing.Point(14, 77);
            this.affectations_dataGridView.MultiSelect = false;
            this.affectations_dataGridView.Name = "affectations_dataGridView";
            this.affectations_dataGridView.ReadOnly = true;
            this.affectations_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.affectations_dataGridView.Size = new System.Drawing.Size(406, 447);
            this.affectations_dataGridView.TabIndex = 63;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Emploi:";
            // 
            // salles_listBox
            // 
            this.salles_listBox.FormattingEnabled = true;
            this.salles_listBox.Location = new System.Drawing.Point(300, 564);
            this.salles_listBox.Name = "salles_listBox";
            this.salles_listBox.Size = new System.Drawing.Size(120, 186);
            this.salles_listBox.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 548);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Jour:";
            // 
            // jours_listBox
            // 
            this.jours_listBox.FormattingEnabled = true;
            this.jours_listBox.Location = new System.Drawing.Point(14, 564);
            this.jours_listBox.Name = "jours_listBox";
            this.jours_listBox.Size = new System.Drawing.Size(120, 186);
            this.jours_listBox.TabIndex = 67;
            // 
            // seances_listBox
            // 
            this.seances_listBox.FormattingEnabled = true;
            this.seances_listBox.Location = new System.Drawing.Point(156, 564);
            this.seances_listBox.Name = "seances_listBox";
            this.seances_listBox.Size = new System.Drawing.Size(120, 186);
            this.seances_listBox.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 548);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Seance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 548);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Salle:";
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(437, 564);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(91, 53);
            this.ajouter_button.TabIndex = 71;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(437, 623);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(91, 53);
            this.supprimer_button.TabIndex = 72;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // Emploi_du_temps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 762);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seances_listBox);
            this.Controls.Add(this.jours_listBox);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox jours_listBox;
        private System.Windows.Forms.ListBox seances_listBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance4;
        private System.Windows.Forms.Button supprimer_button;
    }
}