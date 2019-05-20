namespace Gestion_emploi
{
    partial class emplois_extract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.emploi_dataGridView = new System.Windows.Forms.DataGridView();
            this.Jour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seance4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.emploi_dataGridView.Location = new System.Drawing.Point(335, 12);
            this.emploi_dataGridView.MultiSelect = false;
            this.emploi_dataGridView.Name = "emploi_dataGridView";
            this.emploi_dataGridView.ReadOnly = true;
            this.emploi_dataGridView.Size = new System.Drawing.Size(643, 366);
            this.emploi_dataGridView.TabIndex = 61;
            // 
            // Jour
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Jour.DefaultCellStyle = dataGridViewCellStyle11;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 173);
            this.listBox1.TabIndex = 62;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(167, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(147, 173);
            this.listBox2.TabIndex = 63;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(984, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 54);
            this.button1.TabIndex = 64;
            this.button1.Text = "Extrait";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // emplois_extract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.emploi_dataGridView);
            this.Name = "emplois_extract";
            this.Text = "emplois_extract";
            this.Load += new System.EventHandler(this.emplois_extract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emploi_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView emploi_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seance4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
    }
}