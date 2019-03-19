namespace Gestion_emploi
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
            this.groupe_listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filiere_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // affecter_button
            // 
            this.affecter_button.Location = new System.Drawing.Point(22, 283);
            this.affecter_button.Name = "affecter_button";
            this.affecter_button.Size = new System.Drawing.Size(100, 53);
            this.affecter_button.TabIndex = 65;
            this.affecter_button.Text = "Affecter";
            this.affecter_button.UseVisualStyleBackColor = true;
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
            this.affectations_dataGridView.Location = new System.Drawing.Point(0, 359);
            this.affectations_dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.affectations_dataGridView.MultiSelect = false;
            this.affectations_dataGridView.Name = "affectations_dataGridView";
            this.affectations_dataGridView.ReadOnly = true;
            this.affectations_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.affectations_dataGridView.Size = new System.Drawing.Size(800, 308);
            this.affectations_dataGridView.TabIndex = 64;
            // 
            // module_listBox
            // 
            this.module_listBox.FormattingEnabled = true;
            this.module_listBox.ItemHeight = 16;
            this.module_listBox.Location = new System.Drawing.Point(234, 71);
            this.module_listBox.Name = "module_listBox";
            this.module_listBox.Size = new System.Drawing.Size(332, 196);
            this.module_listBox.TabIndex = 63;
            this.module_listBox.SelectedIndexChanged += new System.EventHandler(this.Module_listBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Module:";
            // 
            // formateur_listBox
            // 
            this.formateur_listBox.FormattingEnabled = true;
            this.formateur_listBox.ItemHeight = 16;
            this.formateur_listBox.Location = new System.Drawing.Point(578, 71);
            this.formateur_listBox.Name = "formateur_listBox";
            this.formateur_listBox.Size = new System.Drawing.Size(200, 196);
            this.formateur_listBox.TabIndex = 61;
            // 
            // groupe_listBox
            // 
            this.groupe_listBox.FormattingEnabled = true;
            this.groupe_listBox.ItemHeight = 16;
            this.groupe_listBox.Location = new System.Drawing.Point(22, 71);
            this.groupe_listBox.Name = "groupe_listBox";
            this.groupe_listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.groupe_listBox.Size = new System.Drawing.Size(200, 196);
            this.groupe_listBox.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Groupe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(575, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 58;
            this.label2.Text = "Formateur:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 57;
            this.label1.Text = "Filiere:";
            // 
            // filiere_comboBox
            // 
            this.filiere_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere_comboBox.FormattingEnabled = true;
            this.filiere_comboBox.Location = new System.Drawing.Point(68, 6);
            this.filiere_comboBox.Name = "filiere_comboBox";
            this.filiere_comboBox.Size = new System.Drawing.Size(182, 24);
            this.filiere_comboBox.TabIndex = 56;
            this.filiere_comboBox.SelectedIndexChanged += new System.EventHandler(this.Filiere_comboBox_SelectedIndexChanged);
            // 
            // Affectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.affecter_button);
            this.Controls.Add(this.affectations_dataGridView);
            this.Controls.Add(this.module_listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.formateur_listBox);
            this.Controls.Add(this.groupe_listBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filiere_comboBox);
            this.Name = "Affectation";
            this.Text = "Affectation";
            this.Load += new System.EventHandler(this.Affectation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.affectations_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button affecter_button;
        private System.Windows.Forms.DataGridView affectations_dataGridView;
        private System.Windows.Forms.ListBox module_listBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox formateur_listBox;
        private System.Windows.Forms.ListBox groupe_listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filiere_comboBox;
    }
}