using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Send_Data_Back_To_Form_Using_Delegate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public delegate void Delegate(object sender, int ID);

        public event Delegate DataBack;

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBox1.Text);

            DataBack?.Invoke(this, ID);


            this.Close();
        }

      
    }
}
