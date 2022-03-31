﻿using System;
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
                    new Task(() => { NewMeth(bp2); }).Start();
                    //NewMeth(bp2);

                }

                //newMeth(bp2);
                pb_live.Image = bp;

            }
            catch (Exception)
            { /*SetText(""); */}
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


                //SetText(Path.GetFileName(lstImgs[indexMatch]));

                SwitchMode(isFound);

                //FaceRe(bp);
            }
            else
            {
                SwitchMode(0);
            }
        }
        void addToPresenceHistory(string strEncod)
        {


            if (currentHour != DateTime.Now.Hour)
            {
                pushTempPresenceHistoriesToDB();
                currentHour = DateTime.Now.Hour;
                tempPresenceHistories = new List<presenceHistory>();
            }
            var encod = Program.dc.stagiaireEncods.First(obj => obj.stringEncod == strEncod);
            var entity = new presenceHistory();
            entity.dateHistory = DateTime.Now;
            entity.cef = encod.cef;
            entity.Stagiaire = encod.Stagiaire;
            if (!tempPresenceHistories.Any(e => e.cef == entity.cef))
            {
                //MessageBox.Show("detecting "+tempPresenceHistories.Count.ToString());
                tempPresenceHistories.Add(entity);
            }


        }
        public void pushTempPresenceHistoriesToDB()
        {
            MessageBox.Show("temp " + tempPresenceHistories.Count.ToString());
            var lst = new List<presenceHistory>();
            foreach (var item in tempPresenceHistories)
            {
                if (lst.Count == 0 && !lst.Any(i => i.cef == item.cef))
                {
                    var p = new presenceHistory();
                    p.cef = item.cef;
                    p.dateHistory = item.dateHistory;
                    lst.Add(p);
                    MessageBox.Show("inside if " + lst.Count.ToString());
                }
            }
            MessageBox.Show("lst " + lst.Count.ToString());
            if (lst.Count == 1)
            {
                MessageBox.Show("1");
                MessageBox.Show(JsonConvert.SerializeObject(lst.First()));
                Program.dc.presenceHistories.Attach(lst.ToArray()[0]);
            }
            //else if (lst.Count > 1)
            //{
            //    MessageBox.Show("2");
            //    Program.dc.presenceHistories.InsertAllOnSubmit(lst);
            //}
            Program.dc.SubmitChanges();
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
                tempPresenceHistories = Program.dc.presenceHistories.ToList().FindAll(e => (e.dateHistory.Date == today.Date) && (e.dateHistory.TimeOfDay.Hours == today.TimeOfDay.Hours));
                Program.dc.presenceHistories.DeleteAllOnSubmit(tempPresenceHistories);
                Program.dc.SubmitChanges();
            }
            else
            {
                tempPresenceHistories = new List<presenceHistory>();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
