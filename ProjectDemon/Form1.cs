using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDemon
{
    public partial class Form1 : Form
    {
        Panel activepanel;
        bool isSideActive = true;
        const int sidewidth = 272;

        #region User-Created-Functions
        void rescale()
        {

        }
        public void switchingpanels() {
            panel15.Visible = false;
            panel7.Visible = false;
        }
        void settingactivepanel() {
            activepanel.Visible = true;
            activepanel.Top = 31;
            activepanel.Height = 802;
            if (isSideActive == true)
            {
                activepanel.Width = this.Width - sidewidth;
                activepanel.Left = sidewidth;
            }
            else
            {
                activepanel.Width = this.Width -  42;
                activepanel.Left = 42;
            }
        }
        #endregion
        public Form1()
        {
            //textBox2.UseSystemPasswordChar = true;
            this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            InitializeComponent();
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.pictureBox2.Image = global::ProjectDemon.Properties.Resources.squares;
            }
            else
            {
                this.pictureBox2.Image = global::ProjectDemon.Properties.Resources.squares_min;
            }
            switchingpanels();
            activepanel = panel7;
            settingactivepanel();
            textBox2.UseSystemPasswordChar = true;
            activepanel = panel7;
        }

        #region Min,max,close Windows
        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(244, 152, 82);
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(255, 235, 220);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(244, 152, 82);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 235, 220);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor= Color.FromArgb(254, 39, 18);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(255, 235, 220);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            { 
                this.pictureBox2.Image = global::ProjectDemon.Properties.Resources.squares_min;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.pictureBox2.Image = global::ProjectDemon.Properties.Resources.squares;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Status Bar
        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Underline|FontStyle.Bold);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font,  FontStyle.Bold);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dcornade");
        }
        #endregion

        private void panel7_SizeChanged(object sender, EventArgs e)
        {
            label6.Left = panel7.Width / 2 - label6.Width / 2;
            label7.Left = panel7.Width / 2 - label7.Width / 2;
            panel8.Left = panel7.Width / 2 - panel8.Width / 2;
        }

        private void Sidepanel1_DoubleClick(object sender, EventArgs e)
        {
            if(isSideActive == true)
            {
                activepanel.Width = activepanel.Width + (sidewidth - 42);
                Sidepanel1.Width = 42;
                activepanel.Left = 42;
                isSideActive = false;
            }
            else
            {
                activepanel.Width = activepanel.Width - (sidewidth - 42);
                Sidepanel1.Width = 272;
                activepanel.Left = 272;
                isSideActive = true;
            }
            
        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            if(activepanel != panel15) { panel13.BackColor = Color.FromArgb(254, 171, 109); }
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            if (activepanel != panel15) { panel13.BackColor = Color.FromArgb(255, 215, 184); }
            
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            switchingpanels();
            activepanel = panel15;
            settingactivepanel();
            panel13.BackColor = Color.FromArgb(254, 171, 109);
            panel10.BackColor = Color.FromArgb(255, 215, 184);
        }

        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            if (activepanel != panel7) { panel10.BackColor = Color.FromArgb(254, 171, 109); }
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            if (activepanel != panel7) { panel10.BackColor = Color.FromArgb(255, 215, 184); }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            switchingpanels();
            activepanel = panel7;
            settingactivepanel();
            panel10.BackColor = Color.FromArgb(254, 171, 109);
            panel13.BackColor = Color.FromArgb(255, 215, 184);
        }

        private void panel15_SizeChanged(object sender, EventArgs e)
        {
            label15.Left = panel15.Width / 2 - label15.Width / 2;
            label14.Left = panel15.Width / 2 - label14.Width / 2;
            panel16.Left = panel15.Width / 2 - panel16.Width / 2;
        }
    }
}
