using Memory_Pictures_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Pictures_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        byte LastValue = 0;

        enum enPlayerChoise { enCaty = 1, enElephant = 2 , enFish = 3, enMonkey = 4, enLion = 5, enZebra = 6 };

        enum enPlayerClicks { Click = 1 , noclick };

        enPlayerClicks PlayerClick1 = enPlayerClicks.Click;
        enPlayerClicks PlayerClick2 = enPlayerClicks.noclick ;

        private void ChangeTurns()
        {
            if (PlayerClick1 == enPlayerClicks.Click)
            {
                PlayerClick2 = enPlayerClicks.Click;
                PlayerClick1 = enPlayerClicks.noclick;

            }
            else
            {
                PlayerClick2 = enPlayerClicks.noclick;
                PlayerClick1 = enPlayerClicks.Click;
            }
        }
   


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcCaty_MouseClick(object sender, MouseEventArgs e)
        {
            if (PlayerClick1 == enPlayerClicks.Click)
            {
                pcCaty.Image = Resources.cat;
                LastValue = Convert.ToByte(pcCaty.Tag);
                ChangeTurns();
                return;
            }


            else
            {
                if (LastValue != Convert.ToByte(pcCaty.Tag))
                {
                    pcCaty.Image = Resources.question_mark_96;
                    pcCaty2.Image = Resources.question_mark_96;
                    ChangeTurns();
                    return;
                }
                else
                    pcCaty.Image = Resources.cat;

            }

          
                
            

        }

        private void pcCaty2_MouseClick(object sender, MouseEventArgs e)
        {
            if (PlayerClick1 == enPlayerClicks.Click)
            {
                pcCaty2.Image = Resources.cat;
                LastValue = Convert.ToByte(pcCaty2.Tag);
                ChangeTurns();
                return;
            }


            else
            {
                if (LastValue != Convert.ToByte(pcCaty2.Tag))
                {
                    pcCaty.Image = Resources.question_mark_96;
                    pcCaty2.Image = Resources.question_mark_96;
                    ChangeTurns();
                    return;
                }
                else
                    pcCaty2.Image = Resources.cat;

            }



        }
        //==========================================================================

        private void pcElephant_MouseClick(object sender, MouseEventArgs e)
        {
           


            if (PlayerClick1 == enPlayerClicks.Click)
            {
                pcElephant.Image = Resources.elephant;
                LastValue = Convert.ToByte(pcElephant.Tag);
                ChangeTurns();
                return;
            }


            else
            {
                if (LastValue != Convert.ToByte(pcElephant.Tag))
                {
                    pcElephant.Image = Resources.question_mark_96;
                    pcElephant2.Image = Resources.question_mark_96;
                    ChangeTurns();
                    return;
                }
                else
                    pcElephant.Image = Resources.elephant;

            }



        }

        private void pcElephant2_MouseClick(object sender, MouseEventArgs e)
        {
            if (PlayerClick1 == enPlayerClicks.Click)
            {
                pcElephant2.Image = Resources.elephant;
                LastValue = Convert.ToByte(pcElephant2.Tag);
                ChangeTurns();
                return;
            }


            else
            {
                if (LastValue != Convert.ToByte(pcElephant.Tag))
                {
                    pcElephant.Image = Resources.question_mark_96;
                    pcElephant2.Image = Resources.question_mark_96;
                    ChangeTurns();
                    return;
                }
                else
                    pcElephant2.Image = Resources.elephant;
            }
        }
       //==========================================================================

        private void pcFish_MouseClick(object sender, MouseEventArgs e)
        {
            pcFish.Image = Resources.fish;
        }

      
        private void pcMonkey_MouseClick(object sender, MouseEventArgs e)
        {
            pcMonkey.Image = Resources.monkey;
        }

        private void pcLion_MouseClick(object sender, MouseEventArgs e)
        {
            pcLion.Image = Resources.lion;
        }

        private void pcMonkey2_MouseClick(object sender, MouseEventArgs e)
        {
            pcMonkey2.Image = Resources.monkey;
        }

        private void pcZebra_MouseClick(object sender, MouseEventArgs e)
        {
            pcZebra.Image = Resources.zebra;
        }

        private void pcFish2_MouseClick(object sender, MouseEventArgs e)
        {
            pcFish2.Image = Resources.fish;
        }

        private void pcZebra2_MouseClick(object sender, MouseEventArgs e)
        {
            pcZebra2.Image = Resources.zebra;
        }

        private void pcLion2_MouseClick(object sender, MouseEventArgs e)
        {
            pcLion2.Image = Resources.lion;
        }

       
    }
}
