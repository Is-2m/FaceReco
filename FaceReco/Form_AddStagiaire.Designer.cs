
namespace FaceReco
{
    partial class Form_AddStagiaire
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
            this.cb_Fil = new System.Windows.Forms.ComboBox();
            this.cb_Grp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CEF = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_Cin = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_addresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Fil
            // 
            this.cb_Fil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Fil.FormattingEnabled = true;
            this.cb_Fil.Location = new System.Drawing.Point(171, 30);
            this.cb_Fil.Name = "cb_Fil";
            this.cb_Fil.Size = new System.Drawing.Size(121, 21);
            this.cb_Fil.TabIndex = 0;
            this.cb_Fil.SelectedIndexChanged += new System.EventHandler(this.cb_Fil_SelectedIndexChanged);
            // 
            // cb_Grp
            // 
            this.cb_Grp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Grp.FormattingEnabled = true;
            this.cb_Grp.Location = new System.Drawing.Point(171, 57);
            this.cb_Grp.Name = "cb_Grp";
            this.cb_Grp.Size = new System.Drawing.Size(121, 21);
            this.cb_Grp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filiere :";
            // 
            // txt_CEF
            // 
            this.txt_CEF.Location = new System.Drawing.Point(171, 84);
            this.txt_CEF.Name = "txt_CEF";
            this.txt_CEF.Size = new System.Drawing.Size(121, 20);
            this.txt_CEF.TabIndex = 2;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(160, 264);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(89, 45);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "&Annuler";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(317, 264);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 45);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "&Enregistrer";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_Cin
            // 
            this.txt_Cin.Location = new System.Drawing.Point(171, 110);
            this.txt_Cin.Name = "txt_Cin";
            this.txt_Cin.Size = new System.Drawing.Size(121, 20);
            this.txt_Cin.TabIndex = 3;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(171, 136);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(197, 20);
            this.txt_Nom.TabIndex = 4;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(171, 162);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(197, 20);
            this.txt_Prenom.TabIndex = 5;
            // 
            // txt_ville
            // 
            this.txt_ville.Location = new System.Drawing.Point(171, 188);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.Size = new System.Drawing.Size(121, 20);
            this.txt_ville.TabIndex = 6;
            // 
            // txt_addresse
            // 
            this.txt_addresse.Location = new System.Drawing.Point(171, 214);
            this.txt_addresse.Name = "txt_addresse";
            this.txt_addresse.Size = new System.Drawing.Size(284, 20);
            this.txt_addresse.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "CEF :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nom :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prenom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ville :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Adresse :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Groupe :";
            // 
            // Form_AddStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 338);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_addresse);
            this.Controls.Add(this.txt_ville);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_Cin);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_CEF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Grp);
            this.Controls.Add(this.cb_Fil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AddStagiaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AddStagiaire";
            this.Load += new System.EventHandler(this.Form_AddStagiaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Fil;
        private System.Windows.Forms.ComboBox cb_Grp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CEF;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_Cin;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_addresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}