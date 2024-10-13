using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ContactsDataAccessLayer;

namespace ContactsBusinnesLayer
{
    public class clsContacts
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int CountryID { get; set; }

        public string ImagePath { get; set; }

        public clsContacts()

        {
            this.ID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Phone = "";
            this.Address = "";
            this.DateOfBirth = DateTime.Now;
            this.CountryID = -1;
            this.ImagePath = "";

            Mode = enMode.AddNew;

        }

        private clsContacts(int ID, string FirstName, string LastName, string Email, string Phone,
             string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
             
            Mode = enMode.Update;
        }

        public static clsContacts Find(int ID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOFBirth = DateTime.Now;
            int CountryID = 1;

            if (clsContactDataAccess.GetContactInfoByID(ID, ref FirstName, ref LastName, ref Email, ref Phone, ref Address,
                ref DateOFBirth, ref CountryID, ref ImagePath))
            {
                return new clsContacts(ID, FirstName, LastName, Email, Phone, Address, DateOFBirth, CountryID, ImagePath);
            }
            else
            {
                return null;
            }

        }

        private bool _AddNewContact()
        {
            this.ID = clsContactDataAccess.AddNewContact(this.FirstName, this.LastName, this.Email, this.Phone, this.Address, this.DateOfBirth,
                                                          this.CountryID, this.ImagePath);

            return (this.ID != -1);
        }

        private bool _UpdateContact()
        {
            return clsContactDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName, this.Email, this.Phone, this.Address,
                                                      this.DateOfBirth, this.CountryID, this.ImagePath);
        }

        public static bool Delete(int ID)
        {
            return clsContactDataAccess.DeleteContact(ID);
        }

        public bool Save()
        {

           switch (Mode)
            {
                case enMode.AddNew:
                 
                 if (_AddNewContact())
                   {
                      Mode = enMode.Update;
                      return true;
                   }
                 else
                    {
                        return false;
                    }

                 case enMode.Update:

                    return _UpdateContact();

                    
            }

            return false;
        }

        public static DataTable GetAllContacts()
        {
            return clsContactDataAccess.GetAllContacts();
        }


        public static bool IsContactExist(int ID)
        {
            return clsContactDataAccess.IsContactExist(ID);
        }
    }
}
