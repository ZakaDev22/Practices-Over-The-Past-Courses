using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLocalLicense
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;

        public int LocalDrivingLicenseApplicationID { get; set; }

        public int ApplicationID { get; set; }

        public int LicenseClassID { get; set; }



        public clsLocalLicense()
        {
           this.LocalDrivingLicenseApplicationID = 0;
            this.ApplicationID = 0;
            this.LicenseClassID = 0;

            _Mode = enMode.AddNew;
        }

        public clsLocalLicense( int localDrivingLicenseApplicationID, int applicationID, int licenseClassID)
        {
            this.LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.ApplicationID = applicationID;
            this.LicenseClassID = licenseClassID;

            _Mode = enMode.Update;

        }

        private bool _AddNewLocalLicense()
        {
            this.LocalDrivingLicenseApplicationID = clsLocalLicenseDataAccess.AddNewLocalLicense( this.ApplicationID,this.LicenseClassID);

            return (this.LocalDrivingLicenseApplicationID != -1);
        }

        private bool _UpdateLocalLicense()
        {
            return clsLocalLicenseDataAccess.UpdateLocalLicense(this.LocalDrivingLicenseApplicationID,
                                                                this.ApplicationID, this.LicenseClassID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewLocalLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLocalLicense();


            }

            return false;
        }

        public static clsLocalLicense Find(int ID)
        {

            int ApplicationID = 0;
          int   LicenseID = 0;
           

            if (clsLocalLicenseDataAccess.Find(ID,ref ApplicationID,ref LicenseID))
            {
                return new clsLocalLicense(ID,ApplicationID,LicenseID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllLocalLicense_View()
        {
            return clsLocalLicenseDataAccess.GetLocalLicense_View();
        }

        public static bool DeleteLicense(int LocalLcensID)
        {
            return clsLocalLicenseDataAccess.DeleteLicense(LocalLcensID);
        }
    }
}
