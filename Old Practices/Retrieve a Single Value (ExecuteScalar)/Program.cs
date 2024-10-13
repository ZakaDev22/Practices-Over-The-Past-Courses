using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


    internal class Program
    {

    static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456";

    static String RetriveSinglValueFromDB(int ID)
    {
        string FirstName = "";

        SqlConnection Connection = new SqlConnection(ConnectionString);

        string Query = "Select FirstName From Contacts where CountryID = @CountryID ";

        SqlCommand Command  = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@CountryID", ID);

        try
            {
            Connection.Open();

            object Result = Command.ExecuteScalar();

            if(Result != null)
            {
                FirstName = Result.ToString();
            }
            else
            {
                FirstName = "0000";
            }

            Connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error",ex.Message);
        }

        return FirstName;
    }
       
        static void Main(string[] args)
        {

        Console.WriteLine( RetriveSinglValueFromDB(1));

        Console.ReadKey();
        }

    }

