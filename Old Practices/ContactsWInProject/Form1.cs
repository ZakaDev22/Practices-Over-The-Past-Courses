using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ContactsBusinnesLayer;
using CountriesBusinessLayer;


namespace ContactsWInProject
{
    public partial class Form1 : Form
    {
       
        

        public Form1()
        {
            InitializeComponent();

            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

        private void _RefreshContactsList()
        {
            djvAllContacts.DataSource = clsContacts.GetAllContacts();
            
        }

        private void EditeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditeContacts frm = new frmAddEditeContacts((int)djvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            _RefreshContactsList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete contact [" + djvAllContacts.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {

                //Perform Delele and refresh
                if (clsContacts.Delete((int)djvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshContactsList();
                }

                else
                    MessageBox.Show("Contact is not deleted.");
            }
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddEditeContacts frm = new frmAddEditeContacts(-1);
            frm.ShowDialog();

            _RefreshContactsList();
        }
    }
}
