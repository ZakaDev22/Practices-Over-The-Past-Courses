using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Practice
{
    public partial class fNumaricUpDown : Form
    {
        public fNumaricUpDown()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString() + "%";

            progressBar1.Value = (int)numericUpDown1.Value ;

            trackBar1.Value = (int)numericUpDown1.Value;
        }
    }
}
