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
    public partial class Form_ListStagiaire : Form
    {
        public Form_ListStagiaire()
        {
            InitializeComponent();
        }

        private void btn_Add_Stgr_Click(object sender, EventArgs e)
        {
            var f = new Form_AddStagiaire(null);
            f.ShowDialog();
            dgvLoad();
        }

        private void Form_ListStagiaire_Load(object sender, EventArgs e)
        {
            dgvLoad();
        }

        void dgvLoad()
        {
            dgv_stgr.Rows.Clear();
            foreach (var s in Program.dc.Stagiaires)
            {
                dgv_stgr.Rows.Add(s.CEF, s.cin, s.nom, s.prenom, s.Groupe.Filier.nomF, s.Groupe.numG, s.ville, s.adresse);
            }
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Del_Stgr_Click(object sender, EventArgs e)
        {
            int pos = dgv_stgr.CurrentCell.RowIndex;
            long cef = long.Parse(dgv_stgr.Rows[pos].Cells[0].Value.ToString());
            DialogResult r = MessageBox.Show("Voulez-vous supprimer cette sauvegarde?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == r)
            {
                var stgr = Program.dc.Stagiaires.First(obj => obj.CEF == cef);
                Program.dc.Stagiaires.DeleteOnSubmit(stgr);
                dgv_stgr.Rows.RemoveAt(pos);
                //Program.dc.SubmitChanges();
            }
        }

        private void btn_Save_Exite_Click(object sender, EventArgs e)
        {

            Program.dc.SubmitChanges();
            this.Close();
        }

        private void btn_Edit_Stgr_Click(object sender, EventArgs e)
        {
            int pos = dgv_stgr.CurrentCell.RowIndex;
            long cef = long.Parse(dgv_stgr.Rows[pos].Cells[0].Value.ToString());
            var stgr = Program.dc.Stagiaires.First(obj => obj.CEF == cef);
            var f = new Form_AddStagiaire(stgr);
            f.ShowDialog();
            dgvLoad();
        }
    }
}
