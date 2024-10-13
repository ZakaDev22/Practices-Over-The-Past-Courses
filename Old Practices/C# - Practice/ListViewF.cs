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
    public partial class ListViewF : Form
    {
        public ListViewF()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text))
                return;

            ListViewItem Item = new ListViewItem(txtID.Text.Trim());

            if (rbMale.Checked)
                Item.ImageIndex = 1;
            else
                Item.ImageIndex = 0;

            Item.SubItems.Add(txtName.Text.Trim());
            listView1.Items.Add(Item);

            txtID.Clear();
            txtName.Clear();
            txtID.Focus();

        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for(int i=1; i <= 10; i++)
            {
                ListViewItem Item = new ListViewItem(i.ToString());

                if (i%2 == 0)
                    Item.ImageIndex = 1;
                else
                    Item.ImageIndex = 0;

                Item.SubItems.Add("Person"+i);
                listView1.Items.Add(Item);
            }
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void ListViewF_Load(object sender, EventArgs e)
        {
            rbDetails.Checked = true;
        }

        private void rbDetails_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].ToString());
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem Item in listView1.Items)
            {
                listView1.Items.Remove(Item);
            }
        }
    }
}
