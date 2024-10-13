using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsLicenseClassesDataAccess
    {



        public static bool Find(int LicenseID, ref string Title,
                                 ref string Description, ref byte Age, ref byte ValidateLength,
                                 ref short PaidFees)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from LicenseClasses
                                Where LicenseClassID = @ID";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@ID", LicenseID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    ISFound = true;

                    Title = (string)Reader["ClassName"];
                    Description = (string)Reader["ClassDescription"];
                    Age = (Byte)Reader["MinimumAllowedAge"];
                    ValidateLength = (Byte)Reader["DefaultValidityLength"];
                    PaidFees = Convert.ToInt16(Reader["ClassFees"]);
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


        public static bool Find(string Name, ref int LicenseID,
                                ref string Description, ref byte Age, ref byte ValidateLength,
                                ref short PaidFees)
        {
            bool ISFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from LicenseClasses
                                Where ClassName = @Name";

            SqlCommand cmd = new SqlCommand(query, Connection);

            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                Connection.Open();

                SqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.Read())
                {
                    ISFound = true;

                    LicenseID = (int)Reader["LicenseClassID"];
                    Description = (string)Reader["ClassDescription"];
                    Age = (Byte)Reader["MinimumAllowedAge"];
                    ValidateLength = (Byte)Reader["DefaultValidityLength"];
                    PaidFees = Convert.ToInt16(Reader["ClassFees"]);
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

        public static DataTable GetAllLicense()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Select * from LicenseClasses";

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
