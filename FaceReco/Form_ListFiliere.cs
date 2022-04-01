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
    public partial class Form_ListFiliere : Form
    {
        public Form_ListFiliere()
        {
            InitializeComponent();
        }

        private void Form_ListFiliere_Load(object sender, EventArgs e)
        {
            Fil_Refresh();
        }
        private void Fil_Refresh()
        {
            dgv_Fil.Rows.Clear();
            foreach (var flr in Program.dc.Filiers)
            {
                dgv_Fil.Rows.Add(flr.nomF, flr.intitule);
            }

        }
        private void Grp_Refresh()
        {
            dgv_Grp.Rows.Clear();

            int i = dgv_Fil.CurrentCell.RowIndex;
            string title = (string)dgv_Fil.Rows[i].Cells[0].Value;
            var flr = Program.dc.Filiers.FirstOrDefault(obj => obj.nomF == title);
            if (flr != null)
            {
                foreach (var g in flr.Groupes)
                {
                    dgv_Grp.Rows.Add(title + " " + g.numG, g.Stagiaires.Count);
                }
            }

            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Fil_SelectionChanged(object sender, EventArgs e)
        {
            Grp_Refresh();
        }

        private void btn_Add_Fil_Click(object sender, EventArgs e)
        {
            var f = new Form_AddFilier(null);
            f.ShowDialog();
            Fil_Refresh();
        }

        private void btn_Add_Grp_Click(object sender, EventArgs e)
        {
            var f = new Form_AddGroupe(null);
            f.ShowDialog();
            Grp_Refresh();
        }

        private void btn_Del_Fil_Click(object sender, EventArgs e)
        {
            int pos = dgv_Fil.CurrentCell.RowIndex;
            string nomF = dgv_Fil.Rows[pos].Cells[0].Value.ToString();
            DialogResult r = MessageBox.Show("Voulez-vous supprimer cette sauvegarde?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                var fil = Program.dc.Filiers.First(obj => obj.nomF==nomF);
                Program.dc.Filiers.Remove(fil);
                dgv_Fil.Rows.RemoveAt(pos);
                //Program.dc.SubmitChanges();
            }
        }

        private void btn_Del_Grp_Click(object sender, EventArgs e)
        {
            int pos = dgv_Grp.CurrentCell.RowIndex;
            string nomF = dgv_Grp.Rows[pos].Cells[0].Value.ToString();
            string[] NomfNumG = nomF.Split(' ');
            DialogResult r = MessageBox.Show("Voulez-vous supprimer cette sauvegarde?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                var grp = Program.dc.Groupes.First(obj => obj.Filier.nomF.ToUpper() == NomfNumG[0].ToUpper() && obj.numG == int.Parse(NomfNumG[1]));
                Program.dc.Groupes.Remove(grp);
                dgv_Grp.Rows.RemoveAt(pos);
                //Program.dc.SubmitChanges();
            }
        }

        private void btn_Save_Exite_Click(object sender, EventArgs e)
        {
            Program.dc.SaveChanges();
            this.Close();
        }

        private void btn_Edit_Fil_Click(object sender, EventArgs e)
        {
            int pos = dgv_Fil.CurrentRow.Index;
            string nomF = dgv_Fil.Rows[pos].Cells[0].Value.ToString().ToUpper();
            var fil = Program.dc.Filiers.First(obj => obj.nomF.ToUpper() == nomF);
            var f = new Form_AddFilier(fil);
            f.ShowDialog();
            Fil_Refresh();

        }

        private void btn_Edit_Grp_Click(object sender, EventArgs e)
        {
            int pos = dgv_Grp.CurrentRow.Index;
            string nomF = dgv_Grp.Rows[pos].Cells[0].Value.ToString();
            string[] name = nomF.Split(' ');
            var grp = Program.dc.Groupes.First(obj => obj.numG == int.Parse(name[1]) && obj.Filier.nomF.ToUpper() == name[0].ToUpper());
            var f = new Form_AddGroupe(grp);
            f.ShowDialog();
            Grp_Refresh();
        }
    }
}
