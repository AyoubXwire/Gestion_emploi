namespace Gestion_emploi
{
    partial class Gestion_des_filieres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_filieres));
            this.filieres_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.secteur_comboBox = new System.Windows.Forms.ComboBox();
            this.nom_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.modifier_button = new System.Windows.Forms.Button();
            this.ajouter_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.filieres_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filieres_dataGridView
            // 
            this.filieres_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filieres_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filieres_dataGridView.Location = new System.Drawing.Point(378, 63);
            this.filieres_dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.filieres_dataGridView.MultiSelect = false;
            this.filieres_dataGridView.Name = "filieres_dataGridView";
            this.filieres_dataGridView.ReadOnly = true;
            this.filieres_dataGridView.RowTemplate.Height = 24;
            this.filieres_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.filieres_dataGridView.Size = new System.Drawing.Size(405, 249);
            this.filieres_dataGridView.TabIndex = 39;
            this.filieres_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Filieres_dataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Secteur:";
            // 
            // secteur_comboBox
            // 
            this.secteur_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secteur_comboBox.FormattingEnabled = true;
            this.secteur_comboBox.Location = new System.Drawing.Point(95, 86);
            this.secteur_comboBox.Margin = new System.Windows.Forms.Padding(2);
            this.secteur_comboBox.Name = "secteur_comboBox";
            this.secteur_comboBox.Size = new System.Drawing.Size(180, 21);
            this.secteur_comboBox.TabIndex = 41;
            this.secteur_comboBox.SelectedIndexChanged += new System.EventHandler(this.Secteur_comboBox_SelectedIndexChanged);
            // 
            // nom_textBox
            // 
            this.nom_textBox.Location = new System.Drawing.Point(95, 153);
            this.nom_textBox.Name = "nom_textBox";
            this.nom_textBox.Size = new System.Drawing.Size(180, 20);
            this.nom_textBox.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nom:";
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(225, 240);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(72, 42);
            this.supprimer_button.TabIndex = 46;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.Location = new System.Drawing.Point(147, 240);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(72, 42);
            this.modifier_button.TabIndex = 45;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.Modifier_button_Click);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(69, 240);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(72, 42);
            this.ajouter_button.TabIndex = 44;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // Gestion_des_filieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 312);
            this.Controls.Add(this.nom_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secteur_comboBox);
            this.Controls.Add(this.filieres_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_des_filieres";
            this.Text = "Gestion_des_filieres";
            this.Load += new System.EventHandler(this.Gestion_des_filieres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filieres_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filieres_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox secteur_comboBox;
        private System.Windows.Forms.TextBox nom_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button ajouter_button;
    }
}