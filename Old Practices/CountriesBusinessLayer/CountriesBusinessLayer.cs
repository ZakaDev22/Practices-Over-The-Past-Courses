using System;
using System.Data;
using CountriesDataAccessLayer2;

namespace CountriesBusinessLayer
{
    public class clsCountries
    {
        enum enMode { AddNew = 1, Update = 2 };
        enMode Mode = enMode.AddNew;

        public int ID { get; set; }
        public string CountryName { get; set; }

        public string Code { get; set; }

        public string PhoneCode { get; set; }

        public clsCountries()
        {
            this.ID = -1;
            this.CountryName = string.Empty;
            this.Code = string.Empty;
            this.PhoneCode = string.Empty;

            Mode = enMode.AddNew;
        }

        private clsCountries(int ID, string CountryName, string Code , string PhoneCode)
        {
            this.ID = ID;
            this.CountryName = CountryName;
            this.PhoneCode= PhoneCode;
            this.Code = Code;

            Mode = enMode.Update;
        }

        public static clsCountries Find(int ID)
        {
            string CountryName = string.Empty;
            string Code = string.Empty;
            string PhoneCode = string.Empty;

            if (clsCountriesDataAccess.GetCountryByID(ID, ref CountryName , ref Code , ref PhoneCode))
            {
                return new clsCountries(ID, CountryName, Code , PhoneCode);
            }
            else
            {
                return null;
            }
        }

        public static clsCountries Find(string CountryName)
        {
            int ID = 0;
            string Code = string.Empty;
            string PhoneCode = string.Empty;


            if (clsCountriesDataAccess.GetCountryByName( ref ID,  CountryName, ref Code, ref PhoneCode))
            {
                return new clsCountries(ID, CountryName,  Code,  PhoneCode);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewCountry()
        {
            this.ID = clsCountriesDataAccess.AddNewCountry(this.CountryName,this.Code,this.PhoneCode);

            return (this.ID != -1);
        }

        private bool _UpdateCountry()
        {
            return clsCountriesDataAccess.UpdateCountry(this.ID,this.CountryName,this.Code,this.PhoneCode);
        }

        public bool Save()
        {

            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateCountry();


            }

            return false;
        }


        public static bool Delete(int ID)
        {
            return clsCountriesDataAccess.DeleteCountry(ID);
        }

        public static DataTable ListCountries()
        {
            return clsCountriesDataAccess.ListCountry();
        }

        public static bool IsCountryExist(int ID)
        {
            return clsCountriesDataAccess.IsCountryExistByID(ID);
        }

        public static bool IsCountryExistByName(string CountryName)
        {
            return clsCountriesDataAccess.IsCountryExistByName(CountryName);
        }
    }
}
