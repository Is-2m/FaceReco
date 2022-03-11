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
    public partial class Form_AddStagiaire : Form
    {
        Stagiaire Stgr;
        public Form_AddStagiaire(Stagiaire stgr)
        {
           
            Stgr = stgr;
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Stgr == null)
                    Create();
                else
                    Modify();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "L'ajoute d'un Stagiaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }
        bool CheckExistence()
        {
            var exist = Program.dc.Stagiaires.Any(obj => obj.CEF == Int64.Parse(txt_CEF.Text));
            return exist;
        }

        void cbFilLoad()
        {
            cb_Fil.Items.Clear();
            foreach (var f in Program.dc.Filiers)
            {
                cb_Fil.Items.Add(f.nomF);
            }
            cb_Fil.SelectedIndex = Program.dc.Filiers.Count() != 0 ? 0 : -1;
        }

        private void Form_AddStagiaire_Load(object sender, EventArgs e)
        {
            cbFilLoad();
            if (Stgr != null)
                show_infos();
        }

        private void cb_Fil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbGrpLoad();
        }
        
        void CbGrpLoad()
        {
            cb_Grp.Items.Clear();
            string text = cb_Fil.SelectedItem.ToString().ToUpper();
            var f = Program.dc.Filiers.First(obj => obj.nomF.ToUpper() == text);
            foreach (var g in f.Groupes)
            {
                cb_Grp.Items.Add(g.numG);
            }
            cb_Grp.SelectedIndex = f.Groupes.Count == 0 ? -1 : 0;

        }
        void Create()
        {
            if (!CheckExistence())
            {
                var selectedFiliere = Program.dc.Filiers.First(obj => obj.nomF == cb_Fil.SelectedItem.ToString());
                var selectedGroupe = selectedFiliere.Groupes.First(obj => obj.numG == int.Parse(cb_Grp.SelectedItem.ToString()));
                Stagiaire s = new Stagiaire();
                s.CEF = Int64.Parse(txt_CEF.Text);
                s.cin = txt_Cin.Text;
                s.nom = txt_Nom.Text;
                s.prenom = txt_Prenom.Text;
                s.idG = selectedGroupe.idG;
                s.ville = txt_ville.Text;
                s.adresse = txt_addresse.Text;
                Program.dc.Stagiaires.InsertOnSubmit(s);
                Program.dc.SubmitChanges();
                MessageBox.Show("Ajouter avec Succès", "L'ajoute d'un Stagiaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                throw new Exception("Stagiaire exist déjà");
            }
        }

        void Modify()
        {
            var selectedFiliere = Program.dc.Filiers.First(obj => obj.nomF == cb_Fil.SelectedItem.ToString());
            var selectedGroupe = selectedFiliere.Groupes.First(obj => obj.numG == int.Parse(cb_Grp.SelectedItem.ToString()));
            Stgr.cin = txt_Cin.Text;
            Stgr.nom = txt_Nom.Text;
            Stgr.prenom = txt_Prenom.Text;
            Stgr.idG = selectedGroupe.idG;
            Stgr.ville = txt_ville.Text;
            Stgr.adresse = txt_addresse.Text;
            Program.dc.SubmitChanges();
            MessageBox.Show("Edité avec succès", "L'édition d'un Stagiaire", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void show_infos()
        {
            cb_Fil.Text = Stgr.Groupe.Filier.nomF;
            cb_Grp.Text = Stgr.Groupe.numG.ToString();
            txt_CEF.Text = Stgr.CEF.ToString();
            txt_CEF.Enabled = false;
            txt_Cin.Text = Stgr.cin.ToString();
            txt_Nom.Text = Stgr.nom;
            txt_Prenom.Text = Stgr.prenom;
            txt_ville.Text = Stgr.ville;
            txt_addresse.Text = Stgr.adresse;
        }
    }
}
