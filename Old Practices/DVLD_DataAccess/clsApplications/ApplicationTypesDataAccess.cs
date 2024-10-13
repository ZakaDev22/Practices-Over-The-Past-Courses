using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsApplicationTypesDataAccess
    {

        public static bool FindApplicationTypeByID(int ID, ref string Title, ref byte Fees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "Select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ID);

            try
            {


                Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    Title = (string)reader["ApplicationTypeTitle"];
                    Fees = Convert.ToByte(reader["ApplicationFees"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return IsFound;
        }

        public static DataTable GetAlAplicaationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "Select * from ApplicationTypes";

            SqlCommand command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

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

        public static bool UpdateApplicationTypeByID(int ID, byte Fees)
        {
            byte RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update  ApplicationTypes
                            set ApplicationFees = @ApplicationFees  
                            where ApplicationTypeID = @ID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@ApplicationFees", Fees);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                RowEffected = Convert.ToByte(command.ExecuteNonQuery());

            }
            catch (System.Exception ex)
            { clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error); }
            finally { Connection.Close(); }


            return (RowEffected > 0);
        }

    }
}
