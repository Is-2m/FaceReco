using FaceRecognitionDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceReco
{
    public partial class Form_LoadFacesToDB : Form
    {
        FaceRecognition fr = Program.fr;
        public Form_LoadFacesToDB()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "Select images to load...";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = Path.GetDirectoryName(fileDialog.FileNames[0]);
                foreach (var item in fileDialog.FileNames)
                {
                    var name = Path.GetFileNameWithoutExtension(item);
                    Stagiaire stgr = new Stagiaire();
                    var bp = new Bitmap(item);
                    var img = FaceRecognition.LoadImage(new Bitmap(bp,bp.Width/3,bp.Height/3));
                    var loc = fr.FaceLocations(img);
                    if (loc.Count() != 0)
                    {
                        var l = loc.First();
                        var encod = fr.FaceEncodings(img).First(); 
                        stgr.CEF = name.Replace(' ', '_') + new Random().Next(6546, 56456);
                        stgr.nom = name.Split(' ')[0];
                        stgr.prenom = name.Split(' ')[1];
                        stgr.stringEncod = String.Join(",", encod.GetRawEncoding());
                    }
                    Program.dc.Stagiaires.Add(stgr);
                    //selectedImages.Add(Path.GetFileNameWithoutExtension(item));
                }
                MessageBox.Show("Done loading Click save to apply the changes");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Program.dc.SaveChanges();
            this.Close();
        }
    }
}
