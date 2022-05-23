
namespace FaceReco
{
    partial class Form_LoadFacesToDB
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
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(38, 32);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(352, 20);
            this.txt_path.TabIndex = 0;
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_browse.Location = new System.Drawing.Point(427, 29);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "...";
            this.btn_browse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_browse.UseCompatibleTextRendering = true;
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_save.Location = new System.Drawing.Point(110, 109);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(123, 51);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseCompatibleTextRendering = true;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(299, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_LoadFacesToDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 206);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_path);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_LoadFacesToDB";
            this.Text = "Load Faces To DB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button2;
    }
}