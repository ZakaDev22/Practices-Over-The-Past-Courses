using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____Pizza__Poject
{
    public partial class PizzaOrderForm : Form
    {
        public PizzaOrderForm()
        {
            InitializeComponent();
        }

        private void PizzaOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowOrderScreen_Click(object sender, EventArgs e)
        {
            Form frm1 = new OrderForm();
            frm1.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
