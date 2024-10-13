using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsLocalLicenseDataAccess
    {


        public static int AddNewLocalLicense(int ApplicationID, int LicenseID)

        {
            int LocalLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"insert Into LocalDrivingLicenseApplications
                            Values(@ApplicationID,@LicenseID)
                                    Select Scope_Identity()";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);




            try
            {
                Connection.Open();

                object obj = cmd.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int InsertedResult))
                {
                    LocalLicenseID = InsertedResult;
                }

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return LocalLicenseID;

        }


        public static bool UpdateLocalLicense(int LocalLicenseID, int ApplicationID, int LicenseID)

        {
            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update LocalDrivingLicenseApplications
                            Set ApplicationID =@ApplicationID,
                                LicenseClassID = @LicenseID
                            where LocalDrivingLicenseApplicationID = @LocalLicenseID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

            cmd.Parameters.AddWithValue("@LocalLicenseID", LocalLicenseID);


            try
            {
                Connection.Open();

                RowEffected = cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return (RowEffected > 0);

        }


        public static bool Find(int LocalLicenseID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from LocalDrivingLicenseApplications
                                Where LocalDrivingLicenseApplicationID = @ID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", LocalLicenseID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    ISFound = true;

                    ApplicationID = (int)Reader["ApplicationID"];
                    LicenseClassID = (int)Reader["LicenseClassID"];
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return ISFound;
        }


        public static DataTable GetLocalLicense_View()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from LocalDrivingLicenseApplications_View";

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

        public static bool DeleteLicense(int LocallicenseID)
        {
            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Delete from LocalDrivingLicenseApplications
                                where LocalDrivingLicenseApplicationID = @ID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", LocallicenseID);

            try
            {
                Connection.Open();


                RowEffected = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                RowEffected = 0;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }


            return (RowEffected > 0);
        }
    }
}
