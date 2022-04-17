using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognitionDotNet;
using Emgu.CV;
using System.Drawing;
using Emgu.CV.Structure;
using FR_Image = FaceRecognitionDotNet.Image;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Emgu.CV.CvEnum;
using System.IO;
using System.Windows;
using System.Timers;
using System.Runtime.CompilerServices;
using Emgu.CV.Face;
using Emgu.CV.Util;
using Microsoft.Win32;
using System.Drawing.Drawing2D;


namespace FaceReco
{
    public partial class Form_FaceReco : Form
    {
        #region Variables 
        Graphics graph;
        int frm = 0;
        int currentHour = DateTime.Now.Hour;
        public List<presenceHistory> tempPresenceHistories = new List<presenceHistory>();
        FaceRecognition fr = Program.fr;
        List<FaceEncoding> lstEncods = Program.lstEncods;
        private VideoCapture videoCapture;
        readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(Path.Combine(Environment.CurrentDirectory, @"haarcascade_frontalface_alt_tree.xml"));
        #endregion

        public Form_FaceReco()
        {

            InitializeComponent();
        }

        #region Events
        private void Form_FaceReco_Load(object sender, EventArgs e)
        {
            Program.loadEncodings();
            lstEncods = Program.lstEncods;
            loadTempPresence();
        }

        private void btn_Detect_Click(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture(0);
            videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
            videoCapture.Start();
        }
        private void VideoCapture_ImageGrabbed(object sender, EventArgs e)
        {
            //try
            //{
            Mat m = new Mat();
            videoCapture.Retrieve(m);

            byte[] bytes = m.ToImage<Bgr, byte>().ToJpegData();
            Bitmap bp = (Bitmap)((new ImageConverter()).ConvertFrom(bytes));
            //var rects = cascadeClassifier.DetectMultiScale(m, 1.1, 3, Size.Empty, Size.Empty);
            var rects = cascadeClassifier.DetectMultiScale(m, 1.1, 4);
            Pen p = new Pen(Color.Green, 3);
            graph = Graphics.FromImage(bp);
            foreach (var rect in rects)
            {
                graph.DrawRectangle(p, rect);
            }

            var bp2 = new Bitmap(bp, bp.Width / 4, bp.Height / 4);

            frm++;
            if (frm == 10)
            {
                frm = 0;
                new Task(() => { FaceChecking(bp2, bp); }).Start();

            }

            pb_live.Image = bp;

            //}
            //catch (Exception)
            //{ /*SetText(""); */}
        }

        private void Form_FaceReco_FormClosing(object sender, FormClosingEventArgs e)
        {
            pushTempPresenceHistoriesToDB();
        }
        private void FaceChecking(Bitmap bp, Bitmap OrgBp)
        {

            var img = FaceRecognition.LoadImage(bp);
            var loc = fr.FaceLocations(img);
            if (loc.Count() != 0)
            {
                IEnumerable<FaceEncoding> encd = fr.FaceEncodings(img, loc);
                const double tolerance = 0.5d;
                bool isFound = false;
                string strEncod = "";
                for (int i = 0; i < lstEncods.Count; i++)
                {
                    for (int j = 0; j < encd.Count(); j++)
                    {
                        if (FaceRecognition.CompareFace(encd.ElementAt(j), lstEncods[i], tolerance))
                        {
                            isFound = true;
                            var s = String.Join(",", lstEncods[i].GetRawEncoding());
                            strEncod = s;
                            addToPresenceHistory(strEncod: s);
                            break;
                        }
                    }
                }
                switchPanels(isFound, strEncod);
                if (!isFound)
                {
                    try
                    {
                        var d = DateTime.Now;
                        String fileName = $"Inconnu {d.Year}{d.Month}{d.Day}{d.Hour}{d.Minute}{d.Second}{d.Millisecond}.png";

                        addToPresenceHistory(strEncod: String.Join(",", encd.First().GetRawEncoding()), dt: d, cef: fileName.Replace(".png", ""));


                        Stagiaire s = new Stagiaire();
                        s.CEF = fileName.Replace(".png", "");
                        s.stringEncod = String.Join(",", encd.First().GetRawEncoding());
                        s.nom = "inconnu";
                        s.prenom = "inconnu";
                        Program.dc.Stagiaires.Add(s);
                        Program.dc.SaveChanges();
                        Program.loadEncodings();
                        this.lstEncods = Program.lstEncods;

                        Directory.CreateDirectory(Application.StartupPath + $@"\unknowen Images\");
                        OrgBp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        File.Move(Application.StartupPath + $@"\{fileName}", Application.StartupPath + $@"\unknowen Images\" + fileName);
                    }
                    catch (Exception ex)
                    { }
                }
            }
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            stop();
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (videoCapture.IsOpened && btn_pause.Text == "&Pause")
            {
                videoCapture.Pause();
                btn_pause.Text = "&Start";
            }
            else if (videoCapture.IsOpened && btn_pause.Text == "&Start")
            {
                btn_pause.Text = "&Pause";
                videoCapture.Start();
            }
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            stop();
            this.Close();
        }
        #endregion
        #region Methods
        void addToPresenceHistory(string strEncod = "", DateTime? dt = null, string cef = "")
        {
            try
            {
                if (currentHour != DateTime.Now.Hour)
                {
                    pushTempPresenceHistoriesToDB();
                    currentHour = DateTime.Now.Hour;
                    tempPresenceHistories = new List<presenceHistory>();
                }
                var Stgr = Program.dc.Stagiaires.First(obj => obj.stringEncod == strEncod);
                var entity = new presenceHistory();
                entity.dateHistory = dt == null ? DateTime.Now : dt.Value;
                entity.cef = cef != "" ? cef : Stgr.CEF;
                if (!tempPresenceHistories.Any(e => e.cef == entity.cef))
                {
                    tempPresenceHistories.Add(entity);
                }
            }
            catch (Exception)
            { }
        }
        void switchPanels(bool isFound, string strEncod = "")
        {
            try
            {
                pan_red.Invoke((MethodInvoker)(() => pan_red.Visible = !isFound));
                pan_green.Invoke((MethodInvoker)(() => pan_green.Visible = isFound));
                if (isFound && strEncod != "")
                {
                    var Stgr = Program.dc.Stagiaires.First(obj => obj.stringEncod == strEncod);

                    txt_CEF.Invoke((MethodInvoker)(() => txt_CEF.Text = Stgr.CEF));
                    txt_Cin.Invoke((MethodInvoker)(() => txt_Cin.Text = Stgr.cin == null ? "null" : Stgr.cin));
                    txt_Nom.Invoke((MethodInvoker)(() => txt_Nom.Text = Stgr.nom));
                    txt_Prenom.Invoke((MethodInvoker)(() => txt_Prenom.Text = Stgr.prenom));
                    txt_ville.Invoke((MethodInvoker)(() => txt_ville.Text = Stgr.ville == null ? "null" : Stgr.ville));
                    txt_addresse.Invoke((MethodInvoker)(() => txt_addresse.Text = Stgr.adresse == null ? "null" : Stgr.adresse));

                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void pushTempPresenceHistoriesToDB()
        {
            Program.dc.presenceHistories.AddRange(tempPresenceHistories);
            Program.dc.SaveChanges();
        }
        void stop()
        {
            videoCapture.Dispose();
            pb_live.Image = null;
            pan_red.Invoke((MethodInvoker)(() => pan_red.Visible = false));
            pan_green.Invoke((MethodInvoker)(() => pan_green.Visible = false));
        }
        void loadTempPresence()
        {
            if (Program.dc.presenceHistories.Count() != 0)
            {
                var today = DateTime.Now;
                var lst = Program.dc.presenceHistories.ToList().FindAll(e => (e.dateHistory.Date == today.Date) && (e.dateHistory.TimeOfDay.Hours == today.TimeOfDay.Hours));
                foreach (var item in lst)
                {
                    var p = new presenceHistory();
                    p.cef = item.cef;
                    p.dateHistory = item.dateHistory;
                    p.Stagiaire = item.Stagiaire;
                    tempPresenceHistories.Add(p);
                }
                Program.dc.presenceHistories.RemoveRange(lst);
            }
            else
            {
                tempPresenceHistories = new List<presenceHistory>();
            }
        }
        #endregion



    }
}
