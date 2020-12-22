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
        public Form1()
        {    
            
            InitializeComponent();
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.pictureBox2.Image = global::ProjectDemon.Properties.Resources.squares;
            }
            else
            {
                this.pictureBox2.Image = global::ProjectDemon.Properties.Resources.squares_min;
            }
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
    }
}
