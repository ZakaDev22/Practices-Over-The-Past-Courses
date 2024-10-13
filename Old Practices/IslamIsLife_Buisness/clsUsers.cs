using IslamIsLife_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IslamIsLife_Buisness
{
    public class clsUsers
    {

        // The Permissions For Users in The system
        enum enPermissions { AddNewStudent=1, UpdateStudent = 2, DeleteStudent = 4 ,AddNewUser =8,UpdateUser = 16, DeleteUser = 32 }
        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        // nullabel Members with <?> Mark
        public int? UserID { get; set; }
        public int? PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public int? Permissions { get; set; }



        clsPeople _PersonInfo;

      

        public clsUsers()
        {
            this.UserID = null;
            this.PersonID = null;
            this.UserName = null;
            this.Password = null;
            this.IsActive = false;

            this.Permissions = null;



            this._Mode = enMode.AddNew;
        }

       private clsUsers(int? userID,int? personid,string username,string password,bool isactive,int? permissions)
        {
            this.UserID = userID;
            this.PersonID = personid;
            this.UserName = username;
            this.Password = password;
            this.IsActive = isactive;
            this.Permissions = permissions;

            _PersonInfo = clsPeople.FindPersonWithID(personid);


            this._Mode = enMode.Update;

        }


        private bool _AddNewUser()
        {
            // Update data access
            this.UserID = clsUsers_DataAccess.AddNewUser(this.UserName, this.PersonID, this.Password, this.IsActive,
                                                            this.Permissions);

            return (this.UserID != null);
        }

        private bool _UpdateUser()
        {
           // Fill update Method.
            return clsUsers_DataAccess.UpdateUser(this.UserID,this.UserName, this.PersonID, this.Password, this.IsActive,
                                                            this.Permissions);
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                        return true;
                    else
                        return false;

                case enMode.Update:
                    return _UpdateUser();

            }

            return false;
        }

        public static clsUsers FindUserByID(int? UserID)
        {
            int? personID = null;
            string UserName = null;
            string Password = null;
            bool isActive = false;
            int? Permissions = null;

            // update data access
            bool IsFind = clsUsers_DataAccess.FindUserByID(UserID, ref UserName , ref personID, ref Password,ref isActive, ref Permissions);

            if (IsFind)
            {
                // update constructor.
                return new clsUsers(UserID, personID, UserName, Password, isActive, Permissions);
            }
            else
                return null;
        }

        public static clsUsers FindUserByName(string UserName)
        {
            int? personID = null;
            int? UserID = null;
            string Password = null;
            bool isActive = false;
            int? Permissions = null;

            // update data access
            bool IsFind = clsUsers_DataAccess.FindUserByName(UserName, ref personID, ref UserID, ref Password, ref isActive, ref Permissions);

            if (IsFind)
            {
                // update constructor.
                return new clsUsers(UserID, personID, UserName, Password, isActive, Permissions);
            }
            else
                return null;
        }

        

        public static clsUsers FindByUsernameAndPassword(string UserName,string Password)
        {
            int? personID = null;
            int? UserID = null;
            bool isActive = false;
            int? Permissions = null;

            // update data access
            bool IsFind = clsUsers_DataAccess.FindByUsernameAndPassword(UserName, Password, ref personID, ref UserID, ref isActive, ref Permissions);

            if (IsFind)
            {
                // update constructor.
                return new clsUsers(UserID, personID, UserName, Password, isActive, Permissions);
            }
            else
                return null;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUsers_DataAccess.DeleteUserWithID(UserID);
        }

        public static DataTable GetAllUsers()
        {
            return clsUsers_DataAccess.GetAllUsers();
        }

        public static int GetAllUsersCount()
        {
            return clsUsers_DataAccess.GetAllUsersCount();
        }

        public static bool IsUserExistByUserID(int UserID)
        {
            return clsUsers_DataAccess.IsUserExistByUserID(UserID);
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            return clsUsers_DataAccess.IsUserExistByPersonID(PersonID);
        }

        public static bool IsUserExistByUserName(string UserName)
        {
            return clsUsers_DataAccess.IsUserExistByUserName(UserName);
        }
    }
}

