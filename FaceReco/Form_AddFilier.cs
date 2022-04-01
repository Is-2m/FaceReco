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
        Filier Fil;
        public Form_AddFilier(Filier fil)
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
            var exist = Program.dc.Filiers.Any(obj => obj.nomF.ToUpper() == txt_nomF.Text.ToUpper());
            return exist;
        }
        void Create()
        {
            if (!CheckExistence())
            {
                var lastFilier = Program.dc.Filiers.OrderByDescending(obj => obj.idF).FirstOrDefault();
                int lastGivenId = lastFilier.idF;
                Filier f = new Filier
                {
                    idF = lastGivenId + 1,
                    nomF = txt_nomF.Text.ToUpper(),
                    intitule = txt_intitule.Text
                };
                Program.dc.Filiers.Add(f);
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
            if(Fil!=null)
                show_infos();
        }
    }
}
