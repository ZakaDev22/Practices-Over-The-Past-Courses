using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;

namespace DVLD_BusinessLayer
{
    public class clsCountry
    {

        public int ID { get; set; }
        public string CountryName { get; set; }

        public clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
        }

        public static clsCountry FindCountryByID(int ID)
        {
            string CountryName = "";

            if(clsCountryDataAccess.GetCountryByID(ID,ref CountryName))
            {
                return new clsCountry(ID,CountryName);
            }
            else
                return null;
        }

        public static clsCountry FindCountryByName(string CountryName)
        {
            int ID = 0;

            if (clsCountryDataAccess.GetCountryByName(CountryName, ref ID))
            {
                return new clsCountry(ID, CountryName);
            }
            else
                return null;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.ListCountries();
        }
    }
}
