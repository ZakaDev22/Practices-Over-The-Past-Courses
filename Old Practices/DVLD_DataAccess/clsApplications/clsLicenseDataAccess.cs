using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsLicenseDataAccess
    {

        public static int AddNewLicense(int ApplicationID, int DriverID,
                                        int LicenseClasseID, DateTime IssueDate, DateTime ExpirationDate,
                  String Notes, int PaidFees,
               bool IsActive, byte IssueReason, int CreatedByUserID)

        {
            int LicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"insert Into Licenses
                            Values(@ApplicationID,@DriverID,@LicenseClasseID,@IssueDate
                                    , @ExpirationDate, @Notes,@PaidFees,@IsActive,@IssueReason,@CreatedByUserID)
                                    Select Scope_Identity()";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClasseID", LicenseClasseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);



            try
            {
                Connection.Open();

                object obj = cmd.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int InsertedResult))
                {
                    LicenseID = InsertedResult;
                }

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return LicenseID;

        }

        public static bool UpdateLicense(int ID, int ApplicationID, int DriverID,
                                              int LicenseClasseID, DateTime IssueDate, DateTime ExpirationDate,
                        String Notes, int PaidFees,
                    bool IsActive, byte IssueReason, int CreatedByUserID)

        {
            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);


            string query = @"Update  Licenses
                             Set ApplicationID = @ApplicationID,
                                 DriverID =@DriverID,
                                 LicenseClass = @LicenseClasseID,
                                  IssueDate =  @IssueDate,
                                  ExpirationDate = @ExpirationDate,
                                  Notes =  @Notes,
                                  PaidFees = @PaidFees,
                                  IsActive =@IsActive,
                                  IssueReason = @IssueReason,
                                  CreatedByUserID =  @CreatedByUserID
                            where LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseClasseID", LicenseClasseID);
            cmd.Parameters.AddWithValue("@IssueDate", IssueDate);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@IssueReason", IssueReason);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@LicenseID", ID);


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

        public static bool FindByApplicationID(int ApplicationID, ref int LicenseID, ref int DriverID,
                                             ref int LicenseClasseID, ref DateTime IssueDate,
                   ref DateTime ExpirationDate, ref String Notes, ref int PaidFees,
                    ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select * from Licenses
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

                    LicenseID = (int)Reader["LicenseID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClasseID = (int)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    PaidFees = Convert.ToInt32(Reader["PaidFees"]);
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = Convert.ToByte(Reader["IssueReason"]);
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                    if (Reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)Reader["Notes"];
                    }
                    else
                    {
                        Notes = string.Empty;
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

        public static bool FindByLicenseID(int LicenseID, ref int ApplicationID, ref int DriverID,
                                           ref int LicenseClasseID, ref DateTime IssueDate,
                 ref DateTime ExpirationDate, ref String Notes, ref int PaidFees,
                  ref bool IsActive, ref byte IssueReason, ref int CreatedByUserID)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select * from Licenses
                              where LicenseID  = @ID ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", LicenseID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    ISFound = true;

                    ApplicationID = (int)Reader["ApplicationID"];
                    DriverID = (int)Reader["DriverID"];
                    LicenseClasseID = (int)Reader["LicenseClass"];
                    IssueDate = (DateTime)Reader["IssueDate"];
                    ExpirationDate = (DateTime)Reader["ExpirationDate"];
                    PaidFees = Convert.ToInt32(Reader["PaidFees"]);
                    IsActive = (bool)Reader["IsActive"];
                    IssueReason = Convert.ToByte(Reader["IssueReason"]);
                    CreatedByUserID = (int)Reader["CreatedByUserID"];

                    if (Reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)Reader["Notes"];
                    }
                    else
                    {
                        Notes = string.Empty;
                    }

                }

                Reader.Close();
            }
            catch
            {

            }
            finally { Connection.Close(); }

            return ISFound;
        }

        public static bool IsThisPersonHasThisLicense(int DriverID, int LicenseclassID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select IsFound=1 from Licenses
                              where DriverID  = @DriverID  And LicenseClass = @LicenseclassID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@LicenseclassID", LicenseclassID);

            try
            {
                Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
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

        public static DataTable GetPersonLicenseHistory(int PersonID)
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @" SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate, Licenses.ExpirationDate, Licenses.IsActive
                           FROM            Licenses INNER JOIN
                         LicenseClasses ON Licenses.LicenseClass = LicenseClasses.LicenseClassID INNER JOIN
                         Applications ON Licenses.ApplicationID = Applications.ApplicationID 
                        
                            where   Applications.ApplicantPersonID = @PersonID
                           order by  IsActive desc, LicenseID Desc ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

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


        public static bool ISLicenseActiveAndType_3(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select True = 1 From Licenses where LicenseID = @ID And LicenseClass = 3 And IsActive =1";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", LicenseID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsFound = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }



            return IsFound;

        }

        public static bool ISLicenseActive(int LicenseID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select True = 1 From Licenses where LicenseID = @ID And IsActive =1";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", LicenseID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsFound = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }



            return IsFound;

        }

        public static bool IsLicenseNotExpired(int LicenseID, DateTime ExpiratoinDate)
        {
            bool IsActive = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"SELECT IsActive = 1 from Licenses
                                where LicenseID = @ID AND  DATEDIFF(DAY , getdate(), @ExpirationDate) > 0";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", LicenseID);
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpiratoinDate);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsActive = true;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                IsActive = false;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }



            return IsActive;
        }
    }
}
