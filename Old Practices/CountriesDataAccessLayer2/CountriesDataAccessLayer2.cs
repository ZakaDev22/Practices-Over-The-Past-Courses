using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;


namespace CountriesDataAccessLayer2
{
   
    public class clsCountriesDataAccess
    {

       public static bool GetCountryByID(int ID , ref string country , ref string Code , ref string PhoneCode)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsCountriesDataSetting.ConnectionString);

            string query = "Select * from Countries Where CountryID = @ID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    country = (string)Reader["CountryName"];
                    Code = (string)Reader["Code"];
                    PhoneCode = (string)Reader["PhoneCode"];
                }
                else
                {
                    IsFound = false;
                }

                Reader.Close();
            }
            catch (Exception ex) 
            {
               // IsFound = false;
            }
            finally { Connection.Close(); }



            return IsFound;
        }

        public static bool GetCountryByName( ref int ID,  string country, ref string Code, ref string PhoneCode)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsCountriesDataSetting.ConnectionString);

            string query = "Select * from Countries Where CountryName = @CountryName";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryName", country);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;

                    ID = (int)Reader["CountryID"];
                    Code = (string)Reader["Code"];
                    PhoneCode = (string)Reader["PhoneCode"];
                }
                else
                {
                    IsFound = false;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                // IsFound = false;
            }
            finally { Connection.Close(); }



            return IsFound;
        }

        public static int AddNewCountry(string country,string Code,string PhoneCode)
        {
            int ContactID = -1;

            SqlConnection Connection = new SqlConnection(clsCountriesDataSetting.ConnectionString);

            string query = @"Insert Into Countries
                                    values (@CountryName,@Code,@PhoneCode)
                                    Select Scope_Identity()";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryName", country);
            Command.Parameters.AddWithValue("@Code", Code);
            Command.Parameters.AddWithValue("@PhoneCode", PhoneCode);

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ContactID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            { Connection.Close(); }

            return ContactID;
        }

        public static bool UpdateCountry(int ID ,string country,string Code,string PhoneCode)
        {
            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsCountriesDataSetting.ConnectionString);

            string query = @"Update Countries
                                    Set CountryName = @CountryName,
                                        Code = @Code,
                                        PhoneCode = @PhoneCode
                                    where CountryID = @CountryID ";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("CountryName", country);
            Command.Parameters.AddWithValue("@CountryID", ID);
            Command.Parameters.AddWithValue("@Code", Code);
            Command.Parameters.AddWithValue("@PhoneCode", PhoneCode);

            try
            {
                Connection.Open();

                RowEffected = Command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                return false;
            }
            finally { Connection.Close(); }


            return (RowEffected > 0);
        }

        public static bool DeleteCountry(int ID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsCountriesDataSetting.ConnectionString);

            string query = @"Delete from Countries 
                             where CountryID = @CountryID ";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                connection.Open();

                RowEffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                return false;

            }
            finally { connection.Close(); }


            return (RowEffected > 0);
        }

        public static DataTable ListCountry()
        {
            DataTable table = new DataTable();

            SqlConnection connection = new SqlConnection(clsCountriesDataSetting.ConnectionString);

            string query = "SELECT * FROM Countries order by CountryName";

            SqlCommand Command = new SqlCommand(query,connection);

            try
            {
                connection.Open();

                SqlDataReader Reader  = Command.ExecuteReader();

                if(Reader.HasRows)
                {
                    table.Load(Reader);
                }
            }
            catch(Exception ex)
            {

            }
            finally
            { connection.Close(); }


            return table;
        }

        public static bool IsCountryExistByID(int ID)
        {
            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsCountriesDataSetting.ConnectionString);

            string query = "Select Found = 1 from Countries where CountryID = @CountryID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally { Connection.Close(); }



            return IsFound;
        }

        public static bool IsCountryExistByName(string CountryNAme)
        {
            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsCountriesDataSetting.ConnectionString);

            string query = "Select Found = 1 from Countries where CountryName = @CountryName";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryName", CountryNAme);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally { Connection.Close(); }



            return IsFound;
        }


    }
}
