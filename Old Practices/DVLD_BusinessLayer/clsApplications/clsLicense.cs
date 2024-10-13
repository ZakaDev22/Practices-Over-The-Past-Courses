using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicense
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;

        public int LicenseID { get; set; }

        public int ApplicationID { get; set; }

        public int DriverID { get; set; }

        public int LicenseClasseID { get; set; }

        public DateTime IssueDate { get; set; }

        public DateTime ExpirationDate { get; set; }

        public string Notes { get; set; }

        public int PaidFees { get; set; }

        public bool IsActive { get; set; }

        public byte IssueReason { get; set; }

        public int CreateByUserID { get; set; }

        public int ValidityYear { get; set; }


        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationID = -1;
            this.DriverID = -1;
            this.LicenseClasseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;

            this.Notes = string.Empty;
            this.PaidFees = 0;

            this.IsActive = false;
            this.IssueReason = 0;
            this.CreateByUserID = -1;

            _Mode = enMode.AddNew;
        }

        public clsLicense( int licenseID, int applicationID, int driverID, int licenseClasseID, DateTime issueDate, DateTime expirationDate, string notes, int paidFees, bool isActive, byte issueReason, int createByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseClasseID = licenseClasseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreateByUserID = createByUserID;

            _Mode = enMode.Update;

        }

        private bool _AddNewLicense()
        {
            this.LicenseID = clsLicenseDataAccess.AddNewLicense(this.ApplicationID, this.DriverID,
                                                      this.LicenseClasseID, this.IssueDate,this.ExpirationDate,
                                                       this.Notes, this.PaidFees,this.IsActive,this.IssueReason,this.CreateByUserID);

            return (this.LicenseID != -1);
        }

        private bool _UpdateLicense()
        {
            return clsLicenseDataAccess.UpdateLicense(this.LicenseID,this.ApplicationID, this.DriverID,
                                    this.LicenseClasseID, this.IssueDate, this.ExpirationDate,
                                    this.Notes, this.PaidFees, this.IsActive, this.IssueReason, this.CreateByUserID);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateLicense();


            }

            return false;
        }

        public static clsLicense FindByApplicatioID(int ApplicationID)
        {

            int LicenseID = -1;  int DriverID = -1;  int LicenseClasseID = -1; DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now; string Notes = string.Empty;

            int PaidFees = 0;  bool IsActive = false;  byte IssueReason = 0;  int CreateByUserID = -1;

        if (clsLicenseDataAccess.FindByApplicationID(ApplicationID, ref LicenseID, ref DriverID,
                                             ref LicenseClasseID, ref IssueDate,
                   ref ExpirationDate, ref Notes, ref PaidFees,ref IsActive,ref IssueReason,ref CreateByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClasseID, IssueDate,
                                  ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreateByUserID);
            }
            else
            {
                return null;
            }
        }

        public static clsLicense FindByLicenseID(int LicenseID)
        {

            int ApplicationID = -1; int DriverID = -1; int LicenseClasseID = -1; DateTime IssueDate = DateTime.Now;

            DateTime ExpirationDate = DateTime.Now; string Notes = string.Empty;

            int PaidFees = 0; bool IsActive = false; byte IssueReason = 0; int CreateByUserID = -1;

            if (clsLicenseDataAccess.FindByLicenseID(LicenseID, ref ApplicationID, ref DriverID,
                                                 ref LicenseClasseID, ref IssueDate,
                       ref ExpirationDate, ref Notes, ref PaidFees, ref IsActive, ref IssueReason, ref CreateByUserID))
            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClasseID, IssueDate,
                                  ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreateByUserID);
            }
            else
            {
                return null;
            }
        }

        public static bool IsThisPersonHasThisLicense(int DriverID , int LicenseclassID)
        {
            return clsLicenseDataAccess.IsThisPersonHasThisLicense(DriverID, LicenseclassID);
        }

        public static DataTable GetPersonLicenseHistory(int PersonID)
        {
            return  clsLicenseDataAccess.GetPersonLicenseHistory(PersonID);
        }

        public static bool IsLicenseActiveAndType_3(int LicenseID)
        {
            return clsLicenseDataAccess.ISLicenseActiveAndType_3(LicenseID);
        }

        public static bool IsLicenseActive(int LicenseID)
        {
            return clsLicenseDataAccess.ISLicenseActive(LicenseID);
        }

        public static bool IsLicenseNotExpired(int LicenseID,DateTime ExpirationDate)
        {
            return clsLicenseDataAccess.IsLicenseNotExpired(LicenseID,ExpirationDate);
        }
    }

}
