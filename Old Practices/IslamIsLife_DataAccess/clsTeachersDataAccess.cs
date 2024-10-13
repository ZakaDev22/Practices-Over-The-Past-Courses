using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslamIsLife_DataAccess
{
    public class clsTeachersDataAccess
    {

        public static int? AddNewTeacher(int? PersonID,int? UserID, byte? RecitationsNo, bool IsActive)
        {
            int? TeacherID = null;


            try
            {
                // replace The New Members with The Old one..

                using (var Connection = new SqlConnection(clsSettings.ConnectionString))
                {

                    Connection.Open();

                    string query = @"Insert into Teachers Values (
                              PersonID = @PersonID,
                              UserID = @UserID,
                              RecitationsNo = @RecitationsNo,
                              IsActive = @IsActive,
                            Select Scope_Identity()";

                    using (SqlCommand cmd = new SqlCommand(query, Connection))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@UserName", UserID);
                        cmd.Parameters.AddWithValue("@RecitationsNo", RecitationsNo);


                        if (IsActive)
                        {
                            cmd.Parameters.AddWithValue("@IsActive", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsActive", 0);
                        }



                        object Result = cmd.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                        {
                            TeacherID = InsertedID;
                        }

                    }




                }


            }
            catch
            {
                // Return False // Person = -1
            }


            return TeacherID;
        }

        public static bool UpdateTeacher(int? TeacherID,int? PersonID,int? UserID, byte? RecitationsNo, bool IsActive)
        {
            int? RowEffected = null;

            try
            {

                using (var Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"Update  Teachers 
                            Set  PersonID = @PersonID,
                                 UserID = @UserID,
                                 RecitationsNo = @RecitationsNo,
                                 IsActive = @IsActive,
                                 where TeacherID = @TeacherID";

                    using (SqlCommand cmd = new SqlCommand(query, Connection))
                    {

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@RecitationsNo", RecitationsNo);


                        if (IsActive)
                        {
                            cmd.Parameters.AddWithValue("@IsActive", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsActive", 0);
                        }


                        cmd.Parameters.AddWithValue("@TeacherID", TeacherID);


                        RowEffected = cmd.ExecuteNonQuery();

                    }

                }


            }
            catch
            {
                // Return False // RowEffected = 0
            }


            return (RowEffected != 0);
        }


        public static bool FindTeacherByID(int? TeacherID,ref int? PersonID, ref int? UserID, ref byte? RecitationsNo, ref bool IsActive)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Teachers Where TeacherID = @TeacherID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@TeacherID", TeacherID);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud = true;
                                PersonID = (int)reader["PersonID"];
                                UserID = (int)reader["UserID"];
                                RecitationsNo = Convert.ToByte(reader["RecitationsNo"]);
                                IsActive = (Boolean)reader["IsActive"];
                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }



            return IsFoud;
        }

        public static bool FindTeacherByUserID(int? UserID, ref int? TeacherID,ref int? PersonID, ref byte? RecitationsNo, ref bool IsActive)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Teachers Where UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@UserID", UserID);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud = true;
                                TeacherID = (int)reader["TeacherID"];
                                PersonID = (int)reader["PersonID"];
                                RecitationsNo = Convert.ToByte(reader["RecitationsNo"]);
                                IsActive = (Boolean)reader["IsActive"];
                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }



            return IsFoud;
        }

        
        public static bool FindTeacherByPersonID(int? PersonID , ref int? TeacherID, ref int? UserID, ref byte? RecitationsNo, ref bool IsActive)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Teachers Where PersonID = @PersonID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud = true;
                                TeacherID = (int)reader["TeacherID"];
                                UserID = (int)reader["UserID"];
                                RecitationsNo = Convert.ToByte(reader["RecitationsNo"]);
                                IsActive = (Boolean)reader["IsActive"];
                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }



            return IsFoud;
        }

        public static bool DeleteTeacherWithID(int TeacherID)
        {
            int IsDeleted = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Delete From Teachers Where TeacherID = @TeacherID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TeacherID", TeacherID);

                        IsDeleted = cmd.ExecuteNonQuery();
                    }
                }

            }
            catch { }



            return (IsDeleted > 0);
        }

        public static DataTable GetAllTeachers()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "Select * from ManageTeachers_View";

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

        public static int GetAllTeachersCount()
        {
            int TeachersNumber = 0;

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select Count(*) As TeachersNumbers from Teachers";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TeachersNumber = (int)reader[0];
                            }
                        }
                    }

                }


            }
            catch { }

            return TeachersNumber;

        }

    }
}
