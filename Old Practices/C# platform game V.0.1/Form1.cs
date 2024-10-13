using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__platform_game_V._0._1
{
    public partial class Form1 : Form
    {

        int UpDownGravity = 2;
        int RigthLeftGravity = 2;
        int RigthLeftGravityCat1 = 2;
        int RigthLeftGravityCat2 = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            pcMove1.Top += UpDownGravity;
            pcMove2.Left += RigthLeftGravity;

            pcCat1.Left += RigthLeftGravityCat1;
            pcCat2.Left += RigthLeftGravityCat2;

            PerformMove1();
            PerfomMove2();

            PerformCat1();
            PerformCat2();
        }

        private void PerformMove1()
        {
            if (pcMove1.Top >= 342)
            {
                UpDownGravity = -2;
            }

            if (pcMove1.Top <= 125)
            {
                UpDownGravity = 2;
            }
        }

        private void PerfomMove2()
        {

            if (pcMove2.Left >= 290)
            {
                RigthLeftGravity = -2;
            }

            if (pcMove2.Left <= 150)
            {
                RigthLeftGravity = 2;
            }
        }

        private void PerformCat1()
        {
            if (pcCat1.Left >= 370)
            {
                RigthLeftGravityCat1 = -2;
            }

            if (pcCat1.Left <= 212)
            {
                RigthLeftGravityCat1 = 2;
            }
        }

        private void PerformCat2()
        {
            if (pcCat2.Left >= 283)
            {
                RigthLeftGravityCat2 = -2;
            }

            if (pcCat2.Left <= 158)
            {
                RigthLeftGravityCat2 = 2;
            }
        }
    }
}
