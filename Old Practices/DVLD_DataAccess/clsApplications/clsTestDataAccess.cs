using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestDataAccess
    {


        public static int AddNewTest(int TestAppointmentsID, bool TestResult
                                      , string Notes, int CreatedByUserID)

        {
            int AppID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"insert Into Tests
                            Values(@TestAppointmentsID,@TestResult,@Notes,@CreatedByUserID)
                                    Select Scope_Identity()";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@TestAppointmentsID", TestAppointmentsID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                Connection.Open();

                object obj = cmd.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int InsertedResult))
                {
                    AppID = InsertedResult;
                }

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return AppID;

        }


        public static bool UpdateTest(int ID, int TestAppointmentsID, bool TestResult
                                      , string Notes, int CreatedByUserID)

        {
            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update Test
                            Set TestAppointmentsID =@TestAppointmentsID,
                                TestResult = @TestResult,
                                Notes = @Notes,
                                CreatedByUserID = @CreatedByUserID,
                                
                            where TestID = @TestID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@TestAppointmentsID", TestAppointmentsID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            cmd.Parameters.AddWithValue("@TestID", ID);



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


        public static bool Find(int ID, ref int TestAppointmentID, ref string Notes, ref int CreateByUserID, ref bool TestResult)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select * from Tests
                              where TestID  = @ID ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    ISFound = true;

                    TestAppointmentID = (int)Reader["TestAppointmentID"];

                    Notes = (string)Reader["Notes"];

                    CreateByUserID = (int)Reader["CreatedByUserID"];

                    TestResult = (Boolean)Reader["TestResult"];

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

        public static bool IsTestValide(int TestAppointmentID)
        {
            int RowEffected = 0;


            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);


            string query = @"select IsFound =1  from Tests where TestAppointmentID = @TestAppointmentID And TestResult =1";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    RowEffected = (int)Reader[0];
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                RowEffected = 0;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return (RowEffected > 0);
        }

        public static bool IsPersonFailInTheLastTest(int TestAppointmentID, int TestType)
        {
            int RowEffected = 0;


            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);


            string query = @" select DISTINCT  IsFound =1
                                                        from tests inner join TestAppointments on TestAppointments.TestAppointmentID = Tests.TestAppointmentID
                     where  Tests.TestAppointmentID = @TestAppointmentID AND TestResult = 1 And TestTypeID = @TestType";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            cmd.Parameters.AddWithValue("@TestType", TestType);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    RowEffected = (int)Reader[0];
                }

                Reader.Close();
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
