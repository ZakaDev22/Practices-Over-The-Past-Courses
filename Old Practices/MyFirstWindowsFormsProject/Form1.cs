using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindowsFormsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox1.Text;
            label2.Text = textBox1.Text;
        }

        private void Mouse_Enter3(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
            button6.BackColor = Color.Yellow;
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
