using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDriversDataAccess
    {

        public static int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            int DriverID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"insert Into Drivers
                            Values(@PersonID,@CreatedByUserID,@CreatedDate)
                                    Select Scope_Identity()";

            SqlCommand cmd = new SqlCommand(query, Connection);


            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);




            try
            {
                Connection.Open();

                object obj = cmd.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int InsertedResult))
                {
                    DriverID = InsertedResult;
                }

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return DriverID;

        }

        public static bool Find(int PersonID, ref int DriverID, ref DateTime CreatedDate, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * From Drivers
                               where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    DriverID = (int)reader["DriverID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];

                }
                reader.Close();
            }
            catch (System.Exception ex)

            {
                IsFound = false;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }

            finally { Connection.Close(); }

            return IsFound;
        }

        public static bool IsDriverExiste(int PersonID)
        {
            byte IsFound = 0;


            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select IsFound = 1 From Drivers
                               where PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, Connection);


            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = Convert.ToByte(Reader[0]);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return (IsFound > 0);

        }

        public static DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"SELECT   Drivers.DriverID, Drivers.PersonID, People.NationalNo, (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' +People.LastName) As FullName,
			Drivers.CreatedDate , (Select Count(*) From Licenses where IsActive = 1 And Licenses.DriverID = Drivers.DriverID) As ActiveLicense
                            FROM            People INNER JOIN
                         Drivers ON People.PersonID = Drivers.PersonID   ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
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
