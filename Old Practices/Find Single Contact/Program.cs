using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;



internal class Program
    {
   
    static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456";

      static bool ReturnSingleCintact(int ID , ref stContacts Contact)
    {
        bool isFound = false;

        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = "Select * from Contacts where ContactID = @ID";

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@ID", ID);

        try
        {
            Connection.Open();
            SqlDataReader Reader = command.ExecuteReader();

            if(Reader.Read())
            {
                isFound = true;

                Contact.ID = (int)Reader["ContactID"];
                Contact.FirstName = (string)Reader["FirstName"];
                Contact.LastName = (string)Reader["LastName"];
                Contact.Email = (string)Reader["Email"];
                Contact.PhoneNumber = (string)Reader["Phone"];
                Contact.Address = (string)Reader["Address"];
                Contact.CountryID = (int)Reader["CountryID"];
            }
            else
            {
                isFound = false;
            }

            Reader.Close();

            Connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return isFound;
    }

    public struct stContacts
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }


    }

    static void Main(string[] args)
        {

        stContacts Contact = new stContacts();

        if(ReturnSingleCintact(1, ref Contact))
        {
            Console.WriteLine($"Contact Id  = {Contact.ID}");

            Console.WriteLine($"Full Name   = {Contact.FirstName} {Contact.LastName}");

            Console.WriteLine($"Email       = {Contact.Email}");

            Console.WriteLine($"Phone Num   = {Contact.PhoneNumber}");

            Console.WriteLine($"Address     = {Contact.Address}");

            Console.WriteLine($"Country ID  = {Contact.CountryID}");

        }
        else
        {
            Console.WriteLine("Contact Was Not Fount!!!");
        }

        Console.ReadKey();

        }
    }

