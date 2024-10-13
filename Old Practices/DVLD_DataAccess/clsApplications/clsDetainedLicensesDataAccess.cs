using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsDetainedLicensesDataAccess
    {


        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate,
                                                      short FineFees, int CreatedByUserID, bool IsReleased)

        {
            int DetainedlLicenseID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"insert Into DetainedLicenses
                            Values(@LicenseID,@DetainDate,@FineFees,@CreatedByUserID,
                                    @IsReleased,
                                   @ReleaseDate,@ReleasedByUserID,@ReleaseApplicationID)
                                    Select Scope_Identity()";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@DetainDate", DetainDate);
            cmd.Parameters.AddWithValue("@FineFees", FineFees);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", DBNull.Value);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);



            try
            {
                Connection.Open();

                object obj = cmd.ExecuteScalar();

                if (obj != null && int.TryParse(obj.ToString(), out int InsertedResult))
                {
                    DetainedlLicenseID = InsertedResult;
                }

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }

            return DetainedlLicenseID;
        }

        public static bool UpdateDetainedLicense(int LicenseID, bool IsReleased, DateTime ReleaseDate
                                                 , int ReleasedByUserID, int ReleaseApplicationID)

        {
            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);


            string query = @"Update  DetainedLicenses
                             Set 
                                  IsReleased = @IsReleased,
                                  ReleaseDate =@ReleaseDate,
                                  ReleasedByUserID =  @ReleasedByUserID,
                                  ReleaseApplicationID = @ReleaseApplicationID
                            where LicenseID = @LicenseID And IsReleased = 0 ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@IsReleased", IsReleased);
            cmd.Parameters.AddWithValue("@ReleaseDate", ReleaseDate);
            cmd.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);
            cmd.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);


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

        public static bool FindByDetainedLicenseID(int licenseID, ref int detainedLicenseID, ref DateTime DetainDate,
                                                 ref short FineFees, ref int CreatedByUserID, ref bool IsReleased
                                                    , ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select * from DetainedLicenses
                              where LicenseID  = @ID ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", licenseID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    ISFound = true;

                    detainedLicenseID = (int)Reader["DetainID"];
                    DetainDate = (DateTime)Reader["DetainDate"];
                    FineFees = Convert.ToInt16(Reader["FineFees"]);
                    CreatedByUserID = (int)Reader["CreatedByUserID"];
                    IsReleased = Convert.ToBoolean(Reader["IsReleased"]);

                    if (Reader["ReleaseDate"] != DBNull.Value)
                    {
                        ReleaseDate = (DateTime)Reader["ReleaseDate"];

                    }
                    else
                    {
                        //  ReleaseDate = null
                    }

                    if (Reader["ReleasedByUserID"] != DBNull.Value)
                    {
                        ReleasedByUserID = (int)Reader["ReleasedByUserID"];
                    }
                    else
                    {
                        //  ReleasedByUserID = null
                    }


                    if (Reader["ReleaseApplicationID"] != DBNull.Value)
                    {
                        ReleaseApplicationID = (int)Reader["ReleaseApplicationID"];

                    }
                    else
                    {
                        //  ReleasedByUserID = null
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

        public static bool isDetainedLicense(int LicenseID)
        {
            bool IsDetained = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"select IsDetained =1 from DetainedLicenses
                            where LicenseID = @ID And IsReleased = 0 ";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", LicenseID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    IsDetained = true;


                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally { Connection.Close(); }


            return IsDetained;
        }


        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"SELECT DISTINCT 
                         DetainedLicenses.DetainID, DetainedLicenses.LicenseID, DetainedLicenses.IsReleased, DetainedLicenses.FineFees, DetainedLicenses.ReleaseDate,
                            People.NationalNo, People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName AS FullName,
                            DetainedLicenses.ReleaseApplicationID
                FROM            DetainedLicenses INNER JOIN
                                                     Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN
                         Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                                                                         People ON Drivers.PersonID = People.PersonID
                            ORDER BY DetainedLicenses.DetainID DESC";

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
