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
    public partial class frmAddEditeContacts : Form
    {

        public enum EnMode { AddNew = 0, Update = 1, };

        private EnMode _Mode;

        int _ContactID = -1;

       

        clsContacts _Contact;
        public frmAddEditeContacts(int ContactID)
        {
            InitializeComponent();

            _ContactID = ContactID;

            if(_ContactID == -1)
            {
                _Mode = EnMode.AddNew;
            }
            else
            {
                _Mode = EnMode.Update;
            }
        }

     
       private void _FillCountriesInComboBox()
        {
            DataTable CountryTable = clsCountries.ListCountries();

            foreach(DataRow Row in CountryTable.Rows)
            {
                comboBox1.Items.Add(Row["CountryName"]);
            }
        }

        private void frmAddEditeContacts_Load(object sender, EventArgs e)
        {
            _FillCountriesInComboBox();

            comboBox1.SelectedIndex = 0;

            if(_Mode == EnMode.AddNew)
            {
                lbAddUpdate.Text = "Add New Contact";
                _Contact = new clsContacts();
                return;
            }

            _Contact = clsContacts.Find(_ContactID);

            if( _Contact == null )
            {
                MessageBox.Show($"this Form Will Be Closed Because  Contact With {_ContactID} Is Not Found :-( ");
                this.Close();
                return;
            }

            lbAddUpdate.Text = $"Edite Contact With ID {_ContactID}";
            lbContactID.Text = _ContactID.ToString();

           txtFirstName.Text = _Contact.FirstName ;
            txtLastName.Text  = _Contact.LastName;
            txtAddress.Text   = _Contact.Address;
            txtEmail.Text     = _Contact.Email;
            txtPhone.Text     = _Contact.Phone;
            dtpDatOfBirth.Value = _Contact.DateOfBirth;

            if(_Contact.ImagePath != "")
            {
                pictureBox1.Load(_Contact.ImagePath);
            }

            llRemoveImage.Visible = (_Contact.ImagePath != "");

            comboBox1.SelectedIndex = comboBox1.FindString(clsCountries.Find(_Contact.CountryID).CountryName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountries.Find(comboBox1.Text).ID;

            
            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.CountryID = CountryID;

            if (pictureBox1.ImageLocation != null)
            {
                _Contact.ImagePath = pictureBox1.ImageLocation;
            }
            else
                _Contact.ImagePath = "";

            if(_Contact.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error! : Data Is Not Saved Successfully.");
            }

            _Mode = EnMode.Update;

            lbAddUpdate.Text = $"Edite Contact With ID {_Contact.ID}";
            lbContactID.Text = _Contact.ID.ToString();
        } 

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pictureBox1.Load(selectedFilePath);
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.Image = null;
            llRemoveImage.Visible = false;
        }
    }
}
