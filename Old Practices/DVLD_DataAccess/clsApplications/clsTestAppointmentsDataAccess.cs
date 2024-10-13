using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestAppointmentsDataAccess
    {

        public static int AddNewAppointment(int TestTypeID, int LocalDrivingLicenseID, DateTime AppointmentDate,
                                  short PaidFees, int CreateByUserID, bool IsLocked, int RetakeTestApplicationID)

        {
            int AppID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"insert Into TestAppointments
                            Values(@TestTypeID,@LocalDrivingLicenseID,@AppointmentDate,@PaidFees,@CreatedByUserID,
                                    @IsLocked,@RetakeTestApplicationID)
                                    Select Scope_Identity()";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreateByUserID);

            if (RetakeTestApplicationID == -1)
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }



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


        public static bool UpdateAppointment(int ID, int TestTypeID, int LocalDrivingLicenseID, DateTime AppointmentDate,
                                  short PaidFees, int CreateByUserID, bool IsLocked, int RetakeTestApplicationID)

        {
            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update TestAppointments
                            Set TestTypeID =@TestTypeID,
                                LocalDrivingLicenseApplicationID = @LocalDrivingLicenseID,
                                AppointmentDate = @AppointmentDate,
                                PaidFees = @PaidFees,
                                 IsLocked =   @IsLocked,
                                 RetakeTestApplicationID = @RetakeTestApplicationID,
                                 CreatedByUserID = @CreateByUserID
                            where TestAppointmentID = @TestAppointmentID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseID", LocalDrivingLicenseID);
            cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsLocked", IsLocked);
            cmd.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);

            cmd.Parameters.AddWithValue("@TestAppointmentID", ID);

            if (RetakeTestApplicationID == -1)
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", DBNull.Value);

            }
            else
            {
                cmd.Parameters.AddWithValue("@RetakeTestApplicationID", RetakeTestApplicationID);
            }

            try
            {
                Connection.Open();

                RowEffected = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return (RowEffected > 0);

        }


        public static bool Find(int ID, ref int TestTypeID, ref int LocalDrivingLicenseID, ref DateTime AppointmentDate,
                                 ref short PaidFees, ref int CreateByUserID, ref bool IsLocked, ref int RetakeTestApplicationID)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select * from TestAppointments
                              where TestAppointmentID  = @ID ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    ISFound = true;

                    TestTypeID = (int)Reader["TestTypeID"];
                    LocalDrivingLicenseID = (int)Reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)Reader["AppointmentDate"];

                    PaidFees = Convert.ToInt16(Reader["PaidFees"]);

                    CreateByUserID = (int)Reader["CreatedByUserID"];

                    IsLocked = (Boolean)Reader["IsLocked"];



                    if (Reader["RetakeTestApplicationID"] != DBNull.Value)
                    {
                        RetakeTestApplicationID = (int)Reader["RetakeTestApplicationID"];

                    }
                    else
                    {
                        RetakeTestApplicationID = -1;
                    }
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


        public static DataTable GetallAppiontments(int ID, int TestType)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select TestAppointments.TestAppointmentID As AppointmentID ,
                                    TestAppointments.AppointmentDate , TestAppointments.PaidFees , TestAppointments.IsLocked
                             from TestAppointments
                                where LocalDrivingLicenseApplicationID = @ID And  TestTypeID =@TestType
                                     order by TestAppointmentID desc";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@TestType", TestType);

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


        public static bool IsAppointmentExiste(int ID, int TestType)
        {
            int IsFound = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select  DISTINCT  IsFound =1
                                                        from TestAppointments
                     where LocalDrivingLicenseApplicationID = @ID And IsLocked = 0 And TestTypeID = @TestType ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@TestType", TestType);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = (int)Reader[0];
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

        public static bool IsAppointmentLocked(int TestAppointmentID)
        {
            int IsFound = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"  select IsFound = 1 from TestAppointments
                                    where TestAppointmentID = @TestAppointmentID And IsLocked = 1 ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = (int)Reader[0];
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


    }

}
