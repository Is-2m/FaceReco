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

        FaceRecognition fr = Program.fr;
        List<FaceEncoding> lstEncods = Program.lstEncods;
        private VideoCapture videoCapture;
        List<String> lstImgs;
        readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(Path.Combine(Environment.CurrentDirectory, @"haarcascade_frontalface_alt_tree.xml"));
        public Form_FaceReco()
        {
            InitializeComponent();
        }

        private void Form_FaceReco_Load(object sender, EventArgs e)
        {
            //loadImages();
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
            try
            {
                Mat m = new Mat();
                videoCapture.Retrieve(m);

                byte[] bytes = m.ToImage<Bgr, byte>().ToJpegData();
                Bitmap bp = (Bitmap)((new ImageConverter()).ConvertFrom(bytes));
                var rects = cascadeClassifier.DetectMultiScale(m, 1.1, 3, Size.Empty, Size.Empty);
                graph = Graphics.FromImage(bp);
                foreach (var rect in rects)
                {
                    graph.DrawRectangle(Pens.Green, rect);
                }

                var bp2 = new Bitmap(bp, bp.Width / 4, bp.Height / 4);

                frm++;
                if (frm == 5)
                {
                    frm = 0;
                    new Task(() => { newMeth(bp2); }).Start();

                }

                //newMeth(bp2);
                pb_live.Image = bp;

            }
            catch (Exception)
            { /*SetText(""); */}
        }

        private void Form_FaceReco_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private async Task newMeth(Bitmap bp)
        {

            var img = FaceRecognition.LoadImage(bp);
            var loc = fr.FaceLocations(img);
            if (loc.Count() != 0)
            {
                foreach (var l in loc)
                {

                    graph.DrawRectangle(Pens.Green, l.Left * 4, l.Top * 4, (l.Right - l.Left) * 4, (l.Bottom - l.Top) * 4);
                }
                IEnumerable<FaceEncoding> encd = fr.FaceEncodings(img, loc);
                const double tolerance = 0.5d;
                //IEnumerable<FaceEncoding> enumEncod = lstEncods;
                bool isFound = false;

                for (int i = 0; i < lstEncods.Count; i++)
                {
                    for (int j = 0; j < encd.Count(); j++)
                    {
                        if (FaceRecognition.CompareFace(encd.ElementAt(j), lstEncods[i], tolerance))
                        {
                            //graph.DrawString(Path.GetFileName(lstImgs[i]), new Font("Tahoma", 20), Brushes.Black, new System.Drawing.Point(loc.ElementAt(j).Left * 4 + 2, loc.ElementAt(j).Top * 4 - 35));
                            isFound = true;
                            //var entity = new presenceHistory();
                            //var s =String.Join(",", lstEncods[i].GetRawEncoding());
                            //var encod = Program.dc.stagiaireEncods.First(obj => obj.stringEncod == s);
                            //entity.cef = encod.cef;
                            //entity.Stagiaire = encod.Stagiaire;
                            //entity.dateHistory = DateTime.Now;
                            //Program.dc.presenceHistories.InsertOnSubmit(entity);
                            //Program.dc.SubmitChanges();
                            break;
                        }

                    }


                }


                //SetText(Path.GetFileName(lstImgs[indexMatch]));

                SwitchMode(isFound);

                //FaceRe(bp);
            }
            else
            {
                SwitchMode(0);
            }
        }

        private void FaceRe(Bitmap bp)
        {
            var img = FaceRecognition.LoadImage(bp);
            //bp.Dispose();
            try
            {
                var locationsA = fr.FaceLocations(img);
                IEnumerable<FaceEncoding> encodingA = fr.FaceEncodings(img, locationsA);
                const double tolerance = 0.5d;

                int indexMatch = -1;
                for (int i = 0; i < lstEncods.Count; i++)
                {
                    if (FaceRecognition.CompareFace(encodingA.First(), lstEncods[i], tolerance))
                    {
                        indexMatch = i;
                        break;
                    }
                }

                //SetText(Path.GetFileName(lstImgs[indexMatch]));
            }
            catch (Exception) { }
            //{ SetText(""); }

        }

        delegate void SetTextCallback(bool b);

        private void SwitchMode(bool b)
        {
            if (this.pan_green.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SwitchMode);
                this.Invoke(d, new object[] { b });
            }
            else
            {
                
                    this.pan_red.Visible = !b;
                    this.pan_green.Visible = b;

            }
        }
        private void SwitchMode(int a)
        {
            if (this.pan_green.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SwitchMode);
                this.Invoke(d, new object[] { a });
            }
            else
            {
                this.pan_red.Visible = true;
                this.pan_green.Visible = true;

            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            videoCapture.Dispose();
            pb_live.Image = null;

            pan_red.Visible = true;
            pan_green.Visible = true;
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
    }
}
