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
        Graphics graph;
        int currentHour = DateTime.Now.Hour;
        public List<presenceHistory> tempPresenceHistories = new List<presenceHistory>();
        FaceRecognition fr = Program.fr;
        List<FaceEncoding> lstEncods = Program.lstEncods;
        private VideoCapture videoCapture;
        readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(Path.Combine(Environment.CurrentDirectory, @"haarcascade_frontalface_alt_tree.xml"));
        public Form_FaceReco()
        {

            InitializeComponent();
        }

        private void Form_FaceReco_Load(object sender, EventArgs e)
        {
            loadTempPresence();
            if (videoCapture == null)
            {
                videoCapture = new VideoCapture(0);
            }
        }
        int frm = 0;

        private void btn_Detect_Click(object sender, EventArgs e)
        {
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
            var rects = cascadeClassifier.DetectMultiScale(m, 1.1, 3, Size.Empty, Size.Empty);
            Pen p = new Pen(Color.Green, 3);
            graph = Graphics.FromImage(bp);
            foreach (var rect in rects)
            {
                graph.DrawRectangle(p, rect);
            }

            var bp2 = new Bitmap(bp, bp.Width / 4, bp.Height / 4);

            frm++;
            if (frm == 5)
            {
                frm = 0;
                new Task(() => { NewMeth(bp2); }).Start();
                //NewMeth(bp2);

            }

            //newMeth(bp2);
            pb_live.Image = bp;

            //}
            //catch (Exception)
            //{ /*SetText(""); */}
        }

        private void Form_FaceReco_FormClosing(object sender, FormClosingEventArgs e)
        {
            pushTempPresenceHistoriesToDB();
        }
        private void NewMeth(Bitmap bp)
        {

            var img = FaceRecognition.LoadImage(bp);
            var loc = fr.FaceLocations(img);
            if (loc.Count() != 0)
            {
                //MessageBox.Show("FaceDetected");
                //foreach (var l in loc)
                //{

                //    graph.DrawRectangle(Pens.Green, l.Left * 4, l.Top * 4, (l.Right - l.Left) * 4, (l.Bottom - l.Top) * 4);
                //}
                IEnumerable<FaceEncoding> encd = fr.FaceEncodings(img, loc);
                const double tolerance = 0.5d;
                bool isFound = false;

                for (int i = 0; i < lstEncods.Count; i++)
                {
                    for (int j = 0; j < encd.Count(); j++)
                    {
                        if (FaceRecognition.CompareFace(encd.ElementAt(j), lstEncods[i], tolerance))
                        {
                            //MessageBox.Show("FaceKnowen");
                            //graph.DrawString(Path.GetFileName(lstImgs[i]), new Font("Tahoma", 20), Brushes.Black, new System.Drawing.Point(loc.ElementAt(j).Left * 4 + 2, loc.ElementAt(j).Top * 4 - 35));
                            isFound = true;
                            var s = String.Join(",", lstEncods[i].GetRawEncoding());
                            //new Task(() => { addToPresenceHistory(s); }).Start();
                            addToPresenceHistory(s);

                            break;

                        }

                    }


                }

                //SwitchMode(isFound);
                //new Task(() => { SwitchMode(isFound); }).Start();



                kda(isFound);


                if (!isFound)
                {
                    try
                    {
                        //String pth = Application.StartupPath + $@"\unknowen Images\";
                        //MessageBox.Show(pth);
                        //pb_live.Image.Sa
                        //File.Move(Path.Combine(Directory.GetCurrentDirectory(),fileName), Path.Combine(Directory.GetCurrentDirectory(), $@"\unknowen Images\", fileName) );
                        var d = DateTime.Now;
                        addToPresenceHistory("");
                        String fileName = $"Inconnu {d.Year}{d.Month}{d.Day}{d.Hour}{d.Minute}{d.Second}{d.Millisecond}.png";
                        Directory.CreateDirectory(Application.StartupPath + $@"\unknowen Images\");
                        bp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        File.Move(Application.StartupPath + $@"\{fileName}", Application.StartupPath + $@"\unknowen Images\" + fileName);
                    }
                    catch (Exception ex)
                    { }
                }




                //FaceRe(bp);
            }
            //else
            //{
            //    SwitchMode();
            //}
        }
        void addToPresenceHistory(string strEncod)
        {
            try
            {
                if (currentHour != DateTime.Now.Hour)
                {
                    pushTempPresenceHistoriesToDB();
                    currentHour = DateTime.Now.Hour;
                    tempPresenceHistories = new List<presenceHistory>();
                }
                if (strEncod == "")
                {
                    var entity = new presenceHistory();
                    entity.dateHistory = DateTime.Now;
                    entity.cef = "";
                }
                else
                {
                    var encod = Program.dc.stagiaireEncods.First(obj => obj.stringEncod == strEncod);
                    var entity = new presenceHistory();
                    entity.dateHistory = DateTime.Now;
                    entity.cef = encod.cef;
                    entity.Stagiaire = encod.Stagiaire;
                    if (!tempPresenceHistories.Any(e => e.cef == entity.cef))
                    {
                        tempPresenceHistories.Add(entity);
                    }
                }

            }
            catch (Exception)
            { }




        }
        void kda(bool isFound)
        {
            pan_red.Visible = !isFound;
            //pan_red.Enabled = !isFound;
            pan_green.Visible = isFound;
        }
        public void pushTempPresenceHistoriesToDB()
        {

            Program.dc.presenceHistories.AddRange(tempPresenceHistories);
            Program.dc.SaveChanges();
        }


        delegate void SetTextCallback(bool b);

        private void SwitchMode(bool b)
        {
            MessageBox.Show("inside");
            if (this.pan_green.InvokeRequired)
            {
                MessageBox.Show("in if");
                SetTextCallback d = new SetTextCallback(SwitchMode);
                this.Invoke(d, new object[] { b });
            }
            else
            {
                MessageBox.Show("in else");
                this.pan_red.Visible = !b;
                this.pan_green.Visible = b;

            }
        }
        //private void SwitchMode(int a)
        //{
        //    if (this.pan_green.InvokeRequired)
        //    {
        //        SetTextCallback d = new SetTextCallback(SwitchMode);
        //        this.Invoke(d, new object[] { a });
        //    }
        //    else
        //    {
        //        this.pan_red.Visible = true;
        //        this.pan_green.Visible = true;

        //    }
        //}

        private void btn_stop_Click(object sender, EventArgs e)
        {
            stop();
        }
        void stop()
        {
            videoCapture.Dispose();

            pb_live.Image = null;
            pan_red.Visible = false;
            pan_green.Visible = false;
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (btn_pause.Text == "&Pause")
            {
                videoCapture.Pause();
                btn_pause.Text = "&Start";
            }
            else
            {
                videoCapture.Start();
            }
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            stop();
            this.Close();
        }

    }
}
