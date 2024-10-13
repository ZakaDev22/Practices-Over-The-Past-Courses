using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IslamIsLife_DataAccess
{
    public class clsBooksDataAccess
    {
        public static int? AddNewBook(string Title , string Author, string ISBN, DateTime? PublicationDate,
                                                        string Publisher, string Genre, string Description, int? Pages, string ImagePath)
        {
            int? Id = null;

            try
            {
                using(SqlConnection conn = new SqlConnection(clsSettings.ConnectionString))
                {
                    conn.Open();

                    string query = @"Insert into Books Values (
                                        Title = @Title,
                                        Author = @Author,
                                        ISBN = @ISBN,
                                        PublicationDate = @PublicationDate,
                                        Publisher = @Publisher, 
                                        Genre = @Genre,
                                        Description = @Description,
                                        Pages = @Pages,
                                        ImagePath = @ImagePath
                                   Select Scope_Identity()";

                    using(SqlCommand cmd = new SqlCommand(query,conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", Title);
                        cmd.Parameters.AddWithValue("@Author", Author);
                        cmd.Parameters.AddWithValue("@ISBN", ISBN);
                        cmd.Parameters.AddWithValue("@PublicationDate", PublicationDate);

                        cmd.Parameters.AddWithValue("@Publisher", Publisher);

                        cmd.Parameters.AddWithValue("@Genre", Genre);


                        if (Description != null)
                        {
                            cmd.Parameters.AddWithValue("@Description", Description);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                        }

                        if (Pages != null)
                        {
                            cmd.Parameters.AddWithValue("@Pages", Pages);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Pages", DBNull.Value);
                        }

                        if (ImagePath != null)
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        }

                        object result = cmd.ExecuteScalar();

                        if(result != null && int.TryParse(result.ToString(),out int InsertedID))
                        {
                            Id = InsertedID;
                        }
                    }
                }
            }
            catch { }

            return Id;
        }

        public static bool UpdateBook(int? BookID,string Title, string Author, string ISBN, DateTime? PublicationDate,
                                                        string Publisher, string Genre, string Description, int? Pages, string ImagePath)
        {
            int RowEffected = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(clsSettings.ConnectionString))
                {
                    conn.Open();

                    string query = @"Update Books 
                                   SET  Title = @Title,
                                        Author = @Author,
                                        ISBN = @ISBN,
                                        PublicationDate = @PublicationDate,
                                        Publisher = @Publisher, 
                                        Genre = @Genre,
                                        Description = @Description,
                                        Pages = @Pages,
                                        ImagePath = @ImagePath
                                   where BookID = @BookID
                                   Select Scope_Identity()";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", Title);
                        cmd.Parameters.AddWithValue("@Author", Author);
                        cmd.Parameters.AddWithValue("@ISBN", ISBN);
                        cmd.Parameters.AddWithValue("@PublicationDate", PublicationDate);

                        cmd.Parameters.AddWithValue("@Publisher", Publisher);

                        cmd.Parameters.AddWithValue("@Genre", Genre);


                        if (Description != null)
                        {
                            cmd.Parameters.AddWithValue("@Description", Description);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Description", DBNull.Value);
                        }

                        if (Pages != null)
                        {
                            cmd.Parameters.AddWithValue("@Pages", Pages);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Pages", DBNull.Value);
                        }

                        if (ImagePath != null)
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@BookID", BookID);

                        RowEffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }

            return (RowEffected > 0);
        }

        public static bool FindBookByID(int? BookID,ref string Title, ref string Author, ref string ISBN, ref DateTime? PublicationDate,
                                             ref string Publisher, ref string Genre, ref string Description, ref int? Pages, ref string ImagePath)
        {
            bool IsFoud = false;


            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Select * from Books Where BookID = @BookID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {

                        cmd.Parameters.AddWithValue("@BookID", BookID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                IsFoud = true;

                                Title = (string)reader["Title"];
                                Author = (string)reader["Author"];
                                ISBN = (string)reader["ISBN"];
                                PublicationDate = (DateTime)reader["PublicationDate"];
                                Publisher = (string)reader["Publisher"];
                                Genre = (string)reader["Genre"];

                                if (reader["Description"] != DBNull.Value)
                                {
                                    Description = (string)reader["Description"];
                                }

                                if (reader["Pages"] != DBNull.Value)
                                {
                                    Pages = (int?)reader["Pages"];
                                }

                                if (reader["ImagePath"] != DBNull.Value)
                                {
                                    ImagePath = (string)reader["ImagePath"];
                                }     

                            }
                        }
                    }



                }


            }
            catch { IsFoud = false; }

            return IsFoud;
        }


        public static bool DeleteBookWithID(int BookID)
        {
            int IsDeleted = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"Delete From Books Where BookID = @BookID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BookID", BookID);

                        IsDeleted = cmd.ExecuteNonQuery();
                    }
                }

            }
            catch { }



            return (IsDeleted > 0);
        }

        public static DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select * from ManageBooks_View";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }

                }


            }
            catch { }

            return dt;

        }

        public static int GetAllBooksCount()
        {
            int BooksNumber = 0;

            try
            {
                using (var connection = new SqlConnection(clsSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "select Count(*) As BooksNumbers from Books";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                BooksNumber = (int)reader[0];
                            }
                        }
                    }

                }


            }
            catch { }

            return BooksNumber;

        }

    }
}
