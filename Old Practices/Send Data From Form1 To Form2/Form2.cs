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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private int _ID ;

        public Form2(int ID)
        {
            InitializeComponent();
            _ID = ID;
            label2.Text = _ID.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
