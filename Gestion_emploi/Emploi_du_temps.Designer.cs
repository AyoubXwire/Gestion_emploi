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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ajouter_button = new System.Windows.Forms.Button();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
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
            this.emploi_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Emploi_dataGridView_CellClick);
            // 
            // Jour
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Jour.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.salles_listBox.Location = new System.Drawing.Point(14, 530);
            this.salles_listBox.Name = "salles_listBox";
            this.salles_listBox.Size = new System.Drawing.Size(406, 186);
            this.salles_listBox.TabIndex = 65;
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(437, 530);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(121, 78);
            this.ajouter_button.TabIndex = 71;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(564, 530);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(121, 78);
            this.supprimer_button.TabIndex = 72;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(691, 530);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(121, 78);
            this.reset_button.TabIndex = 73;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.Reset_button_Click);
            // 
            // Emploi_du_temps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 727);
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
    }
}