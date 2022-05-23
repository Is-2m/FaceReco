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
            LoadTheme();
            CB_Load();
            if (Grp != null)
                show_infos();
        }

        void CB_Load()
        {
            cb_Fil.Items.Clear();
            foreach (var f in Program.dc.Filieres)
            {
                cb_Fil.Items.Add(f.nomF);
            }
            cb_Fil.SelectedIndex = Program.dc.Filieres.Count() != 0 ? 0 : -1;
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
            var numG = txt_NumG.Text;
            var exist = Program.dc.Groupes.Any(obj => obj.Filiere.nomF.ToUpper() == nomF && obj.numG == numG);
            return exist;
        }
        void Create()
        {
            if (!CheckExist())
            {
                var f = Program.dc.Filieres.First(obj => obj.nomF.ToUpper() == cb_Fil.SelectedItem.ToString().ToUpper());
                var lastGroupe = Program.dc.Groupes.OrderByDescending(obj => obj.idG).FirstOrDefault();
                int lastGivenId = lastGroupe == null ? 0 : lastGroupe.idG;
                Groupe g = new Groupe();
                g.idG = ++lastGivenId;
                g.numG = txt_NumG.Text;
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
            Grp.numG = txt_NumG.Text;
            Program.dc.SaveChanges();
            MessageBox.Show("Edité avec succès", "L'édition d'un Groupe", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void show_infos()
        {
            txt_NumG.Text = Grp.numG.ToString();
            cb_Fil.Text = Grp.Filiere.nomF.ToUpper();
            cb_Fil.Enabled = false;
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
            cb_Fil.BackColor = ThemeColor.PrimaryColor;
        }

    }
}
