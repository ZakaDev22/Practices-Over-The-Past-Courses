using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_Strip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zikoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("21 Years Old :-)");
        }

        private void sSiyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("23.10 Years Old :-)");
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Lvl 77 :-)");
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Lvl 76 :-)");
        }

        private void zToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 51000 :-)");
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" 56000 :-)");
        }

        private void zToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" The Wolf :-)");
        }

        private void aToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" My Caty :-)");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exite is Her :-)");
        }

        

        private void showContexFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenueF frm = new ContextMenueF();

            frm.MdiParent = this;
            frm.Show();
        }
    }
}
