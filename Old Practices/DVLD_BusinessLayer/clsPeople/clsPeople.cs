using DVLD_DataAccess;
using System;
using System.Data;
using System.Text;

namespace DVLD_BusinessLayer
{
    public class clsPeople
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string NationalNo { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gendor { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public int NationalityCountryID { get; set; }

        public string ImagePath { get; set; }

        public string FullName()
        {
            StringBuilder sb = new StringBuilder();

            if (FirstName != "" && SecondName != "" && ThirdName != "" && LastName != "")
            {
                sb.Append(FirstName + " "); sb.Append(SecondName + " "); sb.Append(ThirdName + " "); sb.Append(LastName);
            }

            sb.Append(FirstName + " ");
            sb.Append(SecondName);

            return sb.ToString();
        }

        public clsPeople()
        {
            this.ID = -1;
            this.NationalNo = string.Empty;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.ThirdName = string.Empty;
            this.LastName = string.Empty;
            this.DateOfBirth = DateTime.Now;
            this.Gendor = string.Empty;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Email = string.Empty;
            this.NationalityCountryID = -1;
            this.ImagePath = string.Empty;

            Mode = enMode.AddNew;
        }


        public clsPeople(int iD, string nationalNo, string firstName, string secondName,
            string thirdName, string lastName, DateTime dateOfBirth,
            string gendor, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            this.ID = iD;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.ImagePath = imagePath;

            Mode = enMode.Update;
        }

        public static clsPeople Find(int ID)
        {
            string NationalNo = string.Empty;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "", Gendor = "";
            DateTime DateOFBirth = DateTime.Now;
            int NationalityCountryID = 1;

            if (clsPeopleDataAccess.GetPersonInfoByID(ID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOFBirth, ref Gendor, ref Address, ref Phone, ref Email,
                         ref NationalityCountryID, ref ImagePath))
            {
                return new clsPeople(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOFBirth, Gendor, Address,
                                     Phone, Email, NationalityCountryID, ImagePath);
            }

            else
            {
                return null;
            }


        }

        public static clsPeople Find(string NationalNo)
        {
            //string NationalNo = string.Empty;
            int ID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "", Gendor = "";
            DateTime DateOFBirth = DateTime.Now;
            int NationalityCountryID = -1;

            if (clsPeopleDataAccess.GetPersonInfoByNationalNo(NationalNo, ref ID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOFBirth, ref Gendor, ref Address, ref Phone, ref Email,
                         ref NationalityCountryID, ref ImagePath))
            {
                return new clsPeople(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOFBirth, Gendor, Address,
                                     Phone, Email, NationalityCountryID, ImagePath);
            }

            else
            {
                return null;
            }


        }


        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

        //public static DataTable GetAllPeopleWithFilter(string Filter,string Obj)
        //{
        //    return clsPeopleDataAccess.GetAllPeopleWithFilter(Filter, Obj);
        //}

        private bool _AddNewPerson()
        {
            this.ID = clsPeopleDataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                                                 this.LastName, this.DateOfBirth, this.Gendor, this.Address,
                                                 this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return (this.ID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson(this.ID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName,
                                          this.LastName, this.DateOfBirth, this.Gendor, this.Address,
                                              this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdatePerson();


            }

            return false;
        }

        public static bool DeletePerson(int ID)
        {
            return clsPeopleDataAccess.DeletePersonByID(ID);
        }



        public static bool IsPersonExistByNationalNo(string NamtionalNo)
        {
            return clsPeopleDataAccess.IsPersonExistByNationalNo(NamtionalNo);
        }

    }
}
