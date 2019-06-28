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
    public partial class Form1 : Form
    {

        bool check = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = .5;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                check = true;
            }
            else
            {
                if (check == false)
                {
                    Opacity += .03;
                }
            }

            if (check)
            {
                timer1.Stop();
                timer2.Start();
            }
            this.ShowInTaskbar = false;
        }

        private void reflectionImage1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(check)
            {

            timer2.Interval = 90;
            Opacity -= .03;

            if (Opacity == 0)
            {
                App A = new App();
                A.Show();

                timer2.Stop();
            }

            }
        }

    }
}
