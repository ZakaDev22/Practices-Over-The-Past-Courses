using IslamIsLife_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslamIsLife_Buisness
{
    public class clsTeachers
    {
        // make All The Classes And Data Access First.

        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        // nullabel Members with <?> Mark
        public int? TeacherID { get; set; }
        public int? PersonID { get; set; }
        public int? UserID { get; set; }
        public byte? RecitationsNo { get; set; }
        public bool IsActive { get; set; }


       public clsUsers _UserInfo;
       public clsPeople _PersonInfo;



        public clsTeachers()
        {
            this.TeacherID = null;
            this.UserID = null;
            this.RecitationsNo = null;
            this.IsActive = false;


            this._Mode = enMode.AddNew;
        }

        public clsTeachers(int? teacherID,int? PersonID, int? UserID, byte? recitationsNo, bool isactive)
        {
            this.TeacherID = teacherID;
            this.PersonID = PersonID;
            this.UserID = UserID;
            this.RecitationsNo = recitationsNo;
            this.IsActive = isactive;

            _UserInfo = clsUsers.FindUserByID(UserID);
            _PersonInfo = clsPeople.FindPersonWithID(PersonID);


            this._Mode = enMode.Update;

        }


        private bool _AddNewTeacher()
        {
            // Update data access
            this.UserID = clsTeachersDataAccess.AddNewTeacher(this.PersonID,this.UserID, this.RecitationsNo, this.IsActive);

            return (this.UserID != -1);
        }

        private bool _UpdateTeacher()
        {
            // Fill update Method.
            return clsTeachersDataAccess.UpdateTeacher(this.TeacherID,this.PersonID, this.UserID, this.RecitationsNo, this.IsActive);
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTeacher())
                        return true;
                    else
                        return false;

                case enMode.Update:
                    return _UpdateTeacher();

            }

            return false;
        }

        public static clsTeachers FindTeacherByID(int? TeacherID)
        {
            int? PersonID = null;
            int? UserID = null;
            byte? RecitationsNo = null;
            bool isActive = false;

            // update data access
            bool IsFind = clsTeachersDataAccess.FindTeacherByID(TeacherID,ref PersonID, ref UserID, ref RecitationsNo, ref isActive);

            if (IsFind)
            {
                // update constructor.
                return new clsTeachers(TeacherID,PersonID, UserID, RecitationsNo, isActive);
            }
            else
                return null;
        }

        public static clsTeachers FindTeacherByUserID(int? UserID)
        {
            int? PersonID = null;
            int? TeacherID = null;
            byte? RecitationsNo = null;
            bool isActive = false;

            // update data access
            bool IsFind = clsTeachersDataAccess.FindTeacherByUserID(UserID, ref TeacherID, ref PersonID, ref RecitationsNo, ref isActive);

            if (IsFind)
            {
                // update constructor.
                return new clsTeachers(TeacherID, PersonID, UserID, RecitationsNo, isActive);
            }
            else
                return null;
        }

        

       public static clsTeachers FindTeacherByPersonID(int? PersonID)
        {
            int? UserID = null;
            int? TeacherID = null;
            byte? RecitationsNo = null;
            bool isActive = false;

            // update data access
            bool IsFind = clsTeachersDataAccess.FindTeacherByPersonID(PersonID , ref TeacherID, ref UserID, ref RecitationsNo, ref isActive);

            if (IsFind)
            {
                // update constructor.
                return new clsTeachers(TeacherID, PersonID, UserID, RecitationsNo, isActive);
            }
            else
                return null;
        }

        public static bool DeleteTeacher(int TeacherID)
        {
            return clsTeachersDataAccess.DeleteTeacherWithID(TeacherID);
        }

        public static DataTable GetAllTeachers()
        {
            return clsTeachersDataAccess.GetAllTeachers();
        }

        public static int GetAllTeachersCount()
        {
            return clsTeachersDataAccess.GetAllTeachersCount();
        }
    }
}
