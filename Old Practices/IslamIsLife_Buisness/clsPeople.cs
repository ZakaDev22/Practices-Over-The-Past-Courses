using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using IslamIsLife_DataAccess;

namespace IslamIsLife_Buisness
{
    public class clsPeople
    {

        enum enMode { AddNew =0,Update =1 }

        enMode _Mode = enMode.AddNew;

        // make all the members Nullabel.

        public int? PersonID { get; set; }

        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gendor { get; set; }

        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string Phone { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }

        public string ImagePath { get; set; }

        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string GendorName(bool Gendor)
        {
            switch(Gendor)
            {
                case true:
                    return "Male";

                    case false:
                    return "Female";

                default:
                    return "Unknown";
            }
        }

        public clsPeople()
        {
            this.PersonID = null;
            this.NationalNo = null;
            this.FirstName = null;
            this.LastName = null;
            this.Gendor = true;
            this.CountryName = null;
            this.CityName = null;
            this.Phone = null;
            this.DateOfBirth = null;
            this.Email = null;
            this.ImagePath = null;

            this._Mode = enMode.AddNew;
        }

        private clsPeople(int? PersonID, string FirstName, string LastName,string NationalNo, bool Gendor,string countryname,string cityname,string phone,
                                        DateTime? DateOfBirth, string Email, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gendor = Gendor;
            this.CountryName= countryname;
            this.CityName = cityname;
            this.Phone = phone;
            this.DateOfBirth = DateOfBirth;
            this.Email = Email;
            this.ImagePath = ImagePath;

            this._Mode = enMode.Update;
        }


        private bool _AddNewPerson()
        {
            this.PersonID = clsPeople_DataAccess.AddNewPerson(this.FirstName, this.LastName,this.NationalNo, this.Gendor,this.CountryName,this.CityName,this.Phone,
                        this.DateOfBirth,this.Email,this.ImagePath);

            return (this.PersonID != null);
        }

        private bool _UpdatePerson()
        {
            
            return clsPeople_DataAccess.UpdatePerson(this.PersonID,this.FirstName, this.LastName,this.NationalNo, this.Gendor,
                                                       this.CountryName, this.CityName, this.Phone,this.DateOfBirth, this.Email, this.ImagePath);
        }

        public bool Save()
        {
            switch(this._Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                        return true;
                    else
                        return false;

                case enMode.Update:
                    return _UpdatePerson();

            }

            return false;
        }

        public static clsPeople FindPersonWithID(int? PersonID)
        {
            string FirstName = null;
            string LastName = null;
            string NationalNo = null;
            bool Gendor = false;
            DateTime? DateOfBirth = null;
            string Email = null;
            string ImagePath = null;
            string countryNmae = null;
            string cityNmae = null;
            string phone = null;

            bool IsFind = clsPeople_DataAccess.FindPersonByID(PersonID,ref FirstName,ref LastName,ref NationalNo,ref Gendor,ref countryNmae,
                                                                  ref cityNmae,ref phone,ref DateOfBirth,ref Email,ref ImagePath);

            if (IsFind)
            {
                return new clsPeople(PersonID, FirstName, LastName, NationalNo, Gendor, countryNmae,cityNmae,phone, DateOfBirth, Email, ImagePath);
            }
            else
                return null;
        }

        public static clsPeople FindPersonByNationalNo(string NationalNo)
        {
            string FirstName = null;
            string LastName = null;
            int? PersonID = null;
            bool Gendor = false;
            DateTime? DateOfBirth = null;
            string Email = null;
            string ImagePath = null;
            string countryNmae = null;
            string cityNmae = null;
            string phone = null;

            bool IsFind = clsPeople_DataAccess.FindPersonByNationalNo(NationalNo,ref PersonID, ref FirstName, ref LastName, ref Gendor, ref countryNmae,
                                                                  ref cityNmae, ref phone, ref DateOfBirth, ref Email, ref ImagePath);

            if (IsFind)
            {
                return new clsPeople(PersonID, FirstName, LastName, NationalNo, Gendor, countryNmae, cityNmae, phone, DateOfBirth, Email, ImagePath);
            }
            else
                return null;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPeople_DataAccess.DeletePersonWithID(PersonID);
        }

        public static DataTable GetAllPeople()
        {
            return clsPeople_DataAccess.GetAllPeople();
        }

        public static int GetAllPeopleCount()
        {
            return clsPeople_DataAccess.GetAllPeopleCount();
        }

        public static bool isPersonExist(string NationalNo)
        {
            return clsPeople_DataAccess.IsPersonExist(NationalNo);
        }

        public static bool isPersonExist(int PersonID)
        {
            return clsPeople_DataAccess.IsPersonExist(PersonID);
        }
    }
}
