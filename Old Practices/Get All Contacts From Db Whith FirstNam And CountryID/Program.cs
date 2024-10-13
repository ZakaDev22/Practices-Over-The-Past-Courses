using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

  internal class Program
    {

    static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456";

    static void PrintAllRecordsWithFirstName(String Firstname)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = "Select * from Contacts where FirstName = @FirstName";

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@FirstName", Firstname);

        try
        {
            Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ContactId = (int)reader["ContactID"];
                string FirstName = (string)reader["FirstName"];
                string LastName = (string)reader["LastName"];
                string Email = (string)reader["Email"];
                string Phone = (string)reader["Phone"];
                string Address = (string)reader["Address"];
                int CountryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID : {ContactId}");
                Console.WriteLine($"First Name : {FirstName}");
                Console.WriteLine($"Last Name  : {LastName}");
                Console.WriteLine($"Email      : {Email}");
                Console.WriteLine($"Phone      : {Phone}");
                Console.WriteLine($"Address    : {Address}");
                Console.WriteLine($"Country ID : {CountryID}");
                Console.WriteLine();
            }

            reader.Close();
            Connection.Close();
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void PrintAllRecordsWithFirstNameAndCountryID(String Firstname,int CountryId)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = "Select * from Contacts where FirstName = @FirstName AND CountryID = @CountryID";

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@FirstName", Firstname);
        command.Parameters.AddWithValue("@CountryID", CountryId);

        try
        {
            Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ContactId = (int)reader["ContactID"];
                string FirstName = (string)reader["FirstName"];
                string LastName = (string)reader["LastName"];
                string Email = (string)reader["Email"];
                string Phone = (string)reader["Phone"];
                string Address = (string)reader["Address"];
                int CountryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID : {ContactId}");
                Console.WriteLine($"First Name : {FirstName}");
                Console.WriteLine($"Last Name  : {LastName}");
                Console.WriteLine($"Email      : {Email}");
                Console.WriteLine($"Phone      : {Phone}");
                Console.WriteLine($"Address    : {Address}");
                Console.WriteLine($"Country ID : {CountryID}");
                Console.WriteLine();
            }

            reader.Close();
            Connection.Close();
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void SearchContactsStartWith(String StartWith)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = "Select * from Contacts where FirstName LIKE  '' + @StartWith + '%' ";

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@StartWith", StartWith);

        try
        {
            Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ContactId = (int)reader["ContactID"];
                string FirstName = (string)reader["FirstName"];
                string LastName = (string)reader["LastName"];
                string Email = (string)reader["Email"];
                string Phone = (string)reader["Phone"];
                string Address = (string)reader["Address"];
                int CountryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID : {ContactId}");
                Console.WriteLine($"First Name : {FirstName}");
                Console.WriteLine($"Last Name  : {LastName}");
                Console.WriteLine($"Email      : {Email}");
                Console.WriteLine($"Phone      : {Phone}");
                Console.WriteLine($"Address    : {Address}");
                Console.WriteLine($"Country ID : {CountryID}");
                Console.WriteLine();
            }

            reader.Close();
            Connection.Close();
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static void SearchContactsEndWith(string EndWith)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = "select * from Contacts Where FirstName Like '%' + @EndWith + '' ";

        SqlCommand command =  new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@EndWith", EndWith);

        try
        {
            Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ContactId = (int)reader["ContactID"];
                string FirstName = (string)reader["FirstName"];
                string LastName = (string)reader["LastName"];
                string Email = (string)reader["Email"];
                string Phone = (string)reader["Phone"];
                string Address = (string)reader["Address"];
                int CountryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID : {ContactId}");
                Console.WriteLine($"First Name : {FirstName}");
                Console.WriteLine($"Last Name  : {LastName}");
                Console.WriteLine($"Email      : {Email}");
                Console.WriteLine($"Phone      : {Phone}");
                Console.WriteLine($"Address    : {Address}");
                Console.WriteLine($"Country ID : {CountryID}");
                Console.WriteLine();
            }

            reader.Close();
            Connection.Close();
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error," , ex.Message);
        }
    }

    static void SearchContactsContins(string Contains)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = "select * from Contacts Where FirstName Like '%' + @Contains + '%' ";

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@Contains", Contains);

        try
        {
            Connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int ContactId = (int)reader["ContactID"];
                string FirstName = (string)reader["FirstName"];
                string LastName = (string)reader["LastName"];
                string Email = (string)reader["Email"];
                string Phone = (string)reader["Phone"];
                string Address = (string)reader["Address"];
                int CountryID = (int)reader["CountryID"];

                Console.WriteLine($"Contact ID : {ContactId}");
                Console.WriteLine($"First Name : {FirstName}");
                Console.WriteLine($"Last Name  : {LastName}");
                Console.WriteLine($"Email      : {Email}");
                Console.WriteLine($"Phone      : {Phone}");
                Console.WriteLine($"Address    : {Address}");
                Console.WriteLine($"Country ID : {CountryID}");
                Console.WriteLine();
            }

            reader.Close();
            Connection.Close();
        }

        catch (Exception ex)
        {
            Console.WriteLine("Error,", ex.Message);
        }
    }


    static void Main(string[] args)
           {
          
           // PrintAllRecordsWithFirstName("Jane");

        Console.WriteLine("============================================");

        //  PrintAllRecordsWithFirstNameAndCountryID("Jane",1);

        Console.WriteLine("============================================");
        //   SearchContactsStartWith("J");


        Console.WriteLine("============================================");
      //  SearchContactsEndWith("e");


        Console.WriteLine("============================================");
        SearchContactsContins("AEL");


        Console.ReadKey();

           }
    }

