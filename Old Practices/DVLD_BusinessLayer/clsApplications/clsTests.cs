using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTests
    {




        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;

        public int TestID { get; set; }

        public int TestAppointmentsID { get; set; }


        public bool TestResult { get; set; }

        public string Notes { get; set; }

        public int CreatedByUserID { get; set; }



        public clsTests()
        {
            this.TestID = -1;
            this.TestAppointmentsID = -1;
            this.TestResult = false;
            this.Notes = string.Empty;
            this.CreatedByUserID = -1;
           
            _Mode = enMode.AddNew;
        }

        public clsTests( int testID, int testAppointmentsID, bool testResult, string notes, int createdByUserID)
        {
           
            TestID = testID;
            TestAppointmentsID = testAppointmentsID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserID = createdByUserID;

            _Mode = enMode.Update; ;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestDataAccess.AddNewTest(this.TestAppointmentsID, this.TestResult
                                      , this.Notes, this.CreatedByUserID);

            return (this.TestID != -1);
        }

        private bool _UpdateTest()
        {
            return clsTestDataAccess.UpdateTest(this.TestID,this.TestAppointmentsID, this.TestResult
                                      , this.Notes, this.CreatedByUserID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTest())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTest();


            }

            return false;
        }

        public static clsTests Find(int ID)
        {

            int TestAppointmentID = -1;
            string Notes = string.Empty;
            int CreateByUserID = -1;
            bool TestResult = false;


            if (clsTestDataAccess.Find(ID, ref TestAppointmentID, ref Notes, ref CreateByUserID, ref TestResult))
            {
                return new clsTests(ID,TestAppointmentID,TestResult,Notes,CreateByUserID);
            }
            else
            {
                return null;
            }
        }


        public static bool IsValideTest(int TestAppointmentID)
        {
            return clsTestDataAccess.IsTestValide(TestAppointmentID);
        }

        public static bool IsPersonFailInTheLastTest(int TestAppointmentID,int TestType)
        {
            return clsTestDataAccess.IsPersonFailInTheLastTest(TestAppointmentID,TestType);
        }
        


    }

}
