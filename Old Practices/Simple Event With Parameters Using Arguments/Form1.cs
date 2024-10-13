using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Event_With_Parameters_Using_Arguments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myUserControl1_OnCalculationComplete(object sender, MyUserControl.CalculationCompleteEventArg e)
        {
            if(e.Val1 > e.Val2)
            {
                MessageBox.Show($"Valaue1 is the King");
            }
            else if (e.Val1 < e.Val2)
            {
                MessageBox.Show($"Valaue2 is the King");
            }
            else
                MessageBox.Show($"Valaue12 And Value is Equall");


            MessageBox.Show($"Valaue1 : {e.Val1} + Value2 : {e.Val2} = {e.Result}");
        }
    }
}
