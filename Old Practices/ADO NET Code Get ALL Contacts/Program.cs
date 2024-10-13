using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


    internal class Program
    {

    static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456";

    static void PrintAllRecords()
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = "Select * from Contacts";

        SqlCommand command = new SqlCommand(query, Connection);

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

        static void Main(string[] args)
        {

        PrintAllRecords();

        Console.ReadKey();

        }
    }

