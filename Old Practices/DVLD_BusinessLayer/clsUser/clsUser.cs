using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode _Mode = enMode.AddNew;
        public int UserID { get; set; }

        public int PersonID { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActived { get; set; }



        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.IsActived = false;

            _Mode = enMode.AddNew;
        }

        public clsUser(int userID, int personID, string userName, string password, bool isActived)
        {
            this.UserID = userID;
            this.PersonID = personID;
            this.UserName = userName;
            this.Password = password;
            this.IsActived = isActived;

            _Mode = enMode.Update;
        }

        private  bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActived);

            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActived);
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();


            }

            return false;
        }

        public static clsUser Find(int ID)
        {
            string UserName = "", Password = "";
            int PersonID = -1;
            bool IsActive = false;

            if(clsUserDataAccess.Find(ID,ref PersonID,ref UserName,ref Password,ref IsActive))
            {
                return new clsUser(ID,PersonID,UserName,Password,IsActive);
            }
            else
            {
                return null;
            }
        }

        public static clsUser IsUserExiste(string UserName,string Password)
        {
            int userID = -1, PersonID = -1;
            bool isActived = false;

            if (clsUserDataAccess.IsUserExist(UserName, Password, ref userID, ref PersonID, ref isActived))
            {
                return new clsUser(userID, PersonID, UserName, Password, isActived);
            }
            else
                return null;
        }

        public static bool IsUserExisteByID(int ID)
        {
            return clsUserDataAccess.IsUserExistByPersonID(ID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static bool DeleteUserByID(int ID)
        {
            return clsUserDataAccess.DeleteUserByID(ID);
        }
    }
}
