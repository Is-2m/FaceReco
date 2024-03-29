﻿using System;
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
    public partial class Form_ListGroupe : Form
    {
        public Form_ListGroupe()
        {
            InitializeComponent();
        }

        private void Form_ListGroupe_Load(object sender, EventArgs e)
        {
            LoadTheme();
            Grp_Refresh();
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
        }
        void Grp_Refresh()
        {
            dgv_Grp.Rows.Clear();
            foreach (var g in Program.dc.Groupes)
            {
                dgv_Grp.Rows.Add(g.Filiere != null ? g.Filiere.nomF : "" + " " + g.numG, g.Stagiaires.Count, g.idG);
            }
        }

        void Stgr_Refresh()
        {
            try
            {
                dgv_stgr.Rows.Clear();
                int pos = dgv_Grp.CurrentCell.RowIndex;
                string text = (string)dgv_Grp.Rows[pos].Cells[0].Value;
                string[] title = text.Split(' ');
                var grp = Program.dc.Groupes.First(obj => obj.Filiere.nomF == title.First() && obj.numG == title.Last());
                if (grp != null)
                {
                    foreach (var s in grp.Stagiaires)
                    {
                        dgv_stgr.Rows.Add(s.CEF, s.cin, s.nom.ToUpper(), s.prenom.ToUpper(), s.ville, s.adresse);
                    }
                }
            }
            catch (Exception)
            { }
        }


        private void btn_Add_Grp_Click(object sender, EventArgs e)
        {
            var f = new Form_AddGroupe(null);
            f.ShowDialog();
            Grp_Refresh();
        }

        private void btn_Add_Stgr_Click(object sender, EventArgs e)
        {
            var f = new Form_AddStagiaire(null);
            f.ShowDialog();
        }

        private void dgv_Grp_SelectionChanged(object sender, EventArgs e)
        {
            Stgr_Refresh();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Exite_Click(object sender, EventArgs e)
        {
            Program.dc.SaveChanges();
            this.Close();
        }

        private void btn_Del_Grp_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = dgv_Grp.CurrentCell.RowIndex;
                string nomF = dgv_Grp.Rows[pos].Cells[0].Value.ToString();
                string[] NomfNumG = nomF.Split(' ');
                DialogResult r = MessageBox.Show("Voulez-vous supprimer cette sauvegarde?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == r)
                {
                    var grp = Program.dc.Groupes.AsEnumerable().FirstOrDefault(obj => obj.Filiere.nomF.ToUpper() == NomfNumG.FirstOrDefault().ToUpper() && obj.numG == NomfNumG.LastOrDefault());
                    Program.dc.Groupes.Remove(grp);
                    dgv_Grp.Rows.RemoveAt(pos);
                    ////Program.dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Del_Stgr_Click(object sender, EventArgs e)
        {
            int pos = dgv_stgr.CurrentCell.RowIndex;
            String cef = dgv_stgr.Rows[pos].Cells[0].Value.ToString();
            DialogResult r = MessageBox.Show("Voulez-vous supprimer cette sauvegarde?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == r)
            {
                var stgr = Program.dc.Stagiaires.First(obj => obj.CEF == cef);
                Program.dc.Stagiaires.Remove(stgr);
                dgv_stgr.Rows.RemoveAt(pos);
            }
        }

        private void btn_Edit_Stgr_Click(object sender, EventArgs e)
        {
            int pos = dgv_stgr.CurrentCell.RowIndex;
            String cef = dgv_stgr.Rows[pos].Cells[0].Value.ToString();
            var stgr = Program.dc.Stagiaires.First(obj => obj.CEF == cef);
            var f = new Form_AddStagiaire(stgr);
            f.ShowDialog();
            Stgr_Refresh();
        }

        private void btn_Edit_Grp_Click(object sender, EventArgs e)
        {
            int pos = dgv_Grp.CurrentRow.Index;
            int grpNum = int.Parse(dgv_Grp.Rows[pos].Cells[2].Value.ToString());
            string nomF = dgv_Grp.Rows[pos].Cells[0].Value.ToString();
            string[] name = nomF.Split(' ');
            var grp = Program.dc.Groupes.First(obj => obj.idG == grpNum);
            var f = new Form_AddGroupe(grp);
            f.ShowDialog();

            Grp_Refresh();
        }
    }
}
