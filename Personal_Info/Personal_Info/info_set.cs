using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Personal_Info
{
    public partial class info_set : Form
    {
        public info_set()
        {
            InitializeComponent();
          
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void info_set_Load(object sender, EventArgs e)
        {
            label10.Text = Form1.a;
            label11.Text = Form1.b;
            label12.Text = Form1.c;
            label13.Text = Form1.d;
            label14.Text = Form1.e1;
            label16.Text = Form1.f;
            label15.Text = Form1.g;
            label17.Text = Form1.h;
            label19.Text = Form1.i;
            pictureBox1.Image = new Bitmap(Form1.p);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
