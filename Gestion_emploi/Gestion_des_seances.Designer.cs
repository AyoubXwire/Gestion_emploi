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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seances_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // seances_dataGridView
            // 
            this.seances_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seances_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seances_dataGridView.Location = new System.Drawing.Point(262, 195);
            this.seances_dataGridView.Name = "seances_dataGridView";
            this.seances_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seances_dataGridView.Size = new System.Drawing.Size(872, 364);
            this.seances_dataGridView.TabIndex = 0;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 179);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 380);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 179);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(681, 13);
            this.label1.TabIndex = 90;
            this.label1.Text = "Give the user a way to modify \"nombre de seances\" of any given affectation.. (he " +
    "can select and modify multiple affectations from datagridview)";
            // 
            // Gestion_des_seances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}