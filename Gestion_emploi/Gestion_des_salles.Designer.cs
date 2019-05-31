namespace Gestion_emploi
{
    partial class Gestion_des_salles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_salles));
            this.type_comboBox = new System.Windows.Forms.ComboBox();
            this.nom_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.modifier_button = new System.Windows.Forms.Button();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.salles_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salles_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // type_comboBox
            // 
            this.type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_comboBox.FormattingEnabled = true;
            this.type_comboBox.Location = new System.Drawing.Point(106, 109);
            this.type_comboBox.Name = "type_comboBox";
            this.type_comboBox.Size = new System.Drawing.Size(180, 21);
            this.type_comboBox.TabIndex = 40;
            // 
            // nom_textBox
            // 
            this.nom_textBox.Location = new System.Drawing.Point(106, 69);
            this.nom_textBox.Name = "nom_textBox";
            this.nom_textBox.Size = new System.Drawing.Size(180, 20);
            this.nom_textBox.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nom:";
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(208, 160);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(72, 42);
            this.supprimer_button.TabIndex = 34;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.Location = new System.Drawing.Point(130, 160);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(72, 42);
            this.modifier_button.TabIndex = 33;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.Modifier_button_Click);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(52, 160);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(72, 42);
            this.ajouter_button.TabIndex = 32;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // salles_dataGridView
            // 
            this.salles_dataGridView.AllowUserToAddRows = false;
            this.salles_dataGridView.AllowUserToDeleteRows = false;
            this.salles_dataGridView.AllowUserToResizeColumns = false;
            this.salles_dataGridView.AllowUserToResizeRows = false;
            this.salles_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salles_dataGridView.Location = new System.Drawing.Point(344, 61);
            this.salles_dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.salles_dataGridView.MultiSelect = false;
            this.salles_dataGridView.Name = "salles_dataGridView";
            this.salles_dataGridView.ReadOnly = true;
            this.salles_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salles_dataGridView.Size = new System.Drawing.Size(456, 157);
            this.salles_dataGridView.TabIndex = 30;
            this.salles_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Salles_dataGridView_CellClick);
            // 
            // Gestion_des_salles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 218);
            this.Controls.Add(this.type_comboBox);
            this.Controls.Add(this.nom_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.salles_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_des_salles";
            this.Text = "Gestion_des_salles";
            this.Load += new System.EventHandler(this.Gestion_des_salles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salles_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox type_comboBox;
        private System.Windows.Forms.TextBox nom_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.DataGridView salles_dataGridView;
    }
}