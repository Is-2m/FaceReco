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
    public partial class Form_AddFilier : Form
    {
        Filiere Fil;
        public Form_AddFilier(Filiere fil)
        {
            Fil = fil;
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fil == null)
                    Create();
                else
                    Modify();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "L'ajoute d'un Filiere", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool CheckExistence()
        {
            var exist = Program.dc.Filieres.Any(obj => obj.nomF.ToUpper() == txt_nomF.Text.ToUpper());
            return exist;
        }
        void Create()
        {
            if (!CheckExistence())
            {
                var lastFilier = Program.dc.Filieres.OrderByDescending(obj => obj.idF).FirstOrDefault();
                int lastGivenId = lastFilier == null ? 0 : lastFilier.idF;
                Filiere f = Program.dc.Filieres.Create();

                f.idF = lastGivenId + 1;
                f.nomF = txt_nomF.Text.ToUpper();
                f.intitule = txt_intitule.Text;

                Program.dc.Filieres.Add(f);
                Program.dc.SaveChanges();
                MessageBox.Show("Créé avec Succès", "L'ajoute d'un Filiere", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                throw new Exception("Filière exist déjà");
            }
        }

        void Modify()
        {
            Fil.nomF = txt_nomF.Text;
            Fil.intitule = txt_intitule.Text;
            Program.dc.SaveChanges();
            MessageBox.Show("Edité avec succès", "L'édition d'un Filiere", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void show_infos()
        {
            txt_intitule.Text = Fil.intitule;
            txt_nomF.Text = Fil.nomF.ToString();
        }
        private void Form_AddFilier_Load(object sender, EventArgs e)
        {
            if (Fil != null)
                show_infos();
            LoadTheme();
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
        }
    }
}
