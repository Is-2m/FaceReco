using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognitionDotNet;

namespace FaceReco
{
    static class Program
    {
        public static FaceRecDataContext dc = new FaceRecDataContext();
        static public List<FaceEncoding> lstEncods=new List<FaceEncoding>();


        static public FaceRecognition fr;
        static public string dir = Path.Combine(Environment.CurrentDirectory, "models");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FaceRecognition.InternalEncoding = Encoding.GetEncoding("shift_jis");
            fr = FaceRecognition.Create(dir);
            loadEncodings();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_Form());

        }
        public static void loadEncodings()
        {
            if (dc.stagiaireEncods.Count() != 0)
            {
                foreach (var f in dc.stagiaireEncods)
                {
                    var doubleEncod = Array.ConvertAll(f.stringEncod.Split(','), Double.Parse);
                    lstEncods.Add(FaceRecognition.LoadFaceEncoding(doubleEncod));
                }
            }
        }
    }
}
