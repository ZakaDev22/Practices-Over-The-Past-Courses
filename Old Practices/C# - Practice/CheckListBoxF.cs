using C____Practice.Properties;
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
    public partial class CheckListBoxF : Form
    {
        public CheckListBoxF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(byte i =1; i <= 5; i++)
            {
                chkListB1.Items.Add("Item" + i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < chkListB1.CheckedItems.Count ; i++)
            {
                MessageBox.Show(chkListB1.CheckedItems[i].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           switch (comboBox1.SelectedIndex)
            {
                case 0:

                    pictureBox1.Image = Resources.Youtub;
                    break;


                case 1:

                    pictureBox1.Image = Resources.ProgrammingAdvices;
                    break;


                case 2:

                    pictureBox1.Image = Resources.LinkedIn;
                    break;

            }
        }

        private void LlbYoutub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LlbYoutub.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.youtube.com/@ProgrammingAdvices");
        }

        private void LlbProgrammingAdvices_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LlbYoutub.LinkVisited = true;

            System.Diagnostics.Process.Start("https://programmingadvices.com/courses");
        }

        private void LlbLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LlbYoutub.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.linkedin.com/in/zakaria-elfakhar/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i=0; i <chkListB1.Items.Count; i++)
            {
                chkListB1.SetItemChecked(i, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chkListB1.Items.RemoveAt(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListB1.Items.Count; i++)
            {
                chkListB1.SetItemChecked(i, false);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.images__7_;
        }
    }
}
