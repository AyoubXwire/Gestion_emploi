namespace Gestion_emploi
{
    partial class Gestion_des_modules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_modules));
            this.module_dataGridView = new System.Windows.Forms.DataGridView();
            this.niveau_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mass_horaire_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.modifier_button = new System.Windows.Forms.Button();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.nouveau_button = new System.Windows.Forms.Button();
            this.metier_comboBox = new System.Windows.Forms.ComboBox();
            this.nom_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.filiere_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.module_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_horaire_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // module_dataGridView
            // 
            this.module_dataGridView.AllowUserToAddRows = false;
            this.module_dataGridView.AllowUserToDeleteRows = false;
            this.module_dataGridView.AllowUserToResizeColumns = false;
            this.module_dataGridView.AllowUserToResizeRows = false;
            this.module_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.module_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.module_dataGridView.Location = new System.Drawing.Point(499, 63);
            this.module_dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.module_dataGridView.MultiSelect = false;
            this.module_dataGridView.Name = "module_dataGridView";
            this.module_dataGridView.ReadOnly = true;
            this.module_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.module_dataGridView.Size = new System.Drawing.Size(429, 313);
            this.module_dataGridView.TabIndex = 2;
            this.module_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Module_dataGridView_CellClick);
            // 
            // niveau_numericUpDown
            // 
            this.niveau_numericUpDown.Location = new System.Drawing.Point(145, 211);
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
            this.niveau_numericUpDown.Size = new System.Drawing.Size(200, 20);
            this.niveau_numericUpDown.TabIndex = 37;
            this.niveau_numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mass_horaire_numericUpDown
            // 
            this.mass_horaire_numericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.mass_horaire_numericUpDown.Location = new System.Drawing.Point(145, 257);
            this.mass_horaire_numericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.mass_horaire_numericUpDown.Name = "mass_horaire_numericUpDown";
            this.mass_horaire_numericUpDown.Size = new System.Drawing.Size(200, 20);
            this.mass_horaire_numericUpDown.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mass horaire: ";
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(314, 316);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(89, 42);
            this.supprimer_button.TabIndex = 34;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.Location = new System.Drawing.Point(216, 316);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(89, 42);
            this.modifier_button.TabIndex = 33;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.Modifier_button_Click);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(116, 316);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(89, 42);
            this.ajouter_button.TabIndex = 32;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // nouveau_button
            // 
            this.nouveau_button.Location = new System.Drawing.Point(20, 316);
            this.nouveau_button.Name = "nouveau_button";
            this.nouveau_button.Size = new System.Drawing.Size(89, 42);
            this.nouveau_button.TabIndex = 31;
            this.nouveau_button.Text = "Nouveau";
            this.nouveau_button.UseVisualStyleBackColor = true;
            this.nouveau_button.Click += new System.EventHandler(this.Nouveau_button_Click);
            // 
            // metier_comboBox
            // 
            this.metier_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metier_comboBox.FormattingEnabled = true;
            this.metier_comboBox.Location = new System.Drawing.Point(145, 124);
            this.metier_comboBox.Name = "metier_comboBox";
            this.metier_comboBox.Size = new System.Drawing.Size(200, 21);
            this.metier_comboBox.TabIndex = 30;
            // 
            // nom_textBox
            // 
            this.nom_textBox.Location = new System.Drawing.Point(145, 167);
            this.nom_textBox.Name = "nom_textBox";
            this.nom_textBox.Size = new System.Drawing.Size(200, 20);
            this.nom_textBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Metier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Niveau: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nom:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Filiere:";
            // 
            // filiere_comboBox
            // 
            this.filiere_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filiere_comboBox.FormattingEnabled = true;
            this.filiere_comboBox.Location = new System.Drawing.Point(145, 81);
            this.filiere_comboBox.Name = "filiere_comboBox";
            this.filiere_comboBox.Size = new System.Drawing.Size(200, 21);
            this.filiere_comboBox.TabIndex = 40;
            // 
            // Gestion_des_modules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 376);
            this.Controls.Add(this.filiere_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.niveau_numericUpDown);
            this.Controls.Add(this.mass_horaire_numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.nouveau_button);
            this.Controls.Add(this.metier_comboBox);
            this.Controls.Add(this.nom_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.module_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_des_modules";
            this.Text = "Gestion_des_modules";
            this.Load += new System.EventHandler(this.Gestion_des_modules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.module_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niveau_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_horaire_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView module_dataGridView;
        private System.Windows.Forms.NumericUpDown niveau_numericUpDown;
        private System.Windows.Forms.NumericUpDown mass_horaire_numericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button nouveau_button;
        private System.Windows.Forms.ComboBox metier_comboBox;
        private System.Windows.Forms.TextBox nom_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox filiere_comboBox;
    }
}