using PictureBox_Exercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBoy.Checked)
            {
                pictureBox1.Image = Resources.Boy;
                lbTitel.Text = ((RadioButton)sender).Tag.ToString();
            }
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGirl.Checked)
            {
                lbTitel.Text = ((RadioButton)sender).Tag.ToString();
                pictureBox1.Image = Resources.Girl;
            }
        }

        private void rbBook_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBook.Checked)
            {
                lbTitel.Text = ((RadioButton)sender).Tag.ToString();
                pictureBox1.Image = Resources.Book;
            }
        }

        private void rbPen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPen.Checked)
            {
                lbTitel.Text = ((RadioButton)sender).Tag.ToString();
                pictureBox1.Image = Resources.Pen;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbBoy.Checked = true;
        }
    }
}
