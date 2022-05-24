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
    public partial class Form_PresenceSheet : Form
    {
        public Form_PresenceSheet()
        {
            InitializeComponent();
        }

        private void Form_PresenceSheet_Load(object sender, EventArgs e)
        {
            cb_type.SelectedIndex = 0;
            LoadTheme();
            refresh(0, DateTime.Now);
        }
        void refresh(int i, DateTime dt)
        {
            dgv_presence.Rows.Clear();
            var lstPres = Program.dc.presenceHistories.ToList().FindAll(ph => (ph.dateHistory.Value.Date == dt.Date && ph.Stagiaire != null));
            if (i == 0)
            {
                foreach (var item in lstPres)
                {
                    dgv_presence.Rows.Add(item.cef == null ? "null" : item.cef.ToString(), item.Stagiaire == null ? "null" : item.Stagiaire.nom, item.Stagiaire == null ? "null" : item.Stagiaire.prenom, item.dateHistory);
                }
                lbl_Total.Text = lstPres.Count.ToString();
            }
            else if (i == 1)
            {
                var PresIds = lstPres.Select(ph => ph.cef).ToList();
                var lstAbs = Program.dc.Stagiaires.Where(s => !PresIds.Contains(s.CEF));
                foreach (var item in lstAbs)
                {
                    dgv_presence.Rows.Add(item.CEF, item.nom, item.prenom, dt.Date);
                }
                lbl_Total.Text = lstAbs.Count().ToString();
            }
            else if (i == 2)
            {
                var lstIntr = Program.dc.presenceHistories.ToList().Where(ph => (ph.dateHistory.Value.Date == dt.Date && ph.Intruder != null));
                foreach (var item in lstIntr)
                {
                    dgv_presence.Rows.Add(item.cef == null ? item.idIntr : item.cef.ToString(), item.Stagiaire == null ? "null" : item.Stagiaire.nom, item.Stagiaire == null ? "null" : item.Stagiaire.prenom, item.dateHistory);
                }
                lbl_Total.Text = lstIntr.Count().ToString();
            }

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
            cb_type.BackColor = ThemeColor.PrimaryColor;
            cb_type.ForeColor = Color.White;
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh(cb_type.SelectedIndex, dtp.Value);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {

            refresh(cb_type.SelectedIndex, dtp.Value);
        }
    }
}
