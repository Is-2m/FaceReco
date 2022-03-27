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
    public partial class Main_Form : Form
    {
        
        
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listerFiliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            var f = new Form_ListFiliere();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }


        private void listerGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            var f = new Form_ListGroupe();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void creeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_AddFilier(null);
            f.ShowDialog();
        }

        private void ajouterGroupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_AddGroupe(null);
            f.ShowDialog();
        }

        private void ajouterStagiaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Form_AddStagiaire(null);
            f.ShowDialog();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            var f = new Form_ListStagiaire();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.dc.SubmitChanges();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            var f = new Form_FaceReco();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
