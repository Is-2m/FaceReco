
namespace FaceReco
{
    partial class Form_ListGroupe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_stgr = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Grp = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add_Stgr = new System.Windows.Forms.Button();
            this.gb_Stgr = new System.Windows.Forms.GroupBox();
            this.btn_Del_Stgr = new System.Windows.Forms.Button();
            this.btn_Edit_Stgr = new System.Windows.Forms.Button();
            this.gb_Grp = new System.Windows.Forms.GroupBox();
            this.btn_Del_Grp = new System.Windows.Forms.Button();
            this.btn_Edit_Grp = new System.Windows.Forms.Button();
            this.btn_Add_Grp = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save_Exite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stgr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grp)).BeginInit();
            this.gb_Stgr.SuspendLayout();
            this.gb_Grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_stgr
            // 
            this.dgv_stgr.AllowUserToAddRows = false;
            this.dgv_stgr.AllowUserToDeleteRows = false;
            this.dgv_stgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgv_stgr.Location = new System.Drawing.Point(12, 252);
            this.dgv_stgr.MultiSelect = false;
            this.dgv_stgr.Name = "dgv_stgr";
            this.dgv_stgr.ReadOnly = true;
            this.dgv_stgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_stgr.Size = new System.Drawing.Size(648, 242);
            this.dgv_stgr.TabIndex = 7;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "CEF";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Cin";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nom";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Prenom";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Ville";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Adresse";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // dgv_Grp
            // 
            this.dgv_Grp.AllowUserToAddRows = false;
            this.dgv_Grp.AllowUserToDeleteRows = false;
            this.dgv_Grp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Grp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgv_Grp.Location = new System.Drawing.Point(12, 12);
            this.dgv_Grp.MultiSelect = false;
            this.dgv_Grp.Name = "dgv_Grp";
            this.dgv_Grp.ReadOnly = true;
            this.dgv_Grp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Grp.Size = new System.Drawing.Size(648, 219);
            this.dgv_Grp.TabIndex = 8;
            this.dgv_Grp.SelectionChanged += new System.EventHandler(this.dgv_Grp_SelectionChanged);
            // 
            // Column3
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Numéro Groupe";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre Stagiaires";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 400;
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
            // gb_Stgr
            // 
            this.gb_Stgr.Controls.Add(this.btn_Del_Stgr);
            this.gb_Stgr.Controls.Add(this.btn_Edit_Stgr);
            this.gb_Stgr.Controls.Add(this.btn_Add_Stgr);
            this.gb_Stgr.Location = new System.Drawing.Point(696, 252);
            this.gb_Stgr.Name = "gb_Stgr";
            this.gb_Stgr.Size = new System.Drawing.Size(108, 147);
            this.gb_Stgr.TabIndex = 1;
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
            // gb_Grp
            // 
            this.gb_Grp.Controls.Add(this.btn_Del_Grp);
            this.gb_Grp.Controls.Add(this.btn_Edit_Grp);
            this.gb_Grp.Controls.Add(this.btn_Add_Grp);
            this.gb_Grp.Location = new System.Drawing.Point(696, 12);
            this.gb_Grp.Name = "gb_Grp";
            this.gb_Grp.Size = new System.Drawing.Size(108, 147);
            this.gb_Grp.TabIndex = 0;
            this.gb_Grp.TabStop = false;
            this.gb_Grp.Text = "Groupe";
            // 
            // btn_Del_Grp
            // 
            this.btn_Del_Grp.Location = new System.Drawing.Point(6, 101);
            this.btn_Del_Grp.Name = "btn_Del_Grp";
            this.btn_Del_Grp.Size = new System.Drawing.Size(96, 35);
            this.btn_Del_Grp.TabIndex = 2;
            this.btn_Del_Grp.Text = "Supprimer";
            this.btn_Del_Grp.UseVisualStyleBackColor = true;
            this.btn_Del_Grp.Click += new System.EventHandler(this.btn_Del_Grp_Click);
            // 
            // btn_Edit_Grp
            // 
            this.btn_Edit_Grp.Location = new System.Drawing.Point(6, 60);
            this.btn_Edit_Grp.Name = "btn_Edit_Grp";
            this.btn_Edit_Grp.Size = new System.Drawing.Size(96, 35);
            this.btn_Edit_Grp.TabIndex = 1;
            this.btn_Edit_Grp.Text = "Modifier";
            this.btn_Edit_Grp.UseVisualStyleBackColor = true;
            this.btn_Edit_Grp.Click += new System.EventHandler(this.btn_Edit_Grp_Click);
            // 
            // btn_Add_Grp
            // 
            this.btn_Add_Grp.Location = new System.Drawing.Point(6, 19);
            this.btn_Add_Grp.Name = "btn_Add_Grp";
            this.btn_Add_Grp.Size = new System.Drawing.Size(96, 35);
            this.btn_Add_Grp.TabIndex = 0;
            this.btn_Add_Grp.Text = "Ajouter";
            this.btn_Add_Grp.UseVisualStyleBackColor = true;
            this.btn_Add_Grp.Click += new System.EventHandler(this.btn_Add_Grp_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(767, 459);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(78, 35);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Quitter";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save_Exite
            // 
            this.btn_Save_Exite.Location = new System.Drawing.Point(666, 459);
            this.btn_Save_Exite.Name = "btn_Save_Exite";
            this.btn_Save_Exite.Size = new System.Drawing.Size(78, 35);
            this.btn_Save_Exite.TabIndex = 2;
            this.btn_Save_Exite.Text = "Enregistrer et Quitter";
            this.btn_Save_Exite.UseVisualStyleBackColor = true;
            this.btn_Save_Exite.Click += new System.EventHandler(this.btn_Save_Exite_Click);
            // 
            // Form_ListGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 506);
            this.Controls.Add(this.btn_Save_Exite);
            this.Controls.Add(this.dgv_stgr);
            this.Controls.Add(this.dgv_Grp);
            this.Controls.Add(this.gb_Stgr);
            this.Controls.Add(this.gb_Grp);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ListGroupe";
            this.Text = "Form_ListGroupe";
            this.Load += new System.EventHandler(this.Form_ListGroupe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stgr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grp)).EndInit();
            this.gb_Stgr.ResumeLayout(false);
            this.gb_Grp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_stgr;
        private System.Windows.Forms.DataGridView dgv_Grp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_Add_Stgr;
        private System.Windows.Forms.GroupBox gb_Stgr;
        private System.Windows.Forms.Button btn_Del_Stgr;
        private System.Windows.Forms.Button btn_Edit_Stgr;
        private System.Windows.Forms.GroupBox gb_Grp;
        private System.Windows.Forms.Button btn_Del_Grp;
        private System.Windows.Forms.Button btn_Edit_Grp;
        private System.Windows.Forms.Button btn_Add_Grp;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btn_Save_Exite;
    }
}