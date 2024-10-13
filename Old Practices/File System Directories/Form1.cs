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

namespace File_System_Directories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Directory
            foreach(string File in Directory.GetFiles("C:\\Users\\lenovo\\Desktop"))
            {
                listBox1.Items.Add(File);
            }

            // DirectoryInfo
            DirectoryInfo d = new DirectoryInfo("C:\\Users\\lenovo\\Desktop");

            foreach (FileInfo File in d.GetFiles())
            {
                listBox2.Items.Add(File.FullName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // write the right code here to move The Text.txt From Folder 1 to folder 2

            File.Move("C:\\Users\\lenovo\\Desktop\\Camera\\File1.txt", "C:\\Users\\lenovo\\Desktop\\My Projects\\File2.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("C:\\Pictures Path\\Text1.txt", richTextBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
             richTextBox1.Text = File.ReadAllText("C:\\Pictures Path\\Text1.txt");
        }
    }
}
