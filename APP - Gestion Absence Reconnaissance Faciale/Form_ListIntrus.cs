using FaceRecognitionDotNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceReco
{
    public partial class Form_ListIntrus : Form
    {
        public Form_ListIntrus()
        {
            InitializeComponent();
        }

        private void Form_ListIntrus_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dgv_ref();
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
            //csb.OnBackColor = ThemeColor.PrimaryColor;
            //csb.OffBackColor= ThemeColor.SecondaryColor;

        }
        void dgv_ref()
        {
            dgv_Intru.Rows.Clear();
            var lst = from intru in Program.dc.Intruders
                      where intru.isUnknown == true
                      select intru;
            foreach (var item in lst)
            {
                var bp = new Bitmap(Bitmap.FromFile(Application.StartupPath + $@"\unknowen Images\" + item.idIntr + ".png"), 250, 250);
                dgv_Intru.Rows.Add(item.idIntr, bp);
            }
            dgv_Intru.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_Add_Stgr_Click(object sender, EventArgs e)
        {
            //try
            //{
            int pos = dgv_Intru.CurrentCell.RowIndex;
            String id = dgv_Intru.Rows[pos].Cells[0].Value.ToString();
            var Intr = Program.dc.Intruders.First(obj => obj.idIntr == id);
            var stgr = new Stagiaire();
            stgr.CEF = id;
            stgr.stringEncod = Intr.stringEncod;
            stgr.nom = "null";
            stgr.prenom = "null";

            foreach (var p in Intr.presenceHistories)
            {
                p.cef = p.idIntr;
            }
            stgr.presenceHistories = new List<presenceHistory>(Intr.presenceHistories); 

            Program.dc.Stagiaires.Add(stgr);
            Program.dc.Intruders.Remove(Intr);
            Program.dc.SaveChanges();

            var f = new Form_AddStagiaire(stgr);
            f.ShowDialog();

            Program.lstEncods = new List<FaceEncoding>();
            Program.loadEncodings();
            dgv_ref();

            //}
            //catch (Exception)
            //{

            //}
        }
    }
}
