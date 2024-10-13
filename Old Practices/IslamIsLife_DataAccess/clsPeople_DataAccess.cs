using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;

namespace IslamIsLife_DataAccess
{ 
    public class clsPeople_DataAccess
    {

        public static bool IsPersonExist(string NationalNo)
        {

            bool isFound = false;

          
            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT Found=1 FROM People WHERE NationalNo = @NationalNo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@NationalNo", NationalNo);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            isFound = reader.HasRows;
                        }

                    }

                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
           

            return isFound;
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT Found=1 FROM People WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static int? AddNewPerson(string FirstName, string LastName,string NationalNo, bool Gendor ,string CountryName,string CityName,
                                    string Phone,DateTime? DateOfBirth, string Email,string ImagePath)
        {
            int? PersonID = null;


            try
            {

                using (var Connection = new SqlConnection(clsSettings.ConnectionString))
                {

                    Connection.Open();

                    string query = @" Insert into People 

                         VALUES
               (@FirstName,@LastName,@Gendor,@CountryName,@CityName,@DateOfBirth,@Phone,@Email,@ImagePath,@NationalNo)
                       
                        select SCOPE_IDENTITY();
                                        
                                   ";

                    using (SqlCommand cmd = new SqlCommand(query, Connection))
                    {

                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Gendor", Gendor);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                        // make the another functions Also Nullable for National No
                        if (NationalNo != null)
                        {
                            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NationalNo", DBNull.Value);
                        }

                        if (CountryName != null)
                        {
                            cmd.Parameters.AddWithValue("@CountryName", CountryName);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@CountryName", DBNull.Value);
                        }

                        if (CityName != null)
                        {
                            cmd.Parameters.AddWithValue("@CityName", CityName);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@CityName", DBNull.Value);
                        }
                        if (Phone != null)
                        {
                            cmd.Parameters.AddWithValue("@Phone", Phone);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Phone", DBNull.Value);
                        }
                        //

                        if (Email != null)
                        {
                            cmd.Parameters.AddWithValue("@Email", Email);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                        }


                        if (ImagePath != null)
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        }


                        object Result = cmd.ExecuteScalar();

                        if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                        {
                            PersonID = InsertedID;
                        }

                    }




                }


            }
            catch
            {
                // Return False // Person = null
            }


            return PersonID;
        }

        public static bool UpdatePerson(int? PersonID, string FirstName, string LastName,string NationalNo, bool Gendor, string CountryName, string CityName,
                                    string Phone , DateTime? DateOfBirth, string Email, string ImagePath)
        {
            int? RowEffected = null;

            try
            {

                using (var Connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    Connection.Open();


                 string query = @"UPDATE [dbo].[People]
                                         SET [FirstName] = @FirstName,
                                            [LastName] = @LastName,
                                            [Gendor] = @Gendor,
                                            [CountryName] = @CountryName,
                                            [CityName] =@CityName ,
                                            [DateOfBirth] = @DateOfBirth,
                                            [Phone] = @Phone,
                                            [Email] =@Email ,
                                            [ImagePath] = @ImagePath,
                                            [NationalNo] = @NationalNo
                                       WHERE PersonID = @PersonID";

                    using (SqlCommand cmd = new SqlCommand(query, Connection))
                    {

                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Gendor", Gendor);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);

                        if (NationalNo != null)
                        {
                            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@NationalNo", DBNull.Value);
                        }

                        if (CountryName != null)
                        {
                            cmd.Parameters.AddWithValue("@CountryName", CountryName);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@CountryName", DBNull.Value);
                        }

                        if (CityName != null)
                        {
                            cmd.Parameters.AddWithValue("@CityName", CityName);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@CityName", DBNull.Value);
                        }
                        if (Phone != null)
                        {
                            cmd.Parameters.AddWithValue("@Phone", Phone);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Phone", DBNull.Value);
                        }

                        if (Email != null)
                        {
                            cmd.Parameters.AddWithValue("@Email", Email);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                        }


                        if (ImagePath != null)
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);


                        RowEffected = cmd.ExecuteNonQuery();

                    }

                }


            }
            catch
            {
                // Return False // RowEffected = 0
            }


            return (RowEffected != null);
        }


        public static bool FindPersonByID(int? PersonID, ref string FirstName, ref string LastName,ref string NationalNo,
                                          ref bool Gendor,ref string CountryName, ref string CityName,
                                          ref string Phone, ref DateTime? DateOfBirth, ref string Email, ref string ImagePath)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from People Where PersonID = @PersonID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud = true;

                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                Gendor = (Boolean)reader["Gendor"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];


                                if (reader["NationalNo"] != DBNull.Value)
                                {
                                    NationalNo = (string)reader["NationalNo"];
                                }

                                if (reader["CountryName"] != DBNull.Value)
                                {
                                    CountryName = (string)reader["CountryName"];
                                }

                                if (reader["CityName"] != DBNull.Value)
                                {
                                    CityName = (string)reader["CityName"];
                                }

                                if (reader["Phone"] != DBNull.Value)
                                {
                                    Phone = (string)reader["Phone"];
                                }

                                if (reader["Email"] != DBNull.Value)
                                {
                                    Email = (string)reader["Email"];
                                }

                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }

                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }

            return IsFoud;
        }

        public static bool FindPersonByNationalNo(string NationalNo,ref int? PersonID, ref string FirstName, ref string LastName, 
                                         ref bool Gendor, ref string CityName, ref string Phone,
                                           ref string CountryName, ref DateTime? DateOfBirth, ref string Email, ref string ImagePath)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from People Where NationalNo = @NationalNo";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud = true;

                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                LastName = (string)reader["LastName"];
                                NationalNo = (string)reader["NationalNo"];
                                Gendor = (Boolean)reader["Gendor"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];

                                if (reader["CountryName"] != DBNull.Value)
                                {
                                    CountryName = (string)reader["CountryName"];
                                }

                                if (reader["CityName"] != DBNull.Value)
                                {
                                    CityName = (string)reader["CityName"];
                                }

                                if (reader["Phone"] != DBNull.Value)
                                {
                                    Phone = (string)reader["Phone"];
                                }

                                if (reader["Email"] != DBNull.Value)
                                {
                                    Email = (string)reader["Email"];
                                }

                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }

                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }

            return IsFoud;
        }

        public static bool DeletePersonWithID(int PersonID)
        {
            int IsDeleted = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Delete From People Where PersonID = @PersonID";
    
                  using (SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);

                        IsDeleted = cmd.ExecuteNonQuery();
                    }
                }

            }
            catch { }



            return (IsDeleted > 0);
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from ManagePeople_View";

                    using(var cmd = new SqlCommand(query,connection))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if(reader.HasRows)
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

        public static int GetAllPeopleCount()
        {
            int PeopleNumber = 0;

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select Count(*) As PeopleNumbers from People";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PeopleNumber = (int)reader[0];
                            }
                        }
                    }

                }


            }
            catch { }

            return PeopleNumber;

        }

    }
}
