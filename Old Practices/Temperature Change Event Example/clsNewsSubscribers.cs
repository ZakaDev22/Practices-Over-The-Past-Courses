using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Temperature_Change_Event_Example
{
    public class clsNewsSubscribers
    {
        public string Name { get; }

        public clsNewsSubscribers(string name)
        {
            Name = name;
        }

        public void Subscribe(clsPublisher Publesher)
        {
            Publesher.NewNewsPubleshed += HandelPubleshideNew;
        }

        public void UnSubscribe(clsPublisher Publesher)
        {
            Publesher.NewNewsPubleshed -= HandelPubleshideNew;
        }

        private int AddPubleshedNewToDataBase(NewsArticle article)
        {
            int RowEffected = -1;

        string ConnectionString = "Server=.;Database=NewsPublisherDB;User Id=sa;Password=sa123456;";

            SqlConnection connection = new SqlConnection(ConnectionString);

            string Query = @"insert into NewsArticle  Values (@Title,@Content)
                                    select SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Title",article.Title);
            command.Parameters.AddWithValue("@Content", article.Content);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString() , out int Result2))
                {
                    RowEffected =  Result2;
                }
            }
            catch
            {

            }
            finally { connection.Close(); }

            return RowEffected ;
        }

        public void HandelPubleshideNew(object Sender , NewsArticle article)
        {
            int RecordID = AddPubleshedNewToDataBase(article);

            if(RecordID == -1)
            {
                Console.WriteLine($"\n Save Record Failed   ");
                return;
            }

            Console.WriteLine($"\n Success.   ");
            Console.WriteLine($"\n {Name} Received a New Message  ");
            Console.WriteLine($"\n  Title         :  {article.Title} ");
            Console.WriteLine($"\n  Content       :   {article.Content} ");
        }
    }
}
