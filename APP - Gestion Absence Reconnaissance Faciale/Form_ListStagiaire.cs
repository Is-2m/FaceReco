using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FaceRecognitionDotNet;

namespace FaceReco
{
    public partial class Form_ListStagiaire : Form
    {
        public Form_ListStagiaire()
        {
            InitializeComponent();
        }

        private void btn_Add_Stgr_Click(object sender, EventArgs e)
        {
            var f = new Form_AddStagiaire(null);
            f.ShowDialog();
            Program.lstEncods = new List<FaceEncoding>();
            Program.loadEncodings();
            dgvLoad();
        }

        private void Form_ListStagiaire_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgvLoad();
        }
        void LoadTheme()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    Button btn = (Button)ctrl;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                if (ctrl.GetType() == typeof(Label))
                {
                    Label lbl = (Label)ctrl;
                    lbl.ForeColor = ThemeColor.SecondaryColor;
                    lbl.Font = new Font("Poppins SemiBold", lbl.Font.Size);
                }
                if (ctrl.GetType() == typeof(GroupBox))
                {
                    GroupBox groupBox = (GroupBox)ctrl;

                    foreach (Control btns in groupBox.Controls)
                    {
                        if (btns.GetType() == typeof(Button))
                        {
                            Button btn = (Button)btns;
                            btn.BackColor = ThemeColor.PrimaryColor;
                            btn.ForeColor = Color.White;
                            btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                        }
                    }
                }
            }
        }
        void dgvLoad()
        {
            dgv_stgr.Rows.Clear();
            foreach (var s in Program.dc.Stagiaires)
            {
                dgv_stgr.Rows.Add(s.CEF, s.cin, s.nom, s.prenom, s.Groupe == null ? "null" : s.Groupe.Filiere.nomF, s.Groupe == null ? "null" : s.Groupe.numG.ToString(), s.ville, s.adresse);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Del_Stgr_Click(object sender, EventArgs e)
        {
            int pos = dgv_stgr.CurrentCell.RowIndex;
            String cef = dgv_stgr.Rows[pos].Cells[0].Value.ToString();
            DialogResult r = MessageBox.Show("Voulez-vous supprimer cette sauvegarde?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                var stgr = Program.dc.Stagiaires.First(obj => obj.CEF == cef);
                Program.dc.Stagiaires.Remove(stgr);
                dgv_stgr.Rows.RemoveAt(pos);
                Program.dc.SaveChanges();
                Program.lstEncods = new List<FaceEncoding>();
                Program.loadEncodings();
            }

        }

        private void btn_Save_Exite_Click(object sender, EventArgs e)
        {

            Program.dc.SaveChanges();
            Program.loadEncodings();
            this.Close();
        }

        private void btn_Edit_Stgr_Click(object sender, EventArgs e)
        {
            int pos = dgv_stgr.CurrentCell.RowIndex;
            String cef = dgv_stgr.Rows[pos].Cells[0].Value.ToString();
            var stgr = Program.dc.Stagiaires.First(obj => obj.CEF == cef);
            var f = new Form_AddStagiaire(stgr);
            f.ShowDialog();
            Program.lstEncods = new List<FaceEncoding>();
            Program.loadEncodings();
            dgvLoad();
        }

        private void btn_del_dup_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "Supprimer les doublons en fonction des images sélectionnées";
            fileDialog.InitialDirectory = Application.StartupPath + $@"\unknowen Images\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> selectedImages = new List<string>();
                foreach (var item in fileDialog.FileNames)
                {
                    selectedImages.Add(Path.GetFileNameWithoutExtension(item));

                }
                if(MessageBox.Show("voulez-vous vraiment supprimer les stagiaires sélectionnés", "suppression des doublons", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var s in selectedImages)
                    {
                        var stgr = Program.dc.Stagiaires.Find(s);
                        if (stgr != null)
                        {
                            Program.dc.Stagiaires.Remove(stgr);
                        }
                    }
                    Program.dc.SaveChanges();
                    Program.lstEncods = new List<FaceEncoding>();
                    Program.loadEncodings();
                    dgvLoad();
                }
            }
        }

        private void Form_ListStagiaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.loadEncodings();
        }
    }
}
