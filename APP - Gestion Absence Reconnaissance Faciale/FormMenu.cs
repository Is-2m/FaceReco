using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceReco
{
    public partial class FormMenu : Form
    {
        //Fields
        private Button currentButton;
        private Random random = new Random();
        private int tempIndex;
        private Form activeForm;

        public FormMenu()
        {
            InitializeComponent();
        }
        #region Events

        private void FormMenu_Load(object sender, EventArgs e)
        {
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btn_Filieres_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Form_ListFiliere(), sender);
        }

        private void btn_Groupe_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Form_ListGroupe(), sender);

        }

        private void btn_Stagiaire_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = !panelSubMenu.Visible;
        }

        private void btn_FaceRec_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Form_FaceReco(), sender);

        }

        private void btn_PresenceSheet_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            OpenChildForm(new Form_PresenceSheet(), sender);

        }



        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                MyToolTip.SetToolTip(btn_Maximize, "Restaurer");
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                MyToolTip.SetToolTip(btn_Maximize, "Maximize");
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        #endregion/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Methods
        void HideSubMenu()
        {
            panelSubMenu.Visible = false;
            this.btn_Stagiaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btn_Stagiaires.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Stagiaires.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Stagiaires.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Stagiaires.Size = new System.Drawing.Size(220, 40);

            this.btn_Intrus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            this.btn_Intrus.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Intrus.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Intrus.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btn_Intrus.Size = new System.Drawing.Size(220, 40);
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Poppins SemiBold", 15F, System.Drawing.FontStyle.Bold);
                    currentButton.Size = new Size(currentButton.Size.Width, currentButton.Size.Height + 20);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Size = new Size(previousBtn.Size.Width, previousBtn.Size.Height >= 80 ? previousBtn.Size.Height - 20 : previousBtn.Size.Height);
                    previousBtn.Font = new System.Drawing.Font("Poppins SemiBold", 13F, System.Drawing.FontStyle.Bold);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_Title.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            lbl_Title.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
            Program.dc.SaveChanges();
        }




        #endregion/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lbl_Logo_Click(object sender, EventArgs e)
        {
            var f = new Form_LoadFacesToDB();
            f.ShowDialog();
        }

        private void btn_Stagiaires_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ListStagiaire(), btn_Stagiaire);
            HideSubMenu();
        }

        private void btn_Intrus_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_ListIntrus(), btn_Stagiaire);
            HideSubMenu();
        }
    }
}
