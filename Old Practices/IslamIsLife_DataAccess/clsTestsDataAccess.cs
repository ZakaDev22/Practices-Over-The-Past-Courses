using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace IslamIsLife_DataAccess
{
    public class clsTestsDataAccess
    {

        public static int? AddNewTest(int? PersonID, int? TeacherID, int? BookID, byte? SurahNo, short? FromVerse,
                                                short? ToVerse, DateTime? TestDate, bool Result)
        {
            int? Id = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsSettings.ConnectionString))
                {
                    conn.Open();

                    string query = @"Insert into Tests Values (
                                        PersonID = @PersonID,
                                        TeacherID = @TeacherID,
                                        BookID = @BookID,
                                        SurahNo = @SurahNo,
                                        FromVerse = @FromVerse, 
                                        ToVerse = @ToVerse,
                                        TestDate = @TestDate,
                                        Result = @Result
                                   Select Scope_Identity()";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                        cmd.Parameters.AddWithValue("@ISBN", BookID);
                        cmd.Parameters.AddWithValue("@SurahNo", SurahNo);

                        cmd.Parameters.AddWithValue("@FromVerse", FromVerse);

                        cmd.Parameters.AddWithValue("@ToVerse", ToVerse);

                        cmd.Parameters.AddWithValue("@TestDate", TestDate);

                        cmd.Parameters.AddWithValue("@Result", Result);





                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int InsertedID))
                        {
                            Id = InsertedID;
                        }
                    }
                }
            }
            catch { }

            return Id;
        }

        public static bool UpdateTest(int? TestID,int? PersonID, int? TeacherID, int? BookID, byte? SurahNo, short? FromVerse,
                                                short? ToVerse, DateTime? TestDate, bool Result)
        {
            int RowEffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsSettings.ConnectionString))
                {
                    conn.Open();

                    string query = @"Update Tests Values (
                                        PersonID = @PersonID,
                                        TeacherID = @TeacherID,
                                        BookID = @BookID,
                                        SurahNo = @SurahNo,
                                        FromVerse = @FromVerse, 
                                        ToVerse = @ToVerse,
                                        TestDate = @TestDate,
                                        Result = @Result
                                   where TestID = @TestID
                                   Select Scope_Identity()";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@TeacherID", TeacherID);
                        cmd.Parameters.AddWithValue("@ISBN", BookID);
                        cmd.Parameters.AddWithValue("@SurahNo", SurahNo);

                        cmd.Parameters.AddWithValue("@FromVerse", FromVerse);

                        cmd.Parameters.AddWithValue("@ToVerse", ToVerse);

                        cmd.Parameters.AddWithValue("@TestDate", TestDate);

                        cmd.Parameters.AddWithValue("@Result", Result);

                        cmd.Parameters.AddWithValue("@TestID", TestID);

                        RowEffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }

            return (RowEffected > 0);
        }

        public static bool FindTestByID(int? TestID,ref int? PersonID, ref int? TeacherID, ref int? BookID, ref byte? SurahNo, ref short? FromVerse,
                                               ref short? ToVerse, ref DateTime? TestDate, ref bool Result)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Tests Where TestID = @TestID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@TestID", TestID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud = true;

                                PersonID = (int?)reader["PersonID"];
                                TeacherID = (int?)reader["TeacherID"];
                                BookID = (int?)reader["BookID"];
                                SurahNo = Convert.ToByte(reader["SurahNo"]);
                                FromVerse = Convert.ToInt16(reader["FromVerse"]);
                                ToVerse = Convert.ToInt16(reader["ToVerse"]);
                                TestDate = (DateTime)reader["TestDate"];
                                Result = (Boolean)reader["Result"];

                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }

            return IsFoud;
        }


        public static bool DeleteTestWithID(int TestID)
        {
            int IsDeleted = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Delete From Tests Where TestID = @TestID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TestID", TestID);

                        IsDeleted = cmd.ExecuteNonQuery();
                    }
                }

            }
            catch { }



            return (IsDeleted > 0);
        }

        public static DataTable GetAllTests()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from ManageTests_View";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }

                }


            }
            catch { }

            return dt;

        }

        public static int GetAllTestsCount()
        {
            int TestsNumber = 0;

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select Count(*) As TestsNumbers from Tests";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TestsNumber = (int)reader[0];
                            }
                        }
                    }

                }


            }
            catch { }

            return TestsNumber;

        }
    }
}
