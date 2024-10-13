using C______Combo_Box_Exercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C______Combo_Box_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pbPic1_Click(object sender, EventArgs e)
        {
            pbPic1.ImageLocation = @"C:\Users\lenovo\Desktop\C# - Descktop Images\images (7).jpg";
        }

        private void cbPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbPictures.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    pbPic1.Image = Resources.Book;
                    lbTitle.Text = "Boy";
                    break;
                case "girl":
                    pbPic1.Image = Resources.Girl;
                    lbTitle.Text = "Girl";
                    break;
                case "book":
                    pbPic1.Image = Resources.Book;
                    lbTitle.Text = "Book";
                    break;
                case "pen":
                    pbPic1.Image = Resources.Pen;
                    lbTitle.Text = "Pen";
                    break;
            }
        }
    }
}
