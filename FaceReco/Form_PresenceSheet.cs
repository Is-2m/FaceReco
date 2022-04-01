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
            refresh();
        }
        void refresh()
        {
            dgv_presence.Rows.Clear();
            foreach (var item in Program.dc.presenceHistories)
            {
                dgv_presence.Rows.Add(item.cef==null?"null": item.cef.ToString(), item.Stagiaire == null ? "null" : item.Stagiaire.nom, item.Stagiaire==null?"null":item.Stagiaire.prenom, item.dateHistory);
            }
        }
    }
}
