using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestTypes
    {
        public enum enMode { Update = 0, nothing = 1 };
        enMode _Mode = enMode.nothing;

        public int TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }

        public string TestTypeDescription { get; set; }

        public byte TestTypeFees { get; set; }

        clsTestTypes(int TestTypeID, string TestTypeTitle,string TestTypeDescription, byte TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;

            _Mode = enMode.Update;
        }

        public static clsTestTypes Find(int ID)
        {
            string Title = string.Empty;
            string Description = string.Empty;
            byte Fees = 0;

            if (clsTestTypesDataAccess.FindTestTypeByID(ID, ref Title,ref Description, ref Fees))
            {
                return new clsTestTypes(ID, Title,Description, Fees);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }

        private bool _UpdateTestType()
        {

            return clsTestTypesDataAccess.UpdateTestTypeByID(this.TestTypeID,this.TestTypeTitle, this.TestTypeFees); ;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Update:

                    return _UpdateTestType();

                case enMode.nothing:

                    return false;

            }


            return false;
        }

    }
}
