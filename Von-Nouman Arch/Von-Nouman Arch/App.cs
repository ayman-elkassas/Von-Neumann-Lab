using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Von_Nouman_Arch
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.FromArgb(234, 22, 5);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.FromArgb(63,133,254);
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            label15.BackColor = System.Drawing.Color.FromArgb(83, 169, 72);
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = System.Drawing.Color.FromArgb(63,133,254);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label17.BackColor = System.Drawing.Color.FromArgb(63,133,254);
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label17.BackColor = System.Drawing.Color.White;
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Opacity = 0;
            innerApp inA = new innerApp();
            inA.Show();
            this.Opacity = 0;
            this.ShowInTaskbar = false;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
