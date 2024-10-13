using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsCountryDataAccess
    {
        public static bool GetCountryByID(int ID, ref string Name)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            bool isFound = false;

            string query = "Select * from Countries where CountryID=@CountryID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["CountryName"];
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return isFound;
        }

        public static bool GetCountryByName(string Name, ref int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            bool isFound = false;

            string query = "Select * from Countries where CountryName=@CountryName";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@CountryName", Name);

            try
            {
                Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["CountryID"];
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return isFound;
        }

        public static DataTable ListCountries()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string Query = "Select * from Countries";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return dt;
        }
    }
}
