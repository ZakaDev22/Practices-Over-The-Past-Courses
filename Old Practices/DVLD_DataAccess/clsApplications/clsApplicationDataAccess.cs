using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsApplicationDataAccess
    {

        public static int AddNewApplication(int ApplicationPersonID, DateTime ApplicationDate,
                                  int ApplicationTypeID, string ApplicationStatus, DateTime LastStatusDate,
                                  int PaidFees, int CreateByUserID)

        {
            int AppID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"insert Into Applications
                            Values(@ApplicationPersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationStatus,
                                    @LastStatusDate,@PaidFees,@CreateByUserID)
                                    Select Scope_Identity()";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@ApplicationStatus", 1);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);



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


        public static bool UpdateApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate,
                                 int ApplicationTypeID, string ApplicationStatus, DateTime LastStatusDate,
                                 int PaidFees, int CreateByUserID)

        {
            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update Applications
                            Set ApplicantPersonID =@ApplicationPersonID,
                                ApplicationDate = @ApplicationDate,
                                ApplicationTypeID = @ApplicationTypeID,
                                ApplicationStatus = @ApplicationStatus,
                                 LastStatusDate =   @LastStatusDate,
                                 PaidFees =   @PaidFees,
                                 CreatedByUserID = @CreateByUserID
                            where ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            cmd.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreateByUserID", CreateByUserID);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            switch (ApplicationStatus)
            {
                case "New":
                    cmd.Parameters.AddWithValue("@ApplicationStatus", 1);
                    break;
                case "Cancelled":
                    cmd.Parameters.AddWithValue("@ApplicationStatus", 2);
                    break;
                case "Completed":
                    cmd.Parameters.AddWithValue("@ApplicationStatus", 3);
                    break;
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


        public static bool Find(int ApplicationID, ref int ApplicationPersonID, ref DateTime ApplicationDate,
                               ref int ApplicationTypeID, ref string ApplicationStatus, ref DateTime LastStatusDate,
                               ref int PaidFees, ref int CreateByUserID)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select * from Applications
                              where ApplicationID  = @ID ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", ApplicationID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    ISFound = true;

                    ApplicationPersonID = (int)Reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)Reader["ApplicationDate"];
                    ApplicationTypeID = (int)Reader["ApplicationTypeID"];

                    LastStatusDate = (DateTime)Reader["LastStatusDate"];
                    PaidFees = Convert.ToInt32(Reader["PaidFees"]);

                    CreateByUserID = (int)Reader["CreatedByUserID"];

                    int Status = Convert.ToInt32(Reader["ApplicationStatus"]);
                    switch (Status)
                    {
                        case 1:
                            ApplicationStatus = "New";
                            break;

                        case 2:
                            ApplicationStatus = "Canceled";
                            break;

                        case 3:
                            ApplicationStatus = "Completed";
                            break;

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
    }


}