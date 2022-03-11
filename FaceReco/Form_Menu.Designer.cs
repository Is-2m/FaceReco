
namespace FaceReco
{
    partial class Main_Form
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerFiliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterGroupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerGroupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faceRecoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.filiersToolStripMenuItem,
            this.groupesToolStripMenuItem,
            this.stagiairesToolStripMenuItem,
            this.faceRecoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(874, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // filiersToolStripMenuItem
            // 
            this.filiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creeToolStripMenuItem,
            this.listerFiliersToolStripMenuItem});
            this.filiersToolStripMenuItem.Name = "filiersToolStripMenuItem";
            this.filiersToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.filiersToolStripMenuItem.Text = "Filieres";
            // 
            // creeToolStripMenuItem
            // 
            this.creeToolStripMenuItem.Name = "creeToolStripMenuItem";
            this.creeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.creeToolStripMenuItem.Text = "Ajouter Filiere";
            this.creeToolStripMenuItem.Click += new System.EventHandler(this.creeToolStripMenuItem_Click);
            // 
            // listerFiliersToolStripMenuItem
            // 
            this.listerFiliersToolStripMenuItem.Name = "listerFiliersToolStripMenuItem";
            this.listerFiliersToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.listerFiliersToolStripMenuItem.Text = "Lister Filieres";
            this.listerFiliersToolStripMenuItem.Click += new System.EventHandler(this.listerFiliersToolStripMenuItem_Click);
            // 
            // groupesToolStripMenuItem
            // 
            this.groupesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterGroupeToolStripMenuItem,
            this.listerGroupesToolStripMenuItem});
            this.groupesToolStripMenuItem.Name = "groupesToolStripMenuItem";
            this.groupesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.groupesToolStripMenuItem.Text = "Groupes";
            // 
            // ajouterGroupeToolStripMenuItem
            // 
            this.ajouterGroupeToolStripMenuItem.Name = "ajouterGroupeToolStripMenuItem";
            this.ajouterGroupeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ajouterGroupeToolStripMenuItem.Text = "Ajouter Groupe";
            this.ajouterGroupeToolStripMenuItem.Click += new System.EventHandler(this.ajouterGroupeToolStripMenuItem_Click);
            // 
            // listerGroupesToolStripMenuItem
            // 
            this.listerGroupesToolStripMenuItem.Name = "listerGroupesToolStripMenuItem";
            this.listerGroupesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.listerGroupesToolStripMenuItem.Text = "Lister Groupes";
            this.listerGroupesToolStripMenuItem.Click += new System.EventHandler(this.listerGroupesToolStripMenuItem_Click);
            // 
            // stagiairesToolStripMenuItem
            // 
            this.stagiairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterStagiaireToolStripMenuItem,
            this.listerToolStripMenuItem});
            this.stagiairesToolStripMenuItem.Name = "stagiairesToolStripMenuItem";
            this.stagiairesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.stagiairesToolStripMenuItem.Text = "Stagiaires";
            // 
            // ajouterStagiaireToolStripMenuItem
            // 
            this.ajouterStagiaireToolStripMenuItem.Name = "ajouterStagiaireToolStripMenuItem";
            this.ajouterStagiaireToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ajouterStagiaireToolStripMenuItem.Text = "Ajouter Stagiaire";
            this.ajouterStagiaireToolStripMenuItem.Click += new System.EventHandler(this.ajouterStagiaireToolStripMenuItem_Click);
            // 
            // listerToolStripMenuItem
            // 
            this.listerToolStripMenuItem.Name = "listerToolStripMenuItem";
            this.listerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.listerToolStripMenuItem.Text = "Lister Stagiaires";
            this.listerToolStripMenuItem.Click += new System.EventHandler(this.listerToolStripMenuItem_Click);
            // 
            // faceRecoToolStripMenuItem
            // 
            this.faceRecoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.faceRecoToolStripMenuItem.Name = "faceRecoToolStripMenuItem";
            this.faceRecoToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.faceRecoToolStripMenuItem.Text = "FaceReco";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 531);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerFiliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterGroupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerGroupesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stagiairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterStagiaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faceRecoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

