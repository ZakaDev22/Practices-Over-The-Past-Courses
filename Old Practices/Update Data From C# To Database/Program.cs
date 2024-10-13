using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

internal class Program
    {

    static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456";

    static public void UpdateDatabaseData(int ContactID,StContacts Contact)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = @"Update Contacts
                          Set FirstName = @FirstName,
                               LastName = @LastName,
                               Email = @Email,
                               Phone = @Phone,
                               Address =@Address,
                               CountryID = @CountryID
                          where ContactID = @ContactID"; 

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
        command.Parameters.AddWithValue("@LastName", Contact.LastName);
        command.Parameters.AddWithValue("@Email", Contact.Email);
        command.Parameters.AddWithValue("@Phone", Contact.Phone);
        command.Parameters.AddWithValue("@Address", Contact.Address);
        command.Parameters.AddWithValue("@CountryID", Contact.CountryID);
        command.Parameters.AddWithValue("@ContactID", ContactID);


        try
        {
            Connection.Open();

            int RowEffected = command.ExecuteNonQuery();

            if(RowEffected > 0)
            {
                Console.WriteLine("Update Done Successfully.");
            }
            else
            {
                Console.WriteLine("Update Statement is Failed.");
            }

            Connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    static public void DeleteDatabaseData(int ContactID)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string query = @"Delete From Contacts
                         
                          where ContactID = @ContactID";

        SqlCommand command = new SqlCommand(query, Connection);

        command.Parameters.AddWithValue("@ContactID", ContactID);

        try
        {
            Connection.Open();

            int RowEffected = command.ExecuteNonQuery();

            if(RowEffected > 0)
            {
                Console.WriteLine("Delete Done Successfully.");
            }
            else
            {
                Console.WriteLine("Deleting is Failed :-(");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error" + ex.Message);
        }
    }
    public struct StContacts
    {
      //  public int ID {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
    }

        static void Main(string[] args)
        {

        StContacts contacts = new StContacts
        {
            FirstName = "Zakaria",
            LastName = "The King",
            Email = "hhh@Gamail.com",
            Phone = "90284209",
            Address = "ssssssh",
            CountryID = 2

        };

        //  UpdateDatabaseData(9, contacts);


      /*  for(int i= 1; i <= 3;i++ )
        {
            if(i == 1)
            {
                DeleteDatabaseData(10);
            }

            if(i == 2)
            {
                DeleteDatabaseData(11);
            }

            if (i == 3)
            {
                DeleteDatabaseData(12);
            }  

        }*/

        Console.ReadKey();

        }
    }

