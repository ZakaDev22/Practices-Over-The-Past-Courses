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
    public partial class TreeViewF : Form
    {
        public TreeViewF()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(treeView1.SelectedNode.Text);
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            checkTreeViewNode(e.Node, e.Node.Checked);
        }

        private void checkTreeViewNode(TreeNode Node, Boolean IsChecked)
        {

            foreach(TreeNode Item in Node.Nodes)
            {
                Item.Checked = IsChecked;

                if(Node.Nodes.Count > 0)
                {
                    this.checkTreeViewNode(Item, IsChecked);
                }
            }
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            treeView1.Nodes.Add("Z<3S");
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            treeView1.SelectedNode.Text = "SSiya";
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView2.SelectedNode.Text.ToString();
        }
    }
}
