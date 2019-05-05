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
            this.label2 = new System.Windows.Forms.Label();
            this.affectations_dataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.emploi_dataGridView.Location = new System.Drawing.Point(12, 254);
            this.emploi_dataGridView.Name = "emploi_dataGridView";
            this.emploi_dataGridView.Size = new System.Drawing.Size(809, 184);
            this.emploi_dataGridView.TabIndex = 60;
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
            this.affectations_dataGridView.Name = "affectations_dataGridView";
            this.affectations_dataGridView.Size = new System.Drawing.Size(807, 171);
            this.affectations_dataGridView.TabIndex = 63;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // groupe
            // 
            this.groupe.HeaderText = "groupe";
            this.groupe.Name = "groupe";
            // 
            // module
            // 
            this.module.HeaderText = "module";
            this.module.Name = "module";
            // 
            // formateur
            // 
            this.formateur.HeaderText = "formateur";
            this.formateur.Name = "formateur";
            // 
            // Emploi_du_temps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
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
    }
}