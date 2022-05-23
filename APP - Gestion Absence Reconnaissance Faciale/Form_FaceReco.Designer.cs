
namespace FaceReco
{
    partial class Form_FaceReco
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
            this.btn_Detect = new System.Windows.Forms.Button();
            this.pb_live = new System.Windows.Forms.PictureBox();
            this.pan_green = new System.Windows.Forms.Panel();
            this.pan_red = new System.Windows.Forms.Panel();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_addresse = new System.Windows.Forms.TextBox();
            this.txt_ville = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Cin = new System.Windows.Forms.TextBox();
            this.txt_CEF = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pb_live)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Detect
            // 
            this.btn_Detect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Detect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Detect.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detect.Location = new System.Drawing.Point(14, 17);
            this.btn_Detect.Name = "btn_Detect";
            this.btn_Detect.Size = new System.Drawing.Size(75, 23);
            this.btn_Detect.TabIndex = 0;
            this.btn_Detect.Text = "&Detect";
            this.btn_Detect.UseVisualStyleBackColor = true;
            this.btn_Detect.Click += new System.EventHandler(this.btn_Detect_Click);
            // 
            // pb_live
            // 
            this.pb_live.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_live.BackColor = System.Drawing.Color.Gainsboro;
            this.pb_live.Location = new System.Drawing.Point(12, 12);
            this.pb_live.Name = "pb_live";
            this.pb_live.Size = new System.Drawing.Size(522, 474);
            this.pb_live.TabIndex = 1;
            this.pb_live.TabStop = false;
            // 
            // pan_green
            // 
            this.pan_green.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pan_green.BackColor = System.Drawing.Color.LimeGreen;
            this.pan_green.Location = new System.Drawing.Point(14, 366);
            this.pan_green.Name = "pan_green";
            this.pan_green.Size = new System.Drawing.Size(120, 120);
            this.pan_green.TabIndex = 2;
            this.pan_green.Visible = false;
            // 
            // pan_red
            // 
            this.pan_red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pan_red.BackColor = System.Drawing.Color.Firebrick;
            this.pan_red.Location = new System.Drawing.Point(14, 366);
            this.pan_red.Name = "pan_red";
            this.pan_red.Size = new System.Drawing.Size(120, 120);
            this.pan_red.TabIndex = 3;
            this.pan_red.Visible = false;
            // 
            // btn_pause
            // 
            this.btn_pause.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pause.Location = new System.Drawing.Point(93, 17);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "&Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Poppins SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(172, 17);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "&Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Adresse :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cin :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "CEF :";
            // 
            // txt_addresse
            // 
            this.txt_addresse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addresse.Location = new System.Drawing.Point(65, 223);
            this.txt_addresse.Multiline = true;
            this.txt_addresse.Name = "txt_addresse";
            this.txt_addresse.ReadOnly = true;
            this.txt_addresse.Size = new System.Drawing.Size(197, 49);
            this.txt_addresse.TabIndex = 28;
            // 
            // txt_ville
            // 
            this.txt_ville.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ville.Location = new System.Drawing.Point(65, 197);
            this.txt_ville.Name = "txt_ville";
            this.txt_ville.ReadOnly = true;
            this.txt_ville.Size = new System.Drawing.Size(197, 20);
            this.txt_ville.TabIndex = 27;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Prenom.Location = new System.Drawing.Point(65, 171);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.ReadOnly = true;
            this.txt_Prenom.Size = new System.Drawing.Size(197, 20);
            this.txt_Prenom.TabIndex = 26;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Nom.Location = new System.Drawing.Point(65, 145);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.ReadOnly = true;
            this.txt_Nom.Size = new System.Drawing.Size(197, 20);
            this.txt_Nom.TabIndex = 25;
            // 
            // txt_Cin
            // 
            this.txt_Cin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Cin.Location = new System.Drawing.Point(65, 119);
            this.txt_Cin.Name = "txt_Cin";
            this.txt_Cin.ReadOnly = true;
            this.txt_Cin.Size = new System.Drawing.Size(197, 20);
            this.txt_Cin.TabIndex = 24;
            // 
            // txt_CEF
            // 
            this.txt_CEF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CEF.Location = new System.Drawing.Point(65, 93);
            this.txt_CEF.Name = "txt_CEF";
            this.txt_CEF.ReadOnly = true;
            this.txt_CEF.Size = new System.Drawing.Size(197, 20);
            this.txt_CEF.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pan_red);
            this.panel1.Controls.Add(this.pan_green);
            this.panel1.Controls.Add(this.txt_addresse);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_Detect);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_pause);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_CEF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Cin);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Nom);
            this.panel1.Controls.Add(this.txt_Prenom);
            this.panel1.Controls.Add(this.txt_ville);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(543, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 500);
            this.panel1.TabIndex = 35;
            // 
            // Form_FaceReco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pb_live);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_FaceReco";
            this.Text = "Detection Présence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FaceReco_FormClosing);
            this.Load += new System.EventHandler(this.Form_FaceReco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_live)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Detect;
        private System.Windows.Forms.PictureBox pb_live;
        private System.Windows.Forms.Panel pan_green;
        private System.Windows.Forms.Panel pan_red;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_addresse;
        private System.Windows.Forms.TextBox txt_ville;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Cin;
        private System.Windows.Forms.TextBox txt_CEF;
        private System.Windows.Forms.Panel panel1;
    }
}