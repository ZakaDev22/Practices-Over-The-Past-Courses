using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Practice
{
    public partial class ProgressBarF : Form
    {
        public ProgressBarF()
        {
            InitializeComponent();
        }

        private void ProgressBarF_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";
            }

            else
            {
                timer1.Stop();
                MessageBox.Show("Validate done successfully.","Info!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;
            progressBar2.Value = 0;

           for(int i=1; i <= 10; i++)
            {
                if (progressBar2.Value < 100)
                {
                    Thread.Sleep(500);
                    progressBar2.Value += 10;

                    label2.Text = progressBar2.Value.ToString() + "%";
                    //label2.Text = (((float)progressBar2.Value / progressBar2.Maximum) * 100) + "%";

                    progressBar2.Refresh();
                    label2.Refresh();
                }

                else
                {
                    button1.Enabled = false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar2.Maximum = 100;
            progressBar2.Minimum = 0;
            progressBar2.Value = 0;
            label2.Text = "0%";
        }
    }
}
