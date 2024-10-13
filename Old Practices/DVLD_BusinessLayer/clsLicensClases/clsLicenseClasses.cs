using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicenseClasses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;

        public int LicenseClassID { get; set; }
        public string LicenseClassName { get; set; }

        public string LicenseClassDescription { get; set; }

        public byte Age { get; set; }


        public byte DefaultValidityLength { get; set; }

        public short ClassFees { get; set; }


        public clsLicenseClasses()
        {
            this.LicenseClassID = -1;
            this.LicenseClassName = "";
            this.LicenseClassDescription = "";
            this.Age = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
           

            _Mode = enMode.AddNew;
        }

        public clsLicenseClasses(int LicenseClassID, string LicenseClassName, string LicenseClassDescription,
                                   byte age,byte DefaultValidityLength,short ClassFees)
        {

            this.LicenseClassID = LicenseClassID;
            this.LicenseClassName = LicenseClassName;
            this.LicenseClassDescription = LicenseClassDescription;
            this.Age = age;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;
           
            _Mode = enMode.Update;
        }

      

        public static clsLicenseClasses FindByID(int ID)
        {


          
           string  LicenseClassName = "";
          string  LicenseClassDescription = "";
          byte  Age = 0;
          byte  DefaultValidityLength = 0;
         short   ClassFees = 0;

            if (clsLicenseClassesDataAccess.Find(ID,ref LicenseClassName,ref LicenseClassDescription,
                                                    ref Age,ref DefaultValidityLength,ref ClassFees))
            {
                return new clsLicenseClasses(ID,LicenseClassName,LicenseClassDescription,Age,DefaultValidityLength,ClassFees);
            }
            else
            {
                return null;
            }
        }

        public static clsLicenseClasses FindByName(string Name)
        {



            int ID = 0;
            string LicenseClassDescription = "";
            byte Age = 0;
            byte DefaultValidityLength = 0;
            short ClassFees = 0;

            if (clsLicenseClassesDataAccess.Find(Name, ref ID, ref LicenseClassDescription,
                                                    ref Age, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClasses(ID, Name, LicenseClassDescription, Age, DefaultValidityLength, ClassFees);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllLicense()
        {
            return clsLicenseClassesDataAccess.GetAllLicense();
        }

    }
}
