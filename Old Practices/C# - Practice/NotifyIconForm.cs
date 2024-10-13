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
    public partial class NotifyIconForm : Form
    {
        public NotifyIconForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Message !";
            notifyIcon1.BalloonTipText = "Go To Your Account You Win a Gift";
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Nice Bro :-)", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void notifyIcon1_BalloonTipClosed(object sender, EventArgs e)
        {
            MessageBox.Show("You Closed The Notify :-(", "The wolf", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("double click nice", "The wolf", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
