using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_Data_From_Form1_To_Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(int.TryParse(textBox1.Text, out int val))
            {
                Form2 frm = new Form2(val);
                frm.ShowDialog();
            }
           else
            {
                MessageBox.Show("Person ID Should Be A Number !");
                textBox1.Focus();
            }
        }
    }
}
