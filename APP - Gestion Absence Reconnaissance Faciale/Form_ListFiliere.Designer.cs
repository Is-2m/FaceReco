
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListFiliere));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Del_Grp = new System.Windows.Forms.Button();
            this.btn_Edit_Grp = new System.Windows.Forms.Button();
            this.btn_Add_Grp = new System.Windows.Forms.Button();
            this.gb_Grp = new System.Windows.Forms.GroupBox();
            this.gb_Fil = new System.Windows.Forms.GroupBox();
            this.btn_Del_Fil = new System.Windows.Forms.Button();
            this.btn_Edit_Fil = new System.Windows.Forms.Button();
            this.btn_Add_Fil = new System.Windows.Forms.Button();
            this.dgv_Grp = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Fil = new System.Windows.Forms.DataGridView();
            this.nomF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gb_Grp.SuspendLayout();
            this.gb_Fil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Del_Grp
            // 
            this.btn_Del_Grp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del_Grp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del_Grp.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Del_Grp.Image = global::FaceReco.Properties.Resources.trashSolid;
            this.btn_Del_Grp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Del_Grp.Location = new System.Drawing.Point(27, 98);
            this.btn_Del_Grp.Name = "btn_Del_Grp";
            this.btn_Del_Grp.Size = new System.Drawing.Size(96, 31);
            this.btn_Del_Grp.TabIndex = 2;
            this.btn_Del_Grp.Text = "Supprimer";
            this.btn_Del_Grp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Del_Grp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Del_Grp.UseVisualStyleBackColor = true;
            this.btn_Del_Grp.Click += new System.EventHandler(this.btn_Del_Grp_Click);
            // 
            // btn_Edit_Grp
            // 
            this.btn_Edit_Grp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit_Grp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit_Grp.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Edit_Grp.Image = global::FaceReco.Properties.Resources.pen_to_square_solid;
            this.btn_Edit_Grp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit_Grp.Location = new System.Drawing.Point(27, 61);
            this.btn_Edit_Grp.Name = "btn_Edit_Grp";
            this.btn_Edit_Grp.Size = new System.Drawing.Size(96, 31);
            this.btn_Edit_Grp.TabIndex = 1;
            this.btn_Edit_Grp.Text = "Modifier";
            this.btn_Edit_Grp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit_Grp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit_Grp.UseVisualStyleBackColor = true;
            this.btn_Edit_Grp.Click += new System.EventHandler(this.btn_Edit_Grp_Click);
            // 
            // btn_Add_Grp
            // 
            this.btn_Add_Grp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_Grp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Grp.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Add_Grp.Image = global::FaceReco.Properties.Resources.circle_plus_solid;
            this.btn_Add_Grp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Grp.Location = new System.Drawing.Point(27, 24);
            this.btn_Add_Grp.Name = "btn_Add_Grp";
            this.btn_Add_Grp.Size = new System.Drawing.Size(96, 31);
            this.btn_Add_Grp.TabIndex = 0;
            this.btn_Add_Grp.Text = "Ajouter";
            this.btn_Add_Grp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Grp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add_Grp.UseVisualStyleBackColor = true;
            this.btn_Add_Grp.Click += new System.EventHandler(this.btn_Add_Grp_Click);
            // 
            // gb_Grp
            // 
            this.gb_Grp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Grp.Controls.Add(this.btn_Del_Grp);
            this.gb_Grp.Controls.Add(this.btn_Add_Grp);
            this.gb_Grp.Controls.Add(this.btn_Edit_Grp);
            this.gb_Grp.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Grp.ForeColor = System.Drawing.Color.Black;
            this.gb_Grp.Location = new System.Drawing.Point(769, 262);
            this.gb_Grp.Name = "gb_Grp";
            this.gb_Grp.Size = new System.Drawing.Size(150, 135);
            this.gb_Grp.TabIndex = 9;
            this.gb_Grp.TabStop = false;
            this.gb_Grp.Text = "Groupe";
            // 
            // gb_Fil
            // 
            this.gb_Fil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Fil.Controls.Add(this.btn_Del_Fil);
            this.gb_Fil.Controls.Add(this.btn_Edit_Fil);
            this.gb_Fil.Controls.Add(this.btn_Add_Fil);
            this.gb_Fil.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Fil.ForeColor = System.Drawing.Color.Black;
            this.gb_Fil.Location = new System.Drawing.Point(769, 12);
            this.gb_Fil.Name = "gb_Fil";
            this.gb_Fil.Size = new System.Drawing.Size(150, 140);
            this.gb_Fil.TabIndex = 10;
            this.gb_Fil.TabStop = false;
            this.gb_Fil.Text = "Filiere";
            // 
            // btn_Del_Fil
            // 
            this.btn_Del_Fil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Del_Fil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del_Fil.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del_Fil.Image = global::FaceReco.Properties.Resources.trashSolid;
            this.btn_Del_Fil.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Del_Fil.Location = new System.Drawing.Point(27, 92);
            this.btn_Del_Fil.Name = "btn_Del_Fil";
            this.btn_Del_Fil.Size = new System.Drawing.Size(96, 31);
            this.btn_Del_Fil.TabIndex = 2;
            this.btn_Del_Fil.Text = "Supprimer";
            this.btn_Del_Fil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Del_Fil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Del_Fil.UseVisualStyleBackColor = true;
            this.btn_Del_Fil.Click += new System.EventHandler(this.btn_Del_Fil_Click);
            // 
            // btn_Edit_Fil
            // 
            this.btn_Edit_Fil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit_Fil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit_Fil.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_Fil.Image = global::FaceReco.Properties.Resources.pen_to_square_solid;
            this.btn_Edit_Fil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit_Fil.Location = new System.Drawing.Point(27, 55);
            this.btn_Edit_Fil.Name = "btn_Edit_Fil";
            this.btn_Edit_Fil.Size = new System.Drawing.Size(96, 31);
            this.btn_Edit_Fil.TabIndex = 1;
            this.btn_Edit_Fil.Text = "Modifier";
            this.btn_Edit_Fil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit_Fil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Edit_Fil.UseVisualStyleBackColor = true;
            this.btn_Edit_Fil.Click += new System.EventHandler(this.btn_Edit_Fil_Click);
            // 
            // btn_Add_Fil
            // 
            this.btn_Add_Fil.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add_Fil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Fil.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Fil.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add_Fil.Image")));
            this.btn_Add_Fil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Fil.Location = new System.Drawing.Point(27, 18);
            this.btn_Add_Fil.Name = "btn_Add_Fil";
            this.btn_Add_Fil.Size = new System.Drawing.Size(96, 31);
            this.btn_Add_Fil.TabIndex = 0;
            this.btn_Add_Fil.Text = " Ajouter";
            this.btn_Add_Fil.UseVisualStyleBackColor = true;
            this.btn_Add_Fil.Click += new System.EventHandler(this.btn_Add_Fil_Click);
            // 
            // dgv_Grp
            // 
            this.dgv_Grp.AllowUserToAddRows = false;
            this.dgv_Grp.AllowUserToDeleteRows = false;
            this.dgv_Grp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Grp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.dgv_Grp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Grp.Location = new System.Drawing.Point(0, 0);
            this.dgv_Grp.Margin = new System.Windows.Forms.Padding(10);
            this.dgv_Grp.MultiSelect = false;
            this.dgv_Grp.Name = "dgv_Grp";
            this.dgv_Grp.ReadOnly = true;
            this.dgv_Grp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Grp.Size = new System.Drawing.Size(739, 243);
            this.dgv_Grp.TabIndex = 14;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Numéro Groupe";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Nombre Stagiaires";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 400;
            // 
            // dgv_Fil
            // 
            this.dgv_Fil.AllowUserToAddRows = false;
            this.dgv_Fil.AllowUserToDeleteRows = false;
            this.dgv_Fil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Fil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomF,
            this.intitule});
            this.dgv_Fil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Fil.Location = new System.Drawing.Point(0, 0);
            this.dgv_Fil.MultiSelect = false;
            this.dgv_Fil.Name = "dgv_Fil";
            this.dgv_Fil.ReadOnly = true;
            this.dgv_Fil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Fil.Size = new System.Drawing.Size(739, 246);
            this.dgv_Fil.TabIndex = 13;
            this.dgv_Fil.SelectionChanged += new System.EventHandler(this.dgv_Fil_SelectionChanged);
            // 
            // nomF
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomF.DefaultCellStyle = dataGridViewCellStyle7;
            this.nomF.HeaderText = "Abréviation Filiere";
            this.nomF.Name = "nomF";
            this.nomF.ReadOnly = true;
            this.nomF.Width = 150;
            // 
            // intitule
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intitule.DefaultCellStyle = dataGridViewCellStyle8;
            this.intitule.HeaderText = "Intitule";
            this.intitule.Name = "intitule";
            this.intitule.ReadOnly = true;
            this.intitule.Width = 450;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_Fil);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_Grp);
            this.splitContainer1.Size = new System.Drawing.Size(739, 493);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 15;
            // 
            // Form_ListFiliere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(965, 517);
            this.Controls.Add(this.gb_Grp);
            this.Controls.Add(this.gb_Fil);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Form_ListFiliere";
            this.Text = "List Filières";
            this.Load += new System.EventHandler(this.Form_ListFiliere_Load);
            this.gb_Grp.ResumeLayout(false);
            this.gb_Fil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Grp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fil)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Del_Grp;
        private System.Windows.Forms.Button btn_Edit_Grp;
        private System.Windows.Forms.Button btn_Add_Grp;
        private System.Windows.Forms.GroupBox gb_Grp;
        private System.Windows.Forms.Button btn_Del_Fil;
        private System.Windows.Forms.Button btn_Edit_Fil;
        private System.Windows.Forms.GroupBox gb_Fil;
        private System.Windows.Forms.DataGridView dgv_Grp;
        private System.Windows.Forms.DataGridView dgv_Fil;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Add_Fil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomF;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}