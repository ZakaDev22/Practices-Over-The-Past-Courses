using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            DialogResult d = ofd.ShowDialog();

            string Fileloc = "";
            if(d == DialogResult.OK) 
            { 
                Fileloc = ofd.FileName;
            }

            FileInfo fileInfo = new FileInfo(Fileloc);

            label1.Text  = fileInfo.FullName.ToString();
            textBox1.Text = Path.GetFileName(fileInfo.FullName);

            label2.Text = fileInfo.Extension.ToUpper();

            StreamReader sr = new StreamReader(Fileloc);

            string Line;

            while((Line = sr.ReadLine()) != null)
            {
                label3.Text += Line;
            }
        }
    }
}
