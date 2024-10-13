using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsPeopleDataAccess
    {


        public static bool GetPersonInfoByID(int ID, ref string NationalNo, ref string FirstName, ref string SecondName,
           ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref string Gendor,
            ref string Address, ref string Phone, ref string Email,
           ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "select * from People where PersonID = @PersonID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    //   ID = (int)Reader["PersonID"];
                    NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];

                    int test = -1;
                    test = Convert.ToInt32(Reader["Gendor"]);
                    //Gendor = Convert.ToString(Reader["Gendor"]);

                    if (test == 0)
                    {
                        Gendor = "Male";
                    }
                    else
                    {
                        Gendor = "Female";
                    }

                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];



                    NationalityCountryID = (int)Reader["NationalityCountryID"];


                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    isFound = false;
                }

                Reader.Close();
            }
            catch (SqlException ex)
            {

                isFound = false;

                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);

            }
            finally
            {
                Connection.Close();
            }

            return isFound;

        }

        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int ID, ref string FirstName, ref string SecondName,
         ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref string Gendor,
          ref string Address, ref string Phone, ref string Email,
         ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "select * from People where NationalNo = @NationalNo";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    isFound = true;

                    ID = (int)Reader["PersonID"];
                    //   NationalNo = (string)Reader["NationalNo"];
                    FirstName = (string)Reader["FirstName"];
                    SecondName = (string)Reader["SecondName"];
                    ThirdName = (string)Reader["ThirdName"];
                    LastName = (string)Reader["LastName"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];

                    int test = -1;
                    test = Convert.ToInt32(Reader["Gendor"]);
                    //Gendor = Convert.ToString(Reader["Gendor"]);

                    if (test == 0)
                    {
                        Gendor = "Male";
                    }
                    else
                    {
                        Gendor = "Female";
                    }

                    Address = (string)Reader["Address"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];



                    NationalityCountryID = (int)Reader["NationalityCountryID"];


                    if (Reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }

                }
                else
                {
                    isFound = false;
                }

                Reader.Close();
            }
            catch (Exception ex)
            {

                isFound = false;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);

            }
            finally
            {
                Connection.Close();
            }

            return isFound;

        }



        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName";

            SqlCommand command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }





        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastNmae
                                                  , DateTime DateOfBirth, string Gendor, string Address, string Phone,
                                                   string Email, int NationalityCountryID, string ImagePath)
        {
            int _PersonID = -1;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Insert Into People
                              Values(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,
                                      @Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath)
                                      Select Scope_Identity();";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastNmae);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);

            if (Gendor == "Male")
            {
                command.Parameters.AddWithValue("@Gendor", 0);
            }
            else
            {
                command.Parameters.AddWithValue("@Gendor", 1);
            }

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    _PersonID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);

            }
            finally { Connection.Close(); }


            return _PersonID;
        }

        public static bool UpdatePerson(int ID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName
                                               , DateTime DateOfBirth, string Gendor, string Address, string Phone,
                                                string Email, int NationalityCountryID, string ImagePath)
        {

            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = @"Update People
                               set NationalNo = @NationalNo,
                                   FirstName = @FirstName,
                                   SecondName = @SecondName,
                                   ThirdName = @ThirdName,
                                   LastName = @LastName,
                                   Email = @Email,
                                   Phone = @Phone,
                                   Address = @Address,
                                   DateOfBirth = @DateOfBirth,
                                   NationalityCountryID = @NationalityCountryID,
                                   Gendor = @Gendor,
                                   ImagePath = @ImagePath
                        where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@ThirdName", ThirdName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            command.Parameters.AddWithValue("@PersonID", ID);

            if (Gendor == "Male")
            {
                command.Parameters.AddWithValue("@Gendor", 0);
            }
            else
            {
                command.Parameters.AddWithValue("@Gendor", 1);
            }

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                Connection.Open();

                RowEffected = command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                RowEffected = 0;
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);

            }
            finally { Connection.Close(); }


            return (RowEffected > 0);
        }

        public static bool IsPersonExistByNationalNo(string NationalNo)
        {
            int _PersonID = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "Select * from People where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("NationalNo", NationalNo);


            try
            {
                Connection.Open();

                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    _PersonID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);

            }
            finally { Connection.Close(); }

            return (_PersonID != 0);
        }


        public static bool DeletePersonByID(int ID)
        {

            int RowEffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSetting.ConnectionString);

            string query = "Delete from People where PersonID = @PersonId";

            SqlCommand command = new SqlCommand(query, Connection);

            command.Parameters.AddWithValue("@PersonID", ID);

            try
            {
                Connection.Open();

                RowEffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                clsGlobalForDataAccess.LogExseptionsToLogerViewr(ex.Message, System.Diagnostics.EventLogEntryType.Error);
                return false;
            }
            finally { Connection.Close(); }


            return (RowEffected > 0);
        }

    }


}
