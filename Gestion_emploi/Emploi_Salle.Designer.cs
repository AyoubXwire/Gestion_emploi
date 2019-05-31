namespace Gestion_emploi
{
    partial class Emploi_Salle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emploi_Salle));
            this.emploi_dataGridView = new System.Windows.Forms.DataGridView();
            this.Jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupe_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.emploi_dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.emploi_dataGridView.Location = new System.Drawing.Point(261, 82);
            this.emploi_dataGridView.MultiSelect = false;
            this.emploi_dataGridView.Name = "emploi_dataGridView";
            this.emploi_dataGridView.ReadOnly = true;
            this.emploi_dataGridView.Size = new System.Drawing.Size(644, 382);
            this.emploi_dataGridView.TabIndex = 65;
            // 
            // Jour
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Jour.DefaultCellStyle = dataGridViewCellStyle1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Salle:";
            // 
            // groupe_comboBox
            // 
            this.groupe_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupe_comboBox.FormattingEnabled = true;
            this.groupe_comboBox.Location = new System.Drawing.Point(65, 82);
            this.groupe_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupe_comboBox.Name = "groupe_comboBox";
            this.groupe_comboBox.Size = new System.Drawing.Size(138, 21);
            this.groupe_comboBox.TabIndex = 63;
            this.groupe_comboBox.SelectedIndexChanged += new System.EventHandler(this.groupe_comboBox_SelectedIndexChanged);
            // 
            // Emploi_Salle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 496);
            this.Controls.Add(this.emploi_dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupe_comboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Emploi_Salle";
            this.Text = "Emploi_Salle";
            this.Load += new System.EventHandler(this.Emploi_Salle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploi_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView emploi_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupe_comboBox;
    }
}