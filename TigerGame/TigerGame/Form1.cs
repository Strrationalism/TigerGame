using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TigerGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tick(PictureBox pb, int i)
        {
            Bitmap[] bitmaps =
            {
                Properties.Resources.A,
                Properties.Resources.C,
                Properties.Resources.F,
                Properties.Resources.S,
                Properties.Resources.U
            };

            pb.Image = bitmaps[i];
        }

        int timer1s = 0;
        int timer2s = 0;
        int timer3s = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1s++;
            timer1s = timer1s % 5;
            tick(pictureBox31, timer1s);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2s++;
            timer2s = timer2s % 5;
            tick(pictureBox32, timer2s);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3s++;
            timer3s = timer3s % 5;
            tick(pictureBox33, timer3s);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
            {
                if(!timer2.Enabled)
                {
                    if (!timer3.Enabled)
                    {
                        var rnd = new Random();
                        timer1s = rnd.Next(5);
                        timer2s = rnd.Next(5);
                        timer3s = rnd.Next(5);

                        timer1.Enabled = true;
                        timer2.Enabled = true;
                        timer3.Enabled = true;
                    }
                    else
                    {
                        timer3.Enabled = false;
                    }
                }
                else
                {
                    timer2.Enabled = false;
                }
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}
