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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull)
                textBox1.Text = maskedTextBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // comboBox1.Items.Add("The WOlf Zaka");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Text, "ZZZ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm2 = new LinkLbForm();
            frm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm2 = new CheckListBoxF();
            frm2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm2 = new DateTimePickerF();
            frm2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm2 = new MOnthCalendarF();
            frm2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form frm2 = new TimerForm ();
            frm2.ShowDialog();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form frm2 = new NotifyIconForm();
            frm2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form frm2 = new TreeViewF();
            frm2.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form frm3 = new ProgressBarF();
            frm3.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form frm3 = new ListViewF();
            frm3.ShowDialog();
        }

        private void btnErrorProvider1_Click(object sender, EventArgs e)
        {
            Form frm3 = new ErrorPrividerF();
            frm3.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form frm3 = new TrackBarF();
            frm3.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form frm3 = new fNumaricUpDown();
            frm3.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Form frm3 = new fTabControl();
            frm3.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form frm3 = new fColorDailog();
            frm3.ShowDialog();
        }
    }
}
