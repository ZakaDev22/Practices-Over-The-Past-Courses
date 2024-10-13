using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Practice
{
    public partial class DateTimePickerF : Form
    {
        public DateTimePickerF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongDateString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToLongTimeString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbDtaeLabel.Text = dateTimePicker1.Text + Environment.NewLine;
            lbDtaeLabel.Text += dateTimePicker1.Value.ToString("dd-MMM-yyyy") + Environment.NewLine;
            lbDtaeLabel.Text += dateTimePicker1.Value.ToString("dddd-MMM-yyyy") + Environment.NewLine;
            lbDtaeLabel.Text += dateTimePicker1.Value.ToString("MM-dd-yyyy") + Environment.NewLine;
            lbDtaeLabel.Text += dateTimePicker1.Value.ToString("dd/MM/yy") + Environment.NewLine;
            lbDtaeLabel.Text += dateTimePicker1.Value.ToString("dddd,dd-MMM-yyyy") + Environment.NewLine;
        }
    }
}
