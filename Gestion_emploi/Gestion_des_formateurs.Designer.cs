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
            this.vider_button = new System.Windows.Forms.Button();
            this.formateurs_dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metier_label = new System.Windows.Forms.Label();
            this.prenom_label = new System.Windows.Forms.Label();
            this.nom_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metier_comboBox = new System.Windows.Forms.ComboBox();
            this.prenom_textBox = new System.Windows.Forms.TextBox();
            this.nom_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.formateurs_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(251, 330);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(72, 42);
            this.supprimer_button.TabIndex = 22;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.Location = new System.Drawing.Point(173, 330);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(72, 42);
            this.modifier_button.TabIndex = 21;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.Modifier_button_Click);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(95, 330);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(72, 42);
            this.ajouter_button.TabIndex = 20;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // vider_button
            // 
            this.vider_button.Location = new System.Drawing.Point(17, 330);
            this.vider_button.Name = "vider_button";
            this.vider_button.Size = new System.Drawing.Size(72, 42);
            this.vider_button.TabIndex = 19;
            this.vider_button.Text = "Vider";
            this.vider_button.UseVisualStyleBackColor = true;
            this.vider_button.Click += new System.EventHandler(this.Nouveau_button_Click);
            // 
            // formateurs_dataGridView
            // 
            this.formateurs_dataGridView.AllowUserToAddRows = false;
            this.formateurs_dataGridView.AllowUserToDeleteRows = false;
            this.formateurs_dataGridView.AllowUserToResizeColumns = false;
            this.formateurs_dataGridView.AllowUserToResizeRows = false;
            this.formateurs_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.formateurs_dataGridView.CausesValidation = false;
            this.formateurs_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.formateurs_dataGridView.Location = new System.Drawing.Point(357, 61);
            this.formateurs_dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.formateurs_dataGridView.MultiSelect = false;
            this.formateurs_dataGridView.Name = "formateurs_dataGridView";
            this.formateurs_dataGridView.ReadOnly = true;
            this.formateurs_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.formateurs_dataGridView.Size = new System.Drawing.Size(456, 323);
            this.formateurs_dataGridView.TabIndex = 12;
            this.formateurs_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Formateurs_dataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metier_label);
            this.groupBox1.Controls.Add(this.prenom_label);
            this.groupBox1.Controls.Add(this.nom_label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(306, 103);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formateur selectionné";
            // 
            // metier_label
            // 
            this.metier_label.AutoSize = true;
            this.metier_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metier_label.Location = new System.Drawing.Point(85, 74);
            this.metier_label.Name = "metier_label";
            this.metier_label.Size = new System.Drawing.Size(0, 13);
            this.metier_label.TabIndex = 29;
            // 
            // prenom_label
            // 
            this.prenom_label.AutoSize = true;
            this.prenom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom_label.Location = new System.Drawing.Point(85, 50);
            this.prenom_label.Name = "prenom_label";
            this.prenom_label.Size = new System.Drawing.Size(0, 13);
            this.prenom_label.TabIndex = 28;
            // 
            // nom_label
            // 
            this.nom_label.AutoSize = true;
            this.nom_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom_label.Location = new System.Drawing.Point(85, 25);
            this.nom_label.Name = "nom_label";
            this.nom_label.Size = new System.Drawing.Size(0, 13);
            this.nom_label.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Metier:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Prenom:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Nom:";
            // 
            // metier_comboBox
            // 
            this.metier_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metier_comboBox.FormattingEnabled = true;
            this.metier_comboBox.Location = new System.Drawing.Point(109, 268);
            this.metier_comboBox.Name = "metier_comboBox";
            this.metier_comboBox.Size = new System.Drawing.Size(180, 21);
            this.metier_comboBox.TabIndex = 29;
            // 
            // prenom_textBox
            // 
            this.prenom_textBox.Location = new System.Drawing.Point(109, 244);
            this.prenom_textBox.Name = "prenom_textBox";
            this.prenom_textBox.Size = new System.Drawing.Size(180, 20);
            this.prenom_textBox.TabIndex = 28;
            // 
            // nom_textBox
            // 
            this.nom_textBox.Location = new System.Drawing.Point(109, 219);
            this.nom_textBox.Name = "nom_textBox";
            this.nom_textBox.Size = new System.Drawing.Size(180, 20);
            this.nom_textBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Metier:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Prenom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nom:";
            // 
            // Gestion_des_formateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 384);
            this.Controls.Add(this.metier_comboBox);
            this.Controls.Add(this.prenom_textBox);
            this.Controls.Add(this.nom_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.vider_button);
            this.Controls.Add(this.formateurs_dataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Gestion_des_formateurs";
            this.Text = "Gestion_des_formateurs";
            this.Load += new System.EventHandler(this.Gestion_des_formateurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formateurs_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.Button vider_button;
        private System.Windows.Forms.DataGridView formateurs_dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label metier_label;
        private System.Windows.Forms.Label prenom_label;
        private System.Windows.Forms.Label nom_label;
        private System.Windows.Forms.ComboBox metier_comboBox;
        private System.Windows.Forms.TextBox prenom_textBox;
        private System.Windows.Forms.TextBox nom_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}