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
    public partial class MyUserControl : UserControl
    {
        public MyUserControl()
        {
            InitializeComponent();
        }


        public class CalculationCompleteEventArg : EventArgs
        {
            public int Val1 { get; }
            public int Val2 { get; }

            public int Result { get; }

            public CalculationCompleteEventArg(int Val1, int Val2, int result)
            {
                this.Val1 = Val1;
                this.Val2 = Val2;
                this.Result = result;
            }
        }

        public event EventHandler<CalculationCompleteEventArg> OnCalculationComplete;

        public void RiseOnCalculationComplete(int val1,int val2, int result)
        {
            RiseOnCalculationComplete(new CalculationCompleteEventArg(val1,val2,result));
        }

        public void RiseOnCalculationComplete(CalculationCompleteEventArg e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int val1, val2, result;

            val1 = int.Parse(txtVal1.Text);
            val2 = int.Parse(txtVal2.Text);

            result = val1 + val2;

            lbResult.Text = result.ToString();

            if(OnCalculationComplete != null)
                RiseOnCalculationComplete(val1 , val2, result);
        }
    }
}
