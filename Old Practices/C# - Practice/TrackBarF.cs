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
    public partial class TrackBarF : Form
    {
        public TrackBarF()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString() + "%";

            pictureBox1.Size = new Size(trackBar1.Value, trackBar1.Value);
        }

        private void TrackBarF_Load(object sender, EventArgs e)
        {
           
        }
    }
}
