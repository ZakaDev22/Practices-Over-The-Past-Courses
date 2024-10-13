using System;
using System.Collections.Generic; 

using System.Data.SqlClient;

namespace CASE_in_UPDATE_Statements__Conditional_Data_Modification_
{
    internal class Program
    {
        public static string ConnectionString = "server=.;database=C21_DB1;user id=sa; password=sa123456";

        public class clsEmployes
        {
            public string EmployedName { get; set; }

            public double Salary { get; set; }

            public int PerformanceRating { get; set; }

          public  clsEmployes(string employeName,int PerformanceRating, double salary) 
            { 
                this.EmployedName = employeName;
                this.PerformanceRating = PerformanceRating;
                this.Salary = salary;
            }


        }

        public static bool UpdateEmployeSalary(clsEmployes Employes, double TheNewSalary)
        {
            int RowEffected = 0;

           try
            {
                using (var Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();

                    string query = @"Update Employees2 Set Salary = @Salary
                                       where Name = @Name";

                    using (var Command = new SqlCommand(query, Connection))
                    {
                        Command.Parameters.AddWithValue("@Salary", TheNewSalary);
                        Command.Parameters.AddWithValue("@Name", Employes.EmployedName);


                        RowEffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // false
            }

            return (RowEffected != 0);
        }

        public static List<clsEmployes> GetListOFEmployeis()
        {
            List<clsEmployes> EmployesList = new List<clsEmployes>();

            string EmployeName = null;
            int PerformanceRating = 0;
            double Salary = 0;

            clsEmployes Employe;
            
            try
            {

                using (var Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();

                    string query = "Select Name , PerformanceRating , Salary From Employees2";

                    using (var Command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader Reader = Command.ExecuteReader())
                        {
                            while (Reader.Read())
                            {
                                EmployeName = (string)Reader["Name"];
                                PerformanceRating = (int)Reader["PerformanceRating"];

                                // Converting From Int To Float Number
                                Salary = Convert.ToDouble(Reader["Salary"]);

                                // Adding A new Employee For Ech Row
                                Employe = new clsEmployes(EmployeName, PerformanceRating, Salary);

                                // Now We Will Adding Each Employee In The List
                                EmployesList.Add(Employe);

                            }
                        }
                    }
                }
            }
            catch 
            { 
                // False
            }


            return EmployesList;
        }

        static void Main(string[] args)
        {

            List<clsEmployes> EmployiesList = GetListOFEmployeis();

            double TheNewSalary = 0;

            foreach(clsEmployes Employe in EmployiesList)
            {

               if(Employe.PerformanceRating > 90)
                {
                    TheNewSalary = Employe.Salary * 1.15;
                }
               else if(Employe.PerformanceRating > 75 && Employe.PerformanceRating <= 90)
                {
                    TheNewSalary = Employe.Salary * 1.10;
                }
               else if( Employe.PerformanceRating > 50 &&  Employe.PerformanceRating <= 74)
                {
                    TheNewSalary = Employe.Salary * 1.05;
                }

               else
                    TheNewSalary = Employe.Salary;

               if(UpdateEmployeSalary(Employe, TheNewSalary))
                {
                    Console.WriteLine($"\n Salary Of Employe {Employe.EmployedName} Updated Successfully.");
                }
               else
                    Console.WriteLine($"\n Salary Of Employe {Employe.EmployedName} Was Not Updated.");

            }


            Console.ReadKey();
        }
    }
}
