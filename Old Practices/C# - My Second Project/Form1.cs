using C____My_Second_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____My_Second_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Cool;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //  pictureBox1.Image = Image.FromFile(@"C:\Dog.png");
            pictureBox1.ImageLocation = @"C:\images.jpeg.jpg";
        }
    }
}
