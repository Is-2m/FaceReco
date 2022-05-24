
namespace FaceReco
{
    partial class Form_ListIntrus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListIntrus));
            this.dgv_Intru = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.gb_Intru = new System.Windows.Forms.GroupBox();
            this.btn_Add_Stgr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Intru)).BeginInit();
            this.gb_Intru.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Intru
            // 
            this.dgv_Intru.AllowUserToAddRows = false;
            this.dgv_Intru.AllowUserToDeleteRows = false;
            this.dgv_Intru.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Intru.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Intru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Intru.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.photo});
            this.dgv_Intru.Location = new System.Drawing.Point(12, 12);
            this.dgv_Intru.Name = "dgv_Intru";
            this.dgv_Intru.ReadOnly = true;
            this.dgv_Intru.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Intru.Size = new System.Drawing.Size(654, 443);
            this.dgv_Intru.TabIndex = 16;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // photo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.photo.DefaultCellStyle = dataGridViewCellStyle2;
            this.photo.HeaderText = "Photo";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.photo.Width = 500;
            // 
            // gb_Intru
            // 
            this.gb_Intru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Intru.Controls.Add(this.btn_Add_Stgr);
            this.gb_Intru.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.gb_Intru.Location = new System.Drawing.Point(709, 56);
            this.gb_Intru.Name = "gb_Intru";
            this.gb_Intru.Size = new System.Drawing.Size(155, 137);
            this.gb_Intru.TabIndex = 15;
            this.gb_Intru.TabStop = false;
            this.gb_Intru.Text = "Intrus";
            // 
            // btn_Add_Stgr
            // 
            this.btn_Add_Stgr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add_Stgr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Stgr.Font = new System.Drawing.Font("Poppins Medium", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_Add_Stgr.Image = global::FaceReco.Properties.Resources.user_plus_solid;
            this.btn_Add_Stgr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Stgr.Location = new System.Drawing.Point(19, 38);
            this.btn_Add_Stgr.Name = "btn_Add_Stgr";
            this.btn_Add_Stgr.Size = new System.Drawing.Size(111, 74);
            this.btn_Add_Stgr.TabIndex = 0;
            this.btn_Add_Stgr.Text = "Ajouter Comme Stagiaire";
            this.btn_Add_Stgr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add_Stgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add_Stgr.UseVisualStyleBackColor = true;
            this.btn_Add_Stgr.Click += new System.EventHandler(this.btn_Add_Stgr_Click);
            // 
            // Form_ListIntrus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 467);
            this.Controls.Add(this.dgv_Intru);
            this.Controls.Add(this.gb_Intru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ListIntrus";
            this.Text = "List Intrus";
            this.Load += new System.EventHandler(this.Form_ListIntrus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Intru)).EndInit();
            this.gb_Intru.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Intru;
        private System.Windows.Forms.GroupBox gb_Intru;
        private System.Windows.Forms.Button btn_Add_Stgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn photo;
    }
}