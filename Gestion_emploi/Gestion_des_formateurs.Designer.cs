namespace Gestion_emploi
{
    partial class Gestion_des_formateurs
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
            this.supprimer_button = new System.Windows.Forms.Button();
            this.modifier_button = new System.Windows.Forms.Button();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.nouveau_button = new System.Windows.Forms.Button();
            this.metier_comboBox = new System.Windows.Forms.ComboBox();
            this.prenom_textBox = new System.Windows.Forms.TextBox();
            this.nom_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formateurs_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.formateurs_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(405, 204);
            this.supprimer_button.Margin = new System.Windows.Forms.Padding(4);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(119, 52);
            this.supprimer_button.TabIndex = 22;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.Location = new System.Drawing.Point(274, 204);
            this.modifier_button.Margin = new System.Windows.Forms.Padding(4);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(119, 52);
            this.modifier_button.TabIndex = 21;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.Modifier_button_Click);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(143, 204);
            this.ajouter_button.Margin = new System.Windows.Forms.Padding(4);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(119, 52);
            this.ajouter_button.TabIndex = 20;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // nouveau_button
            // 
            this.nouveau_button.Location = new System.Drawing.Point(13, 204);
            this.nouveau_button.Margin = new System.Windows.Forms.Padding(4);
            this.nouveau_button.Name = "nouveau_button";
            this.nouveau_button.Size = new System.Drawing.Size(119, 52);
            this.nouveau_button.TabIndex = 19;
            this.nouveau_button.Text = "Nouveau";
            this.nouveau_button.UseVisualStyleBackColor = true;
            this.nouveau_button.Click += new System.EventHandler(this.Nouveau_button_Click);
            // 
            // metier_comboBox
            // 
            this.metier_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metier_comboBox.FormattingEnabled = true;
            this.metier_comboBox.Location = new System.Drawing.Point(178, 23);
            this.metier_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.metier_comboBox.Name = "metier_comboBox";
            this.metier_comboBox.Size = new System.Drawing.Size(265, 24);
            this.metier_comboBox.TabIndex = 18;
            // 
            // prenom_textBox
            // 
            this.prenom_textBox.Location = new System.Drawing.Point(178, 127);
            this.prenom_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.prenom_textBox.Name = "prenom_textBox";
            this.prenom_textBox.Size = new System.Drawing.Size(265, 22);
            this.prenom_textBox.TabIndex = 17;
            // 
            // nom_textBox
            // 
            this.nom_textBox.Location = new System.Drawing.Point(178, 75);
            this.nom_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.nom_textBox.Name = "nom_textBox";
            this.nom_textBox.Size = new System.Drawing.Size(265, 22);
            this.nom_textBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Metier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prenom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nom:";
            // 
            // formateurs_dataGridView
            // 
            this.formateurs_dataGridView.AllowUserToAddRows = false;
            this.formateurs_dataGridView.AllowUserToDeleteRows = false;
            this.formateurs_dataGridView.AllowUserToResizeColumns = false;
            this.formateurs_dataGridView.AllowUserToResizeRows = false;
            this.formateurs_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.formateurs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formateurs_dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.formateurs_dataGridView.Location = new System.Drawing.Point(556, 0);
            this.formateurs_dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.formateurs_dataGridView.MultiSelect = false;
            this.formateurs_dataGridView.Name = "formateurs_dataGridView";
            this.formateurs_dataGridView.ReadOnly = true;
            this.formateurs_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formateurs_dataGridView.Size = new System.Drawing.Size(600, 470);
            this.formateurs_dataGridView.TabIndex = 12;
            this.formateurs_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Formateurs_dataGridView_CellClick);
            // 
            // Gestion_des_formateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 470);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.nouveau_button);
            this.Controls.Add(this.metier_comboBox);
            this.Controls.Add(this.prenom_textBox);
            this.Controls.Add(this.nom_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formateurs_dataGridView);
            this.Name = "Gestion_des_formateurs";
            this.Text = "Gestion_des_formateurs";
            this.Load += new System.EventHandler(this.Gestion_des_formateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formateurs_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button nouveau_button;
        private System.Windows.Forms.ComboBox metier_comboBox;
        private System.Windows.Forms.TextBox prenom_textBox;
        private System.Windows.Forms.TextBox nom_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView formateurs_dataGridView;
    }
}