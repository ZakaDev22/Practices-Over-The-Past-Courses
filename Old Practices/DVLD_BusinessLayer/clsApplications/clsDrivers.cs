using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDrivers
    {


        public int DriverID { get; set; }

        public int PersonID { get; set; }

        public int CreatedByUserID { get; set; }

        public DateTime CreatedDate { get; set; }



        public clsDrivers()
        {
            this.DriverID = -1;
            this.PersonID = -1;
            this.CreatedDate = DateTime.Now;
            this.CreatedByUserID = -1;

        }

        public clsDrivers(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
        }

        private  bool _AddNewDriver()
        {
            this.DriverID = clsDriversDataAccess.AddNewDriver(this.PersonID, this.CreatedByUserID
                                      , this.CreatedDate);

            return (this.DriverID != -1);
        }

        public  bool Save()
        {
            if(_AddNewDriver())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDriverExiste(int PersonID)
        {
            return clsDriversDataAccess.IsDriverExiste(PersonID);
        }

        public static clsDrivers Find(int PersonID)
        {
            int DriverID = -1;
             DateTime CreatedDate = DateTime.Now;
            int CreatedByUserID = -1;

            if(clsDriversDataAccess.Find(PersonID,ref DriverID,ref CreatedDate, ref CreatedByUserID))
            {
                return new clsDrivers(DriverID,PersonID, CreatedByUserID, CreatedDate);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllDrivers()
        {
            return clsDriversDataAccess.GetAllDrivers();
        }
    }
}
