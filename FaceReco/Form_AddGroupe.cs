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
    public partial class Form_AddGroupe : Form
    {
        Groupe Grp;
        public Form_AddGroupe(Groupe grp)
        {
            Grp = grp;
            InitializeComponent();
        }

        private void Form_AddGroupe_Load(object sender, EventArgs e)
        {
            CB_Load();
            if (Grp != null)
                show_infos();
        }

        void CB_Load()
        {
            cb_Fil.Items.Clear();
            foreach (var f in Program.dc.Filiers)
            {
                cb_Fil.Items.Add(f.nomF);
            }
            cb_Fil.SelectedIndex = Program.dc.Filiers.Count() != 0 ? 0 : -1;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grp == null)
                    Create();
                else
                    Modify();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "L'ajoute d'un Groupe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        bool CheckExist()
        {
            string nomF = cb_Fil.SelectedItem.ToString().ToUpper();
            int numG = int.Parse(txt_NumG.Text);
            var exist = Program.dc.Groupes.Any(obj => obj.Filier.nomF.ToUpper() == nomF && obj.numG == numG);
            return exist;
        }
        void Create()
        {
            if (!CheckExist())
            {
                var f = Program.dc.Filiers.First(obj => obj.nomF.ToUpper() == cb_Fil.SelectedItem.ToString().ToUpper());
                var lastGroupe = Program.dc.Groupes.OrderByDescending(obj => obj.idG).FirstOrDefault();
                int lastGivenId = lastGroupe.idG;
                Groupe g = new Groupe();
                g.idG = ++lastGivenId;
                g.numG = int.Parse(txt_NumG.Text);
                g.idF = f.idF;
                Program.dc.Groupes.Add(g);
                Program.dc.SaveChanges();
                MessageBox.Show("Créé avec Succès", "L'ajoute d'un Groupe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                throw new Exception("Groupe exist déjà");
            }
        }

        void Modify()
        {
            Grp.numG = int.Parse(txt_NumG.Text);
            Program.dc.SaveChanges();
            MessageBox.Show("Edité avec succès", "L'édition d'un Groupe", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void show_infos()
        {
            txt_NumG.Text = Grp.numG.ToString();
            cb_Fil.Text = Grp.Filier.nomF.ToUpper();
            cb_Fil.Enabled = false;
        }

    }
}
