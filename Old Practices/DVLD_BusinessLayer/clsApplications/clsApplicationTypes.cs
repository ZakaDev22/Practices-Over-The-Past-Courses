using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DVLD_DataAccess;


namespace DVLD_BusinessLayer
{
    public class clsApplicationTypes
    {
      public  enum enMode { Update = 0 , nothing =1};
        enMode _Mode = enMode.nothing;

        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }

        public byte ApplicationFees { get; set; }

        clsApplicationTypes(int ApplicationID ,string ApplicationTitle ,byte ApplicationFees )
        {
            this.ApplicationTypeID = ApplicationID;
            this.ApplicationTypeTitle = ApplicationTitle;
            this.ApplicationFees = ApplicationFees;

            _Mode = enMode.Update;
        }

        public static clsApplicationTypes Find(int ID)
        {
            string Title = string.Empty;
            byte Fees = 0;

            if(clsApplicationTypesDataAccess.FindApplicationTypeByID(ID, ref Title, ref Fees))
            {
                return new clsApplicationTypes(ID, Title, Fees);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllApplication()
        {
            return clsApplicationTypesDataAccess.GetAlAplicaationTypes();
        }

        private bool _UpdateApplicationType()
        {

            return clsApplicationTypesDataAccess.UpdateApplicationTypeByID(this.ApplicationTypeID, this.ApplicationFees); ;
        }

        public  bool Save()
        {
            switch(_Mode)
            {
                case enMode.Update:

                    return _UpdateApplicationType();

                    case enMode.nothing:

                    return false;
                   
            }


            return false;
        }
    }
}
