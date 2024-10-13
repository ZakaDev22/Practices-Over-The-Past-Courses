using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDetainedLicenses
    {

        // make All This Function To Deatined Licenses.
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;

        public int DetainID { get; set; }

        public int LicenseID { get; set; }

        public DateTime DetainDate { get; set; }

        public short FineFees { get; set; }

        public int CreatedByUserID { get; set; }

        public bool IsReleased { get; set; }

        public DateTime ReleaseDate { get; set; }


        public int ReleasedByUserID { get; set; }

        public int ReleaseApplicationID { get; set; }


        public clsDetainedLicenses()
        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            // this.ReleaseDate;
            // this.ReleasedByUserID;
            //this.ReleaseApplicationID;

            _Mode = enMode.AddNew;
        }

        public clsDetainedLicenses(int detainID, int licenseID, DateTime detainDate, short fineFees, int createdByUserID, bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
             this.DetainID = detainID;
             this.LicenseID = licenseID;
             this.DetainDate = detainDate;
             this.FineFees = fineFees;
             this.CreatedByUserID = createdByUserID;
             this.IsReleased = isReleased;
             this.ReleaseDate = releaseDate;
             this.ReleasedByUserID = releasedByUserID;
             this.ReleaseApplicationID = releaseApplicationID;
             
            _Mode = enMode.Update;
             
        }

        private bool _AddNewDetainedLicense()
        {
            this.DetainID = clsDetainedLicensesDataAccess.AddNewDetainedLicense(this.LicenseID, this.DetainDate,
                                                      this.FineFees, this.CreatedByUserID,this.IsReleased);

            return (this.DetainID != -1);
        }

        private bool _UpdateDetainedLicense()
        {
            return clsDetainedLicensesDataAccess.UpdateDetainedLicense(this.LicenseID, this.IsReleased,
                                                                       this.ReleaseDate,this.ReleasedByUserID,this.ReleaseApplicationID);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewDetainedLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateDetainedLicense();


            }

            return false;
        }


         // make find Function To this detained Class  == Done.
        public static clsDetainedLicenses FindByDetainedLicenseID(int licenseID)
        {
            int detainedLicenseID = -1;
            DateTime detainDate = DateTime.Now;
            short fineFees = 0;
            int createdByUserID = -1;
            bool isReleased = false;
            DateTime releaseDate = DateTime.Now;
            int releasedByUserID = -1;
            int releaseApplicationID = -1;

            if (clsDetainedLicensesDataAccess.FindByDetainedLicenseID(licenseID, ref detainedLicenseID, ref detainDate,
                                                 ref fineFees, ref createdByUserID, ref isReleased
                                                    , ref releaseDate, ref releasedByUserID,ref releaseApplicationID))
            {
                return new clsDetainedLicenses(detainedLicenseID,  licenseID,  detainDate,
                                                  fineFees,  createdByUserID,  isReleased
                                                    ,  releaseDate,  releasedByUserID, releaseApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static bool isDetainedLicense(int LicenseID)
        {
            return clsDetainedLicensesDataAccess.isDetainedLicense(LicenseID);
        }




        public static DataTable GetAllDetainedLicenses()
        {
            return clsDetainedLicensesDataAccess.GetAllDetainedLicenses();
        }
    }
}
