using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslamIsLife_DataAccess
{
    public class clsUsers_DataAccess
    {
        public static int? AddNewUser(string UserName, int? PersonID, string Password, bool IsActive, int? Permissions)
        {
            int? UserID = null;


            try
            {
                // replace The New Members with The Old one..

                using (var Connection = new SqlConnection(clsSettings.ConnectionString))
                {

                    Connection.Open();

                    string query = @"Insert into Users Values (

                               @UserName,
                               @PersonID,
                               @Password,
                               @IsActive,
                               @Permissions )

                            Select Scope_Identity()";

                    using (SqlCommand cmd = new SqlCommand(query, Connection))
                    {

                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@Password", Password);
                      

                        if (IsActive)
                        {
                            cmd.Parameters.AddWithValue("@IsActive", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsActive", 0);
                        }

                        cmd.Parameters.AddWithValue("@Permissions", Permissions);

                        object Result = cmd.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                        {
                            UserID = InsertedID;
                        }

                    }




                }


            }
            catch
            {
                // Return False // Person = -1
            }


            return UserID;
        }

        public static bool UpdateUser(int? UserID, string UserName, int? PersonID, string Password, bool IsActive, int? Permissions)
        {
            int? RowEffected = null;

            try
            {

                using (var Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    Connection.Open();

                    string query = @"Update  Users 
                            Set  UserName = @UserName,
                                 PersonID = @PersonID,
                                 Password = @Password,
                                 IsActive = @IsActive,
                                 Permissions = @Permissions
                                 where UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, Connection))
                    {

                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@Password", Password);


                        if (IsActive)
                        {
                            cmd.Parameters.AddWithValue("@IsActive", 1);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@IsActive", 0);
                        }

                        cmd.Parameters.AddWithValue("@Permissions", Permissions);

                        cmd.Parameters.AddWithValue("@UserID", UserID);


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


        public static bool FindUserByID(int? UserID,ref string UserName,ref int? PersonID, ref string Password, ref bool IsActive,ref int? Permissions)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Users Where UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@UserID", UserID);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud = true;

                                UserName = (string)reader["UserName"];
                                PersonID = (int)reader["PersonID"];
                                Password = (string)reader["Password"];
                                Permissions = (int)reader["Permissions"];
                                IsActive = (Boolean)reader["IsActive"];
                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }



            return IsFoud;
        }
            
        public static bool FindUserByName(string UserName, ref int? UserID,ref int? PersonID, ref string Password,ref bool IsActive, ref int? Permissions)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Users Where UserName = @UserName";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@UserName", UserName);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud= true;

                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                Password = (string)reader["Password"];
                                Permissions = (int)reader["Permissions"];
                                IsActive = (Boolean)reader["IsActive"];
                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }



            return IsFoud;
        }

        public static bool DeleteUserWithID(int UserID)
        {
            int IsDeleted = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Delete From Users Where UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);

                        IsDeleted = cmd.ExecuteNonQuery();
                    }
                }

            }
            catch { }



            return (IsDeleted > 0);
        }
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from ManageUsers_View";

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

        public static int GetAllUsersCount()
        {
            int UsersNumber = 0;

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select Count(*) As UsersNumbers from Users";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UsersNumber = (int)reader[0];
                            }
                        }
                    }

                }


            }
            catch { }

            return UsersNumber;

        }

        public static bool FindByUsernameAndPassword(string UserName,string Password,
                        ref int? PersonID, ref int? UserID, ref bool isActive, ref int? Permissions)
        {
            bool IsFound = false;
            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"select *  from Users 
                                                where UserName = @UserName AND Password = @Password";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
                                Permissions = Convert.ToInt32(reader["Permissions"]);
                                isActive = (Boolean)reader["IsActive"];
                            }
                        }
                    }

                }


            }
            catch { IsFound = false; }

            return IsFound;

        }

        public static bool IsUserExistByUserID(int UserID)
        {
            bool IsFound = false;

            using(var Connection = new SqlConnection(clsSettings.ConnectionString))
            {
                Connection.Open();

                string query = @"Select IsFound=1 From Users Where UserID = @UserID";

                using(var cmd = new SqlCommand(query,Connection))
                {
                    cmd.Parameters.AddWithValue("@UserID", UserID);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.HasRows)
                        {
                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;

        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool IsFound = false;

            using (var Connection = new SqlConnection(clsSettings.ConnectionString))
            {
                Connection.Open();

                string query = @"Select IsFound=1 From Users Where PersonID = @PersonID";

                using (var cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;

        }

        public static bool IsUserExistByUserName(string UserName)
        {
            bool IsFound = false;

            using (var Connection = new SqlConnection(clsSettings.ConnectionString))
            {
                Connection.Open();

                string query = @"Select IsFound=1 From Users Where UserName = @UserName";

                using (var cmd = new SqlCommand(query, Connection))
                {
                    cmd.Parameters.AddWithValue("@UserName", UserName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            IsFound = true;
                        }
                    }
                }
            }

            return IsFound;

        }

        
    }
}

