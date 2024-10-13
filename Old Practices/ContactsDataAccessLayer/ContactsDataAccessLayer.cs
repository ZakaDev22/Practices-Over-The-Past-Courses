using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ContactsDataAccessLayer
{
    public class clsContactDataAccess
    {

        public static bool GetContactInfoByID(int ID, ref string FirstName, ref string LastName, ref string Email, ref string Phone,
            ref string Address, ref DateTime DateOfBirth , ref int CountryID, ref string ImagePath)
        {
            bool isFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "select * from Contacts where ContactID = @ContactID";

            SqlCommand Command  = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.Read())
                {
                    isFound = true;

                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (string)Reader["Phone"];
                    Address = (string)Reader["Address"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    CountryID = (int)Reader["CountryID"];
                   

                   if(Reader["ImagePath"] != DBNull.Value)
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
            
            }
            finally
            {
                Connection.Close();
            }

            return isFound;
            
        }


        public static int AddNewContact(string FirstNmae, string LastNmae, string Email, string Phone,string Address,
                                        DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int ContactID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Insert Into Contacts(FirstName,LastName,Email,Phone,Address,DateOfBirth,CountryID,ImagePath)
                                         Values(@FirstName,@LastName,@Email,@Phone,@Address,@DateOfBirth,@CountryID,@ImagePath)
                                           Select Scope_Identity()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstNmae);
            command.Parameters.AddWithValue("@LastName", LastNmae);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
           
            if(ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if(Result != null && int.TryParse(Result.ToString(),out int InsertedID))
                {
                    ContactID = InsertedID;
                }

            }
            catch (Exception ex) 
            { 
            
            
            }
            finally { connection.Close(); }


            return ContactID;
        }

        public static bool UpdateContact(int ID,string FirstNmae, string LastNmae, string Email, string Phone, string Address,
                                              DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Contacts

                               Set FirstName = @FirstName,
                                   LastName = @LastName,
                                   Email = @Email,
                                   Phone = @Phone,
                                   Address = @Address,
                                   DateOfBirth = @DateOfBirth,
                                   CountryID = @CountryID,
                                   ImagePath= @ImagePath
                               where ContactID = @ContactID ;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstNmae);
            command.Parameters.AddWithValue("@LastName", LastNmae);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@CountryID", CountryID);
            command.Parameters.AddWithValue("@ContactID", ID);

            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

           

            try
            {
                connection.Open();

                RowEffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }


            return (RowEffected > 0);
        }


        public static bool DeleteContact(int ID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Delete from Contacts 
                             where ContactID = @ContactID ";

            SqlCommand Command = new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                connection.Open();

                RowEffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex) 
            {

                return false;
            
            }
            finally { connection.Close(); }


            return (RowEffected > 0);
        }

        public static DataTable GetAllContacts()
        {
            DataTable dt = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select * from Contacts";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if(Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }
            catch(Exception ex)
            {
                //
            }
            finally { Connection.Close(); }

            return dt;
        }
          
        public static bool IsContactExist(int ID)
        {
            bool IsFound = false;


            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "Select Found = 1 from Contacts where ContactID = @ContactID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if(reader.HasRows)
                {
                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                IsFound= false;
            }
            finally { Connection.Close(); }



            return IsFound;
        }

    }
   
}
