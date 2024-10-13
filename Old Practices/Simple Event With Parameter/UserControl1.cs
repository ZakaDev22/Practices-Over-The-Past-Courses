using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Event_With_Parameter
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public event Action<int> OnCalculationComplete;

        protected virtual void CalculationComplete(int PersonID)
        {
            Action<int> Handler = OnCalculationComplete;

            if(Handler != null)
            {
                Handler(PersonID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Result = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
            lbRsult.Text = Result.ToString();

            if(OnCalculationComplete != null)
            {
                CalculationComplete(Result);
            }
        }
    }
}
