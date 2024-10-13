using IslamIsLife_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslamIsLife_Buisness
{
    public class clsTests
    {
        enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        // make The Test Membes And data Acceess Her insted of books Methods and members

        public int? TestID { get; set; }
        public int? PersonID { get; set; }
        public int? TeacherID { get; set; }

        public int? BookID { get; set; }

        public byte? SurahNo { get; set; }

        public short? FromVerse { get; set; }
        public short? ToVerse { get; set; }

        public DateTime? TestDate { get; set; }
        public bool Result { get; set; }

        // using Compostion
        clsPeople _StudentInfo;
        clsTeachers _Teacher_Info;
        clsBooks _Book_Info;



        public clsTests()
        {
            this.TestID = null;
            this.PersonID = null;
            this.TeacherID = null;
            this.BookID = null;
            this.SurahNo = null;
            this.FromVerse = null;
            this.ToVerse = null;
            this.TestDate = null;
            this.Result = false;

            this._Mode = enMode.AddNew;
        }

       private clsTests( int? testID, int? personID, int? teacherID, int? bookID, byte? surahNo, short? fromVerse, short? toVerse, DateTime? testDate, bool result)
        {
           
            TestID = testID;
            PersonID = personID;
            TeacherID = teacherID;
            BookID = bookID;
            SurahNo = surahNo;
            FromVerse = fromVerse;
            ToVerse = toVerse;
            TestDate = testDate;
            Result = result;

            _StudentInfo = clsPeople.FindPersonWithID(this.PersonID); // fill Student Object With His Information

            _Teacher_Info = clsTeachers.FindTeacherByID(this.TeacherID); // fill Teacher Object With His Information

            _Book_Info = clsBooks.FindBookWithID(this.BookID); // fill Book Object With His Information


            _Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            this.TestID = clsTestsDataAccess.AddNewTest(this.PersonID, this.TeacherID, this.BookID, this.SurahNo,
                                                        this.FromVerse, this.ToVerse, this.TestDate, this.Result);

            return (this.BookID != -1);
        }

        private bool _UpdateTest()
        {

            return clsTestsDataAccess.UpdateTest(this.TestID, this.PersonID, this.TeacherID, this.BookID, this.SurahNo,
                                                        this.FromVerse, this.ToVerse, this.TestDate, this.Result);
        }

        public bool Save()
        {
            switch (this._Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                        return true;
                    else
                        return false;

                case enMode.Update:
                    return _UpdateTest();

            }

            return false;
        }

        public static clsTests FindTestWithID(int? TestID)
        {
            int? PersonID = null;
            int? TeacherID = null;
            int? BookID = null;
            byte? SurahNo = null;
            short? FromVerse = null;
            short? ToVerse = null;
            DateTime? TestDate = null;
            bool Result = false;


            bool IsFind = clsTestsDataAccess.FindTestByID(TestID, ref PersonID, ref TeacherID, ref BookID,
                                                                  ref SurahNo, ref FromVerse, ref ToVerse, ref TestDate, ref Result);

            if (IsFind)
            {
                return new clsTests(TestID,  PersonID,  TeacherID, BookID,SurahNo, FromVerse, ToVerse, TestDate, Result);
            }
            else
                return null;
        }

        public static bool DeleteTest(int TestID)
        {
            return clsTestsDataAccess.DeleteTestWithID(TestID);
        }

        public static DataTable GetAllTests()
        {
            return clsTestsDataAccess.GetAllTests();
        }

        public static int GetAllTestsCount()
        {
            return clsTestsDataAccess.GetAllTestsCount();
        }
    }
}
