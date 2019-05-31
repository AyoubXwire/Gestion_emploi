namespace Gestion_emploi
{
    partial class Gestion_des_metiers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion_des_metiers));
            this.nom_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.supprimer_button = new System.Windows.Forms.Button();
            this.modifier_button = new System.Windows.Forms.Button();
            this.ajouter_button = new System.Windows.Forms.Button();
            this.metiers_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.metiers_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nom_textBox
            // 
            this.nom_textBox.Location = new System.Drawing.Point(96, 82);
            this.nom_textBox.Name = "nom_textBox";
            this.nom_textBox.Size = new System.Drawing.Size(180, 20);
            this.nom_textBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nom:";
            // 
            // supprimer_button
            // 
            this.supprimer_button.Location = new System.Drawing.Point(204, 151);
            this.supprimer_button.Name = "supprimer_button";
            this.supprimer_button.Size = new System.Drawing.Size(72, 42);
            this.supprimer_button.TabIndex = 34;
            this.supprimer_button.Text = "Supprimer";
            this.supprimer_button.UseVisualStyleBackColor = true;
            this.supprimer_button.Click += new System.EventHandler(this.Supprimer_button_Click);
            // 
            // modifier_button
            // 
            this.modifier_button.Location = new System.Drawing.Point(126, 151);
            this.modifier_button.Name = "modifier_button";
            this.modifier_button.Size = new System.Drawing.Size(72, 42);
            this.modifier_button.TabIndex = 33;
            this.modifier_button.Text = "Modifier";
            this.modifier_button.UseVisualStyleBackColor = true;
            this.modifier_button.Click += new System.EventHandler(this.Modifier_button_Click);
            // 
            // ajouter_button
            // 
            this.ajouter_button.Location = new System.Drawing.Point(48, 151);
            this.ajouter_button.Name = "ajouter_button";
            this.ajouter_button.Size = new System.Drawing.Size(72, 42);
            this.ajouter_button.TabIndex = 32;
            this.ajouter_button.Text = "Ajouter";
            this.ajouter_button.UseVisualStyleBackColor = true;
            this.ajouter_button.Click += new System.EventHandler(this.Ajouter_button_Click);
            // 
            // metiers_dataGridView
            // 
            this.metiers_dataGridView.AllowUserToAddRows = false;
            this.metiers_dataGridView.AllowUserToDeleteRows = false;
            this.metiers_dataGridView.AllowUserToResizeColumns = false;
            this.metiers_dataGridView.AllowUserToResizeRows = false;
            this.metiers_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metiers_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metiers_dataGridView.Location = new System.Drawing.Point(344, 61);
            this.metiers_dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.metiers_dataGridView.MultiSelect = false;
            this.metiers_dataGridView.Name = "metiers_dataGridView";
            this.metiers_dataGridView.ReadOnly = true;
            this.metiers_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metiers_dataGridView.Size = new System.Drawing.Size(456, 144);
            this.metiers_dataGridView.TabIndex = 30;
            this.metiers_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Metiers_dataGridView_CellClick);
            // 
            // Gestion_des_metiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 205);
            this.Controls.Add(this.nom_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.supprimer_button);
            this.Controls.Add(this.modifier_button);
            this.Controls.Add(this.ajouter_button);
            this.Controls.Add(this.metiers_dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestion_des_metiers";
            this.Text = "Gestion_des_metiers";
            this.Load += new System.EventHandler(this.Gestion_des_metiers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metiers_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nom_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button supprimer_button;
        private System.Windows.Forms.Button modifier_button;
        private System.Windows.Forms.Button ajouter_button;
        private System.Windows.Forms.DataGridView metiers_dataGridView;
    }
}