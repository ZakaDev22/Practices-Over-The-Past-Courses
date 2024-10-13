using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Database_New_Method
{
    internal class Program
    {
        public static string ConnectionString = "Server=.;Database=ContactsDb1;User Id=sa;Password=sa123456;";
        public static int AddRecord(string CountryName,int? CountryNo)
        {
            int id = -1;

            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"insert into Countries  values (@Name,@CountryNo)
                                     select Scope_Identity()";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (CountryName != null)
                    {
                        cmd.Parameters.AddWithValue("Name", CountryName);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("Name", DBNull.Value);
                    }

                    if (CountryNo != null)
                    {
                        cmd.Parameters.AddWithValue("CountryNo", CountryNo);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("CountryNo", DBNull.Value);
                    }

                    

                    object result = cmd.ExecuteScalar();

                    if(result != null && int.TryParse(result.ToString(),out int InsertedID))
                     {
                        id = InsertedID;
                    }
                }
            }


            return id;

        }

        static void Main(string[] args)
        {
           

            int? CountryNo = null;
            string CountryName = "Zaka_Null";

            Console.WriteLine($" The ID Of The Inserted Recod IS : {AddRecord(CountryName,CountryNo)}");

            Console.ReadKey();
        }
    }
}
