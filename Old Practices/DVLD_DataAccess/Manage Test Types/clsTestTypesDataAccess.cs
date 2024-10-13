using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestTypesDataAccess
    {


        public static bool FindTestTypeByID(int ID, ref string Title, ref string Description, ref byte Fees)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "Select * from TestTypes where TestTypeID = @ID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {


                Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    Title = (string)reader["TestTypeTitle"];
                    Description = (string)reader["TestTypeDescription"];
                    Fees = Convert.ToByte(reader["TestTypeFees"]);
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

        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "Select * from TestTypes";

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

        public static bool UpdateTestTypeByID(int ID, string Title, byte Fees)
        {
            byte RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update  TestTypes
                            set TestTypeFees = @TestTypeFees,
                                TestTypeTitle = @Title
                            where TestTypeID = @ID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@TestTypeFees", Fees);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                RowEffected = Convert.ToByte(command.ExecuteNonQuery());

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }


            return (RowEffected > 0);
        }
    }
}
