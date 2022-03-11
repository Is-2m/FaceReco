
namespace FaceReco
{
    partial class Form_ListFiliere
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Save_Exite = new System.Windows.Forms.Button();
            this.btn_Del_Grp = new System.Windows.Forms.Button();
            this.btn_Edit_Grp = new System.Windows.Forms.Button();
            this.btn_Add_Grp = new System.Windows.Forms.Button();
            this.gb_Grp = new System.Windows.Forms.GroupBox();
            this.btn_Del_Fil = new System.Windows.Forms.Button();
            this.btn_Edit_Fil = new System.Windows.Forms.Button();
            this.gb_Fil = new System.Windows.Forms.GroupBox();
            this.btn_Add_Fil = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Grp = new System.Windows.Forms.DataGridView();
            this.dgv_Fil = new System.Windows.Forms.DataGridView();
            this.nomF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gb_Grp.SuspendLayout();
            this.gb_Fil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fil)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save_Exite
            // 
            this.btn_Save_Exite.Location = new System.Drawing.Point(666, 459);
            this.btn_Save_Exite.Name = "btn_Save_Exite";
            this.btn_Save_Exite.Size = new System.Drawing.Size(78, 35);
            this.btn_Save_Exite.TabIndex = 11;
            this.btn_Save_Exite.Text = "Enregistrer et Quitter";
            this.btn_Save_Exite.UseVisualStyleBackColor = true;
            this.btn_Save_Exite.Click += new System.EventHandler(this.btn_Save_Exite_Click);
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
            // gb_Grp
            // 
            this.gb_Grp.Controls.Add(this.btn_Del_Grp);
            this.gb_Grp.Controls.Add(this.btn_Edit_Grp);
            this.gb_Grp.Controls.Add(this.btn_Add_Grp);
            this.gb_Grp.Location = new System.Drawing.Point(696, 295);
            this.gb_Grp.Name = "gb_Grp";
            this.gb_Grp.Size = new System.Drawing.Size(108, 147);
            this.gb_Grp.TabIndex = 9;
            this.gb_Grp.TabStop = false;
            this.gb_Grp.Text = "Groupe";
            // 
            // btn_Del_Fil
            // 
            this.btn_Del_Fil.Location = new System.Drawing.Point(6, 101);
            this.btn_Del_Fil.Name = "btn_Del_Fil";
            this.btn_Del_Fil.Size = new System.Drawing.Size(96, 35);
            this.btn_Del_Fil.TabIndex = 2;
            this.btn_Del_Fil.Text = "Supprimer";
            this.btn_Del_Fil.UseVisualStyleBackColor = true;
            this.btn_Del_Fil.Click += new System.EventHandler(this.btn_Del_Fil_Click);
            // 
            // btn_Edit_Fil
            // 
            this.btn_Edit_Fil.Location = new System.Drawing.Point(6, 60);
            this.btn_Edit_Fil.Name = "btn_Edit_Fil";
            this.btn_Edit_Fil.Size = new System.Drawing.Size(96, 35);
            this.btn_Edit_Fil.TabIndex = 1;
            this.btn_Edit_Fil.Text = "Modifier";
            this.btn_Edit_Fil.UseVisualStyleBackColor = true;
            this.btn_Edit_Fil.Click += new System.EventHandler(this.btn_Edit_Fil_Click);
            // 
            // gb_Fil
            // 
            this.gb_Fil.Controls.Add(this.btn_Del_Fil);
            this.gb_Fil.Controls.Add(this.btn_Edit_Fil);
            this.gb_Fil.Controls.Add(this.btn_Add_Fil);
            this.gb_Fil.Location = new System.Drawing.Point(696, 33);
            this.gb_Fil.Name = "gb_Fil";
            this.gb_Fil.Size = new System.Drawing.Size(108, 147);
            this.gb_Fil.TabIndex = 10;
            this.gb_Fil.TabStop = false;
            this.gb_Fil.Text = "Filiere";
            // 
            // btn_Add_Fil
            // 
            this.btn_Add_Fil.Location = new System.Drawing.Point(6, 19);
            this.btn_Add_Fil.Name = "btn_Add_Fil";
            this.btn_Add_Fil.Size = new System.Drawing.Size(96, 35);
            this.btn_Add_Fil.TabIndex = 0;
            this.btn_Add_Fil.Text = "Ajouter";
            this.btn_Add_Fil.UseVisualStyleBackColor = true;
            this.btn_Add_Fil.Click += new System.EventHandler(this.btn_Add_Fil_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre Stagiaires";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 400;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Numéro Groupe";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // dgv_Grp
            // 
            this.dgv_Grp.AllowUserToAddRows = false;
            this.dgv_Grp.AllowUserToDeleteRows = false;
            this.dgv_Grp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Grp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgv_Grp.Location = new System.Drawing.Point(12, 275);
            this.dgv_Grp.MultiSelect = false;
            this.dgv_Grp.Name = "dgv_Grp";
            this.dgv_Grp.ReadOnly = true;
            this.dgv_Grp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Grp.Size = new System.Drawing.Size(648, 219);
            this.dgv_Grp.TabIndex = 14;
            // 
            // dgv_Fil
            // 
            this.dgv_Fil.AllowUserToAddRows = false;
            this.dgv_Fil.AllowUserToDeleteRows = false;
            this.dgv_Fil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomF,
            this.intitule});
            this.dgv_Fil.Location = new System.Drawing.Point(12, 12);
            this.dgv_Fil.MultiSelect = false;
            this.dgv_Fil.Name = "dgv_Fil";
            this.dgv_Fil.ReadOnly = true;
            this.dgv_Fil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Fil.Size = new System.Drawing.Size(648, 242);
            this.dgv_Fil.TabIndex = 13;
            this.dgv_Fil.SelectionChanged += new System.EventHandler(this.dgv_Fil_SelectionChanged);
            // 
            // nomF
            // 
            this.nomF.HeaderText = "Abréviation Filiere";
            this.nomF.Name = "nomF";
            this.nomF.ReadOnly = true;
            this.nomF.Width = 150;
            // 
            // intitule
            // 
            this.intitule.HeaderText = "Intitule";
            this.intitule.Name = "intitule";
            this.intitule.ReadOnly = true;
            this.intitule.Width = 450;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(767, 459);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(78, 35);
            this.btn_Close.TabIndex = 12;
            this.btn_Close.Text = "Quitter";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Form_ListFiliere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 506);
            this.Controls.Add(this.btn_Save_Exite);
            this.Controls.Add(this.gb_Grp);
            this.Controls.Add(this.gb_Fil);
            this.Controls.Add(this.dgv_Grp);
            this.Controls.Add(this.dgv_Fil);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form_ListFiliere";
            this.Text = "Form_ListFiliere";
            this.Load += new System.EventHandler(this.Form_ListFiliere_Load);
            this.gb_Grp.ResumeLayout(false);
            this.gb_Fil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save_Exite;
        private System.Windows.Forms.Button btn_Del_Grp;
        private System.Windows.Forms.Button btn_Edit_Grp;
        private System.Windows.Forms.Button btn_Add_Grp;
        private System.Windows.Forms.GroupBox gb_Grp;
        private System.Windows.Forms.Button btn_Del_Fil;
        private System.Windows.Forms.Button btn_Edit_Fil;
        private System.Windows.Forms.GroupBox gb_Fil;
        private System.Windows.Forms.Button btn_Add_Fil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dgv_Grp;
        private System.Windows.Forms.DataGridView dgv_Fil;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomF;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitule;
    }
}