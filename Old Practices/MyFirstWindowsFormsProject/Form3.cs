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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi This Is A Message!");
        }

        private void btnShowJeryPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi This Is A Message!"," title : THe Wolf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm", " Are You Sure !",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show(" You Pressed Ok Good Job :-) ","Result",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show(" You Pressed Cancel :-( ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
