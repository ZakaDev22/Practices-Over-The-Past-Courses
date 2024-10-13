using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsApplications
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;

        public int ApplicationID { get; set; }

        public int ApplicationPersonID { get; set; }

        public DateTime ApplicationDate { get; set; }

        public int ApplicationTypeID { get; set; }

        public string ApplicationStatus { get; set; }

        public DateTime LastStatusDate { get; set; }

        public int PaidFees { get; set; }

        public int CreateByUserID { get; set; }



        public clsApplications()
        {
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = "New";
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreateByUserID = -1;

            _Mode = enMode.AddNew;
        }

        public clsApplications( int applicationID, int applicationPersonID, DateTime applicationDate, int applicationTypeID, string applicationStatus, DateTime lastStatusDate, int paidFees, int createByUserID)
        {

             this.ApplicationID = applicationID;
             this.ApplicationPersonID = applicationPersonID;
             this.ApplicationDate = applicationDate;
             this.ApplicationTypeID = applicationTypeID;
             this.ApplicationStatus = applicationStatus;
             this.LastStatusDate = lastStatusDate;
             this.PaidFees = paidFees;
             this.CreateByUserID = createByUserID;

            _Mode = enMode.Update;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationDataAccess.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate,
                                                                            this.ApplicationTypeID,this.ApplicationStatus,this.LastStatusDate,
                                                                            this.PaidFees,this.CreateByUserID);

            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationDataAccess.UpdateApplication(this.ApplicationID,this.ApplicationPersonID, this.ApplicationDate,
                                                            this.ApplicationTypeID, this.ApplicationStatus, this.LastStatusDate,
                                                              this.PaidFees, this.CreateByUserID);
        }

        public static bool _DeleteApplication(int ID)
        {
            return true;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();


            }

            return false;
        }

        public static clsApplications Find(int ID)
        {


            int ApplicationPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            int ApplicationTypeID = -1;
            string ApplicationStatus = "";
            DateTime LastStatusDate = DateTime.Now;
            int PaidFees = 0;
            int CreateByUserID = -1;

            if (clsApplicationDataAccess.Find(ID, ref ApplicationPersonID, ref ApplicationDate,
                                             ref ApplicationTypeID, ref ApplicationStatus,
                                             ref LastStatusDate,ref PaidFees , ref CreateByUserID))
            {
                return new clsApplications(ID, ApplicationPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus,
                                                LastStatusDate, PaidFees, CreateByUserID);
            }
            else
            {
                return null;
            }
        }
        

    }


}

