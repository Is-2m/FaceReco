
namespace FaceReco
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lbl_Logo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btn_Maximize = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btn_Stagiaires = new System.Windows.Forms.Button();
            this.btn_Intrus = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btn_PresenceSheet = new System.Windows.Forms.Button();
            this.btn_FaceRec = new System.Windows.Forms.Button();
            this.btn_Stagiaire = new System.Windows.Forms.Button();
            this.btn_Groupe = new System.Windows.Forms.Button();
            this.btn_Filieres = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_PresenceSheet);
            this.panelMenu.Controls.Add(this.btn_FaceRec);
            this.panelMenu.Controls.Add(this.panelSubMenu);
            this.panelMenu.Controls.Add(this.btn_Stagiaire);
            this.panelMenu.Controls.Add(this.btn_Groupe);
            this.panelMenu.Controls.Add(this.btn_Filieres);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 504);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lbl_Logo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lbl_Logo
            // 
            this.lbl_Logo.AutoSize = true;
            this.lbl_Logo.Font = new System.Drawing.Font("Poppins Black", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Logo.ForeColor = System.Drawing.Color.LightGray;
            this.lbl_Logo.Location = new System.Drawing.Point(52, 16);
            this.lbl_Logo.Name = "lbl_Logo";
            this.lbl_Logo.Size = new System.Drawing.Size(112, 48);
            this.lbl_Logo.TabIndex = 2;
            this.lbl_Logo.Text = "SGARF";
            this.lbl_Logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Logo.Click += new System.EventHandler(this.lbl_Logo_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btn_Maximize);
            this.panelTitleBar.Controls.Add(this.btn_Minimize);
            this.panelTitleBar.Controls.Add(this.btn_Exit);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lbl_Title);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(614, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Font = new System.Drawing.Font("Montserrat", 15F);
            this.btn_Maximize.ForeColor = System.Drawing.Color.White;
            this.btn_Maximize.Location = new System.Drawing.Point(554, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(30, 30);
            this.btn_Maximize.TabIndex = 6;
            this.btn_Maximize.Tag = "";
            this.btn_Maximize.Text = "O";
            this.MyToolTip.SetToolTip(this.btn_Maximize, "Maximize");
            this.btn_Maximize.UseCompatibleTextRendering = true;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Montserrat", 15F);
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.Location = new System.Drawing.Point(524, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 5;
            this.btn_Minimize.Tag = "";
            this.btn_Minimize.Text = "O";
            this.MyToolTip.SetToolTip(this.btn_Minimize, "Minimize");
            this.btn_Minimize.UseCompatibleTextRendering = true;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Montserrat", 15F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(584, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(30, 30);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Tag = "";
            this.btn_Exit.Text = "O";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MyToolTip.SetToolTip(this.btn_Exit, "Close");
            this.btn_Exit.UseCompatibleTextRendering = true;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Poppins ExtraBold", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(255, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(103, 39);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Accueil";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(614, 424);
            this.panelDesktopPane.TabIndex = 3;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenu.Controls.Add(this.btn_Intrus);
            this.panelSubMenu.Controls.Add(this.btn_Stagiaires);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 260);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(220, 86);
            this.panelSubMenu.TabIndex = 0;
            this.panelSubMenu.Visible = false;
            // 
            // btn_Stagiaires
            // 
            this.btn_Stagiaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btn_Stagiaires.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Stagiaires.FlatAppearance.BorderSize = 0;
            this.btn_Stagiaires.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stagiaires.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Stagiaires.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Stagiaires.Location = new System.Drawing.Point(0, 0);
            this.btn_Stagiaires.Name = "btn_Stagiaires";
            this.btn_Stagiaires.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Stagiaires.Size = new System.Drawing.Size(220, 40);
            this.btn_Stagiaires.TabIndex = 1;
            this.btn_Stagiaires.Text = "Stagiaires";
            this.btn_Stagiaires.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stagiaires.UseVisualStyleBackColor = false;
            this.btn_Stagiaires.Click += new System.EventHandler(this.btn_Stagiaires_Click);
            // 
            // btn_Intrus
            // 
            this.btn_Intrus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btn_Intrus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Intrus.FlatAppearance.BorderSize = 0;
            this.btn_Intrus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Intrus.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Intrus.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Intrus.Location = new System.Drawing.Point(0, 40);
            this.btn_Intrus.Name = "btn_Intrus";
            this.btn_Intrus.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Intrus.Size = new System.Drawing.Size(220, 40);
            this.btn_Intrus.TabIndex = 2;
            this.btn_Intrus.Text = "Intrus";
            this.btn_Intrus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Intrus.UseVisualStyleBackColor = false;
            this.btn_Intrus.Click += new System.EventHandler(this.btn_Intrus_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::FaceReco.Properties.Resources.Exit;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 3;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btn_PresenceSheet
            // 
            this.btn_PresenceSheet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PresenceSheet.FlatAppearance.BorderSize = 0;
            this.btn_PresenceSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PresenceSheet.Font = new System.Drawing.Font("Poppins SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btn_PresenceSheet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_PresenceSheet.Image = global::FaceReco.Properties.Resources.Attendence_Sheet;
            this.btn_PresenceSheet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PresenceSheet.Location = new System.Drawing.Point(0, 416);
            this.btn_PresenceSheet.Name = "btn_PresenceSheet";
            this.btn_PresenceSheet.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_PresenceSheet.Size = new System.Drawing.Size(220, 70);
            this.btn_PresenceSheet.TabIndex = 5;
            this.btn_PresenceSheet.Text = "   &Feuille \r\n   Présence";
            this.btn_PresenceSheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PresenceSheet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PresenceSheet.UseVisualStyleBackColor = true;
            this.btn_PresenceSheet.Click += new System.EventHandler(this.btn_PresenceSheet_Click);
            // 
            // btn_FaceRec
            // 
            this.btn_FaceRec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_FaceRec.FlatAppearance.BorderSize = 0;
            this.btn_FaceRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FaceRec.Font = new System.Drawing.Font("Poppins SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btn_FaceRec.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_FaceRec.Image = global::FaceReco.Properties.Resources.FaceRec;
            this.btn_FaceRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FaceRec.Location = new System.Drawing.Point(0, 346);
            this.btn_FaceRec.Name = "btn_FaceRec";
            this.btn_FaceRec.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_FaceRec.Size = new System.Drawing.Size(220, 70);
            this.btn_FaceRec.TabIndex = 4;
            this.btn_FaceRec.Text = "   &Detection\r\n   Présence";
            this.btn_FaceRec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_FaceRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_FaceRec.UseVisualStyleBackColor = true;
            this.btn_FaceRec.Click += new System.EventHandler(this.btn_FaceRec_Click);
            // 
            // btn_Stagiaire
            // 
            this.btn_Stagiaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Stagiaire.FlatAppearance.BorderSize = 0;
            this.btn_Stagiaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stagiaire.Font = new System.Drawing.Font("Poppins SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Stagiaire.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Stagiaire.Image = global::FaceReco.Properties.Resources.Stagaires;
            this.btn_Stagiaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stagiaire.Location = new System.Drawing.Point(0, 200);
            this.btn_Stagiaire.Name = "btn_Stagiaire";
            this.btn_Stagiaire.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Stagiaire.Size = new System.Drawing.Size(220, 60);
            this.btn_Stagiaire.TabIndex = 2;
            this.btn_Stagiaire.Text = "   &Stagiaires";
            this.btn_Stagiaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stagiaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Stagiaire.UseVisualStyleBackColor = true;
            this.btn_Stagiaire.Click += new System.EventHandler(this.btn_Stagiaire_Click);
            // 
            // btn_Groupe
            // 
            this.btn_Groupe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Groupe.FlatAppearance.BorderSize = 0;
            this.btn_Groupe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Groupe.Font = new System.Drawing.Font("Poppins SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Groupe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Groupe.Image = global::FaceReco.Properties.Resources.Groups;
            this.btn_Groupe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Groupe.Location = new System.Drawing.Point(0, 140);
            this.btn_Groupe.Name = "btn_Groupe";
            this.btn_Groupe.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Groupe.Size = new System.Drawing.Size(220, 60);
            this.btn_Groupe.TabIndex = 1;
            this.btn_Groupe.Text = "   &Groupes";
            this.btn_Groupe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Groupe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Groupe.UseVisualStyleBackColor = true;
            this.btn_Groupe.Click += new System.EventHandler(this.btn_Groupe_Click);
            // 
            // btn_Filieres
            // 
            this.btn_Filieres.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Filieres.FlatAppearance.BorderSize = 0;
            this.btn_Filieres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filieres.Font = new System.Drawing.Font("Poppins SemiBold", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Filieres.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Filieres.Image = global::FaceReco.Properties.Resources.Filieres1;
            this.btn_Filieres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filieres.Location = new System.Drawing.Point(0, 80);
            this.btn_Filieres.Name = "btn_Filieres";
            this.btn_Filieres.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Filieres.Size = new System.Drawing.Size(220, 60);
            this.btn_Filieres.TabIndex = 0;
            this.btn_Filieres.Text = "   &Filières";
            this.btn_Filieres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filieres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Filieres.UseVisualStyleBackColor = true;
            this.btn_Filieres.Click += new System.EventHandler(this.btn_Filieres_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 504);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(850, 530);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Gestion Absence Reconnaissance Faciale";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_Filieres;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn_PresenceSheet;
        private System.Windows.Forms.Button btn_FaceRec;
        private System.Windows.Forms.Button btn_Stagiaire;
        private System.Windows.Forms.Button btn_Groupe;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Logo;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Maximize;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btn_Intrus;
        private System.Windows.Forms.Button btn_Stagiaires;
    }
}

