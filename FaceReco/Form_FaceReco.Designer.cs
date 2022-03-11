
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
            ((System.ComponentModel.ISupportInitialize)(this.pb_live)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Detect
            // 
            this.btn_Detect.Location = new System.Drawing.Point(540, 39);
            this.btn_Detect.Name = "btn_Detect";
            this.btn_Detect.Size = new System.Drawing.Size(75, 23);
            this.btn_Detect.TabIndex = 0;
            this.btn_Detect.Text = "&Detect";
            this.btn_Detect.UseVisualStyleBackColor = true;
            this.btn_Detect.Click += new System.EventHandler(this.btn_Detect_Click);
            // 
            // pb_live
            // 
            this.pb_live.BackColor = System.Drawing.Color.Gainsboro;
            this.pb_live.Location = new System.Drawing.Point(12, 12);
            this.pb_live.Name = "pb_live";
            this.pb_live.Size = new System.Drawing.Size(522, 474);
            this.pb_live.TabIndex = 1;
            this.pb_live.TabStop = false;
            // 
            // pan_green
            // 
            this.pan_green.BackColor = System.Drawing.Color.LimeGreen;
            this.pan_green.Location = new System.Drawing.Point(554, 354);
            this.pan_green.Name = "pan_green";
            this.pan_green.Size = new System.Drawing.Size(138, 132);
            this.pan_green.TabIndex = 2;
            this.pan_green.Visible = false;
            // 
            // pan_red
            // 
            this.pan_red.BackColor = System.Drawing.Color.Firebrick;
            this.pan_red.Location = new System.Drawing.Point(698, 354);
            this.pan_red.Name = "pan_red";
            this.pan_red.Size = new System.Drawing.Size(138, 132);
            this.pan_red.TabIndex = 3;
            this.pan_red.Visible = false;
            // 
            // Form_FaceReco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 498);
            this.Controls.Add(this.pan_red);
            this.Controls.Add(this.pan_green);
            this.Controls.Add(this.pb_live);
            this.Controls.Add(this.btn_Detect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_FaceReco";
            this.Text = "Form_FaceReco";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FaceReco_FormClosing);
            this.Load += new System.EventHandler(this.Form_FaceReco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_live)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Detect;
        private System.Windows.Forms.PictureBox pb_live;
        private System.Windows.Forms.Panel pan_green;
        private System.Windows.Forms.Panel pan_red;
    }
}