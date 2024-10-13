using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C___User_Controls
{
    public partial class ctrSimpleCalculator : UserControl
    {
        public ctrSimpleCalculator()
        {
            InitializeComponent();
        }

        private void ctrSimpleCalculator_Load(object sender, EventArgs e)
        {

        }

        public float Result
        {
            get
            {
                return (float)Convert.ToDouble(lbAge.Text);
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            lbAge.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)).ToString();
        }

      
    }
}
