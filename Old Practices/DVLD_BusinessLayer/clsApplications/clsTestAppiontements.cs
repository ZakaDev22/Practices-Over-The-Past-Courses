using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointements
    {


        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;

        public int TestAppointmentsID { get; set; }

        public int TestTypeID { get; set; }

        public int LocalDrivingLicenseID { get; set; }

        public DateTime AppointmentDate { get; set; }

        public short PaidFees { get; set; }

        public int CreateByUserID { get; set; }

        public bool IsLocked { get; set; }

        public int RetakeTestApplicationID { get; set; }

   

        public clsTestAppointements()
        {
            this.TestAppointmentsID = -1;
            this.TestTypeID = -1;
            this.LocalDrivingLicenseID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreateByUserID = -1;
            this.IsLocked = false;
            this.RetakeTestApplicationID = -1;

            _Mode = enMode.AddNew;
        }

        clsTestAppointements( int testAppointmentsID, int testTypeID, int localDrivingLicenseID, DateTime appointmentDate, short paidFees, int createByUserID, bool isLocked, int retakeTestApplicationID)
        {
          
            this.TestAppointmentsID = testAppointmentsID;
            this.TestTypeID = testTypeID;
            this.LocalDrivingLicenseID = localDrivingLicenseID;
            this.AppointmentDate = appointmentDate;
            this.PaidFees = paidFees;
            this.CreateByUserID = createByUserID;
            this.IsLocked = isLocked;
            this.RetakeTestApplicationID = retakeTestApplicationID;

            _Mode = enMode.Update;
        }

        private bool _AddNewAppointments()
        {
            this.TestAppointmentsID = clsTestAppointmentsDataAccess.AddNewAppointment(this.TestTypeID,this.LocalDrivingLicenseID
                                      ,this.AppointmentDate,this.PaidFees,this.CreateByUserID,this.IsLocked,this.RetakeTestApplicationID);

            return (this.TestAppointmentsID != -1);
        }

        private bool _UpdateAppointments()
        {
            return clsTestAppointmentsDataAccess.UpdateAppointment(this.TestAppointmentsID,this.TestTypeID, this.LocalDrivingLicenseID
                                      , this.AppointmentDate, this.PaidFees, this.CreateByUserID, this.IsLocked, this.RetakeTestApplicationID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewAppointments())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateAppointments();


            }

            return false;
        }

        public static clsTestAppointements Find(int ID)
        {

           int TestTypeID = -1;
           int LocalDrivingLicenseID = -1;
          DateTime  AppointmentDate = DateTime.Now;
           short PaidFees = 0;
         int   CreateByUserID = -1;
          bool  IsLocked = false;
           int RetakeTestApplicationID = -1;


            if (clsTestAppointmentsDataAccess.Find(ID,ref TestTypeID,ref LocalDrivingLicenseID,ref AppointmentDate,
                                                    ref PaidFees, ref CreateByUserID, ref IsLocked,ref RetakeTestApplicationID))
            {
                return new clsTestAppointements(ID,TestTypeID,LocalDrivingLicenseID,AppointmentDate,PaidFees,
                                                           CreateByUserID,IsLocked,RetakeTestApplicationID);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetallAppiontments(int ID,int TestType)
        {
            return clsTestAppointmentsDataAccess.GetallAppiontments(ID,TestType);
        }

        public static bool IsAppointmentExiste(int ID,int TestType)
        {
            return clsTestAppointmentsDataAccess.IsAppointmentExiste(ID,TestType);
        }

        public static bool IsAppointmentLocked(int TestAppointmentID)
        {
            return clsTestAppointmentsDataAccess.IsAppointmentLocked(TestAppointmentID);
        }
    }
}
