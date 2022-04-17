
namespace FaceReco
{
    partial class Form_ListStagiaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Save_Exite = new System.Windows.Forms.Button();
            this.dgv_stgr = new System.Windows.Forms.DataGridView();
            this.CEF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Stgr = new System.Windows.Forms.GroupBox();
            this.btn_Del_Stgr = new System.Windows.Forms.Button();
            this.btn_Edit_Stgr = new System.Windows.Forms.Button();
            this.btn_Add_Stgr = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_del_dup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stgr)).BeginInit();
            this.gb_Stgr.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save_Exite
            // 
            this.btn_Save_Exite.Location = new System.Drawing.Point(683, 448);
            this.btn_Save_Exite.Name = "btn_Save_Exite";
            this.btn_Save_Exite.Size = new System.Drawing.Size(78, 35);
            this.btn_Save_Exite.TabIndex = 1;
            this.btn_Save_Exite.Text = "Enregistrer et Quitter";
            this.btn_Save_Exite.UseVisualStyleBackColor = true;
            this.btn_Save_Exite.Click += new System.EventHandler(this.btn_Save_Exite_Click);
            // 
            // dgv_stgr
            // 
            this.dgv_stgr.AllowUserToAddRows = false;
            this.dgv_stgr.AllowUserToDeleteRows = false;
            this.dgv_stgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CEF,
            this.cin,
            this.nom,
            this.prenom,
            this.filiere,
            this.groupe,
            this.ville,
            this.adresse});
            this.dgv_stgr.Location = new System.Drawing.Point(12, 12);
            this.dgv_stgr.Name = "dgv_stgr";
            this.dgv_stgr.ReadOnly = true;
            this.dgv_stgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stgr.Size = new System.Drawing.Size(659, 482);
            this.dgv_stgr.TabIndex = 14;
            // 
            // CEF
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CEF.DefaultCellStyle = dataGridViewCellStyle9;
            this.CEF.HeaderText = "CEF";
            this.CEF.Name = "CEF";
            this.CEF.ReadOnly = true;
            // 
            // cin
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cin.DefaultCellStyle = dataGridViewCellStyle10;
            this.cin.HeaderText = "Cin";
            this.cin.Name = "cin";
            this.cin.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 200;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            this.prenom.Width = 200;
            // 
            // filiere
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.filiere.DefaultCellStyle = dataGridViewCellStyle11;
            this.filiere.HeaderText = "Filiere";
            this.filiere.Name = "filiere";
            this.filiere.ReadOnly = true;
            this.filiere.Width = 75;
            // 
            // groupe
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.groupe.DefaultCellStyle = dataGridViewCellStyle12;
            this.groupe.HeaderText = "Groupe";
            this.groupe.Name = "groupe";
            this.groupe.ReadOnly = true;
            this.groupe.Width = 75;
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            this.ville.ReadOnly = true;
            // 
            // adresse
            // 
            this.adresse.HeaderText = "Adresse";
            this.adresse.Name = "adresse";
            this.adresse.ReadOnly = true;
            // 
            // gb_Stgr
            // 
            this.gb_Stgr.Controls.Add(this.btn_Del_Stgr);
            this.gb_Stgr.Controls.Add(this.btn_Edit_Stgr);
            this.gb_Stgr.Controls.Add(this.btn_Add_Stgr);
            this.gb_Stgr.Location = new System.Drawing.Point(705, 26);
            this.gb_Stgr.Name = "gb_Stgr";
            this.gb_Stgr.Size = new System.Drawing.Size(108, 147);
            this.gb_Stgr.TabIndex = 0;
            this.gb_Stgr.TabStop = false;
            this.gb_Stgr.Text = "Stagiaire";
            // 
            // btn_Del_Stgr
            // 
            this.btn_Del_Stgr.Location = new System.Drawing.Point(6, 101);
            this.btn_Del_Stgr.Name = "btn_Del_Stgr";
            this.btn_Del_Stgr.Size = new System.Drawing.Size(96, 35);
            this.btn_Del_Stgr.TabIndex = 2;
            this.btn_Del_Stgr.Text = "Supprimer";
            this.btn_Del_Stgr.UseVisualStyleBackColor = true;
            this.btn_Del_Stgr.Click += new System.EventHandler(this.btn_Del_Stgr_Click);
            // 
            // btn_Edit_Stgr
            // 
            this.btn_Edit_Stgr.Location = new System.Drawing.Point(6, 60);
            this.btn_Edit_Stgr.Name = "btn_Edit_Stgr";
            this.btn_Edit_Stgr.Size = new System.Drawing.Size(96, 35);
            this.btn_Edit_Stgr.TabIndex = 1;
            this.btn_Edit_Stgr.Text = "Modifier";
            this.btn_Edit_Stgr.UseVisualStyleBackColor = true;
            this.btn_Edit_Stgr.Click += new System.EventHandler(this.btn_Edit_Stgr_Click);
            // 
            // btn_Add_Stgr
            // 
            this.btn_Add_Stgr.Location = new System.Drawing.Point(6, 19);
            this.btn_Add_Stgr.Name = "btn_Add_Stgr";
            this.btn_Add_Stgr.Size = new System.Drawing.Size(96, 35);
            this.btn_Add_Stgr.TabIndex = 0;
            this.btn_Add_Stgr.Text = "Ajouter";
            this.btn_Add_Stgr.UseVisualStyleBackColor = true;
            this.btn_Add_Stgr.Click += new System.EventHandler(this.btn_Add_Stgr_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(767, 448);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(78, 35);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Quitter";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_del_dup
            // 
            this.btn_del_dup.Location = new System.Drawing.Point(705, 202);
            this.btn_del_dup.Name = "btn_del_dup";
            this.btn_del_dup.Size = new System.Drawing.Size(108, 43);
            this.btn_del_dup.TabIndex = 15;
            this.btn_del_dup.Text = "Supprimer les doublons";
            this.btn_del_dup.UseVisualStyleBackColor = true;
            this.btn_del_dup.Click += new System.EventHandler(this.btn_del_dup_Click);
            // 
            // Form_ListStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 506);
            this.Controls.Add(this.btn_del_dup);
            this.Controls.Add(this.btn_Save_Exite);
            this.Controls.Add(this.dgv_stgr);
            this.Controls.Add(this.gb_Stgr);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ListStagiaire";
            this.Text = "Form_ListStagiaire";
            this.Load += new System.EventHandler(this.Form_ListStagiaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stgr)).EndInit();
            this.gb_Stgr.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save_Exite;
        private System.Windows.Forms.DataGridView dgv_stgr;
        private System.Windows.Forms.GroupBox gb_Stgr;
        private System.Windows.Forms.Button btn_Del_Stgr;
        private System.Windows.Forms.Button btn_Edit_Stgr;
        private System.Windows.Forms.Button btn_Add_Stgr;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEF;
        private System.Windows.Forms.DataGridViewTextBoxColumn cin;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn filiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresse;
        private System.Windows.Forms.Button btn_del_dup;
    }
}