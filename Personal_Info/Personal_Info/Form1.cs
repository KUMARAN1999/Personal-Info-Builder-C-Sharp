using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Personal_Info
{
    public partial class Form1 : Form
    {
        public static String a, b, c=null, d, e1, f, g, h, i;
        public static String p;
        Regex alphabet = new Regex("^[a-zA-Z]+$");
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            b = textBox2.Text;
            if (radioButton1.Checked==true)
            {
                c = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                c = radioButton2.Text;
            }
            else
            {
                c = null;
            }
            d = dateTimePicker1.Text;
            e1 = textBox3.Text;
            f = textBox4.Text;
            g = comboBox4.Text;
            h = richTextBox1.Text;
            i = richTextBox2.Text;
            validate();
            validate1();
            validate2();
            if (label15.Text == " X " || label16.Text == " X " || label17.Text == " X ")
            {
                MessageBox.Show("Enter the correct info");
            }
            else if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || richTextBox1.Text == null || richTextBox2.Text == null || c == null || pictureBox1.Image ==null)
            {
                MessageBox.Show("Some Textareas are empty, please fill it and continue"); 
            }
            else
            {
                info_set s = new info_set();
                s.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)| *.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                p = open.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void validate()
        {
            if (textBox1.Text == string.Empty || !alphabet.IsMatch(textBox1.Text))
            {
                label15.Text = " X ";
                label15.ForeColor = Color.Red;
            }
            else
            {
                label15.Text = " ✔ ";
                label15.ForeColor = Color.Green;
            }

        }
        private void validate1()
        {
            if (textBox2.Text == string.Empty || alphabet.IsMatch(textBox2.Text))
            {
                label16.Text = " X ";
                label16.ForeColor = Color.Red;
            }
            else
            {
                label16.Text = " ✔ ";
                label16.ForeColor = Color.Green;
            }
        }
        private void validate2()
        {
            if(textBox3.Text.Length==10)
            {
                label17.Text = " ✔ ";
                label17.ForeColor = Color.Green;     
            }
            else
            {
                label17.Text = " X ";
                label17.ForeColor = Color.Red;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
