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
    public partial class checkBoxForm : Form
    {
        public checkBoxForm()
        {
            InitializeComponent();
        }

        private void btnHideCheckBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString(),"Check Box 1 Value");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnCheckBoxVAl.Visible = checkBox1.Checked;
            btnHideCheckBox1.Enabled = checkBox1.Checked;
        }

        private void btnRadioButtomValue_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rbSmall.Checked.ToString()," Radio Button Value ");
        }
    }
}
