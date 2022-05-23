using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Imaging;
using FaceRecognitionDotNet;
using System.Data.Objects.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace FaceReco
{
    public partial class Form_AddStagiaire : Form
    {
        Graphics graph;
        VideoCapture videoCapture;
        String encode;
        FaceRecognition fr = Program.fr;
        Stagiaire Stgr;
        public Form_AddStagiaire(Stagiaire stgr)
        {
            Stgr = stgr;
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            videoCapture.Dispose();
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Stgr == null)
                    Create();
                else
                    Modify();
                Program.loadEncodings();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "L'ajoute d'un Stagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            videoCapture.Dispose();
            this.Close();
        }
        bool CheckExistence()
        {
            var exist = Program.dc.Stagiaires.Any(obj => obj.CEF == txt_CEF.Text);
            return exist;
        }

        void cbFilLoad()
        {
            cb_Fil.Items.Clear();
            foreach (var f in Program.dc.Filieres)
            {
                cb_Fil.Items.Add(f.nomF);
            }
            cb_Fil.SelectedIndex = Program.dc.Filieres.Count() != 0 ? 0 : -1;
        }

        private void Form_AddStagiaire_Load(object sender, EventArgs e)
        {
            LoadTheme();
            videoCapture = new VideoCapture(0);
            cbFilLoad();
            if (Stgr != null)
                show_infos();
        }

        private void cb_Fil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbGrpLoad();
        }

        void CbGrpLoad()
        {
            cb_Grp.Items.Clear();
            string text = cb_Fil.SelectedItem.ToString().ToUpper();
            var f = Program.dc.Filieres.First(obj => obj.nomF.ToUpper() == text);
            foreach (var g in f.Groupes)
            {
                cb_Grp.Items.Add(g.numG);
            }
            cb_Grp.SelectedIndex = f.Groupes.Count == 0 ? -1 : 0;
        }
        void Create()
        {
            if (!CheckExistence())
            {
                Stgr = new Stagiaire();
                Stgr.CEF = txt_CEF.Text;
                getInfosFromTxts();
                Program.dc.Stagiaires.Add(Stgr);
                Program.dc.SaveChanges();
                MessageBox.Show("Ajouter avec Succès", "L'ajoute d'un Stagiaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                throw new Exception("Stagiaire exist déjà");
            }
        }

        void Modify()
        {
            if (Stgr.CEF.Contains("Inconnu"))
            {
                var lstPH = new List<presenceHistory> (Stgr.presenceHistories);
                Program.dc.presenceHistories.RemoveRange(Stgr.presenceHistories);
                Program.dc.Stagiaires.Remove(Stgr);
                Program.dc.SaveChanges();
                Stgr.CEF = txt_CEF.Text;
                getInfosFromTxts();
                foreach (var history in lstPH)
                {
                    history.cef = Stgr.CEF;
                }
                Stgr.presenceHistories = lstPH;
                MessageBox.Show(Stgr.presenceHistories.Count().ToString(), "After");
                Program.dc.Stagiaires.Add(Stgr);
                Program.dc.presenceHistories.AddRange(lstPH);
            }
            else
                getInfosFromTxts();
            Program.dc.SaveChanges();
            MessageBox.Show("Edité avec succès", "L'édition d'un Stagiaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void getInfosFromTxts()
        {
            var selectedFiliere = Program.dc.Filieres.First(obj => obj.nomF == cb_Fil.SelectedItem.ToString());
            var selectedGroupe = selectedFiliere.Groupes.First(obj => obj.numG == cb_Grp.SelectedItem.ToString());
            Stgr.cin = txt_Cin.Text;
            Stgr.nom = txt_Nom.Text;
            Stgr.prenom = txt_Prenom.Text;
            Stgr.idG = selectedGroupe.idG;
            Stgr.ville = txt_ville.Text;
            Stgr.adresse = txt_addresse.Text;
            Stgr.stringEncod = encode;

        }

        void show_infos()
        {
            cb_Fil.Text = Stgr.Groupe == null ? "" : Stgr.Groupe.Filiere.nomF;
            cb_Grp.Text = Stgr.Groupe == null ? "" : Stgr.Groupe.numG.ToString();
            txt_CEF.Text = Stgr.CEF;
            txt_CEF.Enabled = Stgr.CEF.Contains("Inconnu");
            txt_Cin.Text = Stgr.cin == null ? "null" : Stgr.cin.ToString();
            txt_Nom.Text = Stgr.nom;
            txt_Prenom.Text = Stgr.prenom;
            txt_ville.Text = Stgr.ville == null ? "null" : Stgr.ville;
            txt_addresse.Text = Stgr.adresse == null ? "null" : Stgr.adresse;
            encode = Stgr != null ? Stgr.stringEncod : "";
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            btn_pause.Enabled = true;
            videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
            videoCapture.Start();
            btn_capture.Text = "re-Capturer Image";

        }

        private void VideoCapture_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                videoCapture.Retrieve(m);

                byte[] bytes = m.ToImage<Bgr, byte>().ToJpegData();
                Bitmap bp = (Bitmap)((new ImageConverter()).ConvertFrom(bytes));

                pb_live.SizeMode = PictureBoxSizeMode.StretchImage;

                graph = Graphics.FromImage(bp);
                Pen pG = new Pen(Color.Green, 6);

                var img = FaceRecognition.LoadImage(new Bitmap(bp, bp.Width / 4, bp.Height / 4));
                var loc = fr.FaceLocations(img);
                if (loc.Count() != 0)
                {
                    var l = loc.First();
                    graph.DrawRectangle(pG, l.Left * 4, l.Top * 4, (l.Right - l.Left) * 4, (l.Bottom - l.Top) * 4);
                    var bp2 = FaceRecognition.CropFaces(img, loc);
                    pb_face.Image = bp2.First().ToBitmap();
                    pb_face.SizeMode = PictureBoxSizeMode.StretchImage;
                    var encod = fr.FaceEncodings(img).First();
                    encode = String.Join(",", encod.GetRawEncoding());
                    videoCapture.Stop();
                }
                pb_live.Image = bp;

            }
            catch (Exception)
            { /*SetText(""); */}
        }


        private void btn_Import_Click(object sender, EventArgs e)
        {
            Bitmap bp;
            var ofd = new OpenFileDialog();
            ofd.Filter = "JPEG Files|*.jpg;*.jpeg;*.png|BMP Files |*.BMP;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bp = new Bitmap(ofd.FileName);
                pb_live.Image = bp;
                pb_live.SizeMode = PictureBoxSizeMode.StretchImage;

                graph = Graphics.FromImage(bp);
                Pen pG = new Pen(Color.Green, 6);

                var img = FaceRecognition.LoadImage(new Bitmap(bp, bp.Width / 4, bp.Height / 4));
                var loc = fr.FaceLocations(img);
                if (loc.Count() != 0)
                {
                    var l = loc.First();
                    graph.DrawRectangle(pG, l.Left * 4, l.Top * 4, (l.Right - l.Left) * 4, (l.Bottom - l.Top) * 4);
                    var bp2 = FaceRecognition.CropFaces(img, loc);
                    pb_face.Image = bp2.First().ToBitmap();
                    pb_face.SizeMode = PictureBoxSizeMode.StretchImage;
                    var encod = fr.FaceEncodings(img).First();
                    encode = String.Join(",", encod.GetRawEncoding());
                }


            }
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            videoCapture.Dispose();
            btn_pause.Enabled = false;
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

            }
            cb_Fil.BackColor = ThemeColor.PrimaryColor;
            cb_Fil.ForeColor = Color.White;
            cb_Grp.ForeColor = Color.White;
            cb_Grp.BackColor = ThemeColor.PrimaryColor;
        }
    }
}