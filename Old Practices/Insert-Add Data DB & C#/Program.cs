using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {
    static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456";

    public static void InsertDataInDatabase( stContacts Contact)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = "Insert Into Contacts " +
                       "  Values (@FirstName,@LAstName,@Email,@Phone,@Address,@CountryID)";

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
        command.Parameters.AddWithValue("@LastName", Contact.LastName);
        command.Parameters.AddWithValue("@Email", Contact.Email);
        command.Parameters.AddWithValue("@Phone", Contact.Phone);
        command.Parameters.AddWithValue("@Address", Contact.Address);
        command.Parameters.AddWithValue("@CountryID", Contact.CountryID);

        try
        {
            Connection.Open();

            int RowEffected = command.ExecuteNonQuery();

            if (RowEffected > 0)
            {
                Console.WriteLine("Record Inserted Successfully :-)");
            }
            else
            {
                Console.WriteLine(" Record Insertion Failed :-(");
            }

        }
        catch (Exception ex) 
        {

            Console.WriteLine(ex.Message);
        }

        Connection.Close();
    }

    public static void RetrieveAutoNumberAfterInsertingAddingData(stContacts Contact)
    {

        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = @"Insert Into Contacts 
                         Values (@FirstName,@LAstName,@Email,@Phone,@Address,@CountryID)
                         Select SCOPE_IDENTITY();";

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
        command.Parameters.AddWithValue("@LastName", Contact.LastName);
        command.Parameters.AddWithValue("@Email", Contact.Email);
        command.Parameters.AddWithValue("@Phone", Contact.Phone);
        command.Parameters.AddWithValue("@Address", Contact.Address);
        command.Parameters.AddWithValue("@CountryID", Contact.CountryID);

        try
        {
            Connection.Open();

            object result = command.ExecuteScalar();

            if( result != null && int.TryParse(result.ToString() , out int InsrtedId))
            {
                Console.WriteLine($"Newly Inserted ID : {InsrtedId}");
            }
            else
            {
                Console.WriteLine("Inserted Failed :-(");
            }

            Connection.Close();
        }
        catch (Exception Ex)
        { 
          Console.WriteLine($"{Ex.Message}");
        }
    }


    public struct stContacts
    {
        public int ID { get; set; }
        public int CountryID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; } 

        public string Phone { get; set; }
        public string Email { get; set; }


    }



    static void Main(string[] args)
    {

        stContacts contacts = new stContacts
        {
            FirstName = "Ziko",
            LastName = "King",
            Email = "Z.A@Gmail.com",
            Address = "SSiyaHeart",
            Phone = "20231212",
            CountryID = 1
        };



        stContacts contacts2 = new stContacts
        {
            FirstName = "SSiya",
            LastName = "Caty",
            Email = "Z.A@Gmail.com",
            Address = "WolfHeart",
            Phone = "20231212",
            CountryID = 1
        };

        stContacts contacts3 = new stContacts
        {
            FirstName = "hh",
            LastName = "hh",
            Email = "Z.A@Gmail.com",
            Address = "WolfHeart",
            Phone = "20231212",
            CountryID = 1
        };


        //InsertDataInDatabase (contacts);

        //  InsertDataInDatabase(contacts2);

        RetrieveAutoNumberAfterInsertingAddingData(contacts3);

        Console.ReadKey();

        }
    }

