﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ProjectDemon
{
    public partial class Form1 : Form
    {
        OleDbConnection oleDb;
        #region infopanels
        //panel7 = login window
        //panel15 = registration window
        #endregion
        bool usersame = false;
        Panel activepanel;
        bool isSideActive = true;
        const int sidewidth = 272;

        #region User-Created-Functions
        public void uncheckers()
        {
            checkBox1.Checked = false;
        }
        public void warningvisible() {
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }
        public void textcleaner() {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        public void switchingpanels() {
            panel15.Visible = false;
            panel7.Visible = false;
            textcleaner();
            warningvisible();
            uncheckers();
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
                activepanel.Width = this.Width - 42;
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
            oleDb = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = school.mdb");
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
            panel2.BackColor = Color.FromArgb(254, 39, 18);
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
            label5.Font = new Font(label5.Font, FontStyle.Underline | FontStyle.Bold);
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Font = new Font(label5.Font, FontStyle.Bold);
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
            if (isSideActive == true)
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

        #region Login And Registration
        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            if (activepanel != panel15) { panel13.BackColor = Color.FromArgb(254, 171, 109); }
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

        private void panel11_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            pictureBox7.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
                pictureBox7.Image = global::ProjectDemon.Properties.Resources.invisible;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                pictureBox7.Image = global::ProjectDemon.Properties.Resources.eye;
            }
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            textBox4.Focus();
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text.Length <= 3)
            {
                label19.Visible = true;
                label19.Text = "Username should be more than 3 letters";
                textBox3.Focus();
            }
            else
            {
                pictureBox8.Visible = true;
                label19.Visible = false;
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            pictureBox8.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (textBox4.UseSystemPasswordChar == true)
            {
                textBox4.UseSystemPasswordChar = false;
                pictureBox8.Image = global::ProjectDemon.Properties.Resources.invisible;
            }
            else
            {
                textBox4.UseSystemPasswordChar = true;
                pictureBox8.Image = global::ProjectDemon.Properties.Resources.eye;
            }
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            textBox5.Focus();
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text.Length <= 3)
            {
                label19.Visible = true;
                label19.Text = "Username should be more than 3 letters";
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                pictureBox8.Visible = true;
                label19.Visible = false;
                label20.Visible = true;
                textBox4.Focus();
            }
            else
            {
                pictureBox9.Visible = true;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (textBox5.UseSystemPasswordChar == true)
            {
                textBox5.UseSystemPasswordChar = false;
                pictureBox9.Image = global::ProjectDemon.Properties.Resources.invisible;
            }
            else
            {
                textBox5.UseSystemPasswordChar = true;
                pictureBox9.Image = global::ProjectDemon.Properties.Resources.eye;
            }
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switchingpanels();
            activepanel = panel15;
            settingactivepanel();
            panel13.BackColor = Color.FromArgb(254, 171, 109);
            panel10.BackColor = Color.FromArgb(255, 215, 184);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oleDb.Open();
            string sql = "Select * from Login where UserId='" + textBox1.Text + "' and passw = '" + textBox2.Text + "'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, oleDb);
            DataSet set = new DataSet();
            adapter.Fill(set);
            if (set.Tables[0].Rows.Count != 0)
            {
                //label17.Visible = true;
                //label17.Text = "Login Successful!";
                switchingpanels();
                activepanel = panel20;
                settingactivepanel();
                panel13.Visible = false;
                panel10.Visible = false;
                panel21.Visible = true;
                panel21.Location = new Point(0, 0);
            }
            else
            {
                label17.Visible = true;
                label17.Text = "Wrong Username or Password!";
            }

            oleDb.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oleDb.Open();
            if (textBox3.Text.Length <= 3 || usersame)
            {
                label19.Visible = true;
                if (textBox3.Text.Length <= 3) {
                    label19.Text = "Username should be more than 3 letters";
                }
                else
                {
                    label19.Text = "Username already exists";
                }
                textBox3.Focus();
            }
            else if (textBox4.Text == "")
            {
                pictureBox8.Visible = true;
                label19.Visible = false;
                label20.Visible = true;
                textBox4.Focus();
            }
            else if (textBox4.Text != textBox5.Text)
            {
                label18.Visible = true;
                textBox5.Focus();
            }
            else
            {
                string user, pass;
                bool reqadm = (checkBox1.Checked) ? true : false;
                user = textBox3.Text;
                pass = textBox4.Text;
                string sql = "Insert into Login values('" + user + "', '" + pass + "', " + false + ", " + reqadm + ")";
                OleDbCommand dbCommand = new OleDbCommand(sql, oleDb);
                dbCommand.ExecuteNonQuery();
                textcleaner();
                label18.Visible = true;
                label18.Text = "Account Created!";
                label19.Visible = false;
            }
            oleDb.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length <= 3)
            {
                label19.Visible = true;
                label19.Text = "Username should be more than 3 letters";
            }
            else
            {
                oleDb.Open();
                string sql = "Select * from Login where UserId='" + textBox3.Text + "'";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sql, oleDb);
                DataSet set = new DataSet();
                adapter.Fill(set);
                if (set.Tables[0].Rows.Count != 0)
                {
                    label19.Visible = true;
                    label19.Text = "Username already exists";
                    usersame = true;
                }
                else
                {
                    usersame = false;
                    label19.Visible = false;
                }
                oleDb.Close();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length <= 3 || usersame == true)
            {
                label19.Visible = true;
                if (usersame == true)
                {
                    label19.Text = "Username already exists";
                }
                else
                {
                    label19.Text = "Username should be more than 3 letters";
                }
                textBox3.Focus();
            }
            else
            {
                label19.Visible = false;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {

            }
            else
            {
                label20.Visible = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != textBox5.Text)
            {
                label18.Visible = true;
            }
            else
            {
                label18.Visible = false;
            }
        }
        #endregion
    }
}
