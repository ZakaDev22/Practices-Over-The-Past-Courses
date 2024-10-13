using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;

        public int InternationalLicenseID { get; set; }

        public int ApplicationID { get; set; }

        public int DriverID { get; set; }

        public int IssuedUsingLocalLicenseID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public bool IsActive { get; set; }


        public int CreateByUserID { get; set; }


        public clsInternationalLicense()
        {
            this.InternationalLicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = this.IssueDate.AddYears(1);
            this.IsActive = false;
            this.CreateByUserID = -1;

            _Mode = enMode.AddNew;
        }

        public clsInternationalLicense(int internationalLicenseID, int applicationID, int driverID, int localLicenseID,
                                        DateTime issuedDate, DateTime exparationDate, bool isActive, int createdByUserID)
        {
            this.InternationalLicenseID = internationalLicenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.IssuedUsingLocalLicenseID = localLicenseID;
            this.IssueDate = issuedDate;
            this.ExpirationDate = exparationDate;
            this.IsActive = isActive;
            this.CreateByUserID = createdByUserID;

            _Mode = enMode.Update;
        }

        private bool _AddNewInternationalLicense()
        {
            this.InternationalLicenseID = clsInternationalLicenseDataAccess.AddNewInternationalLicense(this.ApplicationID, this.DriverID,
                                                      this.IssuedUsingLocalLicenseID, this.IssueDate,
                                                        this.ExpirationDate, this.IsActive, this.CreateByUserID);

            return (this.InternationalLicenseID != -1);
        }

        private bool _UpdateInternationalLicense()
        {
            return clsInternationalLicenseDataAccess.UpdateInternationalLicense(this.InternationalLicenseID, this.ApplicationID, this.DriverID,
                                                      this.IssuedUsingLocalLicenseID, this.IssueDate,
                                                        this.ExpirationDate, this.IsActive, this.CreateByUserID);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewInternationalLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateInternationalLicense();


            }

            return false;
        }


        public static clsInternationalLicense FindByInternationalLicenseID(int internationalLicenseID)
        {

            int IssuedUsingLocalLicenseID = -1; int ApplicationID = -1; int DriverID = -1;  DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now;

            bool IsActive = false;  int CreateByUserID = -1;

            if (clsInternationalLicenseDataAccess.FindByInternationalLicenseID(internationalLicenseID, ref ApplicationID, ref DriverID,
                                                 ref IssuedUsingLocalLicenseID, ref IssueDate,ref ExpirationDate, ref IsActive,  ref CreateByUserID))
            {
                return new clsInternationalLicense(internationalLicenseID,  ApplicationID,  DriverID,
                                       IssuedUsingLocalLicenseID,  IssueDate,  ExpirationDate,  IsActive, CreateByUserID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetPersonInternationalLicenseHistory(int PersonID)
        {
            return clsInternationalLicenseDataAccess.GetPersonInternationalLicenseHistory(PersonID);
        }

        public static bool IsPersonHaveActiveInternationalLicense(int InternationalLicenseID)
        {
            return clsInternationalLicenseDataAccess.IsPersonHaveActiveInternationalLicense(InternationalLicenseID);
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicenseDataAccess.GetAllInternationalLicenses();
        }
    }
}  
